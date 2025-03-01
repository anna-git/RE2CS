﻿/*
 * Copyright (c) 2020 The Go Authors. All rights reserved.
 *
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file.
 */
// Generated at 2020-06-09T16:20:06.352Z by Java 1.8.0_181 using Unicode version 6.0.0.0.
// Do not change this file, your edits will be lost. Instead change UnicodeTablesGenerator.java.
namespace RE2CS;

public static class UnicodeTables
{
    public static char[] CASE_ORBIT;

    public static int[][] Lu = make_Lu();

    public static int[][] Ll = make_Ll();

    public static int[][] Lt = make_Lt();

    public static int[][] Lm = make_Lm();

    public static int[][] Lo = make_Lo();

    public static int[][] Mn = make_Mn();

    public static int[][] Me = make_Me();

    public static int[][] Mc = make_Mc();

    public static int[][] Nd = make_Nd();

    public static int[][] Nl = make_Nl();

    public static int[][] No = make_No();

    public static int[][] Zs = make_Zs();

    public static int[][] Zl = make_Zl();

    public static int[][] Zp = make_Zp();

    public static int[][] Cc = make_Cc();

    public static int[][] Cf = make_Cf();

    public static int[][] Co = make_Co();

    public static int[][] Cs = make_Cs();

    public static int[][] Pd = make_Pd();

    public static int[][] Ps = make_Ps();

    public static int[][] Pe = make_Pe();

    public static int[][] Pc = make_Pc();

    public static int[][] Po = make_Po();

    public static int[][] Sm = make_Sm();

    public static int[][] Sc = make_Sc();

    public static int[][] Sk = make_Sk();

    public static int[][] So = make_So();

    public static int[][] Pi = make_Pi();

    public static int[][] Pf = make_Pf();

    public static int[][] P = make_P();

    public static int[][] S = make_S();

    public static int[][] C = make_C();

    public static int[][] Z = make_Z();

    public static int[][] L = make_L();

    public static int[][] M = make_M();

    public static int[][] N = make_N();

    public static int[][] Common = make_Common();

    public static int[][] Inherited = make_Inherited();

    public static int[][] Bamum = make_Bamum();

    public static int[][] Arabic = make_Arabic();

    public static int[][] Lisu = make_Lisu();

    public static int[][] Armenian = make_Armenian();

    public static int[][] Bengali = make_Bengali();

    public static int[][] Old_South_Arabian = make_Old_South_Arabian();

    public static int[][] Bopomofo = make_Bopomofo();

    public static int[][] Cherokee = make_Cherokee();

    public static int[][] Coptic = make_Coptic();

    public static int[][] Cyrillic = make_Cyrillic();

    public static int[][] Deseret = make_Deseret();

    public static int[][] Devanagari = make_Devanagari();

    public static int[][] Ethiopic = make_Ethiopic();

    public static int[][] Georgian = make_Georgian();

    public static int[][] Gothic = make_Gothic();

    public static int[][] Greek = make_Greek();

    public static int[][] Gujarati = make_Gujarati();

    public static int[][] Gurmukhi = make_Gurmukhi();

    public static int[][] Han = make_Han();

    public static int[][] Hangul = make_Hangul();

    public static int[][] Hebrew = make_Hebrew();

    public static int[][] Hiragana = make_Hiragana();

    public static int[][] Kannada = make_Kannada();

    public static int[][] Katakana = make_Katakana();

    public static int[][] Khmer = make_Khmer();

    public static int[][] Lao = make_Lao();

    public static int[][] Latin = make_Latin();

    public static int[][] Malayalam = make_Malayalam();

    public static int[][] Mongolian = make_Mongolian();

    public static int[][] Myanmar = make_Myanmar();

    public static int[][] Ogham = make_Ogham();

    public static int[][] Old_Italic = make_Old_Italic();

    public static int[][] Oriya = make_Oriya();

    public static int[][] Runic = make_Runic();

    public static int[][] Sinhala = make_Sinhala();

    public static int[][] Syriac = make_Syriac();

    public static int[][] Tamil = make_Tamil();

    public static int[][] Telugu = make_Telugu();

    public static int[][] Thaana = make_Thaana();

    public static int[][] Thai = make_Thai();

    public static int[][] Tibetan = make_Tibetan();

    public static int[][] Canadian_Aboriginal = make_Canadian_Aboriginal();

    public static int[][] Yi = make_Yi();

    public static int[][] Tagalog = make_Tagalog();

    public static int[][] Hanunoo = make_Hanunoo();

    public static int[][] Buhid = make_Buhid();

    public static int[][] Tagbanwa = make_Tagbanwa();

    public static int[][] Braille = make_Braille();

    public static int[][] Cypriot = make_Cypriot();

    public static int[][] Limbu = make_Limbu();

    public static int[][] Linear_B = make_Linear_B();

    public static int[][] Osmanya = make_Osmanya();

    public static int[][] Shavian = make_Shavian();

    public static int[][] Tai_Le = make_Tai_Le();

    public static int[][] Ugaritic = make_Ugaritic();

    public static int[][] Buginese = make_Buginese();

    public static int[][] Glagolitic = make_Glagolitic();

    public static int[][] Kharoshthi = make_Kharoshthi();

    public static int[][] Syloti_Nagri = make_Syloti_Nagri();

    public static int[][] New_Tai_Lue = make_New_Tai_Lue();

    public static int[][] Tifinagh = make_Tifinagh();

    public static int[][] Old_Persian = make_Old_Persian();

    public static int[][] Balinese = make_Balinese();

    public static int[][] Batak = make_Batak();

    public static int[][] Brahmi = make_Brahmi();

    public static int[][] Cham = make_Cham();

    public static int[][] Egyptian_Hieroglyphs = make_Egyptian_Hieroglyphs();

    public static int[][] Javanese = make_Javanese();

    public static int[][] Kayah_Li = make_Kayah_Li();

    public static int[][] Lepcha = make_Lepcha();

    public static int[][] Mandaic = make_Mandaic();

    public static int[][] Nko = make_Nko();

    public static int[][] Old_Turkic = make_Old_Turkic();

    public static int[][] Phags_Pa = make_Phags_Pa();

    public static int[][] Phoenician = make_Phoenician();

    public static int[][] Vai = make_Vai();

    public static int[][] Cuneiform = make_Cuneiform();

    public static int[][] Unknown = make_Unknown();

    public static int[][] Carian = make_Carian();

    public static int[][] Tai_Tham = make_Tai_Tham();

    public static int[][] Lycian = make_Lycian();

    public static int[][] Lydian = make_Lydian();

    public static int[][] Ol_Chiki = make_Ol_Chiki();

    public static int[][] Rejang = make_Rejang();

    public static int[][] Saurashtra = make_Saurashtra();

    public static int[][] Sundanese = make_Sundanese();

    public static int[][] Meetei_Mayek = make_Meetei_Mayek();

    public static int[][] Imperial_Aramaic = make_Imperial_Aramaic();

    public static int[][] Avestan = make_Avestan();

    public static int[][] Kaithi = make_Kaithi();

    public static int[][] Inscriptional_Pahlavi = make_Inscriptional_Pahlavi();

    public static int[][] Inscriptional_Parthian = make_Inscriptional_Parthian();

    public static int[][] Samaritan = make_Samaritan();

    public static int[][] Tai_Viet = make_Tai_Viet();

    public static int[][] Upper = Lu;

    public static Dictionary<string, int[][]> CATEGORIES = Categories();

    public static Dictionary<string, int[][]> SCRIPTS = Scripts();

    private static int[][] foldCommon = make_foldCommon();

    private static int[][] foldInherited = make_foldInherited();

    private static int[][] foldGreek = make_foldGreek();

    public static Dictionary<string, int[][]> FOLD_SCRIPT = FoldScript();

    private static int[][] foldLu = make_foldLu();

    private static int[][] foldLl = make_foldLl();

    private static int[][] foldLt = make_foldLt();

    private static int[][] foldMn = make_foldMn();

    public static Dictionary<string, int[][]> FOLD_CATEGORIES = FoldCategory();

    static UnicodeTables()
    {
        CASE_ORBIT = new char[8492];
        CASE_ORBIT[0x4b] = (char)0x6b;
        CASE_ORBIT[0x53] = (char)0x73;
        CASE_ORBIT[0x6b] = (char)0x212a;
        CASE_ORBIT[0x73] = (char)0x17f;
        CASE_ORBIT[0xb5] = (char)0x39c;
        CASE_ORBIT[0xc5] = (char)0xe5;
        CASE_ORBIT[0xdf] = (char)0x1e9e;
        CASE_ORBIT[0xe5] = (char)0x212b;
        CASE_ORBIT[0x130] = (char)0x130;
        CASE_ORBIT[0x131] = (char)0x131;
        CASE_ORBIT[0x17f] = (char)0x53;
        CASE_ORBIT[0x1c4] = (char)0x1c5;
        CASE_ORBIT[0x1c5] = (char)0x1c6;
        CASE_ORBIT[0x1c6] = (char)0x1c4;
        CASE_ORBIT[0x1c7] = (char)0x1c8;
        CASE_ORBIT[0x1c8] = (char)0x1c9;
        CASE_ORBIT[0x1c9] = (char)0x1c7;
        CASE_ORBIT[0x1ca] = (char)0x1cb;
        CASE_ORBIT[0x1cb] = (char)0x1cc;
        CASE_ORBIT[0x1cc] = (char)0x1ca;
        CASE_ORBIT[0x1f1] = (char)0x1f2;
        CASE_ORBIT[0x1f2] = (char)0x1f3;
        CASE_ORBIT[0x1f3] = (char)0x1f1;
        CASE_ORBIT[0x345] = (char)0x399;
        CASE_ORBIT[0x392] = (char)0x3b2;
        CASE_ORBIT[0x395] = (char)0x3b5;
        CASE_ORBIT[0x398] = (char)0x3b8;
        CASE_ORBIT[0x399] = (char)0x3b9;
        CASE_ORBIT[0x39a] = (char)0x3ba;
        CASE_ORBIT[0x39c] = (char)0x3bc;
        CASE_ORBIT[0x3a0] = (char)0x3c0;
        CASE_ORBIT[0x3a1] = (char)0x3c1;
        CASE_ORBIT[0x3a3] = (char)0x3c2;
        CASE_ORBIT[0x3a6] = (char)0x3c6;
        CASE_ORBIT[0x3a9] = (char)0x3c9;
        CASE_ORBIT[0x3b2] = (char)0x3d0;
        CASE_ORBIT[0x3b5] = (char)0x3f5;
        CASE_ORBIT[0x3b8] = (char)0x3d1;
        CASE_ORBIT[0x3b9] = (char)0x1fbe;
        CASE_ORBIT[0x3ba] = (char)0x3f0;
        CASE_ORBIT[0x3bc] = (char)0xb5;
        CASE_ORBIT[0x3c0] = (char)0x3d6;
        CASE_ORBIT[0x3c1] = (char)0x3f1;
        CASE_ORBIT[0x3c2] = (char)0x3c3;
        CASE_ORBIT[0x3c3] = (char)0x3a3;
        CASE_ORBIT[0x3c6] = (char)0x3d5;
        CASE_ORBIT[0x3c9] = (char)0x2126;
        CASE_ORBIT[0x3d0] = (char)0x392;
        CASE_ORBIT[0x3d1] = (char)0x3f4;
        CASE_ORBIT[0x3d5] = (char)0x3a6;
        CASE_ORBIT[0x3d6] = (char)0x3a0;
        CASE_ORBIT[0x3f0] = (char)0x39a;
        CASE_ORBIT[0x3f1] = (char)0x3a1;
        CASE_ORBIT[0x3f4] = (char)0x398;
        CASE_ORBIT[0x3f5] = (char)0x395;
        CASE_ORBIT[0x1e60] = (char)0x1e61;
        CASE_ORBIT[0x1e61] = (char)0x1e9b;
        CASE_ORBIT[0x1e9b] = (char)0x1e60;
        CASE_ORBIT[0x1e9e] = (char)0xdf;
        CASE_ORBIT[0x1fbe] = (char)0x345;
        CASE_ORBIT[0x2126] = (char)0x3a9;
        CASE_ORBIT[0x212a] = (char)0x4b;
        CASE_ORBIT[0x212b] = (char)0xc5;
    }

    private static int[][] make_Lu()
    {
        return new int[][] {
      new[]{0x0041, 0x005A, 1},
      new[]{0x00C0, 0x00D6, 1},
      new[]{0x00D8, 0x00DE, 1},
      new[]{0x0100, 0x0136, 2},
      new[]{0x0139, 0x0147, 2},
      new[]{0x014A, 0x0178, 2},
      new[]{0x0179, 0x017D, 2},
      new[]{0x0181, 0x0182, 1},
      new[]{0x0184, 0x0186, 2},
      new[]{0x0187, 0x0189, 2},
      new[]{0x018A, 0x018B, 1},
      new[]{0x018E, 0x0191, 1},
      new[]{0x0193, 0x0194, 1},
      new[]{0x0196, 0x0198, 1},
      new[]{0x019C, 0x019D, 1},
      new[]{0x019F, 0x01A0, 1},
      new[]{0x01A2, 0x01A6, 2},
      new[]{0x01A7, 0x01A9, 2},
      new[]{0x01AC, 0x01AE, 2},
      new[]{0x01AF, 0x01B1, 2},
      new[]{0x01B2, 0x01B3, 1},
      new[]{0x01B5, 0x01B7, 2},
      new[]{0x01B8, 0x01BC, 4},
      new[]{0x01C4, 0x01CD, 3},
      new[]{0x01CF, 0x01DB, 2},
      new[]{0x01DE, 0x01EE, 2},
      new[]{0x01F1, 0x01F4, 3},
      new[]{0x01F6, 0x01F8, 1},
      new[]{0x01FA, 0x0232, 2},
      new[]{0x023A, 0x023B, 1},
      new[]{0x023D, 0x023E, 1},
      new[]{0x0241, 0x0243, 2},
      new[]{0x0244, 0x0246, 1},
      new[]{0x0248, 0x024E, 2},
      new[]{0x0370, 0x0372, 2},
      new[]{0x0376, 0x0386, 16},
      new[]{0x0388, 0x038A, 1},
      new[]{0x038C, 0x038E, 2},
      new[]{0x038F, 0x0391, 2},
      new[]{0x0392, 0x03A1, 1},
      new[]{0x03A3, 0x03AB, 1},
      new[]{0x03CF, 0x03D2, 3},
      new[]{0x03D3, 0x03D4, 1},
      new[]{0x03D8, 0x03EE, 2},
      new[]{0x03F4, 0x03F7, 3},
      new[]{0x03F9, 0x03FA, 1},
      new[]{0x03FD, 0x042F, 1},
      new[]{0x0460, 0x0480, 2},
      new[]{0x048A, 0x04C0, 2},
      new[]{0x04C1, 0x04CD, 2},
      new[]{0x04D0, 0x0526, 2},
      new[]{0x0531, 0x0556, 1},
      new[]{0x10A0, 0x10C5, 1},
      new[]{0x1E00, 0x1E94, 2},
      new[]{0x1E9E, 0x1EFE, 2},
      new[]{0x1F08, 0x1F0F, 1},
      new[]{0x1F18, 0x1F1D, 1},
      new[]{0x1F28, 0x1F2F, 1},
      new[]{0x1F38, 0x1F3F, 1},
      new[]{0x1F48, 0x1F4D, 1},
      new[]{0x1F59, 0x1F5F, 2},
      new[]{0x1F68, 0x1F6F, 1},
      new[]{0x1FB8, 0x1FBB, 1},
      new[]{0x1FC8, 0x1FCB, 1},
      new[]{0x1FD8, 0x1FDB, 1},
      new[]{0x1FE8, 0x1FEC, 1},
      new[]{0x1FF8, 0x1FFB, 1},
      new[]{0x2102, 0x2107, 5},
      new[]{0x210B, 0x210D, 1},
      new[]{0x2110, 0x2112, 1},
      new[]{0x2115, 0x2119, 4},
      new[]{0x211A, 0x211D, 1},
      new[]{0x2124, 0x212A, 2},
      new[]{0x212B, 0x212D, 1},
      new[]{0x2130, 0x2133, 1},
      new[]{0x213E, 0x213F, 1},
      new[]{0x2145, 0x2183, 62},
      new[]{0x2C00, 0x2C2E, 1},
      new[]{0x2C60, 0x2C62, 2},
      new[]{0x2C63, 0x2C64, 1},
      new[]{0x2C67, 0x2C6D, 2},
      new[]{0x2C6E, 0x2C70, 1},
      new[]{0x2C72, 0x2C75, 3},
      new[]{0x2C7E, 0x2C80, 1},
      new[]{0x2C82, 0x2CE2, 2},
      new[]{0x2CEB, 0x2CED, 2},
      new[]{0xA640, 0xA66C, 2},
      new[]{0xA680, 0xA696, 2},
      new[]{0xA722, 0xA72E, 2},
      new[]{0xA732, 0xA76E, 2},
      new[]{0xA779, 0xA77D, 2},
      new[]{0xA77E, 0xA786, 2},
      new[]{0xA78B, 0xA78D, 2},
      new[]{0xA790, 0xA7A0, 16},
      new[]{0xA7A2, 0xA7A8, 2},
      new[]{0xFF21, 0xFF3A, 1},
      new[]{0x10400, 0x10427, 1},
      new[]{0x1D400, 0x1D419, 1},
      new[]{0x1D434, 0x1D44D, 1},
      new[]{0x1D468, 0x1D481, 1},
      new[]{0x1D49C, 0x1D49E, 2},
      new[]{0x1D49F, 0x1D4A5, 3},
      new[]{0x1D4A6, 0x1D4A9, 3},
      new[]{0x1D4AA, 0x1D4AC, 1},
      new[]{0x1D4AE, 0x1D4B5, 1},
      new[]{0x1D4D0, 0x1D4E9, 1},
      new[]{0x1D504, 0x1D505, 1},
      new[]{0x1D507, 0x1D50A, 1},
      new[]{0x1D50D, 0x1D514, 1},
      new[]{0x1D516, 0x1D51C, 1},
      new[]{0x1D538, 0x1D539, 1},
      new[]{0x1D53B, 0x1D53E, 1},
      new[]{0x1D540, 0x1D544, 1},
      new[]{0x1D546, 0x1D54A, 4},
      new[]{0x1D54B, 0x1D550, 1},
      new[]{0x1D56C, 0x1D585, 1},
      new[]{0x1D5A0, 0x1D5B9, 1},
      new[]{0x1D5D4, 0x1D5ED, 1},
      new[]{0x1D608, 0x1D621, 1},
      new[]{0x1D63C, 0x1D655, 1},
      new[]{0x1D670, 0x1D689, 1},
      new[]{0x1D6A8, 0x1D6C0, 1},
      new[]{0x1D6E2, 0x1D6FA, 1},
      new[]{0x1D71C, 0x1D734, 1},
      new[]{0x1D756, 0x1D76E, 1},
      new[]{0x1D790, 0x1D7A8, 1},
      new[]{0x1D7CA, 0x1D7CA, 1}
    };
    }

    private static int[][] make_Ll()
    {
        return new int[][] {
      new[]{0x0061, 0x007A, 1},
      new[]{0x00AA, 0x00B5, 11},
      new[]{0x00BA, 0x00DF, 37},
      new[]{0x00E0, 0x00F6, 1},
      new[]{0x00F8, 0x00FF, 1},
      new[]{0x0101, 0x0137, 2},
      new[]{0x0138, 0x0148, 2},
      new[]{0x0149, 0x0177, 2},
      new[]{0x017A, 0x017E, 2},
      new[]{0x017F, 0x0180, 1},
      new[]{0x0183, 0x0185, 2},
      new[]{0x0188, 0x018C, 4},
      new[]{0x018D, 0x0192, 5},
      new[]{0x0195, 0x0199, 4},
      new[]{0x019A, 0x019B, 1},
      new[]{0x019E, 0x01A1, 3},
      new[]{0x01A3, 0x01A5, 2},
      new[]{0x01A8, 0x01AA, 2},
      new[]{0x01AB, 0x01AD, 2},
      new[]{0x01B0, 0x01B4, 4},
      new[]{0x01B6, 0x01B9, 3},
      new[]{0x01BA, 0x01BD, 3},
      new[]{0x01BE, 0x01BF, 1},
      new[]{0x01C6, 0x01CC, 3},
      new[]{0x01CE, 0x01DC, 2},
      new[]{0x01DD, 0x01EF, 2},
      new[]{0x01F0, 0x01F3, 3},
      new[]{0x01F5, 0x01F9, 4},
      new[]{0x01FB, 0x0233, 2},
      new[]{0x0234, 0x0239, 1},
      new[]{0x023C, 0x023F, 3},
      new[]{0x0240, 0x0242, 2},
      new[]{0x0247, 0x024F, 2},
      new[]{0x0250, 0x0293, 1},
      new[]{0x0295, 0x02AF, 1},
      new[]{0x0371, 0x0373, 2},
      new[]{0x0377, 0x037B, 4},
      new[]{0x037C, 0x037D, 1},
      new[]{0x0390, 0x03AC, 28},
      new[]{0x03AD, 0x03CE, 1},
      new[]{0x03D0, 0x03D1, 1},
      new[]{0x03D5, 0x03D7, 1},
      new[]{0x03D9, 0x03EF, 2},
      new[]{0x03F0, 0x03F3, 1},
      new[]{0x03F5, 0x03FB, 3},
      new[]{0x03FC, 0x0430, 52},
      new[]{0x0431, 0x045F, 1},
      new[]{0x0461, 0x0481, 2},
      new[]{0x048B, 0x04BF, 2},
      new[]{0x04C2, 0x04CE, 2},
      new[]{0x04CF, 0x0527, 2},
      new[]{0x0561, 0x0587, 1},
      new[]{0x1D00, 0x1D2B, 1},
      new[]{0x1D62, 0x1D77, 1},
      new[]{0x1D79, 0x1D9A, 1},
      new[]{0x1E01, 0x1E95, 2},
      new[]{0x1E96, 0x1E9D, 1},
      new[]{0x1E9F, 0x1EFF, 2},
      new[]{0x1F00, 0x1F07, 1},
      new[]{0x1F10, 0x1F15, 1},
      new[]{0x1F20, 0x1F27, 1},
      new[]{0x1F30, 0x1F37, 1},
      new[]{0x1F40, 0x1F45, 1},
      new[]{0x1F50, 0x1F57, 1},
      new[]{0x1F60, 0x1F67, 1},
      new[]{0x1F70, 0x1F7D, 1},
      new[]{0x1F80, 0x1F87, 1},
      new[]{0x1F90, 0x1F97, 1},
      new[]{0x1FA0, 0x1FA7, 1},
      new[]{0x1FB0, 0x1FB4, 1},
      new[]{0x1FB6, 0x1FB7, 1},
      new[]{0x1FBE, 0x1FC2, 4},
      new[]{0x1FC3, 0x1FC4, 1},
      new[]{0x1FC6, 0x1FC7, 1},
      new[]{0x1FD0, 0x1FD3, 1},
      new[]{0x1FD6, 0x1FD7, 1},
      new[]{0x1FE0, 0x1FE7, 1},
      new[]{0x1FF2, 0x1FF4, 1},
      new[]{0x1FF6, 0x1FF7, 1},
      new[]{0x210A, 0x210E, 4},
      new[]{0x210F, 0x2113, 4},
      new[]{0x212F, 0x2139, 5},
      new[]{0x213C, 0x213D, 1},
      new[]{0x2146, 0x2149, 1},
      new[]{0x214E, 0x2184, 54},
      new[]{0x2C30, 0x2C5E, 1},
      new[]{0x2C61, 0x2C65, 4},
      new[]{0x2C66, 0x2C6C, 2},
      new[]{0x2C71, 0x2C73, 2},
      new[]{0x2C74, 0x2C76, 2},
      new[]{0x2C77, 0x2C7C, 1},
      new[]{0x2C81, 0x2CE3, 2},
      new[]{0x2CE4, 0x2CEC, 8},
      new[]{0x2CEE, 0x2D00, 18},
      new[]{0x2D01, 0x2D25, 1},
      new[]{0xA641, 0xA66D, 2},
      new[]{0xA681, 0xA697, 2},
      new[]{0xA723, 0xA72F, 2},
      new[]{0xA730, 0xA731, 1},
      new[]{0xA733, 0xA771, 2},
      new[]{0xA772, 0xA778, 1},
      new[]{0xA77A, 0xA77C, 2},
      new[]{0xA77F, 0xA787, 2},
      new[]{0xA78C, 0xA78E, 2},
      new[]{0xA791, 0xA7A1, 16},
      new[]{0xA7A3, 0xA7A9, 2},
      new[]{0xA7FA, 0xFB00, 21254},
      new[]{0xFB01, 0xFB06, 1},
      new[]{0xFB13, 0xFB17, 1},
      new[]{0xFF41, 0xFF5A, 1},
      new[]{0x10428, 0x1044F, 1},
      new[]{0x1D41A, 0x1D433, 1},
      new[]{0x1D44E, 0x1D454, 1},
      new[]{0x1D456, 0x1D467, 1},
      new[]{0x1D482, 0x1D49B, 1},
      new[]{0x1D4B6, 0x1D4B9, 1},
      new[]{0x1D4BB, 0x1D4BD, 2},
      new[]{0x1D4BE, 0x1D4C3, 1},
      new[]{0x1D4C5, 0x1D4CF, 1},
      new[]{0x1D4EA, 0x1D503, 1},
      new[]{0x1D51E, 0x1D537, 1},
      new[]{0x1D552, 0x1D56B, 1},
      new[]{0x1D586, 0x1D59F, 1},
      new[]{0x1D5BA, 0x1D5D3, 1},
      new[]{0x1D5EE, 0x1D607, 1},
      new[]{0x1D622, 0x1D63B, 1},
      new[]{0x1D656, 0x1D66F, 1},
      new[]{0x1D68A, 0x1D6A5, 1},
      new[]{0x1D6C2, 0x1D6DA, 1},
      new[]{0x1D6DC, 0x1D6E1, 1},
      new[]{0x1D6FC, 0x1D714, 1},
      new[]{0x1D716, 0x1D71B, 1},
      new[]{0x1D736, 0x1D74E, 1},
      new[]{0x1D750, 0x1D755, 1},
      new[]{0x1D770, 0x1D788, 1},
      new[]{0x1D78A, 0x1D78F, 1},
      new[]{0x1D7AA, 0x1D7C2, 1},
      new[]{0x1D7C4, 0x1D7C9, 1},
      new[]{0x1D7CB, 0x1D7CB, 1}
    };
    }

