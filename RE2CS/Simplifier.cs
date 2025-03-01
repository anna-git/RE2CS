﻿/*
 * Copyright (c) 2020 The Go Authors. All rights reserved.
 *
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file.
 */
// Original Go source here:
// http://code.google.com/p/go/source/browse/src/pkg/regexp/syntax/simplify.go

namespace RE2CS;

public class Simplifier
{

    // Simplify returns a regexp equivalent to re but without counted
    // repetitions and with various other simplifications, such as
    // rewriting /(?:a+)+/ to /a+/.  The resulting regexp will execute
    // correctly but its string representation will not produce the same
    // parse tree, because capturing parentheses may have been duplicated
    // or removed.  For example, the simplified form for /(x){1,2}/ is
    // /(x)(x)?/ but both parentheses capture as $1.  The returned regexp
    // may share structure with or be the original.
    public static Regexp? Simplify(Regexp? re)
    {
        if (re == null)
        {
            return null;
        }
        switch (re.op)
        {
            case Regexp.Op.CAPTURE:
            case Regexp.Op.CONCAT:
            case Regexp.Op.ALTERNATE:
                {
                    // Simplify children, building new Regexp if children change.
                    var nre = re;
                    for (int i = 0; i < re.subs.Length; ++i)
                    {
                        Regexp sub = re.subs[i];
                        Regexp? nsub = Simplify(sub);
                        if (nre == re && nsub != sub)
                        {
                            // Start a copy.
                            nre = new (re); // shallow copy
                            nre.runes = null;
                            nre.subs = Parser.Subarray(re.subs, 0, re.subs.Length); // clone
                        }
                        if (nre != re)
                        {
                            nre.subs[i] = nsub;
                        }
                    }
                    return nre;
                }
            case Regexp.Op.STAR:
            case Regexp.Op.PLUS:
            case Regexp.Op.QUEST:
                {
                    Regexp? sub = Simplify(re.subs[0]);
                    return SimplifyForUnary(re.op, re.flags, sub, re);
                }
            case Regexp.Op.REPEAT:
                {
                    // Special special case: x{0} matches the empty string
                    // and doesn't even need to consider x.
                    if (re.min == 0 && re.max == 0)
                    {
                        return new Regexp(Regexp.Op.EMPTY_MATCH);
                    }

                    // The fun begins.
                    Regexp sub = Simplify(re.subs[0]);

                    // x{n,} means at least n matches of x.
                    if (re.max == -1)
                    {
                        // Special case: x{0,} is x*.
                        if (re.min == 0)
                        {
                            return SimplifyForUnary(Regexp.Op.STAR, re.flags, sub, null);
                        }

                        // Special case: x{1,} is x+.
                        if (re.min == 1)
                        {
                            return SimplifyForUnary(Regexp.Op.PLUS, re.flags, sub, null);
                        }

                        // General case: x{4,} is xxxx+.
                        Regexp nre = new Regexp(Regexp.Op.CONCAT);
                        var subs = new List<Regexp>();
                        for (int i = 0; i < re.min - 1; i++)
                        {
                            subs.Add(sub);
                        }
                        subs.Add(SimplifyForUnary(Regexp.Op.PLUS, re.flags, sub, null));
                        nre.subs = subs.ToArray();
                        return nre;
                    }

                    // Special case x{0} handled above.

                    // Special case: x{1} is just x.
                    if (re.min == 1 && re.max == 1)
                    {
                        return sub;
                    }

                    // General case: x{n,m} means n copies of x and m copies of x?
                    // The machine will do less work if we nest the final m copies,
                    // so that x{2,5} = xx(x(x(x)?)?)?

                    // Build leading prefix: xx.
                    List<Regexp> prefixSubs = null;
                    if (re.min > 0)
                    {
                        prefixSubs = new List<Regexp>();
                        for (int i = 0; i < re.min; i++)
                        {
                            prefixSubs.Add(sub);
                        }
                    }

                    // Build and attach suffix: (x(x(x)?)?)?
                    if (re.max > re.min)
                    {
                        Regexp suffix = SimplifyForUnary(Regexp.Op.QUEST, re.flags, sub, null);
                        for (int i = re.min + 1; i < re.max; i++)
                        {
                            Regexp nre2 = new Regexp(Regexp.Op.CONCAT);
                            nre2.subs = new Regexp[] { sub, suffix };
                            suffix = SimplifyForUnary(Regexp.Op.QUEST, re.flags, nre2, null);
                        }
                        if (prefixSubs == null)
                        {
                            return suffix;
                        }
                        prefixSubs.Add(suffix);
                    }
                    if (prefixSubs != null)
                    {
                        Regexp prefix = new Regexp(Regexp.Op.CONCAT);
                        prefix.subs = prefixSubs.ToArray();
                        return prefix;
                    }

                    // Some degenerate case like min > max or min < max < 0.
                    // Handle as impossible match.
                    return new Regexp(Regexp.Op.NO_MATCH);
                }
        }

        return re;
    }

    // simplify1 implements Simplify for the unary OpStar,
    // OpPlus, and OpQuest operators.  It returns the simple regexp
    // equivalent to
    //
    //      Regexp{Op: op, Flags: flags, Sub: {sub}}
    //
    // under the assumption that sub is already simple, and
    // without first allocating that structure.  If the regexp
    // to be returned turns out to be equivalent to re, simplify1
    // returns re instead.
    //
    // simplify1 is factored out of Simplify because the implementation
    // for other operators generates these unary expressions.
    // Letting them call simplify1 makes sure the expressions they
    // generate are simple.
    private static Regexp SimplifyForUnary(Regexp.Op op, int flags, Regexp sub, Regexp re)
    {
        // Special case: repeat the empty string as much as
        // you want, but it's still the empty string.
        if (sub.op == Regexp.Op.EMPTY_MATCH)
        {
            return sub;
        }
        // The operators are idempotent if the flags match.
        if (op == sub.op && (flags & RE2.NON_GREEDY) == (sub.flags & RE2.NON_GREEDY))
        {
            return sub;
        }
        if (re != null
            && re.op == op
            && (re.flags & RE2.NON_GREEDY) == (flags & RE2.NON_GREEDY)
            && sub == re.subs[0])
        {
            return re;
        }

        re = new (op);
        re.flags = flags;
        re.subs = new Regexp[] { sub };
        return re;
    }
}
