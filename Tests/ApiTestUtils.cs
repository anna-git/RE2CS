﻿/*
 * Copyright (c) 2020 The Go Authors. All rights reserved.
 *
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file.
 */
/**
 * Some custom asserts and parametric tests.
 *
 * @author afrozm@google.com (Afroz Mohiuddin)
 */
using System.Text;
using NUnit.Framework;

namespace RE2CS.Tests;

[TestFixture]
public class ApiTestUtils
{

    /**
     * Tests that both RE2's and JDK's pattern class act as we expect them. The regular expression
     * {@code regexp} matches the string {@code match} and doesn't match {@code nonMatch}
     */
    public static void testMatches(string regexp, string match, string nonMatch)
    {
        string errorString = "Pattern with regexp: " + regexp;
        assertTrue(
            "JDK " + errorString + " doesn't match: " + match,
            System.Text.RegularExpressions.Regex.IsMatch(regexp, match));
        assertFalse(
            "JDK " + errorString + " matches: " + nonMatch,
            System.Text.RegularExpressions.Regex.IsMatch(regexp, nonMatch));
        assertTrue(errorString + " doesn't match: " + match, Pattern.matches(regexp, match));
        assertFalse(errorString + " matches: " + nonMatch, Pattern.matches(regexp, nonMatch));

        assertTrue(
            errorString + " doesn't match: " + match, Pattern.matches(regexp, getUtf8Bytes(match)));
        assertFalse(
            errorString + " matches: " + nonMatch, Pattern.matches(regexp, getUtf8Bytes(nonMatch)));
    }
    public static void assertTrue(bool v)
    {
        Assert.IsTrue(v);
    }
    public static void assertFalse(bool v)
    {
        Assert.IsFalse(v);
    }
    public static void assertTrue(string s, bool v)
    {
        Assert.IsTrue(v, s);
    }
    public static void assertFalse(string s, bool v)
    {
        Assert.IsFalse(v, s);
    }

    // Test matches via a matcher.
    public static void testMatcherMatches(string regexp, string match, string nonMatch)
    {
        testMatcherMatches(regexp, match);
        testMatcherNotMatches(regexp, nonMatch);
    }

    public static void testMatcherMatches(string regexp, string match)
    {
        java.util.regex.Pattern p = java.util.regex.Pattern.compile(regexp);
        assertTrue(
            "JDK Pattern with regexp: " + regexp + " doesn't match: " + match,
            p.matcher(match).matches());
        Pattern pr = Pattern.compile(regexp);
        assertTrue(
            "Pattern with regexp: " + regexp + " doesn't match: " + match, pr.matcher(match).matches());
        assertTrue(
            "Pattern with regexp: " + regexp + " doesn't match: " + match,
            pr.matcher(getUtf8Bytes(match)).matches());
    }

    public static void testMatcherNotMatches(string regexp, string nonMatch)
    {
        java.util.regex.Pattern p = java.util.regex.Pattern.compile(regexp);
        assertFalse(
            "JDK Pattern with regexp: " + regexp + " matches: " + nonMatch,
            p.matcher(nonMatch).matches());
        Pattern pr = Pattern.compile(regexp);
        assertFalse(
            "Pattern with regexp: " + regexp + " matches: " + nonMatch, pr.matcher(nonMatch).matches());
        assertFalse(
            "Pattern with regexp: " + regexp + " matches: " + nonMatch,
            pr.matcher(getUtf8Bytes(nonMatch)).matches());
    }

    /**
     * This takes a regex and it's compile time flags, a string that is expected to match the regex
     * and a string that is not expected to match the regex.
     *
     * We don't check for JDK compatibility here, since the flags are not in a 1-1 correspondence.
     *
     */
    public static void testMatchesRE2(string regexp, int flags, string match, string nonMatch)
    {
        Pattern p = Pattern.compile(regexp, flags);
        string errorString = "Pattern with regexp: " + regexp + " and flags: " + flags;
        assertTrue(errorString + " doesn't match: " + match, p.matches(match));
        assertTrue(errorString + " doesn't match: " + match, p.matches(getUtf8Bytes(match)));
        assertFalse(errorString + " matches: " + nonMatch, p.matches(nonMatch));
        assertFalse(errorString + " matches: " + nonMatch, p.matches(getUtf8Bytes(nonMatch)));
    }

    /**
     * Tests that both RE2 and JDK split the string on the regex in the same way, and that that way
     * matches our expectations.
     */
    public static void testSplit(string regexp, string text, string[] expected)
    {
        testSplit(regexp, text, 0, expected);
    }

    public static void testSplit(string regexp, string text, int limit, string[] expected)
    {
        Truth.assertThat(java.util.regex.Pattern.compile(regexp).split(text, limit))
            .isEqualTo(expected);
        Truth.assertThat(Pattern.compile(regexp).split(text, limit)).isEqualTo(expected);
    }

    // Helper methods for RE2Matcher's test.

    // Tests that both RE2 and JDK's Matchers do the same replaceFist.
    public static void testReplaceAll(string orig, string regex, string repl, string actual)
    {
        Pattern p = Pattern.compile(regex);
        string replaced;
        foreach (MatcherInput input in Arrays.asList(MatcherInput.utf16(orig), MatcherInput.utf8(orig)))
        {
            Matcher m = p.matcher(input);
            replaced = m.replaceAll(repl);
            assertEquals(actual, replaced);
        }

        // JDK's
        java.util.regex.Pattern pj = java.util.regex.Pattern.compile(regex);
        java.util.regex.Matcher mj = pj.matcher(orig);
        replaced = mj.replaceAll(repl);
        assertEquals(actual, replaced);
    }