    private static int[][] make_Lt()
    {
        return new int[][] {
      new[]{0x01C5, 0x01CB, 3},
      new[]{0x01F2, 0x1F88, 7574},
      new[]{0x1F89, 0x1F8F, 1},
      new[]{0x1F98, 0x1F9F, 1},
      new[]{0x1FA8, 0x1FAF, 1},
      new[]{0x1FBC, 0x1FCC, 16},
      new[]{0x1FFC, 0x1FFC, 1}
    };
    }

    private static int[][] make_Lm()
    {
        return new int[][] {
      new[]{0x02B0, 0x02C1, 1},
      new[]{0x02C6, 0x02D1, 1},
      new[]{0x02E0, 0x02E4, 1},
      new[]{0x02EC, 0x02EE, 2},
      new[]{0x0374, 0x037A, 6},
      new[]{0x0559, 0x0640, 231},
      new[]{0x06E5, 0x06E6, 1},
      new[]{0x07F4, 0x07F5, 1},
      new[]{0x07FA, 0x081A, 32},
      new[]{0x0824, 0x0828, 4},
      new[]{0x0971, 0x0E46, 1237},
      new[]{0x0EC6, 0x10FC, 566},
      new[]{0x17D7, 0x1843, 108},
      new[]{0x1AA7, 0x1C78, 465},
      new[]{0x1C79, 0x1C7D, 1},
      new[]{0x1D2C, 0x1D61, 1},
      new[]{0x1D78, 0x1D9B, 35},
      new[]{0x1D9C, 0x1DBF, 1},
      new[]{0x2071, 0x207F, 14},
      new[]{0x2090, 0x209C, 1},
      new[]{0x2C7D, 0x2D6F, 242},
      new[]{0x2E2F, 0x3005, 470},
      new[]{0x3031, 0x3035, 1},
      new[]{0x303B, 0x309D, 98},
      new[]{0x309E, 0x30FC, 94},
      new[]{0x30FD, 0x30FE, 1},
      new[]{0xA015, 0xA4F8, 1251},
      new[]{0xA4F9, 0xA4FD, 1},
      new[]{0xA60C, 0xA67F, 115},
      new[]{0xA717, 0xA71F, 1},
      new[]{0xA770, 0xA788, 24},
      new[]{0xA9CF, 0xAA70, 161},
      new[]{0xAADD, 0xFF70, 21651},
      new[]{0xFF9E, 0xFF9F, 1}
    };
    }

    private static int[][] make_Lo()
    {
        return new int[][] {
      new[]{0x01BB, 0x01C0, 5},
      new[]{0x01C1, 0x01C3, 1},
      new[]{0x0294, 0x05D0, 828},
      new[]{0x05D1, 0x05EA, 1},
      new[]{0x05F0, 0x05F2, 1},
      new[]{0x0620, 0x063F, 1},
      new[]{0x0641, 0x064A, 1},
      new[]{0x066E, 0x066F, 1},
      new[]{0x0671, 0x06D3, 1},
      new[]{0x06D5, 0x06EE, 25},
      new[]{0x06EF, 0x06FA, 11},
      new[]{0x06FB, 0x06FC, 1},
      new[]{0x06FF, 0x0710, 17},
      new[]{0x0712, 0x072F, 1},
      new[]{0x074D, 0x07A5, 1},
      new[]{0x07B1, 0x07CA, 25},
      new[]{0x07CB, 0x07EA, 1},
      new[]{0x0800, 0x0815, 1},
      new[]{0x0840, 0x0858, 1},
      new[]{0x0904, 0x0939, 1},
      new[]{0x093D, 0x0950, 19},
      new[]{0x0958, 0x0961, 1},
      new[]{0x0972, 0x0977, 1},
      new[]{0x0979, 0x097F, 1},
      new[]{0x0985, 0x098C, 1},
      new[]{0x098F, 0x0990, 1},
      new[]{0x0993, 0x09A8, 1},
      new[]{0x09AA, 0x09B0, 1},
      new[]{0x09B2, 0x09B6, 4},
      new[]{0x09B7, 0x09B9, 1},
      new[]{0x09BD, 0x09CE, 17},
      new[]{0x09DC, 0x09DD, 1},
      new[]{0x09DF, 0x09E1, 1},
      new[]{0x09F0, 0x09F1, 1},
      new[]{0x0A05, 0x0A0A, 1},
      new[]{0x0A0F, 0x0A10, 1},
      new[]{0x0A13, 0x0A28, 1},
      new[]{0x0A2A, 0x0A30, 1},
      new[]{0x0A32, 0x0A33, 1},
      new[]{0x0A35, 0x0A36, 1},
      new[]{0x0A38, 0x0A39, 1},
      new[]{0x0A59, 0x0A5C, 1},
      new[]{0x0A5E, 0x0A72, 20},
      new[]{0x0A73, 0x0A74, 1},
      new[]{0x0A85, 0x0A8D, 1},
      new[]{0x0A8F, 0x0A91, 1},
      new[]{0x0A93, 0x0AA8, 1},
      new[]{0x0AAA, 0x0AB0, 1},
      new[]{0x0AB2, 0x0AB3, 1},
      new[]{0x0AB5, 0x0AB9, 1},
      new[]{0x0ABD, 0x0AD0, 19},
      new[]{0x0AE0, 0x0AE1, 1},
      new[]{0x0B05, 0x0B0C, 1},
      new[]{0x0B0F, 0x0B10, 1},
      new[]{0x0B13, 0x0B28, 1},
      new[]{0x0B2A, 0x0B30, 1},
      new[]{0x0B32, 0x0B33, 1},
      new[]{0x0B35, 0x0B39, 1},
      new[]{0x0B3D, 0x0B5C, 31},
      new[]{0x0B5D, 0x0B5F, 2},
      new[]{0x0B60, 0x0B61, 1},
      new[]{0x0B71, 0x0B83, 18},
      new[]{0x0B85, 0x0B8A, 1},
      new[]{0x0B8E, 0x0B90, 1},
      new[]{0x0B92, 0x0B95, 1},
      new[]{0x0B99, 0x0B9A, 1},
      new[]{0x0B9C, 0x0B9E, 2},
      new[]{0x0B9F, 0x0BA3, 4},
      new[]{0x0BA4, 0x0BA8, 4},
      new[]{0x0BA9, 0x0BAA, 1},
      new[]{0x0BAE, 0x0BB9, 1},
      new[]{0x0BD0, 0x0C05, 53},
      new[]{0x0C06, 0x0C0C, 1},
      new[]{0x0C0E, 0x0C10, 1},
      new[]{0x0C12, 0x0C28, 1},
      new[]{0x0C2A, 0x0C33, 1},
      new[]{0x0C35, 0x0C39, 1},
      new[]{0x0C3D, 0x0C58, 27},
      new[]{0x0C59, 0x0C60, 7},
      new[]{0x0C61, 0x0C85, 36},
      new[]{0x0C86, 0x0C8C, 1},
      new[]{0x0C8E, 0x0C90, 1},
      new[]{0x0C92, 0x0CA8, 1},
      new[]{0x0CAA, 0x0CB3, 1},
      new[]{0x0CB5, 0x0CB9, 1},
      new[]{0x0CBD, 0x0CDE, 33},
      new[]{0x0CE0, 0x0CE1, 1},
      new[]{0x0CF1, 0x0CF2, 1},
      new[]{0x0D05, 0x0D0C, 1},
      new[]{0x0D0E, 0x0D10, 1},
      new[]{0x0D12, 0x0D3A, 1},
      new[]{0x0D3D, 0x0D4E, 17},
      new[]{0x0D60, 0x0D61, 1},
      new[]{0x0D7A, 0x0D7F, 1},
      new[]{0x0D85, 0x0D96, 1},
      new[]{0x0D9A, 0x0DB1, 1},
      new[]{0x0DB3, 0x0DBB, 1},
      new[]{0x0DBD, 0x0DC0, 3},
      new[]{0x0DC1, 0x0DC6, 1},
      new[]{0x0E01, 0x0E30, 1},
      new[]{0x0E32, 0x0E33, 1},
      new[]{0x0E40, 0x0E45, 1},
      new[]{0x0E81, 0x0E82, 1},
      new[]{0x0E84, 0x0E87, 3},
      new[]{0x0E88, 0x0E8A, 2},
      new[]{0x0E8D, 0x0E94, 7},
      new[]{0x0E95, 0x0E97, 1},
      new[]{0x0E99, 0x0E9F, 1},
      new[]{0x0EA1, 0x0EA3, 1},
      new[]{0x0EA5, 0x0EA7, 2},
      new[]{0x0EAA, 0x0EAB, 1},
      new[]{0x0EAD, 0x0EB0, 1},
      new[]{0x0EB2, 0x0EB3, 1},
      new[]{0x0EBD, 0x0EC0, 3},
      new[]{0x0EC1, 0x0EC4, 1},
      new[]{0x0EDC, 0x0EDD, 1},
      new[]{0x0F00, 0x0F40, 64},
      new[]{0x0F41, 0x0F47, 1},
      new[]{0x0F49, 0x0F6C, 1},
      new[]{0x0F88, 0x0F8C, 1},
      new[]{0x1000, 0x102A, 1},
      new[]{0x103F, 0x1050, 17},
      new[]{0x1051, 0x1055, 1},
      new[]{0x105A, 0x105D, 1},
      new[]{0x1061, 0x1065, 4},
      new[]{0x1066, 0x106E, 8},
      new[]{0x106F, 0x1070, 1},
      new[]{0x1075, 0x1081, 1},
      new[]{0x108E, 0x10D0, 66},
      new[]{0x10D1, 0x10FA, 1},
      new[]{0x1100, 0x1248, 1},
      new[]{0x124A, 0x124D, 1},
      new[]{0x1250, 0x1256, 1},
      new[]{0x1258, 0x125A, 2},
      new[]{0x125B, 0x125D, 1},
      new[]{0x1260, 0x1288, 1},
      new[]{0x128A, 0x128D, 1},
      new[]{0x1290, 0x12B0, 1},
      new[]{0x12B2, 0x12B5, 1},
      new[]{0x12B8, 0x12BE, 1},
      new[]{0x12C0, 0x12C2, 2},
      new[]{0x12C3, 0x12C5, 1},
      new[]{0x12C8, 0x12D6, 1},
      new[]{0x12D8, 0x1310, 1},
      new[]{0x1312, 0x1315, 1},
      new[]{0x1318, 0x135A, 1},
      new[]{0x1380, 0x138F, 1},
      new[]{0x13A0, 0x13F4, 1},
      new[]{0x1401, 0x166C, 1},
      new[]{0x166F, 0x167F, 1},
      new[]{0x1681, 0x169A, 1},
      new[]{0x16A0, 0x16EA, 1},
      new[]{0x1700, 0x170C, 1},
      new[]{0x170E, 0x1711, 1},
      new[]{0x1720, 0x1731, 1},
      new[]{0x1740, 0x1751, 1},
      new[]{0x1760, 0x176C, 1},
      new[]{0x176E, 0x1770, 1},
      new[]{0x1780, 0x17B3, 1},
      new[]{0x17DC, 0x1820, 68},
      new[]{0x1821, 0x1842, 1},
      new[]{0x1844, 0x1877, 1},
      new[]{0x1880, 0x18A8, 1},
      new[]{0x18AA, 0x18B0, 6},
      new[]{0x18B1, 0x18F5, 1},
      new[]{0x1900, 0x191C, 1},
      new[]{0x1950, 0x196D, 1},
      new[]{0x1970, 0x1974, 1},
      new[]{0x1980, 0x19AB, 1},
      new[]{0x19C1, 0x19C7, 1},
      new[]{0x1A00, 0x1A16, 1},
      new[]{0x1A20, 0x1A54, 1},
      new[]{0x1B05, 0x1B33, 1},
      new[]{0x1B45, 0x1B4B, 1},
      new[]{0x1B83, 0x1BA0, 1},
      new[]{0x1BAE, 0x1BAF, 1},
      new[]{0x1BC0, 0x1BE5, 1},
      new[]{0x1C00, 0x1C23, 1},
      new[]{0x1C4D, 0x1C4F, 1},
      new[]{0x1C5A, 0x1C77, 1},
      new[]{0x1CE9, 0x1CEC, 1},
      new[]{0x1CEE, 0x1CF1, 1},
      new[]{0x2135, 0x2138, 1},
      new[]{0x2D30, 0x2D65, 1},
      new[]{0x2D80, 0x2D96, 1},
      new[]{0x2DA0, 0x2DA6, 1},
      new[]{0x2DA8, 0x2DAE, 1},
      new[]{0x2DB0, 0x2DB6, 1},
      new[]{0x2DB8, 0x2DBE, 1},
      new[]{0x2DC0, 0x2DC6, 1},
      new[]{0x2DC8, 0x2DCE, 1},
      new[]{0x2DD0, 0x2DD6, 1},
      new[]{0x2DD8, 0x2DDE, 1},
      new[]{0x3006, 0x303C, 54},
      new[]{0x3041, 0x3096, 1},
      new[]{0x309F, 0x30A1, 2},
      new[]{0x30A2, 0x30FA, 1},
      new[]{0x30FF, 0x3105, 6},
      new[]{0x3106, 0x312D, 1},
      new[]{0x3131, 0x318E, 1},
      new[]{0x31A0, 0x31BA, 1},
      new[]{0x31F0, 0x31FF, 1},
      new[]{0x3400, 0x4DB5, 1},
      new[]{0x4E00, 0x9FCB, 1},
      new[]{0xA000, 0xA014, 1},
      new[]{0xA016, 0xA48C, 1},
      new[]{0xA4D0, 0xA4F7, 1},
      new[]{0xA500, 0xA60B, 1},
      new[]{0xA610, 0xA61F, 1},
      new[]{0xA62A, 0xA62B, 1},
      new[]{0xA66E, 0xA6A0, 50},
      new[]{0xA6A1, 0xA6E5, 1},
      new[]{0xA7FB, 0xA801, 1},
      new[]{0xA803, 0xA805, 1},
      new[]{0xA807, 0xA80A, 1},
      new[]{0xA80C, 0xA822, 1},
      new[]{0xA840, 0xA873, 1},
      new[]{0xA882, 0xA8B3, 1},
      new[]{0xA8F2, 0xA8F7, 1},
      new[]{0xA8FB, 0xA90A, 15},
      new[]{0xA90B, 0xA925, 1},
      new[]{0xA930, 0xA946, 1},
      new[]{0xA960, 0xA97C, 1},
      new[]{0xA984, 0xA9B2, 1},
      new[]{0xAA00, 0xAA28, 1},
      new[]{0xAA40, 0xAA42, 1},
      new[]{0xAA44, 0xAA4B, 1},
      new[]{0xAA60, 0xAA6F, 1},
      new[]{0xAA71, 0xAA76, 1},
      new[]{0xAA7A, 0xAA80, 6},
      new[]{0xAA81, 0xAAAF, 1},
      new[]{0xAAB1, 0xAAB5, 4},
      new[]{0xAAB6, 0xAAB9, 3},
      new[]{0xAABA, 0xAABD, 1},
      new[]{0xAAC0, 0xAAC2, 2},
      new[]{0xAADB, 0xAADC, 1},
      new[]{0xAB01, 0xAB06, 1},
      new[]{0xAB09, 0xAB0E, 1},
      new[]{0xAB11, 0xAB16, 1},
      new[]{0xAB20, 0xAB26, 1},
      new[]{0xAB28, 0xAB2E, 1},
      new[]{0xABC0, 0xABE2, 1},
      new[]{0xAC00, 0xD7A3, 1},
      new[]{0xD7B0, 0xD7C6, 1},
      new[]{0xD7CB, 0xD7FB, 1},
      new[]{0xF900, 0xFA2D, 1},
      new[]{0xFA30, 0xFA6D, 1},
      new[]{0xFA70, 0xFAD9, 1},
      new[]{0xFB1D, 0xFB1F, 2},
      new[]{0xFB20, 0xFB28, 1},
      new[]{0xFB2A, 0xFB36, 1},
      new[]{0xFB38, 0xFB3C, 1},
      new[]{0xFB3E, 0xFB40, 2},
      new[]{0xFB41, 0xFB43, 2},
      new[]{0xFB44, 0xFB46, 2},
      new[]{0xFB47, 0xFBB1, 1},
      new[]{0xFBD3, 0xFD3D, 1},
      new[]{0xFD50, 0xFD8F, 1},
      new[]{0xFD92, 0xFDC7, 1},
      new[]{0xFDF0, 0xFDFB, 1},
      new[]{0xFE70, 0xFE74, 1},
      new[]{0xFE76, 0xFEFC, 1},
      new[]{0xFF66, 0xFF6F, 1},
      new[]{0xFF71, 0xFF9D, 1},
      new[]{0xFFA0, 0xFFBE, 1},
      new[]{0xFFC2, 0xFFC7, 1},
      new[]{0xFFCA, 0xFFCF, 1},
      new[]{0xFFD2, 0xFFD7, 1},
      new[]{0xFFDA, 0xFFDC, 1},
      new[]{0x10000, 0x1000B, 1},
      new[]{0x1000D, 0x10026, 1},
      new[]{0x10028, 0x1003A, 1},
      new[]{0x1003C, 0x1003D, 1},
      new[]{0x1003F, 0x1004D, 1},
      new[]{0x10050, 0x1005D, 1},
      new[]{0x10080, 0x100FA, 1},
      new[]{0x10280, 0x1029C, 1},
      new[]{0x102A0, 0x102D0, 1},
      new[]{0x10300, 0x1031E, 1},
      new[]{0x10330, 0x10340, 1},
      new[]{0x10342, 0x10349, 1},
      new[]{0x10380, 0x1039D, 1},
      new[]{0x103A0, 0x103C3, 1},
      new[]{0x103C8, 0x103CF, 1},
      new[]{0x10450, 0x1049D, 1},
      new[]{0x10800, 0x10805, 1},
      new[]{0x10808, 0x1080A, 2},
      new[]{0x1080B, 0x10835, 1},
      new[]{0x10837, 0x10838, 1},
      new[]{0x1083C, 0x1083F, 3},
      new[]{0x10840, 0x10855, 1},
      new[]{0x10900, 0x10915, 1},
      new[]{0x10920, 0x10939, 1},
      new[]{0x10A00, 0x10A10, 16},
      new[]{0x10A11, 0x10A13, 1},
      new[]{0x10A15, 0x10A17, 1},
      new[]{0x10A19, 0x10A33, 1},
      new[]{0x10A60, 0x10A7C, 1},
      new[]{0x10B00, 0x10B35, 1},
      new[]{0x10B40, 0x10B55, 1},
      new[]{0x10B60, 0x10B72, 1},
      new[]{0x10C00, 0x10C48, 1},
      new[]{0x11003, 0x11037, 1},
      new[]{0x11083, 0x110AF, 1},
      new[]{0x12000, 0x1236E, 1},
      new[]{0x13000, 0x1342E, 1},
      new[]{0x16800, 0x16A38, 1},
      new[]{0x1B000, 0x1B001, 1},
      new[]{0x20000, 0x2A6D6, 1},
      new[]{0x2A700, 0x2B734, 1},
      new[]{0x2B740, 0x2B81D, 1},
      new[]{0x2F800, 0x2FA1D, 1}
    };
    }

    private static int[][] make_Mn()
    {
        return new int[][] {
      new[]{0x0300, 0x036F, 1},
      new[]{0x0483, 0x0487, 1},
      new[]{0x0591, 0x05BD, 1},
      new[]{0x05BF, 0x05C1, 2},
      new[]{0x05C2, 0x05C4, 2},
      new[]{0x05C5, 0x05C7, 2},
      new[]{0x0610, 0x061A, 1},
      new[]{0x064B, 0x065F, 1},
      new[]{0x0670, 0x06D6, 102},
      new[]{0x06D7, 0x06DC, 1},
      new[]{0x06DF, 0x06E4, 1},
      new[]{0x06E7, 0x06E8, 1},
      new[]{0x06EA, 0x06ED, 1},
      new[]{0x0711, 0x0730, 31},
      new[]{0x0731, 0x074A, 1},
      new[]{0x07A6, 0x07B0, 1},
      new[]{0x07EB, 0x07F3, 1},
      new[]{0x0816, 0x0819, 1},
      new[]{0x081B, 0x0823, 1},
      new[]{0x0825, 0x0827, 1},
      new[]{0x0829, 0x082D, 1},
      new[]{0x0859, 0x085B, 1},
      new[]{0x0900, 0x0902, 1},
      new[]{0x093A, 0x093C, 2},
      new[]{0x0941, 0x0948, 1},
      new[]{0x094D, 0x0951, 4},
      new[]{0x0952, 0x0957, 1},
      new[]{0x0962, 0x0963, 1},
      new[]{0x0981, 0x09BC, 59},
      new[]{0x09C1, 0x09C4, 1},
      new[]{0x09CD, 0x09E2, 21},
      new[]{0x09E3, 0x0A01, 30},
      new[]{0x0A02, 0x0A3C, 58},
      new[]{0x0A41, 0x0A42, 1},
      new[]{0x0A47, 0x0A48, 1},
      new[]{0x0A4B, 0x0A4D, 1},
      new[]{0x0A51, 0x0A70, 31},
      new[]{0x0A71, 0x0A75, 4},
      new[]{0x0A81, 0x0A82, 1},
      new[]{0x0ABC, 0x0AC1, 5},
      new[]{0x0AC2, 0x0AC5, 1},
      new[]{0x0AC7, 0x0AC8, 1},
      new[]{0x0ACD, 0x0AE2, 21},
      new[]{0x0AE3, 0x0B01, 30},
      new[]{0x0B3C, 0x0B3F, 3},
      new[]{0x0B41, 0x0B44, 1},
      new[]{0x0B4D, 0x0B56, 9},
      new[]{0x0B62, 0x0B63, 1},
      new[]{0x0B82, 0x0BC0, 62},
      new[]{0x0BCD, 0x0C3E, 113},
      new[]{0x0C3F, 0x0C40, 1},
      new[]{0x0C46, 0x0C48, 1},
      new[]{0x0C4A, 0x0C4D, 1},
      new[]{0x0C55, 0x0C56, 1},
      new[]{0x0C62, 0x0C63, 1},
      new[]{0x0CBC, 0x0CBF, 3},
      new[]{0x0CC6, 0x0CCC, 6},
      new[]{0x0CCD, 0x0CE2, 21},
      new[]{0x0CE3, 0x0D41, 94},
      new[]{0x0D42, 0x0D44, 1},
      new[]{0x0D4D, 0x0D62, 21},
      new[]{0x0D63, 0x0DCA, 103},
      new[]{0x0DD2, 0x0DD4, 1},
      new[]{0x0DD6, 0x0E31, 91},
      new[]{0x0E34, 0x0E3A, 1},
      new[]{0x0E47, 0x0E4E, 1},
      new[]{0x0EB1, 0x0EB4, 3},
      new[]{0x0EB5, 0x0EB9, 1},
      new[]{0x0EBB, 0x0EBC, 1},
      new[]{0x0EC8, 0x0ECD, 1},
      new[]{0x0F18, 0x0F19, 1},
      new[]{0x0F35, 0x0F39, 2},
      new[]{0x0F71, 0x0F7E, 1},
      new[]{0x0F80, 0x0F84, 1},
      new[]{0x0F86, 0x0F87, 1},
      new[]{0x0F8D, 0x0F97, 1},
      new[]{0x0F99, 0x0FBC, 1},
      new[]{0x0FC6, 0x102D, 103},
      new[]{0x102E, 0x1030, 1},
      new[]{0x1032, 0x1037, 1},
      new[]{0x1039, 0x103A, 1},
      new[]{0x103D, 0x103E, 1},
      new[]{0x1058, 0x1059, 1},
      new[]{0x105E, 0x1060, 1},
      new[]{0x1071, 0x1074, 1},
      new[]{0x1082, 0x1085, 3},
      new[]{0x1086, 0x108D, 7},
      new[]{0x109D, 0x135D, 704},
      new[]{0x135E, 0x135F, 1},
      new[]{0x1712, 0x1714, 1},
      new[]{0x1732, 0x1734, 1},
      new[]{0x1752, 0x1753, 1},
      new[]{0x1772, 0x1773, 1},
      new[]{0x17B7, 0x17BD, 1},
      new[]{0x17C6, 0x17C9, 3},
      new[]{0x17CA, 0x17D3, 1},
      new[]{0x17DD, 0x180B, 46},
      new[]{0x180C, 0x180D, 1},
      new[]{0x18A9, 0x1920, 119},
      new[]{0x1921, 0x1922, 1},
      new[]{0x1927, 0x1928, 1},
      new[]{0x1932, 0x1939, 7},
      new[]{0x193A, 0x193B, 1},
      new[]{0x1A17, 0x1A18, 1},
      new[]{0x1A56, 0x1A58, 2},
      new[]{0x1A59, 0x1A5E, 1},
      new[]{0x1A60, 0x1A62, 2},
      new[]{0x1A65, 0x1A6C, 1},
      new[]{0x1A73, 0x1A7C, 1},
      new[]{0x1A7F, 0x1B00, 129},
      new[]{0x1B01, 0x1B03, 1},
      new[]{0x1B34, 0x1B36, 2},
      new[]{0x1B37, 0x1B3A, 1},
      new[]{0x1B3C, 0x1B42, 6},
      new[]{0x1B6B, 0x1B73, 1},
      new[]{0x1B80, 0x1B81, 1},
      new[]{0x1BA2, 0x1BA5, 1},
      new[]{0x1BA8, 0x1BA9, 1},
      new[]{0x1BE6, 0x1BE8, 2},
      new[]{0x1BE9, 0x1BED, 4},
      new[]{0x1BEF, 0x1BF1, 1},
      new[]{0x1C2C, 0x1C33, 1},
      new[]{0x1C36, 0x1C37, 1},
      new[]{0x1CD0, 0x1CD2, 1},
      new[]{0x1CD4, 0x1CE0, 1},
      new[]{0x1CE2, 0x1CE8, 1},
      new[]{0x1CED, 0x1DC0, 211},
      new[]{0x1DC1, 0x1DE6, 1},
      new[]{0x1DFC, 0x1DFF, 1},
      new[]{0x20D0, 0x20DC, 1},
      new[]{0x20E1, 0x20E5, 4},
      new[]{0x20E6, 0x20F0, 1},
      new[]{0x2CEF, 0x2CF1, 1},
      new[]{0x2D7F, 0x2DE0, 97},
      new[]{0x2DE1, 0x2DFF, 1},
      new[]{0x302A, 0x302F, 1},
      new[]{0x3099, 0x309A, 1},
      new[]{0xA66F, 0xA67C, 13},
      new[]{0xA67D, 0xA6F0, 115},
      new[]{0xA6F1, 0xA802, 273},
      new[]{0xA806, 0xA80B, 5},
      new[]{0xA825, 0xA826, 1},
      new[]{0xA8C4, 0xA8E0, 28},
      new[]{0xA8E1, 0xA8F1, 1},
      new[]{0xA926, 0xA92D, 1},
      new[]{0xA947, 0xA951, 1},
      new[]{0xA980, 0xA982, 1},
      new[]{0xA9B3, 0xA9B6, 3},
      new[]{0xA9B7, 0xA9B9, 1},
      new[]{0xA9BC, 0xAA29, 109},
      new[]{0xAA2A, 0xAA2E, 1},
      new[]{0xAA31, 0xAA32, 1},
      new[]{0xAA35, 0xAA36, 1},
      new[]{0xAA43, 0xAA4C, 9},
      new[]{0xAAB0, 0xAAB2, 2},
      new[]{0xAAB3, 0xAAB4, 1},
      new[]{0xAAB7, 0xAAB8, 1},
      new[]{0xAABE, 0xAABF, 1},
      new[]{0xAAC1, 0xABE5, 292},
      new[]{0xABE8, 0xABED, 5},
      new[]{0xFB1E, 0xFE00, 738},
      new[]{0xFE01, 0xFE0F, 1},
      new[]{0xFE20, 0xFE26, 1},
      new[]{0x101FD, 0x10A01, 2052},
      new[]{0x10A02, 0x10A03, 1},
      new[]{0x10A05, 0x10A06, 1},
      new[]{0x10A0C, 0x10A0F, 1},
      new[]{0x10A38, 0x10A3A, 1},
      new[]{0x10A3F, 0x11001, 1474},
      new[]{0x11038, 0x11046, 1},
      new[]{0x11080, 0x11081, 1},
      new[]{0x110B3, 0x110B6, 1},
      new[]{0x110B9, 0x110BA, 1},
      new[]{0x1D167, 0x1D169, 1},
      new[]{0x1D17B, 0x1D182, 1},
      new[]{0x1D185, 0x1D18B, 1},
      new[]{0x1D1AA, 0x1D1AD, 1},
      new[]{0x1D242, 0x1D244, 1},
      new[]{0xE0100, 0xE01EF, 1}
    };
    }

