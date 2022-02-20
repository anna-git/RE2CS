﻿/*
 * Copyright (c) 2020 The Go Authors. All rights reserved.
 *
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file.
 */
// Original Go source here:
// http://code.google.com/p/go/source/browse/src/pkg/regexp/syntax/parse.go
namespace RE2CS;

public class CharGroup
{

    public readonly int sign;
    public readonly int[] cls;

    private CharGroup(int sign, int[] cls)
    {
        this.sign = sign;
        this.cls = cls;
    }

    private static readonly int[] code1 = {
        /* \d */
        0x30, 0x39,
    };

    private static readonly int[] code2 = {
        /* \s */
        0x9, 0xa, 0xc, 0xd, 0x20, 0x20,
    };

    private static readonly int[] code3 = {
        /* \w */
        0x30, 0x39, 0x41, 0x5a, 0x5f, 0x5f, 0x61, 0x7a,
    };

    private static readonly int[] code4 = {
        /* [:alnum:] */
        0x30, 0x39, 0x41, 0x5a, 0x61, 0x7a,
    };

    private static readonly int[] code5 = {
        /* [:alpha:] */
        0x41, 0x5a, 0x61, 0x7a,
    };

    private static readonly int[] code6 = {
        /* [:ascii:] */
        0x0, 0x7f,
    };

    private static readonly int[] code7 = {
        /* [:blank:] */
        0x9, 0x9, 0x20, 0x20,
    };

    private static readonly int[] code8 = {
        /* [:cntrl:] */
        0x0, 0x1f, 0x7f, 0x7f,
    };

    private static readonly int[] code9 = {
        /* [:digit:] */
        0x30, 0x39,
    };

    private static readonly int[] code10 = {
        /* [:graph:] */
        0x21, 0x7e,
    };

    private static readonly int[] code11 = {
        /* [:lower:] */
        0x61, 0x7a,
    };

    private static readonly int[] code12 = {
        /* [:print:] */
        0x20, 0x7e,
    };

    private static readonly int[] code13 = {
        /* [:punct:] */
        0x21, 0x2f, 0x3a, 0x40, 0x5b, 0x60, 0x7b, 0x7e,
    };

    private static readonly int[] code14 = {
        /* [:space:] */
        0x9, 0xd, 0x20, 0x20,
    };

    private static readonly int[] code15 = {
        /* [:upper:] */
        0x41, 0x5a,
    };

    private static readonly int[] code16 = {
        /* [:word:] */
        0x30, 0x39, 0x41, 0x5a, 0x5f, 0x5f, 0x61, 0x7a,
    };

    private static readonly int[] code17 = {
        /* [:xdigit:] */
        0x30, 0x39, 0x41, 0x46, 0x61, 0x66,
    };

    public static readonly Dictionary<string, CharGroup> PERL_GROUPS = new();
    public static readonly Dictionary<string, CharGroup> POSIX_GROUPS = new();

    static CharGroup()
    {
        PERL_GROUPS.Add("\\d", new CharGroup(+1, code1));
        PERL_GROUPS.Add("\\D", new CharGroup(-1, code1));
        PERL_GROUPS.Add("\\s", new CharGroup(+1, code2));
        PERL_GROUPS.Add("\\S", new CharGroup(-1, code2));
        PERL_GROUPS.Add("\\w", new CharGroup(+1, code3));
        PERL_GROUPS.Add("\\W", new CharGroup(-1, code3));
        POSIX_GROUPS.Add("[:alnum:]", new CharGroup(+1, code4));
        POSIX_GROUPS.Add("[:^alnum:]", new CharGroup(-1, code4));
        POSIX_GROUPS.Add("[:alpha:]", new CharGroup(+1, code5));
        POSIX_GROUPS.Add("[:^alpha:]", new CharGroup(-1, code5));
        POSIX_GROUPS.Add("[:ascii:]", new CharGroup(+1, code6));
        POSIX_GROUPS.Add("[:^ascii:]", new CharGroup(-1, code6));
        POSIX_GROUPS.Add("[:blank:]", new CharGroup(+1, code7));
        POSIX_GROUPS.Add("[:^blank:]", new CharGroup(-1, code7));
        POSIX_GROUPS.Add("[:cntrl:]", new CharGroup(+1, code8));
        POSIX_GROUPS.Add("[:^cntrl:]", new CharGroup(-1, code8));
        POSIX_GROUPS.Add("[:digit:]", new CharGroup(+1, code9));
        POSIX_GROUPS.Add("[:^digit:]", new CharGroup(-1, code9));
        POSIX_GROUPS.Add("[:graph:]", new CharGroup(+1, code10));
        POSIX_GROUPS.Add("[:^graph:]", new CharGroup(-1, code10));
        POSIX_GROUPS.Add("[:lower:]", new CharGroup(+1, code11));
        POSIX_GROUPS.Add("[:^lower:]", new CharGroup(-1, code11));
        POSIX_GROUPS.Add("[:print:]", new CharGroup(+1, code12));
        POSIX_GROUPS.Add("[:^print:]", new CharGroup(-1, code12));
        POSIX_GROUPS.Add("[:punct:]", new CharGroup(+1, code13));
        POSIX_GROUPS.Add("[:^punct:]", new CharGroup(-1, code13));
        POSIX_GROUPS.Add("[:space:]", new CharGroup(+1, code14));
        POSIX_GROUPS.Add("[:^space:]", new CharGroup(-1, code14));
        POSIX_GROUPS.Add("[:upper:]", new CharGroup(+1, code15));
        POSIX_GROUPS.Add("[:^upper:]", new CharGroup(-1, code15));
        POSIX_GROUPS.Add("[:word:]", new CharGroup(+1, code16));
        POSIX_GROUPS.Add("[:^word:]", new CharGroup(-1, code16));
        POSIX_GROUPS.Add("[:xdigit:]", new CharGroup(+1, code17));
        POSIX_GROUPS.Add("[:^xdigit:]", new CharGroup(-1, code17));
    }
}