    // Tests that both RE2 and JDK's Matchers do the same replaceFist.
    public static void testReplaceFirst(string orig, string regex, string repl, string actual)
    {
        Pattern p = Pattern.compile(regex);
        string replaced;
        foreach (MatcherInput input in Arrays.asList(MatcherInput.utf16(orig), MatcherInput.utf8(orig)))
        {
            Matcher m = p.matcher(orig);
            replaced = m.replaceFirst(repl);
            assertEquals(actual, replaced);
        }

        // JDK's
        java.util.regex.Pattern pj = java.util.regex.Pattern.compile(regex);
        java.util.regex.Matcher mj = pj.matcher(orig);
        replaced = mj.replaceFirst(repl);
        assertEquals(actual, replaced);
    }

    // Tests that both RE2 and JDK's Patterns/Matchers give the same groupCount.
    public static void testGroupCount(string pattern, int count)
    {
        // RE2
        Pattern p = Pattern.compile(pattern);
        Matcher m = p.matcher("x");
        Matcher m2 = p.matcher(getUtf8Bytes("x"));
        
        assertEquals(count, p.groupCount());
        assertEquals(count, m.groupCount());
        assertEquals(count, m2.groupCount());

        // JDK
        java.util.regex.Pattern pj = java.util.regex.Pattern.compile(pattern);
        java.util.regex.Matcher mj = pj.matcher("x");
        // java.util.regex.Pattern doesn't have group count in JDK.
        assertEquals(count, mj.groupCount());
    }

    public static void assertEquals(int v1, int v2)
    {
        Assert.AreEqual(v1, v2);
    }
    public static void assertEquals(string v1, string v2)
    {
        Assert.AreEqual(v1, v2);
    }

    public static void testGroup(string text, string regexp, string[] output)
    {
        // RE2
        Pattern p = Pattern.compile(regexp);
        foreach(MatcherInput input in Arrays.asList(MatcherInput.utf16(text), MatcherInput.utf8(text)))
        {
            Matcher matchString = p.matcher(input);
            assertTrue(matchString.find());
            assertEquals(output[0], matchString.group());
            for (int i = 0; i < output.Length; i++)
            {
                assertEquals(output[i], matchString.group(i));
            }
            assertEquals(output.Length - 1, matchString.groupCount());
        }

        // JDK
        java.util.regex.Pattern pj = java.util.regex.Pattern.compile(regexp);
        java.util.regex.Matcher matchStringj = pj.matcher(text);
        // java.util.regex.Matcher matchBytes =
        //   p.matcher(text.getBytes(Charsets.UTF_8));
        assertTrue(matchStringj.find());
        // assertEquals(true, matchBytes.find());
        assertEquals(output[0], matchStringj.group());
        // assertEquals(output[0], matchBytes.group());
        for (int i = 0; i < output.Length; i++)
        {
            assertEquals(output[i], matchStringj.group(i));
            // assertEquals(output[i], matchBytes.group(i));
        }
    }

    public static void testFind(string text, string regexp, int start, string output)
    {
        // RE2
        Pattern p = Pattern.compile(regexp);
        foreach (MatcherInput input in Arrays.asList(MatcherInput.utf16(text), MatcherInput.utf8(text)))
        {
            Matcher matchString = p.matcher(input);
            // RE2Matcher matchBytes = p.matcher(text.getBytes(Charsets.UTF_8));
            assertTrue(matchString.find(start));
            // assertTrue(matchBytes.find(start));
            assertEquals(output, matchString.group());
            // assertEquals(output, matchBytes.group());
        }

        // JDK
        java.util.regex.Pattern pj = java.util.regex.Pattern.compile(regexp);
        java.util.regex.Matcher matchStringj = pj.matcher(text);
        assertTrue(matchStringj.find(start));
        assertEquals(output, matchStringj.group());
    }

    public static void testFindNoMatch(string text, string regexp, int start)
    {
        // RE2
        Pattern p = Pattern.compile(regexp);
        foreach (MatcherInput input in Arrays.asList(MatcherInput.utf16(text), MatcherInput.utf8(text)))
        {
            Matcher matchString = p.matcher(input);
            // RE2Matcher matchBytes = p.matcher(text.getBytes(Charsets.UTF_8));
            assertFalse(matchString.find(start));
            // assertFalse(matchBytes.find(start));
        }

        // JDK
        java.util.regex.Pattern pj = java.util.regex.Pattern.compile(regexp);
        java.util.regex.Matcher matchStringj = pj.matcher(text);
        assertFalse(matchStringj.find(start));
    }

    public static void testInvalidGroup(string text, string regexp, int group)
    {
        Pattern p = Pattern.compile(regexp);
        Matcher m = p.matcher(text);
        m.find();
        m.group(group);
        fail(); // supposed to have exception by now
    }

    public static void verifyLookingAt(string text, string regexp, bool output)
    {
        assertEquals(output, Pattern.compile(regexp).matcher(text).lookingAt());
        assertEquals(output, Pattern.compile(regexp).matcher(getUtf8Bytes(text)).lookingAt());
        assertEquals(output, java.util.regex.Pattern.compile(regexp).matcher(text).lookingAt());
    }

    private static byte[] getUtf8Bytes(string s)
    {
        return Encoding.UTF8.GetBytes(s);
    }
}