    private static int[][] make_Me()
    {
        return new int[][] {
      new[]{0x0488, 0x0489, 1},
      new[]{0x20DD, 0x20E0, 1},
      new[]{0x20E2, 0x20E4, 1},
      new[]{0xA670, 0xA672, 1}
    };
    }

    private static int[][] make_Mc()
    {
        return new int[][] {
      new[]{0x0903, 0x093B, 56},
      new[]{0x093E, 0x0940, 1},
      new[]{0x0949, 0x094C, 1},
      new[]{0x094E, 0x094F, 1},
      new[]{0x0982, 0x0983, 1},
      new[]{0x09BE, 0x09C0, 1},
      new[]{0x09C7, 0x09C8, 1},
      new[]{0x09CB, 0x09CC, 1},
      new[]{0x09D7, 0x0A03, 44},
      new[]{0x0A3E, 0x0A40, 1},
      new[]{0x0A83, 0x0ABE, 59},
      new[]{0x0ABF, 0x0AC0, 1},
      new[]{0x0AC9, 0x0ACB, 2},
      new[]{0x0ACC, 0x0B02, 54},
      new[]{0x0B03, 0x0B3E, 59},
      new[]{0x0B40, 0x0B47, 7},
      new[]{0x0B48, 0x0B4B, 3},
      new[]{0x0B4C, 0x0B57, 11},
      new[]{0x0BBE, 0x0BBF, 1},
      new[]{0x0BC1, 0x0BC2, 1},
      new[]{0x0BC6, 0x0BC8, 1},
      new[]{0x0BCA, 0x0BCC, 1},
      new[]{0x0BD7, 0x0C01, 42},
      new[]{0x0C02, 0x0C03, 1},
      new[]{0x0C41, 0x0C44, 1},
      new[]{0x0C82, 0x0C83, 1},
      new[]{0x0CBE, 0x0CC0, 2},
      new[]{0x0CC1, 0x0CC4, 1},
      new[]{0x0CC7, 0x0CC8, 1},
      new[]{0x0CCA, 0x0CCB, 1},
      new[]{0x0CD5, 0x0CD6, 1},
      new[]{0x0D02, 0x0D03, 1},
      new[]{0x0D3E, 0x0D40, 1},
      new[]{0x0D46, 0x0D48, 1},
      new[]{0x0D4A, 0x0D4C, 1},
      new[]{0x0D57, 0x0D82, 43},
      new[]{0x0D83, 0x0DCF, 76},
      new[]{0x0DD0, 0x0DD1, 1},
      new[]{0x0DD8, 0x0DDF, 1},
      new[]{0x0DF2, 0x0DF3, 1},
      new[]{0x0F3E, 0x0F3F, 1},
      new[]{0x0F7F, 0x102B, 172},
      new[]{0x102C, 0x1031, 5},
      new[]{0x1038, 0x103B, 3},
      new[]{0x103C, 0x1056, 26},
      new[]{0x1057, 0x1062, 11},
      new[]{0x1063, 0x1064, 1},
      new[]{0x1067, 0x106D, 1},
      new[]{0x1083, 0x1084, 1},
      new[]{0x1087, 0x108C, 1},
      new[]{0x108F, 0x109A, 11},
      new[]{0x109B, 0x109C, 1},
      new[]{0x17B6, 0x17BE, 8},
      new[]{0x17BF, 0x17C5, 1},
      new[]{0x17C7, 0x17C8, 1},
      new[]{0x1923, 0x1926, 1},
      new[]{0x1929, 0x192B, 1},
      new[]{0x1930, 0x1931, 1},
      new[]{0x1933, 0x1938, 1},
      new[]{0x19B0, 0x19C0, 1},
      new[]{0x19C8, 0x19C9, 1},
      new[]{0x1A19, 0x1A1B, 1},
      new[]{0x1A55, 0x1A57, 2},
      new[]{0x1A61, 0x1A63, 2},
      new[]{0x1A64, 0x1A6D, 9},
      new[]{0x1A6E, 0x1A72, 1},
      new[]{0x1B04, 0x1B35, 49},
      new[]{0x1B3B, 0x1B3D, 2},
      new[]{0x1B3E, 0x1B41, 1},
      new[]{0x1B43, 0x1B44, 1},
      new[]{0x1B82, 0x1BA1, 31},
      new[]{0x1BA6, 0x1BA7, 1},
      new[]{0x1BAA, 0x1BE7, 61},
      new[]{0x1BEA, 0x1BEC, 1},
      new[]{0x1BEE, 0x1BF2, 4},
      new[]{0x1BF3, 0x1C24, 49},
      new[]{0x1C25, 0x1C2B, 1},
      new[]{0x1C34, 0x1C35, 1},
      new[]{0x1CE1, 0x1CF2, 17},
      new[]{0xA823, 0xA824, 1},
      new[]{0xA827, 0xA880, 89},
      new[]{0xA881, 0xA8B4, 51},
      new[]{0xA8B5, 0xA8C3, 1},
      new[]{0xA952, 0xA953, 1},
      new[]{0xA983, 0xA9B4, 49},
      new[]{0xA9B5, 0xA9BA, 5},
      new[]{0xA9BB, 0xA9BD, 2},
      new[]{0xA9BE, 0xA9C0, 1},
      new[]{0xAA2F, 0xAA30, 1},
      new[]{0xAA33, 0xAA34, 1},
      new[]{0xAA4D, 0xAA7B, 46},
      new[]{0xABE3, 0xABE4, 1},
      new[]{0xABE6, 0xABE7, 1},
      new[]{0xABE9, 0xABEA, 1},
      new[]{0xABEC, 0x11000, 25620},
      new[]{0x11002, 0x11082, 128},
      new[]{0x110B0, 0x110B2, 1},
      new[]{0x110B7, 0x110B8, 1},
      new[]{0x1D165, 0x1D166, 1},
      new[]{0x1D16D, 0x1D172, 1}
    };
    }

    private static int[][] make_Nd()
    {
        return new int[][] {
      new[]{0x0030, 0x0039, 1},
      new[]{0x0660, 0x0669, 1},
      new[]{0x06F0, 0x06F9, 1},
      new[]{0x07C0, 0x07C9, 1},
      new[]{0x0966, 0x096F, 1},
      new[]{0x09E6, 0x09EF, 1},
      new[]{0x0A66, 0x0A6F, 1},
      new[]{0x0AE6, 0x0AEF, 1},
      new[]{0x0B66, 0x0B6F, 1},
      new[]{0x0BE6, 0x0BEF, 1},
      new[]{0x0C66, 0x0C6F, 1},
      new[]{0x0CE6, 0x0CEF, 1},
      new[]{0x0D66, 0x0D6F, 1},
      new[]{0x0E50, 0x0E59, 1},
      new[]{0x0ED0, 0x0ED9, 1},
      new[]{0x0F20, 0x0F29, 1},
      new[]{0x1040, 0x1049, 1},
      new[]{0x1090, 0x1099, 1},
      new[]{0x17E0, 0x17E9, 1},
      new[]{0x1810, 0x1819, 1},
      new[]{0x1946, 0x194F, 1},
      new[]{0x19D0, 0x19D9, 1},
      new[]{0x1A80, 0x1A89, 1},
      new[]{0x1A90, 0x1A99, 1},
      new[]{0x1B50, 0x1B59, 1},
      new[]{0x1BB0, 0x1BB9, 1},
      new[]{0x1C40, 0x1C49, 1},
      new[]{0x1C50, 0x1C59, 1},
      new[]{0xA620, 0xA629, 1},
      new[]{0xA8D0, 0xA8D9, 1},
      new[]{0xA900, 0xA909, 1},
      new[]{0xA9D0, 0xA9D9, 1},
      new[]{0xAA50, 0xAA59, 1},
      new[]{0xABF0, 0xABF9, 1},
      new[]{0xFF10, 0xFF19, 1},
      new[]{0x104A0, 0x104A9, 1},
      new[]{0x11066, 0x1106F, 1},
      new[]{0x1D7CE, 0x1D7FF, 1}
    };
    }

    private static int[][] make_Nl()
    {
        return new int[][] {
      new[]{0x16EE, 0x16F0, 1},
      new[]{0x2160, 0x2182, 1},
      new[]{0x2185, 0x2188, 1},
      new[]{0x3007, 0x3021, 26},
      new[]{0x3022, 0x3029, 1},
      new[]{0x3038, 0x303A, 1},
      new[]{0xA6E6, 0xA6EF, 1},
      new[]{0x10140, 0x10174, 1},
      new[]{0x10341, 0x1034A, 9},
      new[]{0x103D1, 0x103D5, 1},
      new[]{0x12400, 0x12462, 1}
    };
    }

    private static int[][] make_No()
    {
        return new int[][] {
      new[]{0x00B2, 0x00B3, 1},
      new[]{0x00B9, 0x00BC, 3},
      new[]{0x00BD, 0x00BE, 1},
      new[]{0x09F4, 0x09F9, 1},
      new[]{0x0B72, 0x0B77, 1},
      new[]{0x0BF0, 0x0BF2, 1},
      new[]{0x0C78, 0x0C7E, 1},
      new[]{0x0D70, 0x0D75, 1},
      new[]{0x0F2A, 0x0F33, 1},
      new[]{0x1369, 0x137C, 1},
      new[]{0x17F0, 0x17F9, 1},
      new[]{0x19DA, 0x2070, 1686},
      new[]{0x2074, 0x2079, 1},
      new[]{0x2080, 0x2089, 1},
      new[]{0x2150, 0x215F, 1},
      new[]{0x2189, 0x2460, 727},
      new[]{0x2461, 0x249B, 1},
      new[]{0x24EA, 0x24FF, 1},
      new[]{0x2776, 0x2793, 1},
      new[]{0x2CFD, 0x3192, 1173},
      new[]{0x3193, 0x3195, 1},
      new[]{0x3220, 0x3229, 1},
      new[]{0x3251, 0x325F, 1},
      new[]{0x3280, 0x3289, 1},
      new[]{0x32B1, 0x32BF, 1},
      new[]{0xA830, 0xA835, 1},
      new[]{0x10107, 0x10133, 1},
      new[]{0x10175, 0x10178, 1},
      new[]{0x1018A, 0x10320, 406},
      new[]{0x10321, 0x10323, 1},
      new[]{0x10858, 0x1085F, 1},
      new[]{0x10916, 0x1091B, 1},
      new[]{0x10A40, 0x10A47, 1},
      new[]{0x10A7D, 0x10A7E, 1},
      new[]{0x10B58, 0x10B5F, 1},
      new[]{0x10B78, 0x10B7F, 1},
      new[]{0x10E60, 0x10E7E, 1},
      new[]{0x11052, 0x11065, 1},
      new[]{0x1D360, 0x1D371, 1},
      new[]{0x1F100, 0x1F10A, 1}
    };
    }

    private static int[][] make_Zs()
    {
        return new int[][] {
      new[]{0x0020, 0x00A0, 128},
      new[]{0x1680, 0x180E, 398},
      new[]{0x2000, 0x200A, 1},
      new[]{0x202F, 0x205F, 48},
      new[]{0x3000, 0x3000, 1}
    };
    }

    private static int[][] make_Zl()
    {
        return new int[][] { new[] { 0x2028, 0x2028, 1 } };
    }

    private static int[][] make_Zp()
    {
        return new int[][] { new[] { 0x2029, 0x2029, 1 } };
    }

    private static int[][] make_Cc()
    {
        return new int[][] {
        new[] { 0x0000, 0x001F, 1 },
        new[]{ 0x007F, 0x009F, 1 } };
    }

    private static int[][] make_Cf()
    {
        return new int[][] {
      new[]{0x00AD, 0x0600, 1363},
      new[]{0x0601, 0x0603, 1},
      new[]{0x06DD, 0x070F, 50},
      new[]{0x17B4, 0x17B5, 1},
      new[]{0x200B, 0x200F, 1},
      new[]{0x202A, 0x202E, 1},
      new[]{0x2060, 0x2064, 1},
      new[]{0x206A, 0x206F, 1},
      new[]{0xFEFF, 0xFFF9, 250},
      new[]{0xFFFA, 0xFFFB, 1},
      new[]{0x110BD, 0x1D173, 49334},
      new[]{0x1D174, 0x1D17A, 1},
      new[]{0xE0001, 0xE0020, 31},
      new[]{0xE0021, 0xE007F, 1}
    };
    }

    private static int[][] make_Co()
    {
        return new int[][] { new[] { 0xE000, 0xF8FF, 1 }, new[] { 0xF0000, 0xFFFFD, 1 }, new int[] { 0x100000, 0x10FFFD, 1 } };
    }

    private static int[][] make_Cs()
    {
        return new int[][] { new[] { 0xD800, 0xDFFF, 1 } };
    }

    private static int[][] make_Pd()
    {
        return new int[][] {
      new[]{0x002D, 0x058A, 1373},
      new[]{0x05BE, 0x1400, 3650},
      new[]{0x1806, 0x2010, 2058},
      new[]{0x2011, 0x2015, 1},
      new[]{0x2E17, 0x2E1A, 3},
      new[]{0x301C, 0x3030, 20},
      new[]{0x30A0, 0xFE31, 52625},
      new[]{0xFE32, 0xFE58, 38},
      new[]{0xFE63, 0xFF0D, 170}
    };
    }

    private static int[][] make_Ps()
    {
        return new int[][] {
      new[]{0x0028, 0x005B, 51},
      new[]{0x007B, 0x0F3A, 3775},
      new[]{0x0F3C, 0x169B, 1887},
      new[]{0x201A, 0x201E, 4},
      new[]{0x2045, 0x207D, 56},
      new[]{0x208D, 0x2329, 668},
      new[]{0x2768, 0x2774, 2},
      new[]{0x27C5, 0x27E6, 33},
      new[]{0x27E8, 0x27EE, 2},
      new[]{0x2983, 0x2997, 2},
      new[]{0x29D8, 0x29DA, 2},
      new[]{0x29FC, 0x2E22, 1062},
      new[]{0x2E24, 0x2E28, 2},
      new[]{0x3008, 0x3010, 2},
      new[]{0x3014, 0x301A, 2},
      new[]{0x301D, 0xFD3E, 52513},
      new[]{0xFE17, 0xFE35, 30},
      new[]{0xFE37, 0xFE43, 2},
      new[]{0xFE47, 0xFE59, 18},
      new[]{0xFE5B, 0xFE5D, 2},
      new[]{0xFF08, 0xFF3B, 51},
      new[]{0xFF5B, 0xFF5F, 4},
      new[]{0xFF62, 0xFF62, 1}
    };
    }

    private static int[][] make_Pe()
    {
        return new int[][] {
      new[]{0x0029, 0x005D, 52},
      new[]{0x007D, 0x0F3B, 3774},
      new[]{0x0F3D, 0x169C, 1887},
      new[]{0x2046, 0x207E, 56},
      new[]{0x208E, 0x232A, 668},
      new[]{0x2769, 0x2775, 2},
      new[]{0x27C6, 0x27E7, 33},
      new[]{0x27E9, 0x27EF, 2},
      new[]{0x2984, 0x2998, 2},
      new[]{0x29D9, 0x29DB, 2},
      new[]{0x29FD, 0x2E23, 1062},
      new[]{0x2E25, 0x2E29, 2},
      new[]{0x3009, 0x3011, 2},
      new[]{0x3015, 0x301B, 2},
      new[]{0x301E, 0x301F, 1},
      new[]{0xFD3F, 0xFE18, 217},
      new[]{0xFE36, 0xFE44, 2},
      new[]{0xFE48, 0xFE5A, 18},
      new[]{0xFE5C, 0xFE5E, 2},
      new[]{0xFF09, 0xFF3D, 52},
      new[]{0xFF5D, 0xFF63, 3}
    };
    }

    private static int[][] make_Pc()
    {
        return new int[][] {
      new[]{0x005F, 0x203F, 8160},
      new[]{0x2040, 0x2054, 20},
      new[]{0xFE33, 0xFE34, 1},
      new[]{0xFE4D, 0xFE4F, 1},
      new[]{0xFF3F, 0xFF3F, 1}
    };
    }

    private static int[][] make_Po()
    {
        return new int[][] {
      new[]{0x0021, 0x0023, 1},
      new[]{0x0025, 0x0027, 1},
      new[]{0x002A, 0x002E, 2},
      new[]{0x002F, 0x003A, 11},
      new[]{0x003B, 0x003F, 4},
      new[]{0x0040, 0x005C, 28},
      new[]{0x00A1, 0x00B7, 22},
      new[]{0x00BF, 0x037E, 703},
      new[]{0x0387, 0x055A, 467},
      new[]{0x055B, 0x055F, 1},
      new[]{0x0589, 0x05C0, 55},
      new[]{0x05C3, 0x05C6, 3},
      new[]{0x05F3, 0x05F4, 1},
      new[]{0x0609, 0x060A, 1},
      new[]{0x060C, 0x060D, 1},
      new[]{0x061B, 0x061E, 3},
      new[]{0x061F, 0x066A, 75},
      new[]{0x066B, 0x066D, 1},
      new[]{0x06D4, 0x0700, 44},
      new[]{0x0701, 0x070D, 1},
      new[]{0x07F7, 0x07F9, 1},
      new[]{0x0830, 0x083E, 1},
      new[]{0x085E, 0x0964, 262},
      new[]{0x0965, 0x0970, 11},
      new[]{0x0DF4, 0x0E4F, 91},
      new[]{0x0E5A, 0x0E5B, 1},
      new[]{0x0F04, 0x0F12, 1},
      new[]{0x0F85, 0x0FD0, 75},
      new[]{0x0FD1, 0x0FD4, 1},
      new[]{0x0FD9, 0x0FDA, 1},
      new[]{0x104A, 0x104F, 1},
      new[]{0x10FB, 0x1361, 614},
      new[]{0x1362, 0x1368, 1},
      new[]{0x166D, 0x166E, 1},
      new[]{0x16EB, 0x16ED, 1},
      new[]{0x1735, 0x1736, 1},
      new[]{0x17D4, 0x17D6, 1},
      new[]{0x17D8, 0x17DA, 1},
      new[]{0x1800, 0x1805, 1},
      new[]{0x1807, 0x180A, 1},
      new[]{0x1944, 0x1945, 1},
      new[]{0x1A1E, 0x1A1F, 1},
      new[]{0x1AA0, 0x1AA6, 1},
      new[]{0x1AA8, 0x1AAD, 1},
      new[]{0x1B5A, 0x1B60, 1},
      new[]{0x1BFC, 0x1BFF, 1},
      new[]{0x1C3B, 0x1C3F, 1},
      new[]{0x1C7E, 0x1C7F, 1},
      new[]{0x1CD3, 0x2016, 835},
      new[]{0x2017, 0x2020, 9},
      new[]{0x2021, 0x2027, 1},
      new[]{0x2030, 0x2038, 1},
      new[]{0x203B, 0x203E, 1},
      new[]{0x2041, 0x2043, 1},
      new[]{0x2047, 0x2051, 1},
      new[]{0x2053, 0x2055, 2},
      new[]{0x2056, 0x205E, 1},
      new[]{0x2CF9, 0x2CFC, 1},
      new[]{0x2CFE, 0x2CFF, 1},
      new[]{0x2D70, 0x2E00, 144},
      new[]{0x2E01, 0x2E06, 5},
      new[]{0x2E07, 0x2E08, 1},
      new[]{0x2E0B, 0x2E0E, 3},
      new[]{0x2E0F, 0x2E16, 1},
      new[]{0x2E18, 0x2E19, 1},
      new[]{0x2E1B, 0x2E1E, 3},
      new[]{0x2E1F, 0x2E2A, 11},
      new[]{0x2E2B, 0x2E2E, 1},
      new[]{0x2E30, 0x2E31, 1},
      new[]{0x3001, 0x3003, 1},
      new[]{0x303D, 0x30FB, 190},
      new[]{0xA4FE, 0xA4FF, 1},
      new[]{0xA60D, 0xA60F, 1},
      new[]{0xA673, 0xA67E, 11},
      new[]{0xA6F2, 0xA6F7, 1},
      new[]{0xA874, 0xA877, 1},
      new[]{0xA8CE, 0xA8CF, 1},
      new[]{0xA8F8, 0xA8FA, 1},
      new[]{0xA92E, 0xA92F, 1},
      new[]{0xA95F, 0xA9C1, 98},
      new[]{0xA9C2, 0xA9CD, 1},
      new[]{0xA9DE, 0xA9DF, 1},
      new[]{0xAA5C, 0xAA5F, 1},
      new[]{0xAADE, 0xAADF, 1},
      new[]{0xABEB, 0xFE10, 21029},
      new[]{0xFE11, 0xFE16, 1},
      new[]{0xFE19, 0xFE30, 23},
      new[]{0xFE45, 0xFE46, 1},
      new[]{0xFE49, 0xFE4C, 1},
      new[]{0xFE50, 0xFE52, 1},
      new[]{0xFE54, 0xFE57, 1},
      new[]{0xFE5F, 0xFE61, 1},
      new[]{0xFE68, 0xFE6A, 2},
      new[]{0xFE6B, 0xFF01, 150},
      new[]{0xFF02, 0xFF03, 1},
      new[]{0xFF05, 0xFF07, 1},
      new[]{0xFF0A, 0xFF0E, 2},
      new[]{0xFF0F, 0xFF1A, 11},
      new[]{0xFF1B, 0xFF1F, 4},
      new[]{0xFF20, 0xFF3C, 28},
      new[]{0xFF61, 0xFF64, 3},
      new[]{0xFF65, 0x10100, 411},
      new[]{0x10101, 0x1039F, 670},
      new[]{0x103D0, 0x10857, 1159},
      new[]{0x1091F, 0x1093F, 32},
      new[]{0x10A50, 0x10A58, 1},
      new[]{0x10A7F, 0x10B39, 186},
      new[]{0x10B3A, 0x10B3F, 1},
      new[]{0x11047, 0x1104D, 1},
      new[]{0x110BB, 0x110BC, 1},
      new[]{0x110BE, 0x110C1, 1},
      new[]{0x12470, 0x12473, 1}
    };
    }

    private static int[][] make_Sm()
    {
        return new int[][] {
      new[]{0x002B, 0x003C, 17},
      new[]{0x003D, 0x003E, 1},
      new[]{0x007C, 0x007E, 2},
      new[]{0x00AC, 0x00B1, 5},
      new[]{0x00D7, 0x00F7, 32},
      new[]{0x03F6, 0x0606, 528},
      new[]{0x0607, 0x0608, 1},
      new[]{0x2044, 0x2052, 14},
      new[]{0x207A, 0x207C, 1},
      new[]{0x208A, 0x208C, 1},
      new[]{0x2118, 0x2140, 40},
      new[]{0x2141, 0x2144, 1},
      new[]{0x214B, 0x2190, 69},
      new[]{0x2191, 0x2194, 1},
      new[]{0x219A, 0x219B, 1},
      new[]{0x21A0, 0x21A6, 3},
      new[]{0x21AE, 0x21CE, 32},
      new[]{0x21CF, 0x21D2, 3},
      new[]{0x21D4, 0x21F4, 32},
      new[]{0x21F5, 0x22FF, 1},
      new[]{0x2308, 0x230B, 1},
      new[]{0x2320, 0x2321, 1},
      new[]{0x237C, 0x239B, 31},
      new[]{0x239C, 0x23B3, 1},
      new[]{0x23DC, 0x23E1, 1},
      new[]{0x25B7, 0x25C1, 10},
      new[]{0x25F8, 0x25FF, 1},
      new[]{0x266F, 0x27C0, 337},
      new[]{0x27C1, 0x27C4, 1},
      new[]{0x27C7, 0x27CA, 1},
      new[]{0x27CC, 0x27CE, 2},
      new[]{0x27CF, 0x27E5, 1},
      new[]{0x27F0, 0x27FF, 1},
      new[]{0x2900, 0x2982, 1},
      new[]{0x2999, 0x29D7, 1},
      new[]{0x29DC, 0x29FB, 1},
      new[]{0x29FE, 0x2AFF, 1},
      new[]{0x2B30, 0x2B44, 1},
      new[]{0x2B47, 0x2B4C, 1},
      new[]{0xFB29, 0xFE62, 825},
      new[]{0xFE64, 0xFE66, 1},
      new[]{0xFF0B, 0xFF1C, 17},
      new[]{0xFF1D, 0xFF1E, 1},
      new[]{0xFF5C, 0xFF5E, 2},
      new[]{0xFFE2, 0xFFE9, 7},
      new[]{0xFFEA, 0xFFEC, 1},
      new[]{0x1D6C1, 0x1D6DB, 26},
      new[]{0x1D6FB, 0x1D715, 26},
      new[]{0x1D735, 0x1D74F, 26},
      new[]{0x1D76F, 0x1D789, 26},
      new[]{0x1D7A9, 0x1D7C3, 26}
    };
    }

    private static int[][] make_Sc()
    {
        return new int[][] {
      new[]{0x0024, 0x00A2, 126},
      new[]{0x00A3, 0x00A5, 1},
      new[]{0x060B, 0x09F2, 999},
      new[]{0x09F3, 0x09FB, 8},
      new[]{0x0AF1, 0x0BF9, 264},
      new[]{0x0E3F, 0x17DB, 2460},
      new[]{0x20A0, 0x20B9, 1},
      new[]{0xA838, 0xFDFC, 21956},
      new[]{0xFE69, 0xFF04, 155},
      new[]{0xFFE0, 0xFFE1, 1},
      new[]{0xFFE5, 0xFFE6, 1}
    };
    }

    private static int[][] make_Sk()
    {
        return new int[][] {
      new[]{0x005E, 0x0060, 2},
      new[]{0x00A8, 0x00AF, 7},
      new[]{0x00B4, 0x00B8, 4},
      new[]{0x02C2, 0x02C5, 1},
      new[]{0x02D2, 0x02DF, 1},
      new[]{0x02E5, 0x02EB, 1},
      new[]{0x02ED, 0x02EF, 2},
      new[]{0x02F0, 0x02FF, 1},
      new[]{0x0375, 0x0384, 15},
      new[]{0x0385, 0x1FBD, 7224},
      new[]{0x1FBF, 0x1FC1, 1},
      new[]{0x1FCD, 0x1FCF, 1},
      new[]{0x1FDD, 0x1FDF, 1},
      new[]{0x1FED, 0x1FEF, 1},
      new[]{0x1FFD, 0x1FFE, 1},
      new[]{0x309B, 0x309C, 1},
      new[]{0xA700, 0xA716, 1},
      new[]{0xA720, 0xA721, 1},
      new[]{0xA789, 0xA78A, 1},
      new[]{0xFBB2, 0xFBC1, 1},
      new[]{0xFF3E, 0xFF40, 2},
      new[]{0xFFE3, 0xFFE3, 1}
    };
    }

    private static int[][] make_So()
    {
        return new int[][] {
      new[]{0x00A6, 0x00A7, 1},
      new[]{0x00A9, 0x00AE, 5},
      new[]{0x00B0, 0x00B6, 6},
      new[]{0x0482, 0x060E, 396},
      new[]{0x060F, 0x06DE, 207},
      new[]{0x06E9, 0x06FD, 20},
      new[]{0x06FE, 0x07F6, 248},
      new[]{0x09FA, 0x0B70, 374},
      new[]{0x0BF3, 0x0BF8, 1},
      new[]{0x0BFA, 0x0C7F, 133},
      new[]{0x0D79, 0x0F01, 392},
      new[]{0x0F02, 0x0F03, 1},
      new[]{0x0F13, 0x0F17, 1},
      new[]{0x0F1A, 0x0F1F, 1},
      new[]{0x0F34, 0x0F38, 2},
      new[]{0x0FBE, 0x0FC5, 1},
      new[]{0x0FC7, 0x0FCC, 1},
      new[]{0x0FCE, 0x0FCF, 1},
      new[]{0x0FD5, 0x0FD8, 1},
      new[]{0x109E, 0x109F, 1},
      new[]{0x1360, 0x1390, 48},
      new[]{0x1391, 0x1399, 1},
      new[]{0x1940, 0x19DE, 158},
      new[]{0x19DF, 0x19FF, 1},
      new[]{0x1B61, 0x1B6A, 1},
      new[]{0x1B74, 0x1B7C, 1},
      new[]{0x2100, 0x2101, 1},
      new[]{0x2103, 0x2106, 1},
      new[]{0x2108, 0x2109, 1},
      new[]{0x2114, 0x2116, 2},
      new[]{0x2117, 0x211E, 7},
      new[]{0x211F, 0x2123, 1},
      new[]{0x2125, 0x2129, 2},
      new[]{0x212E, 0x213A, 12},
      new[]{0x213B, 0x214A, 15},
      new[]{0x214C, 0x214D, 1},
      new[]{0x214F, 0x2195, 70},
      new[]{0x2196, 0x2199, 1},
      new[]{0x219C, 0x219F, 1},
      new[]{0x21A1, 0x21A2, 1},
      new[]{0x21A4, 0x21A5, 1},
      new[]{0x21A7, 0x21AD, 1},
      new[]{0x21AF, 0x21CD, 1},
      new[]{0x21D0, 0x21D1, 1},
      new[]{0x21D3, 0x21D5, 2},
      new[]{0x21D6, 0x21F3, 1},
      new[]{0x2300, 0x2307, 1},
      new[]{0x230C, 0x231F, 1},
      new[]{0x2322, 0x2328, 1},
      new[]{0x232B, 0x237B, 1},
      new[]{0x237D, 0x239A, 1},
      new[]{0x23B4, 0x23DB, 1},
      new[]{0x23E2, 0x23F3, 1},
      new[]{0x2400, 0x2426, 1},
      new[]{0x2440, 0x244A, 1},
      new[]{0x249C, 0x24E9, 1},
      new[]{0x2500, 0x25B6, 1},
      new[]{0x25B8, 0x25C0, 1},
      new[]{0x25C2, 0x25F7, 1},
      new[]{0x2600, 0x266E, 1},
      new[]{0x2670, 0x26FF, 1},
      new[]{0x2701, 0x2767, 1},
      new[]{0x2794, 0x27BF, 1},
      new[]{0x2800, 0x28FF, 1},
      new[]{0x2B00, 0x2B2F, 1},
      new[]{0x2B45, 0x2B46, 1},
      new[]{0x2B50, 0x2B59, 1},
      new[]{0x2CE5, 0x2CEA, 1},
      new[]{0x2E80, 0x2E99, 1},
      new[]{0x2E9B, 0x2EF3, 1},
      new[]{0x2F00, 0x2FD5, 1},
      new[]{0x2FF0, 0x2FFB, 1},
      new[]{0x3004, 0x3012, 14},
      new[]{0x3013, 0x3020, 13},
      new[]{0x3036, 0x3037, 1},
      new[]{0x303E, 0x303F, 1},
      new[]{0x3190, 0x3191, 1},
      new[]{0x3196, 0x319F, 1},
      new[]{0x31C0, 0x31E3, 1},
      new[]{0x3200, 0x321E, 1},
      new[]{0x322A, 0x3250, 1},
      new[]{0x3260, 0x327F, 1},
      new[]{0x328A, 0x32B0, 1},
      new[]{0x32C0, 0x32FE, 1},
      new[]{0x3300, 0x33FF, 1},
      new[]{0x4DC0, 0x4DFF, 1},
      new[]{0xA490, 0xA4C6, 1},
      new[]{0xA828, 0xA82B, 1},
      new[]{0xA836, 0xA837, 1},
      new[]{0xA839, 0xAA77, 574},
      new[]{0xAA78, 0xAA79, 1},
      new[]{0xFDFD, 0xFFE4, 487},
      new[]{0xFFE8, 0xFFED, 5},
      new[]{0xFFEE, 0xFFFC, 14},
      new[]{0xFFFD, 0x10102, 261},
      new[]{0x10137, 0x1013F, 1},
      new[]{0x10179, 0x10189, 1},
      new[]{0x10190, 0x1019B, 1},
      new[]{0x101D0, 0x101FC, 1},
      new[]{0x1D000, 0x1D0F5, 1},
      new[]{0x1D100, 0x1D126, 1},
      new[]{0x1D129, 0x1D164, 1},
      new[]{0x1D16A, 0x1D16C, 1},
      new[]{0x1D183, 0x1D184, 1},
      new[]{0x1D18C, 0x1D1A9, 1},
      new[]{0x1D1AE, 0x1D1DD, 1},
      new[]{0x1D200, 0x1D241, 1},
      new[]{0x1D245, 0x1D300, 187},
      new[]{0x1D301, 0x1D356, 1},
      new[]{0x1F000, 0x1F02B, 1},
      new[]{0x1F030, 0x1F093, 1},
      new[]{0x1F0A0, 0x1F0AE, 1},
      new[]{0x1F0B1, 0x1F0BE, 1},
      new[]{0x1F0C1, 0x1F0CF, 1},
      new[]{0x1F0D1, 0x1F0DF, 1},
      new[]{0x1F110, 0x1F12E, 1},
      new[]{0x1F130, 0x1F169, 1},
      new[]{0x1F170, 0x1F19A, 1},
      new[]{0x1F1E6, 0x1F202, 1},
      new[]{0x1F210, 0x1F23A, 1},
      new[]{0x1F240, 0x1F248, 1},
      new[]{0x1F250, 0x1F251, 1},
      new[]{0x1F300, 0x1F320, 1},
      new[]{0x1F330, 0x1F335, 1},
      new[]{0x1F337, 0x1F37C, 1},
      new[]{0x1F380, 0x1F393, 1},
      new[]{0x1F3A0, 0x1F3C4, 1},
      new[]{0x1F3C6, 0x1F3CA, 1},
      new[]{0x1F3E0, 0x1F3F0, 1},
      new[]{0x1F400, 0x1F43E, 1},
      new[]{0x1F440, 0x1F442, 2},
      new[]{0x1F443, 0x1F4F7, 1},
      new[]{0x1F4F9, 0x1F4FC, 1},
      new[]{0x1F500, 0x1F53D, 1},
      new[]{0x1F550, 0x1F567, 1},
      new[]{0x1F5FB, 0x1F5FF, 1},
      new[]{0x1F601, 0x1F610, 1},
      new[]{0x1F612, 0x1F614, 1},
      new[]{0x1F616, 0x1F61C, 2},
      new[]{0x1F61D, 0x1F61E, 1},
      new[]{0x1F620, 0x1F625, 1},
      new[]{0x1F628, 0x1F62B, 1},
      new[]{0x1F62D, 0x1F630, 3},
      new[]{0x1F631, 0x1F633, 1},
      new[]{0x1F635, 0x1F640, 1},
      new[]{0x1F645, 0x1F64F, 1},
      new[]{0x1F680, 0x1F6C5, 1},
      new[]{0x1F700, 0x1F773, 1}
    };
    }

    private static int[][] make_Pi()
    {
        return new int[][] {
      new[]{0x00AB, 0x2018, 8045},
      new[]{0x201B, 0x201C, 1},
      new[]{0x201F, 0x2039, 26},
      new[]{0x2E02, 0x2E04, 2},
      new[]{0x2E09, 0x2E0C, 3},
      new[]{0x2E1C, 0x2E20, 4}
    };
    }

    private static int[][] make_Pf()
    {
        return new int[][] {
      new[]{0x00BB, 0x2019, 8030},
      new[]{0x201D, 0x203A, 29},
      new[]{0x2E03, 0x2E05, 2},
      new[]{0x2E0A, 0x2E0D, 3},
      new[]{0x2E1D, 0x2E21, 4}
    };
    }

    private static int[][] make_P()
    {
        return new int[][] {
      new[]{0x0021, 0x0023, 1},
      new[]{0x0025, 0x002A, 1},
      new[]{0x002C, 0x002F, 1},
      new[]{0x003A, 0x003B, 1},
      new[]{0x003F, 0x0040, 1},
      new[]{0x005B, 0x005D, 1},
      new[]{0x005F, 0x007B, 28},
      new[]{0x007D, 0x00A1, 36},
      new[]{0x00AB, 0x00B7, 12},
      new[]{0x00BB, 0x00BF, 4},
      new[]{0x037E, 0x0387, 9},
      new[]{0x055A, 0x055F, 1},
      new[]{0x0589, 0x058A, 1},
      new[]{0x05BE, 0x05C0, 2},
      new[]{0x05C3, 0x05C6, 3},
      new[]{0x05F3, 0x05F4, 1},
      new[]{0x0609, 0x060A, 1},
      new[]{0x060C, 0x060D, 1},
      new[]{0x061B, 0x061E, 3},
      new[]{0x061F, 0x066A, 75},
      new[]{0x066B, 0x066D, 1},
      new[]{0x06D4, 0x0700, 44},
      new[]{0x0701, 0x070D, 1},
      new[]{0x07F7, 0x07F9, 1},
      new[]{0x0830, 0x083E, 1},
      new[]{0x085E, 0x0964, 262},
      new[]{0x0965, 0x0970, 11},
      new[]{0x0DF4, 0x0E4F, 91},
      new[]{0x0E5A, 0x0E5B, 1},
      new[]{0x0F04, 0x0F12, 1},
      new[]{0x0F3A, 0x0F3D, 1},
      new[]{0x0F85, 0x0FD0, 75},
      new[]{0x0FD1, 0x0FD4, 1},
      new[]{0x0FD9, 0x0FDA, 1},
      new[]{0x104A, 0x104F, 1},
      new[]{0x10FB, 0x1361, 614},
      new[]{0x1362, 0x1368, 1},
      new[]{0x1400, 0x166D, 621},
      new[]{0x166E, 0x169B, 45},
      new[]{0x169C, 0x16EB, 79},
      new[]{0x16EC, 0x16ED, 1},
      new[]{0x1735, 0x1736, 1},
      new[]{0x17D4, 0x17D6, 1},
      new[]{0x17D8, 0x17DA, 1},
      new[]{0x1800, 0x180A, 1},
      new[]{0x1944, 0x1945, 1},
      new[]{0x1A1E, 0x1A1F, 1},
      new[]{0x1AA0, 0x1AA6, 1},
      new[]{0x1AA8, 0x1AAD, 1},
      new[]{0x1B5A, 0x1B60, 1},
      new[]{0x1BFC, 0x1BFF, 1},
      new[]{0x1C3B, 0x1C3F, 1},
      new[]{0x1C7E, 0x1C7F, 1},
      new[]{0x1CD3, 0x2010, 829},
      new[]{0x2011, 0x2027, 1},
      new[]{0x2030, 0x2043, 1},
      new[]{0x2045, 0x2051, 1},
      new[]{0x2053, 0x205E, 1},
      new[]{0x207D, 0x207E, 1},
      new[]{0x208D, 0x208E, 1},
      new[]{0x2329, 0x232A, 1},
      new[]{0x2768, 0x2775, 1},
      new[]{0x27C5, 0x27C6, 1},
      new[]{0x27E6, 0x27EF, 1},
      new[]{0x2983, 0x2998, 1},
      new[]{0x29D8, 0x29DB, 1},
      new[]{0x29FC, 0x29FD, 1},
      new[]{0x2CF9, 0x2CFC, 1},
      new[]{0x2CFE, 0x2CFF, 1},
      new[]{0x2D70, 0x2E00, 144},
      new[]{0x2E01, 0x2E2E, 1},
      new[]{0x2E30, 0x2E31, 1},
      new[]{0x3001, 0x3003, 1},
      new[]{0x3008, 0x3011, 1},
      new[]{0x3014, 0x301F, 1},
      new[]{0x3030, 0x303D, 13},
      new[]{0x30A0, 0x30FB, 91},
      new[]{0xA4FE, 0xA4FF, 1},
      new[]{0xA60D, 0xA60F, 1},
      new[]{0xA673, 0xA67E, 11},
      new[]{0xA6F2, 0xA6F7, 1},
      new[]{0xA874, 0xA877, 1},
      new[]{0xA8CE, 0xA8CF, 1},
      new[]{0xA8F8, 0xA8FA, 1},
      new[]{0xA92E, 0xA92F, 1},
      new[]{0xA95F, 0xA9C1, 98},
      new[]{0xA9C2, 0xA9CD, 1},
      new[]{0xA9DE, 0xA9DF, 1},
      new[]{0xAA5C, 0xAA5F, 1},
      new[]{0xAADE, 0xAADF, 1},
      new[]{0xABEB, 0xFD3E, 20819},
      new[]{0xFD3F, 0xFE10, 209},
      new[]{0xFE11, 0xFE19, 1},
      new[]{0xFE30, 0xFE52, 1},
      new[]{0xFE54, 0xFE61, 1},
      new[]{0xFE63, 0xFE68, 5},
      new[]{0xFE6A, 0xFE6B, 1},
      new[]{0xFF01, 0xFF03, 1},
      new[]{0xFF05, 0xFF0A, 1},
      new[]{0xFF0C, 0xFF0F, 1},
      new[]{0xFF1A, 0xFF1B, 1},
      new[]{0xFF1F, 0xFF20, 1},
      new[]{0xFF3B, 0xFF3D, 1},
      new[]{0xFF3F, 0xFF5B, 28},
      new[]{0xFF5D, 0xFF5F, 2},
      new[]{0xFF60, 0xFF65, 1},
      new[]{0x10100, 0x10101, 1},
      new[]{0x1039F, 0x103D0, 49},
      new[]{0x10857, 0x1091F, 200},
      new[]{0x1093F, 0x10A50, 273},
      new[]{0x10A51, 0x10A58, 1},
      new[]{0x10A7F, 0x10B39, 186},
      new[]{0x10B3A, 0x10B3F, 1},
      new[]{0x11047, 0x1104D, 1},
      new[]{0x110BB, 0x110BC, 1},
      new[]{0x110BE, 0x110C1, 1},
      new[]{0x12470, 0x12473, 1}
    };
    }

    private static int[][] make_S()
    {
        return new int[][] {
      new[]{0x0024, 0x002B, 7},
      new[]{0x003C, 0x003E, 1},
      new[]{0x005E, 0x0060, 2},
      new[]{0x007C, 0x007E, 2},
      new[]{0x00A2, 0x00A9, 1},
      new[]{0x00AC, 0x00AE, 2},
      new[]{0x00AF, 0x00B1, 1},
      new[]{0x00B4, 0x00B8, 2},
      new[]{0x00D7, 0x00F7, 32},
      new[]{0x02C2, 0x02C5, 1},
      new[]{0x02D2, 0x02DF, 1},
      new[]{0x02E5, 0x02EB, 1},
      new[]{0x02ED, 0x02EF, 2},
      new[]{0x02F0, 0x02FF, 1},
      new[]{0x0375, 0x0384, 15},
      new[]{0x0385, 0x03F6, 113},
      new[]{0x0482, 0x0606, 388},
      new[]{0x0607, 0x0608, 1},
      new[]{0x060B, 0x060E, 3},
      new[]{0x060F, 0x06DE, 207},
      new[]{0x06E9, 0x06FD, 20},
      new[]{0x06FE, 0x07F6, 248},
      new[]{0x09F2, 0x09F3, 1},
      new[]{0x09FA, 0x09FB, 1},
      new[]{0x0AF1, 0x0B70, 127},
      new[]{0x0BF3, 0x0BFA, 1},
      new[]{0x0C7F, 0x0D79, 250},
      new[]{0x0E3F, 0x0F01, 194},
      new[]{0x0F02, 0x0F03, 1},
      new[]{0x0F13, 0x0F17, 1},
      new[]{0x0F1A, 0x0F1F, 1},
      new[]{0x0F34, 0x0F38, 2},
      new[]{0x0FBE, 0x0FC5, 1},
      new[]{0x0FC7, 0x0FCC, 1},
      new[]{0x0FCE, 0x0FCF, 1},
      new[]{0x0FD5, 0x0FD8, 1},
      new[]{0x109E, 0x109F, 1},
      new[]{0x1360, 0x1390, 48},
      new[]{0x1391, 0x1399, 1},
      new[]{0x17DB, 0x1940, 357},
      new[]{0x19DE, 0x19FF, 1},
      new[]{0x1B61, 0x1B6A, 1},
      new[]{0x1B74, 0x1B7C, 1},
      new[]{0x1FBD, 0x1FBF, 2},
      new[]{0x1FC0, 0x1FC1, 1},
      new[]{0x1FCD, 0x1FCF, 1},
      new[]{0x1FDD, 0x1FDF, 1},
      new[]{0x1FED, 0x1FEF, 1},
      new[]{0x1FFD, 0x1FFE, 1},
      new[]{0x2044, 0x2052, 14},
      new[]{0x207A, 0x207C, 1},
      new[]{0x208A, 0x208C, 1},
      new[]{0x20A0, 0x20B9, 1},
      new[]{0x2100, 0x2101, 1},
      new[]{0x2103, 0x2106, 1},
      new[]{0x2108, 0x2109, 1},
      new[]{0x2114, 0x2116, 2},
      new[]{0x2117, 0x2118, 1},
      new[]{0x211E, 0x2123, 1},
      new[]{0x2125, 0x2129, 2},
      new[]{0x212E, 0x213A, 12},
      new[]{0x213B, 0x2140, 5},
      new[]{0x2141, 0x2144, 1},
      new[]{0x214A, 0x214D, 1},
      new[]{0x214F, 0x2190, 65},
      new[]{0x2191, 0x2328, 1},
      new[]{0x232B, 0x23F3, 1},
      new[]{0x2400, 0x2426, 1},
      new[]{0x2440, 0x244A, 1},
      new[]{0x249C, 0x24E9, 1},
      new[]{0x2500, 0x26FF, 1},
      new[]{0x2701, 0x2767, 1},
      new[]{0x2794, 0x27C4, 1},
      new[]{0x27C7, 0x27CA, 1},
      new[]{0x27CC, 0x27CE, 2},
      new[]{0x27CF, 0x27E5, 1},
      new[]{0x27F0, 0x2982, 1},
      new[]{0x2999, 0x29D7, 1},
      new[]{0x29DC, 0x29FB, 1},
      new[]{0x29FE, 0x2B4C, 1},
      new[]{0x2B50, 0x2B59, 1},
      new[]{0x2CE5, 0x2CEA, 1},
      new[]{0x2E80, 0x2E99, 1},
      new[]{0x2E9B, 0x2EF3, 1},
      new[]{0x2F00, 0x2FD5, 1},
      new[]{0x2FF0, 0x2FFB, 1},
      new[]{0x3004, 0x3012, 14},
      new[]{0x3013, 0x3020, 13},
      new[]{0x3036, 0x3037, 1},
      new[]{0x303E, 0x303F, 1},
      new[]{0x309B, 0x309C, 1},
      new[]{0x3190, 0x3191, 1},
      new[]{0x3196, 0x319F, 1},
      new[]{0x31C0, 0x31E3, 1},
      new[]{0x3200, 0x321E, 1},
      new[]{0x322A, 0x3250, 1},
      new[]{0x3260, 0x327F, 1},
      new[]{0x328A, 0x32B0, 1},
      new[]{0x32C0, 0x32FE, 1},
      new[]{0x3300, 0x33FF, 1},
      new[]{0x4DC0, 0x4DFF, 1},
      new[]{0xA490, 0xA4C6, 1},
      new[]{0xA700, 0xA716, 1},
      new[]{0xA720, 0xA721, 1},
      new[]{0xA789, 0xA78A, 1},
      new[]{0xA828, 0xA82B, 1},
      new[]{0xA836, 0xA839, 1},
      new[]{0xAA77, 0xAA79, 1},
      new[]{0xFB29, 0xFBB2, 137},
      new[]{0xFBB3, 0xFBC1, 1},
      new[]{0xFDFC, 0xFDFD, 1},
      new[]{0xFE62, 0xFE64, 2},
      new[]{0xFE65, 0xFE66, 1},
      new[]{0xFE69, 0xFF04, 155},
      new[]{0xFF0B, 0xFF1C, 17},
      new[]{0xFF1D, 0xFF1E, 1},
      new[]{0xFF3E, 0xFF40, 2},
      new[]{0xFF5C, 0xFF5E, 2},
      new[]{0xFFE0, 0xFFE6, 1},
      new[]{0xFFE8, 0xFFEE, 1},
      new[]{0xFFFC, 0xFFFD, 1},
      new[]{0x10102, 0x10137, 53},
      new[]{0x10138, 0x1013F, 1},
      new[]{0x10179, 0x10189, 1},
      new[]{0x10190, 0x1019B, 1},
      new[]{0x101D0, 0x101FC, 1},
      new[]{0x1D000, 0x1D0F5, 1},
      new[]{0x1D100, 0x1D126, 1},
      new[]{0x1D129, 0x1D164, 1},
      new[]{0x1D16A, 0x1D16C, 1},
      new[]{0x1D183, 0x1D184, 1},
      new[]{0x1D18C, 0x1D1A9, 1},
      new[]{0x1D1AE, 0x1D1DD, 1},
      new[]{0x1D200, 0x1D241, 1},
      new[]{0x1D245, 0x1D300, 187},
      new[]{0x1D301, 0x1D356, 1},
      new[]{0x1D6C1, 0x1D6DB, 26},
      new[]{0x1D6FB, 0x1D715, 26},
      new[]{0x1D735, 0x1D74F, 26},
      new[]{0x1D76F, 0x1D789, 26},
      new[]{0x1D7A9, 0x1D7C3, 26},
      new[]{0x1F000, 0x1F02B, 1},
      new[]{0x1F030, 0x1F093, 1},
      new[]{0x1F0A0, 0x1F0AE, 1},
      new[]{0x1F0B1, 0x1F0BE, 1},
      new[]{0x1F0C1, 0x1F0CF, 1},
      new[]{0x1F0D1, 0x1F0DF, 1},
      new[]{0x1F110, 0x1F12E, 1},
      new[]{0x1F130, 0x1F169, 1},
      new[]{0x1F170, 0x1F19A, 1},
      new[]{0x1F1E6, 0x1F202, 1},
      new[]{0x1F210, 0x1F23A, 1},
      new[]{0x1F240, 0x1F248, 1},
      new[]{0x1F250, 0x1F251, 1},
      new[]{0x1F300, 0x1F320, 1},
      new[]{0x1F330, 0x1F335, 1},
      new[]{0x1F337, 0x1F37C, 1},
      new[]{0x1F380, 0x1F393, 1},
      new[]{0x1F3A0, 0x1F3C4, 1},
      new[]{0x1F3C6, 0x1F3CA, 1},
      new[]{0x1F3E0, 0x1F3F0, 1},
      new[]{0x1F400, 0x1F43E, 1},
      new[]{0x1F440, 0x1F442, 2},
      new[]{0x1F443, 0x1F4F7, 1},
      new[]{0x1F4F9, 0x1F4FC, 1},
      new[]{0x1F500, 0x1F53D, 1},
      new[]{0x1F550, 0x1F567, 1},
      new[]{0x1F5FB, 0x1F5FF, 1},
      new[]{0x1F601, 0x1F610, 1},
      new[]{0x1F612, 0x1F614, 1},
      new[]{0x1F616, 0x1F61C, 2},
      new[]{0x1F61D, 0x1F61E, 1},
      new[]{0x1F620, 0x1F625, 1},
      new[]{0x1F628, 0x1F62B, 1},
      new[]{0x1F62D, 0x1F630, 3},
      new[]{0x1F631, 0x1F633, 1},
      new[]{0x1F635, 0x1F640, 1},
      new[]{0x1F645, 0x1F64F, 1},
      new[]{0x1F680, 0x1F6C5, 1},
      new[]{0x1F700, 0x1F773, 1}
    };
    }

    private static int[][] make_C()
    {
        return new int[][] {
      new[]{0x0000, 0x001F, 1},
      new[]{0x007F, 0x009F, 1},
      new[]{0x00AD, 0x0600, 1363},
      new[]{0x0601, 0x0603, 1},
      new[]{0x06DD, 0x070F, 50},
      new[]{0x17B4, 0x17B5, 1},
      new[]{0x200B, 0x200F, 1},
      new[]{0x202A, 0x202E, 1},
      new[]{0x2060, 0x2064, 1},
      new[]{0x206A, 0x206F, 1},
      new[]{0xD800, 0xF8FF, 1},
      new[]{0xFEFF, 0xFFF9, 250},
      new[]{0xFFFA, 0xFFFB, 1},
      new[]{0x110BD, 0x1D173, 49334},
      new[]{0x1D174, 0x1D17A, 1},
      new[]{0xE0001, 0xE0020, 31},
      new[]{0xE0021, 0xE007F, 1},
      new[]{0xF0000, 0xFFFFD, 1},
      new[]{0x100000, 0x10FFFD, 1}
    };
    }

    private static int[][] make_Z()
    {
        return new int[][] {
      new[]{0x0020, 0x00A0, 128},
      new[]{0x1680, 0x180E, 398},
      new[]{0x2000, 0x200A, 1},
      new[]{0x2028, 0x2029, 1},
      new[]{0x202F, 0x205F, 48},
      new[]{0x3000, 0x3000, 1}
    };
    }

    private static int[][] make_L()
    {
        return new int[][] {
      new[]{0x0041, 0x005A, 1},
      new[]{0x0061, 0x007A, 1},
      new[]{0x00AA, 0x00B5, 11},
      new[]{0x00BA, 0x00C0, 6},
      new[]{0x00C1, 0x00D6, 1},
      new[]{0x00D8, 0x00F6, 1},
      new[]{0x00F8, 0x02C1, 1},
      new[]{0x02C6, 0x02D1, 1},
      new[]{0x02E0, 0x02E4, 1},
      new[]{0x02EC, 0x02EE, 2},
      new[]{0x0370, 0x0374, 1},
      new[]{0x0376, 0x0377, 1},
      new[]{0x037A, 0x037D, 1},
      new[]{0x0386, 0x0388, 2},
      new[]{0x0389, 0x038A, 1},
      new[]{0x038C, 0x038E, 2},
      new[]{0x038F, 0x03A1, 1},
      new[]{0x03A3, 0x03F5, 1},
      new[]{0x03F7, 0x0481, 1},
      new[]{0x048A, 0x0527, 1},
      new[]{0x0531, 0x0556, 1},
      new[]{0x0559, 0x0561, 8},
      new[]{0x0562, 0x0587, 1},
      new[]{0x05D0, 0x05EA, 1},
      new[]{0x05F0, 0x05F2, 1},
      new[]{0x0620, 0x064A, 1},
      new[]{0x066E, 0x066F, 1},
      new[]{0x0671, 0x06D3, 1},
      new[]{0x06D5, 0x06E5, 16},
      new[]{0x06E6, 0x06EE, 8},
      new[]{0x06EF, 0x06FA, 11},
      new[]{0x06FB, 0x06FC, 1},
      new[]{0x06FF, 0x0710, 17},
      new[]{0x0712, 0x072F, 1},
      new[]{0x074D, 0x07A5, 1},
      new[]{0x07B1, 0x07CA, 25},
      new[]{0x07CB, 0x07EA, 1},
      new[]{0x07F4, 0x07F5, 1},
      new[]{0x07FA, 0x0800, 6},
      new[]{0x0801, 0x0815, 1},
      new[]{0x081A, 0x0824, 10},
      new[]{0x0828, 0x0840, 24},
      new[]{0x0841, 0x0858, 1},
      new[]{0x0904, 0x0939, 1},
      new[]{0x093D, 0x0950, 19},
      new[]{0x0958, 0x0961, 1},
      new[]{0x0971, 0x0977, 1},
      new[]{0x0979, 0x097F, 1},
      new[]{0x0985, 0x098C, 1},
      new[]{0x098F, 0x0990, 1},
      new[]{0x0993, 0x09A8, 1},
      new[]{0x09AA, 0x09B0, 1},
      new[]{0x09B2, 0x09B6, 4},
      new[]{0x09B7, 0x09B9, 1},
      new[]{0x09BD, 0x09CE, 17},
      new[]{0x09DC, 0x09DD, 1},
      new[]{0x09DF, 0x09E1, 1},
      new[]{0x09F0, 0x09F1, 1},
      new[]{0x0A05, 0x0A0A, 1},
      new[]{0x0A0F, 0x0A10, 1},
      new[]{0x0A13, 0x0A28, 1},
      new[]{0x0A2A, 0x0A30, 1},
      new[]{0x0A32, 0x0A33, 1},
      new[]{0x0A35, 0x0A36, 1},
      new[]{0x0A38, 0x0A39, 1},
      new[]{0x0A59, 0x0A5C, 1},
      new[]{0x0A5E, 0x0A72, 20},
      new[]{0x0A73, 0x0A74, 1},
      new[]{0x0A85, 0x0A8D, 1},
      new[]{0x0A8F, 0x0A91, 1},
      new[]{0x0A93, 0x0AA8, 1},
      new[]{0x0AAA, 0x0AB0, 1},
      new[]{0x0AB2, 0x0AB3, 1},
      new[]{0x0AB5, 0x0AB9, 1},
      new[]{0x0ABD, 0x0AD0, 19},
      new[]{0x0AE0, 0x0AE1, 1},
      new[]{0x0B05, 0x0B0C, 1},
      new[]{0x0B0F, 0x0B10, 1},
      new[]{0x0B13, 0x0B28, 1},
      new[]{0x0B2A, 0x0B30, 1},
      new[]{0x0B32, 0x0B33, 1},
      new[]{0x0B35, 0x0B39, 1},
      new[]{0x0B3D, 0x0B5C, 31},
      new[]{0x0B5D, 0x0B5F, 2},
      new[]{0x0B60, 0x0B61, 1},
      new[]{0x0B71, 0x0B83, 18},
      new[]{0x0B85, 0x0B8A, 1},
      new[]{0x0B8E, 0x0B90, 1},
      new[]{0x0B92, 0x0B95, 1},
      new[]{0x0B99, 0x0B9A, 1},
      new[]{0x0B9C, 0x0B9E, 2},
      new[]{0x0B9F, 0x0BA3, 4},
      new[]{0x0BA4, 0x0BA8, 4},
      new[]{0x0BA9, 0x0BAA, 1},
      new[]{0x0BAE, 0x0BB9, 1},
      new[]{0x0BD0, 0x0C05, 53},
      new[]{0x0C06, 0x0C0C, 1},
      new[]{0x0C0E, 0x0C10, 1},
      new[]{0x0C12, 0x0C28, 1},
      new[]{0x0C2A, 0x0C33, 1},
      new[]{0x0C35, 0x0C39, 1},
      new[]{0x0C3D, 0x0C58, 27},
      new[]{0x0C59, 0x0C60, 7},
      new[]{0x0C61, 0x0C85, 36},
      new[]{0x0C86, 0x0C8C, 1},
      new[]{0x0C8E, 0x0C90, 1},
      new[]{0x0C92, 0x0CA8, 1},
      new[]{0x0CAA, 0x0CB3, 1},
      new[]{0x0CB5, 0x0CB9, 1},
      new[]{0x0CBD, 0x0CDE, 33},
      new[]{0x0CE0, 0x0CE1, 1},
      new[]{0x0CF1, 0x0CF2, 1},
      new[]{0x0D05, 0x0D0C, 1},
      new[]{0x0D0E, 0x0D10, 1},
      new[]{0x0D12, 0x0D3A, 1},
      new[]{0x0D3D, 0x0D4E, 17},
      new[]{0x0D60, 0x0D61, 1},
      new[]{0x0D7A, 0x0D7F, 1},
      new[]{0x0D85, 0x0D96, 1},
      new[]{0x0D9A, 0x0DB1, 1},
      new[]{0x0DB3, 0x0DBB, 1},
      new[]{0x0DBD, 0x0DC0, 3},
      new[]{0x0DC1, 0x0DC6, 1},
      new[]{0x0E01, 0x0E30, 1},
      new[]{0x0E32, 0x0E33, 1},
      new[]{0x0E40, 0x0E46, 1},
      new[]{0x0E81, 0x0E82, 1},
      new[]{0x0E84, 0x0E87, 3},
      new[]{0x0E88, 0x0E8A, 2},
      new[]{0x0E8D, 0x0E94, 7},
      new[]{0x0E95, 0x0E97, 1},
      new[]{0x0E99, 0x0E9F, 1},
      new[]{0x0EA1, 0x0EA3, 1},
      new[]{0x0EA5, 0x0EA7, 2},
      new[]{0x0EAA, 0x0EAB, 1},
      new[]{0x0EAD, 0x0EB0, 1},
      new[]{0x0EB2, 0x0EB3, 1},
      new[]{0x0EBD, 0x0EC0, 3},
      new[]{0x0EC1, 0x0EC4, 1},
      new[]{0x0EC6, 0x0EDC, 22},
      new[]{0x0EDD, 0x0F00, 35},
      new[]{0x0F40, 0x0F47, 1},
      new[]{0x0F49, 0x0F6C, 1},
      new[]{0x0F88, 0x0F8C, 1},
      new[]{0x1000, 0x102A, 1},
      new[]{0x103F, 0x1050, 17},
      new[]{0x1051, 0x1055, 1},
      new[]{0x105A, 0x105D, 1},
      new[]{0x1061, 0x1065, 4},
      new[]{0x1066, 0x106E, 8},
      new[]{0x106F, 0x1070, 1},
      new[]{0x1075, 0x1081, 1},
      new[]{0x108E, 0x10A0, 18},
      new[]{0x10A1, 0x10C5, 1},
      new[]{0x10D0, 0x10FA, 1},
      new[]{0x10FC, 0x1100, 4},
      new[]{0x1101, 0x1248, 1},
      new[]{0x124A, 0x124D, 1},
      new[]{0x1250, 0x1256, 1},
      new[]{0x1258, 0x125A, 2},
      new[]{0x125B, 0x125D, 1},
      new[]{0x1260, 0x1288, 1},
      new[]{0x128A, 0x128D, 1},
      new[]{0x1290, 0x12B0, 1},
      new[]{0x12B2, 0x12B5, 1},
      new[]{0x12B8, 0x12BE, 1},
      new[]{0x12C0, 0x12C2, 2},
      new[]{0x12C3, 0x12C5, 1},
      new[]{0x12C8, 0x12D6, 1},
      new[]{0x12D8, 0x1310, 1},
      new[]{0x1312, 0x1315, 1},
      new[]{0x1318, 0x135A, 1},
      new[]{0x1380, 0x138F, 1},
      new[]{0x13A0, 0x13F4, 1},
      new[]{0x1401, 0x166C, 1},
      new[]{0x166F, 0x167F, 1},
      new[]{0x1681, 0x169A, 1},
      new[]{0x16A0, 0x16EA, 1},
      new[]{0x1700, 0x170C, 1},
      new[]{0x170E, 0x1711, 1},
      new[]{0x1720, 0x1731, 1},
      new[]{0x1740, 0x1751, 1},
      new[]{0x1760, 0x176C, 1},
      new[]{0x176E, 0x1770, 1},
      new[]{0x1780, 0x17B3, 1},
      new[]{0x17D7, 0x17DC, 5},
      new[]{0x1820, 0x1877, 1},
      new[]{0x1880, 0x18A8, 1},
      new[]{0x18AA, 0x18B0, 6},
      new[]{0x18B1, 0x18F5, 1},
      new[]{0x1900, 0x191C, 1},
      new[]{0x1950, 0x196D, 1},
      new[]{0x1970, 0x1974, 1},
      new[]{0x1980, 0x19AB, 1},
      new[]{0x19C1, 0x19C7, 1},
      new[]{0x1A00, 0x1A16, 1},
      new[]{0x1A20, 0x1A54, 1},
      new[]{0x1AA7, 0x1B05, 94},
      new[]{0x1B06, 0x1B33, 1},
      new[]{0x1B45, 0x1B4B, 1},
      new[]{0x1B83, 0x1BA0, 1},
      new[]{0x1BAE, 0x1BAF, 1},
      new[]{0x1BC0, 0x1BE5, 1},
      new[]{0x1C00, 0x1C23, 1},
      new[]{0x1C4D, 0x1C4F, 1},
      new[]{0x1C5A, 0x1C7D, 1},
      new[]{0x1CE9, 0x1CEC, 1},
      new[]{0x1CEE, 0x1CF1, 1},
      new[]{0x1D00, 0x1DBF, 1},
      new[]{0x1E00, 0x1F15, 1},
      new[]{0x1F18, 0x1F1D, 1},
      new[]{0x1F20, 0x1F45, 1},
      new[]{0x1F48, 0x1F4D, 1},
      new[]{0x1F50, 0x1F57, 1},
      new[]{0x1F59, 0x1F5F, 2},
      new[]{0x1F60, 0x1F7D, 1},
      new[]{0x1F80, 0x1FB4, 1},
      new[]{0x1FB6, 0x1FBC, 1},
      new[]{0x1FBE, 0x1FC2, 4},
      new[]{0x1FC3, 0x1FC4, 1},
      new[]{0x1FC6, 0x1FCC, 1},
      new[]{0x1FD0, 0x1FD3, 1},
      new[]{0x1FD6, 0x1FDB, 1},
      new[]{0x1FE0, 0x1FEC, 1},
      new[]{0x1FF2, 0x1FF4, 1},
      new[]{0x1FF6, 0x1FFC, 1},
      new[]{0x2071, 0x207F, 14},
      new[]{0x2090, 0x209C, 1},
      new[]{0x2102, 0x2107, 5},
      new[]{0x210A, 0x2113, 1},
      new[]{0x2115, 0x2119, 4},
      new[]{0x211A, 0x211D, 1},
      new[]{0x2124, 0x212A, 2},
      new[]{0x212B, 0x212D, 1},
      new[]{0x212F, 0x2139, 1},
      new[]{0x213C, 0x213F, 1},
      new[]{0x2145, 0x2149, 1},
      new[]{0x214E, 0x2183, 53},
      new[]{0x2184, 0x2C00, 2684},
      new[]{0x2C01, 0x2C2E, 1},
      new[]{0x2C30, 0x2C5E, 1},
      new[]{0x2C60, 0x2CE4, 1},
      new[]{0x2CEB, 0x2CEE, 1},
      new[]{0x2D00, 0x2D25, 1},
      new[]{0x2D30, 0x2D65, 1},
      new[]{0x2D6F, 0x2D80, 17},
      new[]{0x2D81, 0x2D96, 1},
      new[]{0x2DA0, 0x2DA6, 1},
      new[]{0x2DA8, 0x2DAE, 1},
      new[]{0x2DB0, 0x2DB6, 1},
      new[]{0x2DB8, 0x2DBE, 1},
      new[]{0x2DC0, 0x2DC6, 1},
      new[]{0x2DC8, 0x2DCE, 1},
      new[]{0x2DD0, 0x2DD6, 1},
      new[]{0x2DD8, 0x2DDE, 1},
      new[]{0x2E2F, 0x3005, 470},
      new[]{0x3006, 0x3031, 43},
      new[]{0x3032, 0x3035, 1},
      new[]{0x303B, 0x303C, 1},
      new[]{0x3041, 0x3096, 1},
      new[]{0x309D, 0x309F, 1},
      new[]{0x30A1, 0x30FA, 1},
      new[]{0x30FC, 0x30FF, 1},
      new[]{0x3105, 0x312D, 1},
      new[]{0x3131, 0x318E, 1},
      new[]{0x31A0, 0x31BA, 1},
      new[]{0x31F0, 0x31FF, 1},
      new[]{0x3400, 0x4DB5, 1},
      new[]{0x4E00, 0x9FCB, 1},
      new[]{0xA000, 0xA48C, 1},
      new[]{0xA4D0, 0xA4FD, 1},
      new[]{0xA500, 0xA60C, 1},
      new[]{0xA610, 0xA61F, 1},
      new[]{0xA62A, 0xA62B, 1},
      new[]{0xA640, 0xA66E, 1},
      new[]{0xA67F, 0xA697, 1},
      new[]{0xA6A0, 0xA6E5, 1},
      new[]{0xA717, 0xA71F, 1},
      new[]{0xA722, 0xA788, 1},
      new[]{0xA78B, 0xA78E, 1},
      new[]{0xA790, 0xA791, 1},
      new[]{0xA7A0, 0xA7A9, 1},
      new[]{0xA7FA, 0xA801, 1},
      new[]{0xA803, 0xA805, 1},
      new[]{0xA807, 0xA80A, 1},
      new[]{0xA80C, 0xA822, 1},
      new[]{0xA840, 0xA873, 1},
      new[]{0xA882, 0xA8B3, 1},
      new[]{0xA8F2, 0xA8F7, 1},
      new[]{0xA8FB, 0xA90A, 15},
      new[]{0xA90B, 0xA925, 1},
      new[]{0xA930, 0xA946, 1},
      new[]{0xA960, 0xA97C, 1},
      new[]{0xA984, 0xA9B2, 1},
      new[]{0xA9CF, 0xAA00, 49},
      new[]{0xAA01, 0xAA28, 1},
      new[]{0xAA40, 0xAA42, 1},
      new[]{0xAA44, 0xAA4B, 1},
      new[]{0xAA60, 0xAA76, 1},
      new[]{0xAA7A, 0xAA80, 6},
      new[]{0xAA81, 0xAAAF, 1},
      new[]{0xAAB1, 0xAAB5, 4},
      new[]{0xAAB6, 0xAAB9, 3},
      new[]{0xAABA, 0xAABD, 1},
      new[]{0xAAC0, 0xAAC2, 2},
      new[]{0xAADB, 0xAADD, 1},
      new[]{0xAB01, 0xAB06, 1},
      new[]{0xAB09, 0xAB0E, 1},
      new[]{0xAB11, 0xAB16, 1},
      new[]{0xAB20, 0xAB26, 1},
      new[]{0xAB28, 0xAB2E, 1},
      new[]{0xABC0, 0xABE2, 1},
      new[]{0xAC00, 0xD7A3, 1},
      new[]{0xD7B0, 0xD7C6, 1},
      new[]{0xD7CB, 0xD7FB, 1},
      new[]{0xF900, 0xFA2D, 1},
      new[]{0xFA30, 0xFA6D, 1},
      new[]{0xFA70, 0xFAD9, 1},
      new[]{0xFB00, 0xFB06, 1},
      new[]{0xFB13, 0xFB17, 1},
      new[]{0xFB1D, 0xFB1F, 2},
      new[]{0xFB20, 0xFB28, 1},
      new[]{0xFB2A, 0xFB36, 1},
      new[]{0xFB38, 0xFB3C, 1},
      new[]{0xFB3E, 0xFB40, 2},
      new[]{0xFB41, 0xFB43, 2},
      new[]{0xFB44, 0xFB46, 2},
      new[]{0xFB47, 0xFBB1, 1},
      new[]{0xFBD3, 0xFD3D, 1},
      new[]{0xFD50, 0xFD8F, 1},
      new[]{0xFD92, 0xFDC7, 1},
      new[]{0xFDF0, 0xFDFB, 1},
      new[]{0xFE70, 0xFE74, 1},
      new[]{0xFE76, 0xFEFC, 1},
      new[]{0xFF21, 0xFF3A, 1},
      new[]{0xFF41, 0xFF5A, 1},
      new[]{0xFF66, 0xFFBE, 1},
      new[]{0xFFC2, 0xFFC7, 1},
      new[]{0xFFCA, 0xFFCF, 1},
      new[]{0xFFD2, 0xFFD7, 1},
      new[]{0xFFDA, 0xFFDC, 1},
      new[]{0x10000, 0x1000B, 1},
      new[]{0x1000D, 0x10026, 1},
      new[]{0x10028, 0x1003A, 1},
      new[]{0x1003C, 0x1003D, 1},
      new[]{0x1003F, 0x1004D, 1},
      new[]{0x10050, 0x1005D, 1},
      new[]{0x10080, 0x100FA, 1},
      new[]{0x10280, 0x1029C, 1},
      new[]{0x102A0, 0x102D0, 1},
      new[]{0x10300, 0x1031E, 1},
      new[]{0x10330, 0x10340, 1},
      new[]{0x10342, 0x10349, 1},
      new[]{0x10380, 0x1039D, 1},
      new[]{0x103A0, 0x103C3, 1},
      new[]{0x103C8, 0x103CF, 1},
      new[]{0x10400, 0x1049D, 1},
      new[]{0x10800, 0x10805, 1},
      new[]{0x10808, 0x1080A, 2},
      new[]{0x1080B, 0x10835, 1},
      new[]{0x10837, 0x10838, 1},
      new[]{0x1083C, 0x1083F, 3},
      new[]{0x10840, 0x10855, 1},
      new[]{0x10900, 0x10915, 1},
      new[]{0x10920, 0x10939, 1},
      new[]{0x10A00, 0x10A10, 16},
      new[]{0x10A11, 0x10A13, 1},
      new[]{0x10A15, 0x10A17, 1},
      new[]{0x10A19, 0x10A33, 1},
      new[]{0x10A60, 0x10A7C, 1},
      new[]{0x10B00, 0x10B35, 1},
      new[]{0x10B40, 0x10B55, 1},
      new[]{0x10B60, 0x10B72, 1},
      new[]{0x10C00, 0x10C48, 1},
      new[]{0x11003, 0x11037, 1},
      new[]{0x11083, 0x110AF, 1},
      new[]{0x12000, 0x1236E, 1},
      new[]{0x13000, 0x1342E, 1},
      new[]{0x16800, 0x16A38, 1},
      new[]{0x1B000, 0x1B001, 1},
      new[]{0x1D400, 0x1D454, 1},
      new[]{0x1D456, 0x1D49C, 1},
      new[]{0x1D49E, 0x1D49F, 1},
      new[]{0x1D4A2, 0x1D4A5, 3},
      new[]{0x1D4A6, 0x1D4A9, 3},
      new[]{0x1D4AA, 0x1D4AC, 1},
      new[]{0x1D4AE, 0x1D4B9, 1},
      new[]{0x1D4BB, 0x1D4BD, 2},
      new[]{0x1D4BE, 0x1D4C3, 1},
      new[]{0x1D4C5, 0x1D505, 1},
      new[]{0x1D507, 0x1D50A, 1},
      new[]{0x1D50D, 0x1D514, 1},
      new[]{0x1D516, 0x1D51C, 1},
      new[]{0x1D51E, 0x1D539, 1},
      new[]{0x1D53B, 0x1D53E, 1},
      new[]{0x1D540, 0x1D544, 1},
      new[]{0x1D546, 0x1D54A, 4},
      new[]{0x1D54B, 0x1D550, 1},
      new[]{0x1D552, 0x1D6A5, 1},
      new[]{0x1D6A8, 0x1D6C0, 1},
      new[]{0x1D6C2, 0x1D6DA, 1},
      new[]{0x1D6DC, 0x1D6FA, 1},
      new[]{0x1D6FC, 0x1D714, 1},
      new[]{0x1D716, 0x1D734, 1},
      new[]{0x1D736, 0x1D74E, 1},
      new[]{0x1D750, 0x1D76E, 1},
      new[]{0x1D770, 0x1D788, 1},
      new[]{0x1D78A, 0x1D7A8, 1},
      new[]{0x1D7AA, 0x1D7C2, 1},
      new[]{0x1D7C4, 0x1D7CB, 1},
      new[]{0x20000, 0x2A6D6, 1},
      new[]{0x2A700, 0x2B734, 1},
      new[]{0x2B740, 0x2B81D, 1},
      new[]{0x2F800, 0x2FA1D, 1}
    };
    }

    private static int[][] make_M()
    {
        return new int[][] {
      new[]{0x0300, 0x036F, 1},
      new[]{0x0483, 0x0489, 1},
      new[]{0x0591, 0x05BD, 1},
      new[]{0x05BF, 0x05C1, 2},
      new[]{0x05C2, 0x05C4, 2},
      new[]{0x05C5, 0x05C7, 2},
      new[]{0x0610, 0x061A, 1},
      new[]{0x064B, 0x065F, 1},
      new[]{0x0670, 0x06D6, 102},
      new[]{0x06D7, 0x06DC, 1},
      new[]{0x06DF, 0x06E4, 1},
      new[]{0x06E7, 0x06E8, 1},
      new[]{0x06EA, 0x06ED, 1},
      new[]{0x0711, 0x0730, 31},
      new[]{0x0731, 0x074A, 1},
      new[]{0x07A6, 0x07B0, 1},
      new[]{0x07EB, 0x07F3, 1},
      new[]{0x0816, 0x0819, 1},
      new[]{0x081B, 0x0823, 1},
      new[]{0x0825, 0x0827, 1},
      new[]{0x0829, 0x082D, 1},
      new[]{0x0859, 0x085B, 1},
      new[]{0x0900, 0x0903, 1},
      new[]{0x093A, 0x093C, 1},
      new[]{0x093E, 0x094F, 1},
      new[]{0x0951, 0x0957, 1},
      new[]{0x0962, 0x0963, 1},
      new[]{0x0981, 0x0983, 1},
      new[]{0x09BC, 0x09BE, 2},
      new[]{0x09BF, 0x09C4, 1},
      new[]{0x09C7, 0x09C8, 1},
      new[]{0x09CB, 0x09CD, 1},
      new[]{0x09D7, 0x09E2, 11},
      new[]{0x09E3, 0x0A01, 30},
      new[]{0x0A02, 0x0A03, 1},
      new[]{0x0A3C, 0x0A3E, 2},
      new[]{0x0A3F, 0x0A42, 1},
      new[]{0x0A47, 0x0A48, 1},
      new[]{0x0A4B, 0x0A4D, 1},
      new[]{0x0A51, 0x0A70, 31},
      new[]{0x0A71, 0x0A75, 4},
      new[]{0x0A81, 0x0A83, 1},
      new[]{0x0ABC, 0x0ABE, 2},
      new[]{0x0ABF, 0x0AC5, 1},
      new[]{0x0AC7, 0x0AC9, 1},
      new[]{0x0ACB, 0x0ACD, 1},
      new[]{0x0AE2, 0x0AE3, 1},
      new[]{0x0B01, 0x0B03, 1},
      new[]{0x0B3C, 0x0B3E, 2},
      new[]{0x0B3F, 0x0B44, 1},
      new[]{0x0B47, 0x0B48, 1},
      new[]{0x0B4B, 0x0B4D, 1},
      new[]{0x0B56, 0x0B57, 1},
      new[]{0x0B62, 0x0B63, 1},
      new[]{0x0B82, 0x0BBE, 60},
      new[]{0x0BBF, 0x0BC2, 1},
      new[]{0x0BC6, 0x0BC8, 1},
      new[]{0x0BCA, 0x0BCD, 1},
      new[]{0x0BD7, 0x0C01, 42},
      new[]{0x0C02, 0x0C03, 1},
      new[]{0x0C3E, 0x0C44, 1},
      new[]{0x0C46, 0x0C48, 1},
      new[]{0x0C4A, 0x0C4D, 1},
      new[]{0x0C55, 0x0C56, 1},
      new[]{0x0C62, 0x0C63, 1},
      new[]{0x0C82, 0x0C83, 1},
      new[]{0x0CBC, 0x0CBE, 2},
      new[]{0x0CBF, 0x0CC4, 1},
      new[]{0x0CC6, 0x0CC8, 1},
      new[]{0x0CCA, 0x0CCD, 1},
      new[]{0x0CD5, 0x0CD6, 1},
      new[]{0x0CE2, 0x0CE3, 1},
      new[]{0x0D02, 0x0D03, 1},
      new[]{0x0D3E, 0x0D44, 1},
      new[]{0x0D46, 0x0D48, 1},
      new[]{0x0D4A, 0x0D4D, 1},
      new[]{0x0D57, 0x0D62, 11},
      new[]{0x0D63, 0x0D82, 31},
      new[]{0x0D83, 0x0DCA, 71},
      new[]{0x0DCF, 0x0DD4, 1},
      new[]{0x0DD6, 0x0DD8, 2},
      new[]{0x0DD9, 0x0DDF, 1},
      new[]{0x0DF2, 0x0DF3, 1},
      new[]{0x0E31, 0x0E34, 3},
      new[]{0x0E35, 0x0E3A, 1},
      new[]{0x0E47, 0x0E4E, 1},
      new[]{0x0EB1, 0x0EB4, 3},
      new[]{0x0EB5, 0x0EB9, 1},
      new[]{0x0EBB, 0x0EBC, 1},
      new[]{0x0EC8, 0x0ECD, 1},
      new[]{0x0F18, 0x0F19, 1},
      new[]{0x0F35, 0x0F39, 2},
      new[]{0x0F3E, 0x0F3F, 1},
      new[]{0x0F71, 0x0F84, 1},
      new[]{0x0F86, 0x0F87, 1},
      new[]{0x0F8D, 0x0F97, 1},
      new[]{0x0F99, 0x0FBC, 1},
      new[]{0x0FC6, 0x102B, 101},
      new[]{0x102C, 0x103E, 1},
      new[]{0x1056, 0x1059, 1},
      new[]{0x105E, 0x1060, 1},
      new[]{0x1062, 0x1064, 1},
      new[]{0x1067, 0x106D, 1},
      new[]{0x1071, 0x1074, 1},
      new[]{0x1082, 0x108D, 1},
      new[]{0x108F, 0x109A, 11},
      new[]{0x109B, 0x109D, 1},
      new[]{0x135D, 0x135F, 1},
      new[]{0x1712, 0x1714, 1},
      new[]{0x1732, 0x1734, 1},
      new[]{0x1752, 0x1753, 1},
      new[]{0x1772, 0x1773, 1},
      new[]{0x17B6, 0x17D3, 1},
      new[]{0x17DD, 0x180B, 46},
      new[]{0x180C, 0x180D, 1},
      new[]{0x18A9, 0x1920, 119},
      new[]{0x1921, 0x192B, 1},
      new[]{0x1930, 0x193B, 1},
      new[]{0x19B0, 0x19C0, 1},
      new[]{0x19C8, 0x19C9, 1},
      new[]{0x1A17, 0x1A1B, 1},
      new[]{0x1A55, 0x1A5E, 1},
      new[]{0x1A60, 0x1A7C, 1},
      new[]{0x1A7F, 0x1B00, 129},
      new[]{0x1B01, 0x1B04, 1},
      new[]{0x1B34, 0x1B44, 1},
      new[]{0x1B6B, 0x1B73, 1},
      new[]{0x1B80, 0x1B82, 1},
      new[]{0x1BA1, 0x1BAA, 1},
      new[]{0x1BE6, 0x1BF3, 1},
      new[]{0x1C24, 0x1C37, 1},
      new[]{0x1CD0, 0x1CD2, 1},
      new[]{0x1CD4, 0x1CE8, 1},
      new[]{0x1CED, 0x1CF2, 5},
      new[]{0x1DC0, 0x1DE6, 1},
      new[]{0x1DFC, 0x1DFF, 1},
      new[]{0x20D0, 0x20F0, 1},
      new[]{0x2CEF, 0x2CF1, 1},
      new[]{0x2D7F, 0x2DE0, 97},
      new[]{0x2DE1, 0x2DFF, 1},
      new[]{0x302A, 0x302F, 1},
      new[]{0x3099, 0x309A, 1},
      new[]{0xA66F, 0xA672, 1},
      new[]{0xA67C, 0xA67D, 1},
      new[]{0xA6F0, 0xA6F1, 1},
      new[]{0xA802, 0xA806, 4},
      new[]{0xA80B, 0xA823, 24},
      new[]{0xA824, 0xA827, 1},
      new[]{0xA880, 0xA881, 1},
      new[]{0xA8B4, 0xA8C4, 1},
      new[]{0xA8E0, 0xA8F1, 1},
      new[]{0xA926, 0xA92D, 1},
      new[]{0xA947, 0xA953, 1},
      new[]{0xA980, 0xA983, 1},
      new[]{0xA9B3, 0xA9C0, 1},
      new[]{0xAA29, 0xAA36, 1},
      new[]{0xAA43, 0xAA4C, 9},
      new[]{0xAA4D, 0xAA7B, 46},
      new[]{0xAAB0, 0xAAB2, 2},
      new[]{0xAAB3, 0xAAB4, 1},
      new[]{0xAAB7, 0xAAB8, 1},
      new[]{0xAABE, 0xAABF, 1},
      new[]{0xAAC1, 0xABE3, 290},
      new[]{0xABE4, 0xABEA, 1},
      new[]{0xABEC, 0xABED, 1},
      new[]{0xFB1E, 0xFE00, 738},
      new[]{0xFE01, 0xFE0F, 1},
      new[]{0xFE20, 0xFE26, 1},
      new[]{0x101FD, 0x10A01, 2052},
      new[]{0x10A02, 0x10A03, 1},
      new[]{0x10A05, 0x10A06, 1},
      new[]{0x10A0C, 0x10A0F, 1},
      new[]{0x10A38, 0x10A3A, 1},
      new[]{0x10A3F, 0x11000, 1473},
      new[]{0x11001, 0x11002, 1},
      new[]{0x11038, 0x11046, 1},
      new[]{0x11080, 0x11082, 1},
      new[]{0x110B0, 0x110BA, 1},
      new[]{0x1D165, 0x1D169, 1},
      new[]{0x1D16D, 0x1D172, 1},
      new[]{0x1D17B, 0x1D182, 1},
      new[]{0x1D185, 0x1D18B, 1},
      new[]{0x1D1AA, 0x1D1AD, 1},
      new[]{0x1D242, 0x1D244, 1},
      new[]{0xE0100, 0xE01EF, 1}
    };
    }

    private static int[][] make_N()
    {
        return new int[][] {
      new[]{0x0030, 0x0039, 1},
      new[]{0x00B2, 0x00B3, 1},
      new[]{0x00B9, 0x00BC, 3},
      new[]{0x00BD, 0x00BE, 1},
      new[]{0x0660, 0x0669, 1},
      new[]{0x06F0, 0x06F9, 1},
      new[]{0x07C0, 0x07C9, 1},
      new[]{0x0966, 0x096F, 1},
      new[]{0x09E6, 0x09EF, 1},
      new[]{0x09F4, 0x09F9, 1},
      new[]{0x0A66, 0x0A6F, 1},
      new[]{0x0AE6, 0x0AEF, 1},
      new[]{0x0B66, 0x0B6F, 1},
      new[]{0x0B72, 0x0B77, 1},
      new[]{0x0BE6, 0x0BF2, 1},
      new[]{0x0C66, 0x0C6F, 1},
      new[]{0x0C78, 0x0C7E, 1},
      new[]{0x0CE6, 0x0CEF, 1},
      new[]{0x0D66, 0x0D75, 1},
      new[]{0x0E50, 0x0E59, 1},
      new[]{0x0ED0, 0x0ED9, 1},
      new[]{0x0F20, 0x0F33, 1},
      new[]{0x1040, 0x1049, 1},
      new[]{0x1090, 0x1099, 1},
      new[]{0x1369, 0x137C, 1},
      new[]{0x16EE, 0x16F0, 1},
      new[]{0x17E0, 0x17E9, 1},
      new[]{0x17F0, 0x17F9, 1},
      new[]{0x1810, 0x1819, 1},
      new[]{0x1946, 0x194F, 1},
      new[]{0x19D0, 0x19DA, 1},
      new[]{0x1A80, 0x1A89, 1},
      new[]{0x1A90, 0x1A99, 1},
      new[]{0x1B50, 0x1B59, 1},
      new[]{0x1BB0, 0x1BB9, 1},
      new[]{0x1C40, 0x1C49, 1},
      new[]{0x1C50, 0x1C59, 1},
      new[]{0x2070, 0x2074, 4},
      new[]{0x2075, 0x2079, 1},
      new[]{0x2080, 0x2089, 1},
      new[]{0x2150, 0x2182, 1},
      new[]{0x2185, 0x2189, 1},
      new[]{0x2460, 0x249B, 1},
      new[]{0x24EA, 0x24FF, 1},
      new[]{0x2776, 0x2793, 1},
      new[]{0x2CFD, 0x3007, 778},
      new[]{0x3021, 0x3029, 1},
      new[]{0x3038, 0x303A, 1},
      new[]{0x3192, 0x3195, 1},
      new[]{0x3220, 0x3229, 1},
      new[]{0x3251, 0x325F, 1},
      new[]{0x3280, 0x3289, 1},
      new[]{0x32B1, 0x32BF, 1},
      new[]{0xA620, 0xA629, 1},
      new[]{0xA6E6, 0xA6EF, 1},
      new[]{0xA830, 0xA835, 1},
      new[]{0xA8D0, 0xA8D9, 1},
      new[]{0xA900, 0xA909, 1},
      new[]{0xA9D0, 0xA9D9, 1},
      new[]{0xAA50, 0xAA59, 1},
      new[]{0xABF0, 0xABF9, 1},
      new[]{0xFF10, 0xFF19, 1},
      new[]{0x10107, 0x10133, 1},
      new[]{0x10140, 0x10178, 1},
      new[]{0x1018A, 0x10320, 406},
      new[]{0x10321, 0x10323, 1},
      new[]{0x10341, 0x1034A, 9},
      new[]{0x103D1, 0x103D5, 1},
      new[]{0x104A0, 0x104A9, 1},
      new[]{0x10858, 0x1085F, 1},
      new[]{0x10916, 0x1091B, 1},
      new[]{0x10A40, 0x10A47, 1},
      new[]{0x10A7D, 0x10A7E, 1},
      new[]{0x10B58, 0x10B5F, 1},
      new[]{0x10B78, 0x10B7F, 1},
      new[]{0x10E60, 0x10E7E, 1},
      new[]{0x11052, 0x1106F, 1},
      new[]{0x12400, 0x12462, 1},
      new[]{0x1D360, 0x1D371, 1},
      new[]{0x1D7CE, 0x1D7FF, 1},
      new[]{0x1F100, 0x1F10A, 1}
    };
    }

    private static int[][] make_Common()
    {
        return new int[][] {
      new[]{0x0000, 0x0040, 1},
      new[]{0x005B, 0x0060, 1},
      new[]{0x007B, 0x00A9, 1},
      new[]{0x00AB, 0x00B9, 1},
      new[]{0x00BB, 0x00BF, 1},
      new[]{0x00D7, 0x00F7, 32},
      new[]{0x02B9, 0x02DF, 1},
      new[]{0x02E5, 0x02E9, 1},
      new[]{0x02EC, 0x02FF, 1},
      new[]{0x0374, 0x037E, 10},
      new[]{0x0385, 0x0387, 2},
      new[]{0x0589, 0x060C, 131},
      new[]{0x061B, 0x061F, 4},
      new[]{0x0640, 0x0660, 32},
      new[]{0x0661, 0x0669, 1},
      new[]{0x06DD, 0x0964, 647},
      new[]{0x0965, 0x0970, 11},
      new[]{0x0E3F, 0x0FD5, 406},
      new[]{0x0FD6, 0x0FD8, 1},
      new[]{0x10FB, 0x16EB, 1520},
      new[]{0x16EC, 0x16ED, 1},
      new[]{0x1735, 0x1736, 1},
      new[]{0x1802, 0x1803, 1},
      new[]{0x1805, 0x1CD3, 1230},
      new[]{0x1CE1, 0x1CE9, 8},
      new[]{0x1CEA, 0x1CEC, 1},
      new[]{0x1CEE, 0x1CF2, 1},
      new[]{0x2000, 0x200B, 1},
      new[]{0x200E, 0x2064, 1},
      new[]{0x206A, 0x2070, 1},
      new[]{0x2074, 0x207E, 1},
      new[]{0x2080, 0x208E, 1},
      new[]{0x20A0, 0x20B9, 1},
      new[]{0x2100, 0x2125, 1},
      new[]{0x2127, 0x2129, 1},
      new[]{0x212C, 0x2131, 1},
      new[]{0x2133, 0x214D, 1},
      new[]{0x214F, 0x215F, 1},
      new[]{0x2189, 0x2190, 7},
      new[]{0x2191, 0x23F3, 1},
      new[]{0x2400, 0x2426, 1},
      new[]{0x2440, 0x244A, 1},
      new[]{0x2460, 0x26FF, 1},
      new[]{0x2701, 0x27CA, 1},
      new[]{0x27CC, 0x27CE, 2},
      new[]{0x27CF, 0x27FF, 1},
      new[]{0x2900, 0x2B4C, 1},
      new[]{0x2B50, 0x2B59, 1},
      new[]{0x2E00, 0x2E31, 1},
      new[]{0x2FF0, 0x2FFB, 1},
      new[]{0x3000, 0x3004, 1},
      new[]{0x3006, 0x3008, 2},
      new[]{0x3009, 0x3020, 1},
      new[]{0x3030, 0x3037, 1},
      new[]{0x303C, 0x303F, 1},
      new[]{0x309B, 0x309C, 1},
      new[]{0x30A0, 0x30FB, 91},
      new[]{0x30FC, 0x3190, 148},
      new[]{0x3191, 0x319F, 1},
      new[]{0x31C0, 0x31E3, 1},
      new[]{0x3220, 0x325F, 1},
      new[]{0x327F, 0x32CF, 1},
      new[]{0x3358, 0x33FF, 1},
      new[]{0x4DC0, 0x4DFF, 1},
      new[]{0xA700, 0xA721, 1},
      new[]{0xA788, 0xA78A, 1},
      new[]{0xA830, 0xA839, 1},
      new[]{0xFD3E, 0xFD3F, 1},
      new[]{0xFDFD, 0xFE10, 19},
      new[]{0xFE11, 0xFE19, 1},
      new[]{0xFE30, 0xFE52, 1},
      new[]{0xFE54, 0xFE66, 1},
      new[]{0xFE68, 0xFE6B, 1},
      new[]{0xFEFF, 0xFF01, 2},
      new[]{0xFF02, 0xFF20, 1},
      new[]{0xFF3B, 0xFF40, 1},
      new[]{0xFF5B, 0xFF65, 1},
      new[]{0xFF70, 0xFF9E, 46},
      new[]{0xFF9F, 0xFFE0, 65},
      new[]{0xFFE1, 0xFFE6, 1},
      new[]{0xFFE8, 0xFFEE, 1},
      new[]{0xFFF9, 0xFFFD, 1},
      new[]{0x10100, 0x10102, 1},
      new[]{0x10107, 0x10133, 1},
      new[]{0x10137, 0x1013F, 1},
      new[]{0x10190, 0x1019B, 1},
      new[]{0x101D0, 0x101FC, 1},
      new[]{0x1D000, 0x1D0F5, 1},
      new[]{0x1D100, 0x1D126, 1},
      new[]{0x1D129, 0x1D166, 1},
      new[]{0x1D16A, 0x1D17A, 1},
      new[]{0x1D183, 0x1D184, 1},
      new[]{0x1D18C, 0x1D1A9, 1},
      new[]{0x1D1AE, 0x1D1DD, 1},
      new[]{0x1D300, 0x1D356, 1},
      new[]{0x1D360, 0x1D371, 1},
      new[]{0x1D400, 0x1D454, 1},
      new[]{0x1D456, 0x1D49C, 1},
      new[]{0x1D49E, 0x1D49F, 1},
      new[]{0x1D4A2, 0x1D4A5, 3},
      new[]{0x1D4A6, 0x1D4A9, 3},
      new[]{0x1D4AA, 0x1D4AC, 1},
      new[]{0x1D4AE, 0x1D4B9, 1},
      new[]{0x1D4BB, 0x1D4BD, 2},
      new[]{0x1D4BE, 0x1D4C3, 1},
      new[]{0x1D4C5, 0x1D505, 1},
      new[]{0x1D507, 0x1D50A, 1},
      new[]{0x1D50D, 0x1D514, 1},
      new[]{0x1D516, 0x1D51C, 1},
      new[]{0x1D51E, 0x1D539, 1},
      new[]{0x1D53B, 0x1D53E, 1},
      new[]{0x1D540, 0x1D544, 1},
      new[]{0x1D546, 0x1D54A, 4},
      new[]{0x1D54B, 0x1D550, 1},
      new[]{0x1D552, 0x1D6A5, 1},
      new[]{0x1D6A8, 0x1D7CB, 1},
      new[]{0x1D7CE, 0x1D7FF, 1},
      new[]{0x1F000, 0x1F02B, 1},
      new[]{0x1F030, 0x1F093, 1},
      new[]{0x1F0A0, 0x1F0AE, 1},
      new[]{0x1F0B1, 0x1F0BE, 1},
      new[]{0x1F0C1, 0x1F0CF, 1},
      new[]{0x1F0D1, 0x1F0DF, 1},
      new[]{0x1F100, 0x1F10A, 1},
      new[]{0x1F110, 0x1F12E, 1},
      new[]{0x1F130, 0x1F169, 1},
      new[]{0x1F170, 0x1F19A, 1},
      new[]{0x1F1E6, 0x1F1FF, 1},
      new[]{0x1F201, 0x1F202, 1},
      new[]{0x1F210, 0x1F23A, 1},
      new[]{0x1F240, 0x1F248, 1},
      new[]{0x1F250, 0x1F251, 1},
      new[]{0x1F300, 0x1F320, 1},
      new[]{0x1F330, 0x1F335, 1},
      new[]{0x1F337, 0x1F37C, 1},
      new[]{0x1F380, 0x1F393, 1},
      new[]{0x1F3A0, 0x1F3C4, 1},
      new[]{0x1F3C6, 0x1F3CA, 1},
      new[]{0x1F3E0, 0x1F3F0, 1},
      new[]{0x1F400, 0x1F43E, 1},
      new[]{0x1F440, 0x1F442, 2},
      new[]{0x1F443, 0x1F4F7, 1},
      new[]{0x1F4F9, 0x1F4FC, 1},
      new[]{0x1F500, 0x1F53D, 1},
      new[]{0x1F550, 0x1F567, 1},
      new[]{0x1F5FB, 0x1F5FF, 1},
      new[]{0x1F601, 0x1F610, 1},
      new[]{0x1F612, 0x1F614, 1},
      new[]{0x1F616, 0x1F61C, 2},
      new[]{0x1F61D, 0x1F61E, 1},
      new[]{0x1F620, 0x1F625, 1},
      new[]{0x1F628, 0x1F62B, 1},
      new[]{0x1F62D, 0x1F630, 3},
      new[]{0x1F631, 0x1F633, 1},
      new[]{0x1F635, 0x1F640, 1},
      new[]{0x1F645, 0x1F64F, 1},
      new[]{0x1F680, 0x1F6C5, 1},
      new[]{0x1F700, 0x1F773, 1},
      new[]{0xE0001, 0xE0020, 31},
      new[]{0xE0021, 0xE007F, 1}
    };
    }

    private static int[][] make_Inherited()
    {
        return new int[][] {
      new[]{0x0300, 0x036F, 1},
      new[]{0x0485, 0x0486, 1},
      new[]{0x064B, 0x0655, 1},
      new[]{0x065F, 0x0670, 17},
      new[]{0x0951, 0x0952, 1},
      new[]{0x1CD0, 0x1CD2, 1},
      new[]{0x1CD4, 0x1CE0, 1},
      new[]{0x1CE2, 0x1CE8, 1},
      new[]{0x1CED, 0x1DC0, 211},
      new[]{0x1DC1, 0x1DE6, 1},
      new[]{0x1DFC, 0x1DFF, 1},
      new[]{0x200C, 0x200D, 1},
      new[]{0x20D0, 0x20F0, 1},
      new[]{0x302A, 0x302D, 1},
      new[]{0x3099, 0x309A, 1},
      new[]{0xFE00, 0xFE0F, 1},
      new[]{0xFE20, 0xFE26, 1},
      new[]{0x101FD, 0x1D167, 53098},
      new[]{0x1D168, 0x1D169, 1},
      new[]{0x1D17B, 0x1D182, 1},
      new[]{0x1D185, 0x1D18B, 1},
      new[]{0x1D1AA, 0x1D1AD, 1},
      new[]{0xE0100, 0xE01EF, 1}
    };
    }

    private static int[][] make_Bamum()
    {
        return new int[][] {
        new[]{ 0xA6A0, 0xA6F7, 1 },
        new[]{ 0x16800, 0x16A38, 1 } };
    }

    private static int[][] make_Arabic()
    {
        return new int[][] {
      new[]{0x0600, 0x0603, 1},
      new[]{0x0606, 0x060B, 1},
      new[]{0x060D, 0x061A, 1},
      new[]{0x061E, 0x0620, 2},
      new[]{0x0621, 0x063F, 1},
      new[]{0x0641, 0x064A, 1},
      new[]{0x0656, 0x065E, 1},
      new[]{0x066A, 0x066F, 1},
      new[]{0x0671, 0x06DC, 1},
      new[]{0x06DE, 0x06FF, 1},
      new[]{0x0750, 0x077F, 1},
      new[]{0xFB50, 0xFBC1, 1},
      new[]{0xFBD3, 0xFD3D, 1},
      new[]{0xFD50, 0xFD8F, 1},
      new[]{0xFD92, 0xFDC7, 1},
      new[]{0xFDF0, 0xFDFC, 1},
      new[]{0xFE70, 0xFE74, 1},
      new[]{0xFE76, 0xFEFC, 1},
      new[]{0x10E60, 0x10E7E, 1}
    };
    }

    private static int[][] make_Lisu()
    {
        return new int[][] { new[] { 0xA4D0, 0xA4FF, 1 } };
    }

    private static int[][] make_Armenian()
    {
        return new int[][] {
      new[]{0x0531, 0x0556, 1},
      new[]{0x0559, 0x055F, 1},
      new[]{0x0561, 0x0587, 1},
      new[]{0x058A, 0xFB13, 62857},
      new[]{0xFB14, 0xFB17, 1}
    };
    }

    private static int[][] make_Bengali()
    {
        return new int[][] {
      new[]{0x0981, 0x0983, 1},
      new[]{0x0985, 0x098C, 1},
      new[]{0x098F, 0x0990, 1},
      new[]{0x0993, 0x09A8, 1},
      new[]{0x09AA, 0x09B0, 1},
      new[]{0x09B2, 0x09B6, 4},
      new[]{0x09B7, 0x09B9, 1},
      new[]{0x09BC, 0x09C4, 1},
      new[]{0x09C7, 0x09C8, 1},
      new[]{0x09CB, 0x09CE, 1},
      new[]{0x09D7, 0x09DC, 5},
      new[]{0x09DD, 0x09DF, 2},
      new[]{0x09E0, 0x09E3, 1},
      new[]{0x09E6, 0x09FB, 1}
    };
    }

    private static int[][] make_Old_South_Arabian()
    {
        return new int[][] { new[] { 0x10A60, 0x10A7F, 1 } };
    }

    private static int[][] make_Bopomofo()
    {
        return new int[][] { new[] { 0x02EA, 0x02EB, 1 }, new[] { 0x3105, 0x312D, 1 }, new int[] { 0x31A0, 0x31BA, 1 } };
    }

    private static int[][] make_Cherokee()
    {
        return new int[][] { new[] { 0x13A0, 0x13F4, 1 } };
    }

    private static int[][] make_Coptic()
    {
        return new int[][] { new[] { 0x03E2, 0x03EF, 1 }, new[] { 0x2C80, 0x2CF1, 1 }, new int[] { 0x2CF9, 0x2CFF, 1 } };
    }

    private static int[][] make_Cyrillic()
    {
        return new int[][] {
      new[]{0x0400, 0x0484, 1},
      new[]{0x0487, 0x0527, 1},
      new[]{0x1D2B, 0x1D78, 77},
      new[]{0x2DE0, 0x2DFF, 1},
      new[]{0xA640, 0xA673, 1},
      new[]{0xA67C, 0xA697, 1}
    };
    }

    private static int[][] make_Deseret()
    {
        return new int[][] { new[] { 0x10400, 0x1044F, 1 } };
    }

    private static int[][] make_Devanagari()
    {
        return new int[][] {
      new[]{0x0900, 0x0950, 1},
      new[]{0x0953, 0x0963, 1},
      new[]{0x0966, 0x096F, 1},
      new[]{0x0971, 0x0977, 1},
      new[]{0x0979, 0x097F, 1},
      new[]{0xA8E0, 0xA8FB, 1}
    };
    }

    private static int[][] make_Ethiopic()
    {
        return new int[][] {
      new[]{0x1200, 0x1248, 1},
      new[]{0x124A, 0x124D, 1},
      new[]{0x1250, 0x1256, 1},
      new[]{0x1258, 0x125A, 2},
      new[]{0x125B, 0x125D, 1},
      new[]{0x1260, 0x1288, 1},
      new[]{0x128A, 0x128D, 1},
      new[]{0x1290, 0x12B0, 1},
      new[]{0x12B2, 0x12B5, 1},
      new[]{0x12B8, 0x12BE, 1},
      new[]{0x12C0, 0x12C2, 2},
      new[]{0x12C3, 0x12C5, 1},
      new[]{0x12C8, 0x12D6, 1},
      new[]{0x12D8, 0x1310, 1},
      new[]{0x1312, 0x1315, 1},
      new[]{0x1318, 0x135A, 1},
      new[]{0x135D, 0x137C, 1},
      new[]{0x1380, 0x1399, 1},
      new[]{0x2D80, 0x2D96, 1},
      new[]{0x2DA0, 0x2DA6, 1},
      new[]{0x2DA8, 0x2DAE, 1},
      new[]{0x2DB0, 0x2DB6, 1},
      new[]{0x2DB8, 0x2DBE, 1},
      new[]{0x2DC0, 0x2DC6, 1},
      new[]{0x2DC8, 0x2DCE, 1},
      new[]{0x2DD0, 0x2DD6, 1},
      new[]{0x2DD8, 0x2DDE, 1},
      new[]{0xAB01, 0xAB06, 1},
      new[]{0xAB09, 0xAB0E, 1},
      new[]{0xAB11, 0xAB16, 1},
      new[]{0xAB20, 0xAB26, 1},
      new[]{0xAB28, 0xAB2E, 1}
    };
    }

    private static int[][] make_Georgian()
    {
        return new int[][] {
      new[]{0x10A0, 0x10C5, 1}, new int[] {0x10D0, 0x10FA, 1}, new int[] {0x10FC, 0x2D00, 7172}, new int[] {0x2D01, 0x2D25, 1}
    };
    }

    private static int[][] make_Gothic()
    {
        return new int[][] { new int[] { 0x10330, 0x1034A, 1 } };
    }

    private static int[][] make_Greek()
    {
        return new int[][] {
      new[]{0x0370, 0x0373, 1},
      new[]{0x0375, 0x0377, 1},
      new[]{0x037A, 0x037D, 1},
      new[]{0x0384, 0x0388, 2},
      new[]{0x0389, 0x038A, 1},
      new[]{0x038C, 0x038E, 2},
      new[]{0x038F, 0x03A1, 1},
      new[]{0x03A3, 0x03E1, 1},
      new[]{0x03F0, 0x03FF, 1},
      new[]{0x1D26, 0x1D2A, 1},
      new[]{0x1D5D, 0x1D61, 1},
      new[]{0x1D66, 0x1D6A, 1},
      new[]{0x1DBF, 0x1F00, 321},
      new[]{0x1F01, 0x1F15, 1},
      new[]{0x1F18, 0x1F1D, 1},
      new[]{0x1F20, 0x1F45, 1},
      new[]{0x1F48, 0x1F4D, 1},
      new[]{0x1F50, 0x1F57, 1},
      new[]{0x1F59, 0x1F5F, 2},
      new[]{0x1F60, 0x1F7D, 1},
      new[]{0x1F80, 0x1FB4, 1},
      new[]{0x1FB6, 0x1FC4, 1},
      new[]{0x1FC6, 0x1FD3, 1},
      new[]{0x1FD6, 0x1FDB, 1},
      new[]{0x1FDD, 0x1FEF, 1},
      new[]{0x1FF2, 0x1FF4, 1},
      new[]{0x1FF6, 0x1FFE, 1},
      new[]{0x2126, 0x10140, 57370},
      new[]{0x10141, 0x1018A, 1},
      new[]{0x1D200, 0x1D245, 1}
    };
    }

    private static int[][] make_Gujarati()
    {
        return new int[][] {
      new[]{0x0A81, 0x0A83, 1},
      new[]{0x0A85, 0x0A8D, 1},
      new[]{0x0A8F, 0x0A91, 1},
      new[]{0x0A93, 0x0AA8, 1},
      new[]{0x0AAA, 0x0AB0, 1},
      new[]{0x0AB2, 0x0AB3, 1},
      new[]{0x0AB5, 0x0AB9, 1},
      new[]{0x0ABC, 0x0AC5, 1},
      new[]{0x0AC7, 0x0AC9, 1},
      new[]{0x0ACB, 0x0ACD, 1},
      new[]{0x0AD0, 0x0AE0, 16},
      new[]{0x0AE1, 0x0AE3, 1},
      new[]{0x0AE6, 0x0AEF, 1},
      new[]{0x0AF1, 0x0AF1, 1}
    };
    }

    private static int[][] make_Gurmukhi()
    {
        return new int[][] {
      new[]{0x0A01, 0x0A03, 1},
      new[]{0x0A05, 0x0A0A, 1},
      new[]{0x0A0F, 0x0A10, 1},
      new[]{0x0A13, 0x0A28, 1},
      new[]{0x0A2A, 0x0A30, 1},
      new[]{0x0A32, 0x0A33, 1},
      new[]{0x0A35, 0x0A36, 1},
      new[]{0x0A38, 0x0A39, 1},
      new[]{0x0A3C, 0x0A3E, 2},
      new[]{0x0A3F, 0x0A42, 1},
      new[]{0x0A47, 0x0A48, 1},
      new[]{0x0A4B, 0x0A4D, 1},
      new[]{0x0A51, 0x0A59, 8},
      new[]{0x0A5A, 0x0A5C, 1},
      new[]{0x0A5E, 0x0A66, 8},
      new[]{0x0A67, 0x0A75, 1}
    };
    }

    private static int[][] make_Han()
    {
        return new int[][] {
      new[]{0x2E80, 0x2E99, 1},
      new[]{0x2E9B, 0x2EF3, 1},
      new[]{0x2F00, 0x2FD5, 1},
      new[]{0x3005, 0x3007, 2},
      new[]{0x3021, 0x3029, 1},
      new[]{0x3038, 0x303B, 1},
      new[]{0x3400, 0x4DB5, 1},
      new[]{0x4E00, 0x9FCB, 1},
      new[]{0xF900, 0xFA2D, 1},
      new[]{0xFA30, 0xFA6D, 1},
      new[]{0xFA70, 0xFAD9, 1},
      new[]{0x20000, 0x2A6D6, 1},
      new[]{0x2A700, 0x2B734, 1},
      new[]{0x2B740, 0x2B81D, 1},
      new[]{0x2F800, 0x2FA1D, 1}
    };
    }

    private static int[][] make_Hangul()
    {
        return new int[][] {
      new[]{0x1100, 0x11FF, 1},
      new[]{0x302E, 0x302F, 1},
      new[]{0x3131, 0x318E, 1},
      new[]{0x3200, 0x321E, 1},
      new[]{0x3260, 0x327E, 1},
      new[]{0xA960, 0xA97C, 1},
      new[]{0xAC00, 0xD7A3, 1},
      new[]{0xD7B0, 0xD7C6, 1},
      new[]{0xD7CB, 0xD7FB, 1},
      new[]{0xFFA0, 0xFFBE, 1},
      new[]{0xFFC2, 0xFFC7, 1},
      new[]{0xFFCA, 0xFFCF, 1},
      new[]{0xFFD2, 0xFFD7, 1},
      new[]{0xFFDA, 0xFFDC, 1}
    };
    }

    private static int[][] make_Hebrew()
    {
        return new int[][] {
      new[]{0x0591, 0x05C7, 1},
      new[]{0x05D0, 0x05EA, 1},
      new[]{0x05F0, 0x05F4, 1},
      new[]{0xFB1D, 0xFB36, 1},
      new[]{0xFB38, 0xFB3C, 1},
      new[]{0xFB3E, 0xFB40, 2},
      new[]{0xFB41, 0xFB43, 2},
      new[]{0xFB44, 0xFB46, 2},
      new[]{0xFB47, 0xFB4F, 1}
    };
    }

    private static int[][] make_Hiragana()
    {
        return new int[][] { new int[] { 0x3041, 0x3096, 1 }, new int[] { 0x309D, 0x309F, 1 }, new int[] { 0x1B001, 0x1F200, 16895 } };
    }

    private static int[][] make_Kannada()
    {
        return new int[][] {
      new[]{0x0C82, 0x0C83, 1},
      new[]{0x0C85, 0x0C8C, 1},
      new[]{0x0C8E, 0x0C90, 1},
      new[]{0x0C92, 0x0CA8, 1},
      new[]{0x0CAA, 0x0CB3, 1},
      new[]{0x0CB5, 0x0CB9, 1},
      new[]{0x0CBC, 0x0CC4, 1},
      new[]{0x0CC6, 0x0CC8, 1},
      new[]{0x0CCA, 0x0CCD, 1},
      new[]{0x0CD5, 0x0CD6, 1},
      new[]{0x0CDE, 0x0CE0, 2},
      new[]{0x0CE1, 0x0CE3, 1},
      new[]{0x0CE6, 0x0CEF, 1},
      new[]{0x0CF1, 0x0CF2, 1}
    };
    }

    private static int[][] make_Katakana()
    {
        return new int[][] {
      new[]{0x30A1, 0x30FA, 1},
      new[]{0x30FD, 0x30FF, 1},
      new[]{0x31F0, 0x31FF, 1},
      new[]{0x32D0, 0x32FE, 1},
      new[]{0x3300, 0x3357, 1},
      new[]{0xFF66, 0xFF6F, 1},
      new[]{0xFF71, 0xFF9D, 1},
      new[]{0x1B000, 0x1B000, 1}
    };
    }

    private static int[][] make_Khmer()
    {
        return new int[][] {
      new[]{0x1780, 0x17DD, 1}, new int[] {0x17E0, 0x17E9, 1}, new int[] {0x17F0, 0x17F9, 1}, new int[] {0x19E0, 0x19FF, 1}
    };
    }

    private static int[][] make_Lao()
    {
        return new int[][] {
      new[]{0x0E81, 0x0E82, 1},
      new[]{0x0E84, 0x0E87, 3},
      new[]{0x0E88, 0x0E8A, 2},
      new[]{0x0E8D, 0x0E94, 7},
      new[]{0x0E95, 0x0E97, 1},
      new[]{0x0E99, 0x0E9F, 1},
      new[]{0x0EA1, 0x0EA3, 1},
      new[]{0x0EA5, 0x0EA7, 2},
      new[]{0x0EAA, 0x0EAB, 1},
      new[]{0x0EAD, 0x0EB9, 1},
      new[]{0x0EBB, 0x0EBD, 1},
      new[]{0x0EC0, 0x0EC4, 1},
      new[]{0x0EC6, 0x0EC8, 2},
      new[]{0x0EC9, 0x0ECD, 1},
      new[]{0x0ED0, 0x0ED9, 1},
      new[]{0x0EDC, 0x0EDD, 1}
    };
    }

    private static int[][] make_Latin()
    {
        return new int[][] {
      new[]{0x0041, 0x005A, 1},
      new[]{0x0061, 0x007A, 1},
      new[]{0x00AA, 0x00BA, 16},
      new[]{0x00C0, 0x00D6, 1},
      new[]{0x00D8, 0x00F6, 1},
      new[]{0x00F8, 0x02B8, 1},
      new[]{0x02E0, 0x02E4, 1},
      new[]{0x1D00, 0x1D25, 1},
      new[]{0x1D2C, 0x1D5C, 1},
      new[]{0x1D62, 0x1D65, 1},
      new[]{0x1D6B, 0x1D77, 1},
      new[]{0x1D79, 0x1DBE, 1},
      new[]{0x1E00, 0x1EFF, 1},
      new[]{0x2071, 0x207F, 14},
      new[]{0x2090, 0x209C, 1},
      new[]{0x212A, 0x212B, 1},
      new[]{0x2132, 0x214E, 28},
      new[]{0x2160, 0x2188, 1},
      new[]{0x2C60, 0x2C7F, 1},
      new[]{0xA722, 0xA787, 1},
      new[]{0xA78B, 0xA78E, 1},
      new[]{0xA790, 0xA791, 1},
      new[]{0xA7A0, 0xA7A9, 1},
      new[]{0xA7FA, 0xA7FF, 1},
      new[]{0xFB00, 0xFB06, 1},
      new[]{0xFF21, 0xFF3A, 1},
      new[]{0xFF41, 0xFF5A, 1}
    };
    }

    private static int[][] make_Malayalam()
    {
        return new int[][] {
      new[]{0x0D02, 0x0D03, 1},
      new[]{0x0D05, 0x0D0C, 1},
      new[]{0x0D0E, 0x0D10, 1},
      new[]{0x0D12, 0x0D3A, 1},
      new[]{0x0D3D, 0x0D44, 1},
      new[]{0x0D46, 0x0D48, 1},
      new[]{0x0D4A, 0x0D4E, 1},
      new[]{0x0D57, 0x0D60, 9},
      new[]{0x0D61, 0x0D63, 1},
      new[]{0x0D66, 0x0D75, 1},
      new[]{0x0D79, 0x0D7F, 1}
    };
    }

    private static int[][] make_Mongolian()
    {
        return new int[][] {
      new[]{0x1800, 0x1801, 1},
      new[]{0x1804, 0x1806, 2},
      new[]{0x1807, 0x180E, 1},
      new[]{0x1810, 0x1819, 1},
      new[]{0x1820, 0x1877, 1},
      new[]{0x1880, 0x18AA, 1}
    };
    }

    private static int[][] make_Myanmar()
    {
        return new int[][] { new int[] { 0x1000, 0x109F, 1 }, new int[] { 0xAA60, 0xAA7B, 1 } };
    }

    private static int[][] make_Ogham()
    {
        return new int[][] { new int[] { 0x1680, 0x169C, 1 } };
    }

    private static int[][] make_Old_Italic()
    {
        return new int[][] { new int[] { 0x10300, 0x1031E, 1 }, new int[] { 0x10320, 0x10323, 1 } };
    }

    private static int[][] make_Oriya()
    {
        return new int[][] {
      new[]{0x0B01, 0x0B03, 1},
      new[]{0x0B05, 0x0B0C, 1},
      new[]{0x0B0F, 0x0B10, 1},
      new[]{0x0B13, 0x0B28, 1},
      new[]{0x0B2A, 0x0B30, 1},
      new[]{0x0B32, 0x0B33, 1},
      new[]{0x0B35, 0x0B39, 1},
      new[]{0x0B3C, 0x0B44, 1},
      new[]{0x0B47, 0x0B48, 1},
      new[]{0x0B4B, 0x0B4D, 1},
      new[]{0x0B56, 0x0B57, 1},
      new[]{0x0B5C, 0x0B5D, 1},
      new[]{0x0B5F, 0x0B63, 1},
      new[]{0x0B66, 0x0B77, 1}
    };
    }

    private static int[][] make_Runic()
    {
        return new int[][] { new int[] { 0x16A0, 0x16EA, 1 }, new int[] { 0x16EE, 0x16F0, 1 } };
    }

    private static int[][] make_Sinhala()
    {
        return new int[][] {
      new[]{0x0D82, 0x0D83, 1},
      new[]{0x0D85, 0x0D96, 1},
      new[]{0x0D9A, 0x0DB1, 1},
      new[]{0x0DB3, 0x0DBB, 1},
      new[]{0x0DBD, 0x0DC0, 3},
      new[]{0x0DC1, 0x0DC6, 1},
      new[]{0x0DCA, 0x0DCF, 5},
      new[]{0x0DD0, 0x0DD4, 1},
      new[]{0x0DD6, 0x0DD8, 2},
      new[]{0x0DD9, 0x0DDF, 1},
      new[]{0x0DF2, 0x0DF4, 1}
    };
    }

    private static int[][] make_Syriac()
    {
        return new int[][] { new int[] { 0x0700, 0x070D, 1 }, new int[] { 0x070F, 0x074A, 1 }, new int[] { 0x074D, 0x074F, 1 } };
    }

    private static int[][] make_Tamil()
    {
        return new int[][] {
      new[]{0x0B82, 0x0B83, 1},
      new[]{0x0B85, 0x0B8A, 1},
      new[]{0x0B8E, 0x0B90, 1},
      new[]{0x0B92, 0x0B95, 1},
      new[]{0x0B99, 0x0B9A, 1},
      new[]{0x0B9C, 0x0B9E, 2},
      new[]{0x0B9F, 0x0BA3, 4},
      new[]{0x0BA4, 0x0BA8, 4},
      new[]{0x0BA9, 0x0BAA, 1},
      new[]{0x0BAE, 0x0BB9, 1},
      new[]{0x0BBE, 0x0BC2, 1},
      new[]{0x0BC6, 0x0BC8, 1},
      new[]{0x0BCA, 0x0BCD, 1},
      new[]{0x0BD0, 0x0BD7, 7},
      new[]{0x0BE6, 0x0BFA, 1}
    };
    }

    private static int[][] make_Telugu()
    {
        return new int[][] {
      new[]{0x0C01, 0x0C03, 1},
      new[]{0x0C05, 0x0C0C, 1},
      new[]{0x0C0E, 0x0C10, 1},
      new[]{0x0C12, 0x0C28, 1},
      new[]{0x0C2A, 0x0C33, 1},
      new[]{0x0C35, 0x0C39, 1},
      new[]{0x0C3D, 0x0C44, 1},
      new[]{0x0C46, 0x0C48, 1},
      new[]{0x0C4A, 0x0C4D, 1},
      new[]{0x0C55, 0x0C56, 1},
      new[]{0x0C58, 0x0C59, 1},
      new[]{0x0C60, 0x0C63, 1},
      new[]{0x0C66, 0x0C6F, 1},
      new[]{0x0C78, 0x0C7F, 1}
    };
    }

    private static int[][] make_Thaana()
    {
        return new int[][] { new int[] { 0x0780, 0x07B1, 1 } };
    }

    private static int[][] make_Thai()
    {
        return new int[][] { new int[] { 0x0E01, 0x0E3A, 1 }, new int[] { 0x0E40, 0x0E5B, 1 } };
    }

    private static int[][] make_Tibetan()
    {
        return new int[][] {
      new[]{0x0F00, 0x0F47, 1},
      new[]{0x0F49, 0x0F6C, 1},
      new[]{0x0F71, 0x0F97, 1},
      new[]{0x0F99, 0x0FBC, 1},
      new[]{0x0FBE, 0x0FCC, 1},
      new[]{0x0FCE, 0x0FD4, 1},
      new[]{0x0FD9, 0x0FDA, 1}
    };
    }

    private static int[][] make_Canadian_Aboriginal()
    {
        return new int[][] { new int[] { 0x1400, 0x167F, 1 }, new int[] { 0x18B0, 0x18F5, 1 } };
    }

    private static int[][] make_Yi()
    {
        return new int[][] { new int[] { 0xA000, 0xA48C, 1 }, new int[] { 0xA490, 0xA4C6, 1 } };
    }

    private static int[][] make_Tagalog()
    {
        return new int[][] { new int[] { 0x1700, 0x170C, 1 }, new int[] { 0x170E, 0x1714, 1 } };
    }

    private static int[][] make_Hanunoo()
    {
        return new int[][] { new int[] { 0x1720, 0x1734, 1 } };
    }

    private static int[][] make_Buhid()
    {
        return new int[][] { new int[] { 0x1740, 0x1753, 1 } };
    }

    private static int[][] make_Tagbanwa()
    {
        return new int[][] { new int[] { 0x1760, 0x176C, 1 }, new int[] { 0x176E, 0x1770, 1 }, new int[] { 0x1772, 0x1773, 1 } };
    }

    private static int[][] make_Braille()
    {
        return new int[][] { new int[] { 0x2800, 0x28FF, 1 } };
    }

    private static int[][] make_Cypriot()
    {
        return new int[][] {
      new[]{0x10800, 0x10805, 1},
      new[]{0x10808, 0x1080A, 2},
      new[]{0x1080B, 0x10835, 1},
      new[]{0x10837, 0x10838, 1},
      new[]{0x1083C, 0x1083F, 3}
    };
    }

    private static int[][] make_Limbu()
    {
        return new int[][] {
      new[]{0x1900, 0x191C, 1},
      new[]{0x1920, 0x192B, 1},
      new[]{0x1930, 0x193B, 1},
      new[]{0x1940, 0x1944, 4},
      new[]{0x1945, 0x194F, 1}
    };
    }

    private static int[][] make_Linear_B()
    {
        return new int[][] {
      new[]{0x10000, 0x1000B, 1},
      new[]{0x1000D, 0x10026, 1},
      new[]{0x10028, 0x1003A, 1},
      new[]{0x1003C, 0x1003D, 1},
      new[]{0x1003F, 0x1004D, 1},
      new[]{0x10050, 0x1005D, 1},
      new[]{0x10080, 0x100FA, 1}
    };
    }

    private static int[][] make_Osmanya()
    {
        return new int[][] { new int[] { 0x10480, 0x1049D, 1 }, new int[] { 0x104A0, 0x104A9, 1 } };
    }

    private static int[][] make_Shavian()
    {
        return new int[][] { new int[] { 0x10450, 0x1047F, 1 } };
    }

    private static int[][] make_Tai_Le()
    {
        return new int[][] { new int[] { 0x1950, 0x196D, 1 }, new int[] { 0x1970, 0x1974, 1 } };
    }

    private static int[][] make_Ugaritic()
    {
        return new int[][] { new int[] { 0x10380, 0x1039D, 1 }, new int[] { 0x1039F, 0x1039F, 1 } };
    }

    private static int[][] make_Buginese()
    {
        return new int[][] { new int[] { 0x1A00, 0x1A1B, 1 }, new int[] { 0x1A1E, 0x1A1F, 1 } };
    }

    private static int[][] make_Glagolitic()
    {
        return new int[][] { new int[] { 0x2C00, 0x2C2E, 1 }, new int[] { 0x2C30, 0x2C5E, 1 } };
    }

    private static int[][] make_Kharoshthi()
    {
        return new int[][] {
      new[]{0x10A00, 0x10A03, 1},
      new[]{0x10A05, 0x10A06, 1},
      new[]{0x10A0C, 0x10A13, 1},
      new[]{0x10A15, 0x10A17, 1},
      new[]{0x10A19, 0x10A33, 1},
      new[]{0x10A38, 0x10A3A, 1},
      new[]{0x10A3F, 0x10A47, 1},
      new[]{0x10A50, 0x10A58, 1}
    };
    }

    private static int[][] make_Syloti_Nagri()
    {
        return new int[][] { new int[] { 0xA800, 0xA82B, 1 } };
    }

    private static int[][] make_New_Tai_Lue()
    {
        return new int[][] {
      new[]{0x1980, 0x19AB, 1},new int[] {0x19B0, 0x19C9, 1}, new int[]{0x19D0, 0x19DA, 1}, new int[] {0x19DE, 0x19DF, 1}
    };
    }

    private static int[][] make_Tifinagh()
    {
        return new int[][] { new int[] { 0x2D30, 0x2D65, 1 }, new int[] { 0x2D6F, 0x2D70, 1 }, new int[] { 0x2D7F, 0x2D7F, 1 } };
    }

    private static int[][] make_Old_Persian()
    {
        return new int[][] { new int[] { 0x103A0, 0x103C3, 1 }, new int[] { 0x103C8, 0x103D5, 1 } };
    }

    private static int[][] make_Balinese()
    {
        return new int[][] { new int[] { 0x1B00, 0x1B4B, 1 }, new int[] { 0x1B50, 0x1B7C, 1 } };
    }

    private static int[][] make_Batak()
    {
        return new int[][] { new int[] { 0x1BC0, 0x1BF3, 1 }, new int[] { 0x1BFC, 0x1BFF, 1 } };
    }

    private static int[][] make_Brahmi()
    {
        return new int[][] { new int[] { 0x11000, 0x1104D, 1 }, new int[] { 0x11052, 0x1106F, 1 } };
    }

    private static int[][] make_Cham()
    {
        return new int[][] {
      new[]{0xAA00, 0xAA36, 1}, new int[] {0xAA40, 0xAA4D, 1}, new int[] {0xAA50, 0xAA59, 1}, new int[] {0xAA5C, 0xAA5F, 1}
    };
    }

    private static int[][] make_Egyptian_Hieroglyphs()
    {
        return new int[][] { new int[] { 0x13000, 0x1342E, 1 } };
    }

    private static int[][] make_Javanese()
    {
        return new int[][] { new int[] { 0xA980, 0xA9CD, 1 }, new int[] { 0xA9CF, 0xA9D9, 1 }, new int[] { 0xA9DE, 0xA9DF, 1 } };
    }

    private static int[][] make_Kayah_Li()
    {
        return new int[][] { new int[] { 0xA900, 0xA92F, 1 } };
    }

    private static int[][] make_Lepcha()
    {
        return new int[][] { new int[] { 0x1C00, 0x1C37, 1 }, new int[] { 0x1C3B, 0x1C49, 1 }, new int[] { 0x1C4D, 0x1C4F, 1 } };
    }

    private static int[][] make_Mandaic()
    {
        return new int[][] { new int[] { 0x0840, 0x085B, 1 }, new int[] { 0x085E, 0x085E, 1 } };
    }

    private static int[][] make_Nko()
    {
        return new int[][] { new int[] { 0x07C0, 0x07FA, 1 } };
    }

    private static int[][] make_Old_Turkic()
    {
        return new int[][] { new int[] { 0x10C00, 0x10C48, 1 } };
    }

    private static int[][] make_Phags_Pa()
    {
        return new int[][] { new int[] { 0xA840, 0xA877, 1 } };
    }

    private static int[][] make_Phoenician()
    {
        return new int[][] { new int[] { 0x10900, 0x1091B, 1 }, new int[] { 0x1091F, 0x1091F, 1 } };
    }

    private static int[][] make_Vai()
    {
        return new int[][] { new int[] { 0xA500, 0xA62B, 1 } };
    }

    private static int[][] make_Cuneiform()
    {
        return new int[][] { new int[] { 0x12000, 0x1236E, 1 }, new int[] { 0x12400, 0x12462, 1 }, new int[] { 0x12470, 0x12473, 1 } };
    }

    private static int[][] make_Unknown()
    {
        return new int[][] { new int[] { 0xD800, 0xF8FF, 1 }, new int[] { 0xF0000, 0xFFFFD, 1 }, new int[] { 0x100000, 0x10FFFD, 1 } };
    }

    private static int[][] make_Carian()
    {
        return new int[][] { new int[] { 0x102A0, 0x102D0, 1 } };
    }

    private static int[][] make_Tai_Tham()
    {
        return new int[][] {
      new[]{0x1A20, 0x1A5E, 1},
      new[]{0x1A60, 0x1A7C, 1},
      new[]{0x1A7F, 0x1A89, 1},
      new[]{0x1A90, 0x1A99, 1},
      new[]{0x1AA0, 0x1AAD, 1}
    };
    }

    private static int[][] make_Lycian()
    {
        return new int[][] { new int[] { 0x10280, 0x1029C, 1 } };
    }

    private static int[][] make_Lydian()
    {
        return new int[][] { new int[] { 0x10920, 0x10939, 1 }, new int[] { 0x1093F, 0x1093F, 1 } };
    }

    private static int[][] make_Ol_Chiki()
    {
        return new int[][] { new int[] { 0x1C50, 0x1C7F, 1 } };
    }

    private static int[][] make_Rejang()
    {
        return new int[][] { new int[] { 0xA930, 0xA953, 1 }, new int[] { 0xA95F, 0xA95F, 1 } };
    }

    private static int[][] make_Saurashtra()
    {
        return new int[][] { new int[] { 0xA880, 0xA8C4, 1 }, new int[] { 0xA8CE, 0xA8D9, 1 } };
    }

    private static int[][] make_Sundanese()
    {
        return new int[][] { new int[] { 0x1B80, 0x1BAA, 1 }, new int[] { 0x1BAE, 0x1BB9, 1 } };
    }

    private static int[][] make_Meetei_Mayek()
    {
        return new int[][] { new int[] { 0xABC0, 0xABED, 1 }, new int[] { 0xABF0, 0xABF9, 1 } };
    }

    private static int[][] make_Imperial_Aramaic()
    {
        return new int[][] { new int[] { 0x10840, 0x10855, 1 }, new int[] { 0x10857, 0x1085F, 1 } };
    }

    private static int[][] make_Avestan()
    {
        return new int[][] { new int[] { 0x10B00, 0x10B35, 1 }, new int[] { 0x10B39, 0x10B3F, 1 } };
    }

    private static int[][] make_Kaithi()
    {
        return new int[][] { new int[] { 0x11080, 0x110C1, 1 } };
    }

    private static int[][] make_Inscriptional_Pahlavi()
    {
        return new int[][] { new int[] { 0x10B60, 0x10B72, 1 }, new int[] { 0x10B78, 0x10B7F, 1 } };
    }

    private static int[][] make_Inscriptional_Parthian()
    {
        return new int[][] { new int[] { 0x10B40, 0x10B55, 1 }, new int[] { 0x10B58, 0x10B5F, 1 } };
    }

    private static int[][] make_Samaritan()
    {
        return new int[][] { new int[] { 0x0800, 0x082D, 1 }, new int[] { 0x0830, 0x083E, 1 } };
    }

    private static int[][] make_Tai_Viet()
    {
        return new int[][] { new int[] { 0xAA80, 0xAAC2, 1 }, new int[] { 0xAADB, 0xAADF, 1 } };
    }

    private static Dictionary<string, int[][]> Categories()
    {
        Dictionary<string, int[][]> map = new();
        map.Add("Lu", Lu);
        map.Add("Ll", Ll);
        map.Add("Lt", Lt);
        map.Add("Lm", Lm);
        map.Add("Lo", Lo);
        map.Add("Mn", Mn);
        map.Add("Me", Me);
        map.Add("Mc", Mc);
        map.Add("Nd", Nd);
        map.Add("Nl", Nl);
        map.Add("No", No);
        map.Add("Zs", Zs);
        map.Add("Zl", Zl);
        map.Add("Zp", Zp);
        map.Add("Cc", Cc);
        map.Add("Cf", Cf);
        map.Add("Co", Co);
        map.Add("Cs", Cs);
        map.Add("Pd", Pd);
        map.Add("Ps", Ps);
        map.Add("Pe", Pe);
        map.Add("Pc", Pc);
        map.Add("Po", Po);
        map.Add("Sm", Sm);
        map.Add("Sc", Sc);
        map.Add("Sk", Sk);
        map.Add("So", So);
        map.Add("Pi", Pi);
        map.Add("Pf", Pf);
        map.Add("P", P);
        map.Add("S", S);
        map.Add("C", C);
        map.Add("Z", Z);
        map.Add("L", L);
        map.Add("M", M);
        map.Add("N", N);
        return (map);
    }

    private static Dictionary<string, int[][]> Scripts()
    {
        Dictionary<string, int[][]> map = new();
        map.Add("Common", Common);
        map.Add("Inherited", Inherited);
        map.Add("Bamum", Bamum);
        map.Add("Arabic", Arabic);
        map.Add("Lisu", Lisu);
        map.Add("Armenian", Armenian);
        map.Add("Bengali", Bengali);
        map.Add("Old_South_Arabian", Old_South_Arabian);
        map.Add("Bopomofo", Bopomofo);
        map.Add("Cherokee", Cherokee);
        map.Add("Coptic", Coptic);
        map.Add("Cyrillic", Cyrillic);
        map.Add("Deseret", Deseret);
        map.Add("Devanagari", Devanagari);
        map.Add("Ethiopic", Ethiopic);
        map.Add("Georgian", Georgian);
        map.Add("Gothic", Gothic);
        map.Add("Greek", Greek);
        map.Add("Gujarati", Gujarati);
        map.Add("Gurmukhi", Gurmukhi);
        map.Add("Han", Han);
        map.Add("Hangul", Hangul);
        map.Add("Hebrew", Hebrew);
        map.Add("Hiragana", Hiragana);
        map.Add("Kannada", Kannada);
        map.Add("Katakana", Katakana);
        map.Add("Khmer", Khmer);
        map.Add("Lao", Lao);
        map.Add("Latin", Latin);
        map.Add("Malayalam", Malayalam);
        map.Add("Mongolian", Mongolian);
        map.Add("Myanmar", Myanmar);
        map.Add("Ogham", Ogham);
        map.Add("Old_Italic", Old_Italic);
        map.Add("Oriya", Oriya);
        map.Add("Runic", Runic);
        map.Add("Sinhala", Sinhala);
        map.Add("Syriac", Syriac);
        map.Add("Tamil", Tamil);
        map.Add("Telugu", Telugu);
        map.Add("Thaana", Thaana);
        map.Add("Thai", Thai);
        map.Add("Tibetan", Tibetan);
        map.Add("Canadian_Aboriginal", Canadian_Aboriginal);
        map.Add("Yi", Yi);
        map.Add("Tagalog", Tagalog);
        map.Add("Hanunoo", Hanunoo);
        map.Add("Buhid", Buhid);
        map.Add("Tagbanwa", Tagbanwa);
        map.Add("Braille", Braille);
        map.Add("Cypriot", Cypriot);
        map.Add("Limbu", Limbu);
        map.Add("Linear_B", Linear_B);
        map.Add("Osmanya", Osmanya);
        map.Add("Shavian", Shavian);
        map.Add("Tai_Le", Tai_Le);
        map.Add("Ugaritic", Ugaritic);
        map.Add("Buginese", Buginese);
        map.Add("Glagolitic", Glagolitic);
        map.Add("Kharoshthi", Kharoshthi);
        map.Add("Syloti_Nagri", Syloti_Nagri);
        map.Add("New_Tai_Lue", New_Tai_Lue);
        map.Add("Tifinagh", Tifinagh);
        map.Add("Old_Persian", Old_Persian);
        map.Add("Balinese", Balinese);
        map.Add("Batak", Batak);
        map.Add("Brahmi", Brahmi);
        map.Add("Cham", Cham);
        map.Add("Egyptian_Hieroglyphs", Egyptian_Hieroglyphs);
        map.Add("Javanese", Javanese);
        map.Add("Kayah_Li", Kayah_Li);
        map.Add("Lepcha", Lepcha);
        map.Add("Mandaic", Mandaic);
        map.Add("Nko", Nko);
        map.Add("Old_Turkic", Old_Turkic);
        map.Add("Phags_Pa", Phags_Pa);
        map.Add("Phoenician", Phoenician);
        map.Add("Vai", Vai);
        map.Add("Cuneiform", Cuneiform);
        map.Add("Unknown", Unknown);
        map.Add("Carian", Carian);
        map.Add("Tai_Tham", Tai_Tham);
        map.Add("Lycian", Lycian);
        map.Add("Lydian", Lydian);
        map.Add("Ol_Chiki", Ol_Chiki);
        map.Add("Rejang", Rejang);
        map.Add("Saurashtra", Saurashtra);
        map.Add("Sundanese", Sundanese);
        map.Add("Meetei_Mayek", Meetei_Mayek);
        map.Add("Imperial_Aramaic", Imperial_Aramaic);
        map.Add("Avestan", Avestan);
        map.Add("Kaithi", Kaithi);
        map.Add("Inscriptional_Pahlavi", Inscriptional_Pahlavi);
        map.Add("Inscriptional_Parthian", Inscriptional_Parthian);
        map.Add("Samaritan", Samaritan);
        map.Add("Tai_Viet", Tai_Viet);
        return (map);
    }

    private static int[][] make_foldCommon()
    {
        return new int[][] { new int[] { 0x039C, 0x03BC, 32 } };
    }

    private static int[][] make_foldInherited()
    {
        return new int[][] { new int[] { 0x0399, 0x03B9, 32 }, new int[] { 0x1FBE, 0x1FBE, 1 } };
    }

    private static int[][] make_foldGreek()
    {
        return new int[][] { new int[] { 0x00B5, 0x0345, 656 } };
    }

    private static Dictionary<string, int[][]> FoldScript()
    {
        Dictionary<string, int[][]> map = new();
        map.Add("Common", foldCommon);
        map.Add("Inherited", foldInherited);
        map.Add("Greek", foldGreek);
        return map;
    }

    private static int[][] make_foldLu()
    {
        return new int[][] {
      new[]{0x0061, 0x007A, 1},
      new[]{0x00B5, 0x00DF, 42},
      new[]{0x00E0, 0x00F6, 1},
      new[]{0x00F8, 0x00FF, 1},
      new[]{0x0101, 0x012F, 2},
      new[]{0x0133, 0x0137, 2},
      new[]{0x013A, 0x0148, 2},
      new[]{0x014B, 0x0177, 2},
      new[]{0x017A, 0x017E, 2},
      new[]{0x017F, 0x0180, 1},
      new[]{0x0183, 0x0185, 2},
      new[]{0x0188, 0x018C, 4},
      new[]{0x0192, 0x0195, 3},
      new[]{0x0199, 0x019A, 1},
      new[]{0x019E, 0x01A1, 3},
      new[]{0x01A3, 0x01A5, 2},
      new[]{0x01A8, 0x01AD, 5},
      new[]{0x01B0, 0x01B4, 4},
      new[]{0x01B6, 0x01B9, 3},
      new[]{0x01BD, 0x01BF, 2},
      new[]{0x01C5, 0x01C6, 1},
      new[]{0x01C8, 0x01C9, 1},
      new[]{0x01CB, 0x01CC, 1},
      new[]{0x01CE, 0x01DC, 2},
      new[]{0x01DD, 0x01EF, 2},
      new[]{0x01F2, 0x01F3, 1},
      new[]{0x01F5, 0x01F9, 4},
      new[]{0x01FB, 0x021F, 2},
      new[]{0x0223, 0x0233, 2},
      new[]{0x023C, 0x023F, 3},
      new[]{0x0240, 0x0242, 2},
      new[]{0x0247, 0x024F, 2},
      new[]{0x0250, 0x0254, 1},
      new[]{0x0256, 0x0257, 1},
      new[]{0x0259, 0x025B, 2},
      new[]{0x0260, 0x0263, 3},
      new[]{0x0265, 0x0268, 3},
      new[]{0x0269, 0x026B, 2},
      new[]{0x026F, 0x0271, 2},
      new[]{0x0272, 0x0275, 3},
      new[]{0x027D, 0x0283, 3},
      new[]{0x0288, 0x028C, 1},
      new[]{0x0292, 0x0345, 179},
      new[]{0x0371, 0x0373, 2},
      new[]{0x0377, 0x037B, 4},
      new[]{0x037C, 0x037D, 1},
      new[]{0x03AC, 0x03AF, 1},
      new[]{0x03B1, 0x03CE, 1},
      new[]{0x03D0, 0x03D1, 1},
      new[]{0x03D5, 0x03D7, 1},
      new[]{0x03D9, 0x03EF, 2},
      new[]{0x03F0, 0x03F2, 1},
      new[]{0x03F5, 0x03FB, 3},
      new[]{0x0430, 0x045F, 1},
      new[]{0x0461, 0x0481, 2},
      new[]{0x048B, 0x04BF, 2},
      new[]{0x04C2, 0x04CE, 2},
      new[]{0x04CF, 0x0527, 2},
      new[]{0x0561, 0x0586, 1},
      new[]{0x1D79, 0x1D7D, 4},
      new[]{0x1E01, 0x1E95, 2},
      new[]{0x1E9B, 0x1EA1, 6},
      new[]{0x1EA3, 0x1EFF, 2},
      new[]{0x1F00, 0x1F07, 1},
      new[]{0x1F10, 0x1F15, 1},
      new[]{0x1F20, 0x1F27, 1},
      new[]{0x1F30, 0x1F37, 1},
      new[]{0x1F40, 0x1F45, 1},
      new[]{0x1F51, 0x1F57, 2},
      new[]{0x1F60, 0x1F67, 1},
      new[]{0x1F70, 0x1F7D, 1},
      new[]{0x1FB0, 0x1FB1, 1},
      new[]{0x1FBE, 0x1FD0, 18},
      new[]{0x1FD1, 0x1FE0, 15},
      new[]{0x1FE1, 0x1FE5, 4},
      new[]{0x214E, 0x2184, 54},
      new[]{0x2C30, 0x2C5E, 1},
      new[]{0x2C61, 0x2C65, 4},
      new[]{0x2C66, 0x2C6C, 2},
      new[]{0x2C73, 0x2C76, 3},
      new[]{0x2C81, 0x2CE3, 2},
      new[]{0x2CEC, 0x2CEE, 2},
      new[]{0x2D00, 0x2D25, 1},
      new[]{0xA641, 0xA66D, 2},
      new[]{0xA681, 0xA697, 2},
      new[]{0xA723, 0xA72F, 2},
      new[]{0xA733, 0xA76F, 2},
      new[]{0xA77A, 0xA77C, 2},
      new[]{0xA77F, 0xA787, 2},
      new[]{0xA78C, 0xA791, 5},
      new[]{0xA7A1, 0xA7A9, 2},
      new[]{0xFF41, 0xFF5A, 1},
      new[]{0x10428, 0x1044F, 1}
    };
    }

    private static int[][] make_foldLl()
    {
        return new int[][] {
      new[]{0x004B, 0x0053, 8},
      new[]{0x00C5, 0x01C4, 255},
      new[]{0x01C5, 0x01C7, 2},
      new[]{0x01C8, 0x01CA, 2},
      new[]{0x01CB, 0x01F1, 38},
      new[]{0x01F2, 0x0345, 339},
      new[]{0x0392, 0x0398, 3},
      new[]{0x0399, 0x039A, 1},
      new[]{0x039C, 0x03A0, 4},
      new[]{0x03A1, 0x03A3, 2},
      new[]{0x03A6, 0x03A9, 3},
      new[]{0x03F4, 0x1E60, 6764},
      new[]{0x1E9E, 0x2126, 648},
      new[]{0x212A, 0x212B, 1}
    };
    }

    private static int[][] make_foldLt()
    {
        return new int[][] {
      new[]{0x01C4, 0x01C6, 2},
      new[]{0x01C7, 0x01C9, 2},
      new[]{0x01CA, 0x01CC, 2},
      new[]{0x01F1, 0x01F3, 2},
      new[]{0x1F80, 0x1F87, 1},
      new[]{0x1F90, 0x1F97, 1},
      new[]{0x1FA0, 0x1FA7, 1},
      new[]{0x1FB3, 0x1FC3, 16},
      new[]{0x1FF3, 0x1FF3, 1}
    };
    }

    private static int[][] make_foldMn()
    {
        return new int[][] { new int[] { 0x0399, 0x03B9, 32 }, new int[] { 0x1FBE, 0x1FBE, 1 } };
    }

    private static Dictionary<string, int[][]> FoldCategory()
    {
        Dictionary<string, int[][]> map = new();
        map.Add("Lu", foldLu);
        map.Add("Ll", foldLl);
        map.Add("Lt", foldLt);
        map.Add("Mn", foldMn);
        return map;
    }
}
