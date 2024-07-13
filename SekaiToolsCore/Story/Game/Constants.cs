namespace SekaiToolsCore.Story.Game;

public static class Constants
{
    public static readonly Dictionary<int, int> C2dIdToCid = new()
    {
        { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 }, { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 }, { 9, 9 }, { 10, 10 },
        { 11, 11 }, { 12, 12 }, { 13, 13 }, { 14, 14 }, { 15, 15 }, { 16, 16 }, { 17, 17 }, { 18, 18 }, { 19, 19 },
        { 20, 20 }, { 21, 21 }, { 22, 21 }, { 23, 21 }, { 24, 21 }, { 25, 21 }, { 26, 21 }, { 27, 22 }, { 28, 23 },
        { 29, 24 }, { 30, 25 }, { 31, 26 }, { 32, 1 }, { 33, 2 }, { 34, 3 }, { 35, 4 }, { 36, 5 }, { 37, 6 }, { 38, 7 },
        { 39, 8 }, { 40, 9 }, { 41, 10 }, { 42, 11 }, { 43, 12 }, { 44, 13 }, { 45, 14 }, { 46, 15 }, { 47, 16 },
        { 48, 17 }, { 49, 18 }, { 50, 19 }, { 51, 20 }, { 52, 21 }, { 53, 22 }, { 54, 23 }, { 55, 24 }, { 57, 26 },
        { 58, 27 }, { 59, 28 }, { 60, 29 }, { 61, 30 }, { 62, 31 }, { 63, 32 }, { 64, 33 }, { 65, 34 }, { 66, 35 },
        { 67, 36 }, { 68, 37 }, { 69, 38 }, { 70, 39 }, { 71, 40 }, { 72, 41 }, { 73, 42 }, { 74, 43 }, { 75, 44 },
        { 76, 45 }, { 77, 46 }, { 78, 47 }, { 79, 48 }, { 80, 49 }, { 81, 50 }, { 82, 51 }, { 83, 52 }, { 84, 53 },
        { 85, 54 }, { 86, 55 }, { 87, 56 }, { 88, 57 }, { 89, 58 }, { 90, 59 }, { 91, 60 }, { 92, 61 }, { 93, 62 },
        { 94, 63 }, { 95, 64 }, { 96, 65 }, { 97, 66 }, { 98, 67 }, { 99, 68 }, { 100, 69 }, { 101, 70 }, { 102, 71 },
        { 103, 72 }, { 104, 73 }, { 105, 74 }, { 106, 75 }, { 107, 22 }, { 108, 23 }, { 109, 76 }, { 110, 77 },
        { 111, 78 }, { 112, 79 }, { 113, 7 }, { 114, 25 }, { 115, 15 }, { 116, 80 }, { 117, 13 }, { 118, 25 },
        { 119, 24 }, { 120, 22 }, { 121, 22 }, { 122, 81 }, { 123, 82 }, { 124, 83 }, { 125, 84 }, { 126, 13 },
        { 127, 2 }, { 128, 24 }, { 129, 85 }, { 130, 25 }, { 131, 86 }, { 132, 87 }, { 133, 26 }, { 134, 25 },
        { 135, 88 }, { 136, 89 }, { 137, 17 }, { 138, 24 }, { 139, 22 }, { 140, 90 }, { 141, 11 }, { 142, 91 },
        { 143, 23 }, { 144, 4 }, { 145, 8 }, { 146, 18 }, { 147, 26 }, { 148, 16 }, { 149, 23 }, { 150, 22 },
        { 151, 23 }, { 152, 24 }, { 153, 24 }, { 154, 25 }, { 155, 26 }, { 156, 21 }, { 157, 26 }, { 158, 92 },
        { 159, 93 }, { 160, 25 }, { 161, 22 }, { 162, 23 }, { 163, 23 }, { 164, 24 }, { 165, 22 }, { 166, 23 },
        { 167, 24 }, { 168, 25 }, { 169, 26 }, { 170, 94 }, { 171, 95 }, { 172, 1 }, { 173, 2 }, { 174, 3 }, { 175, 4 },
        { 176, 21 }, { 177, 22 }, { 178, 23 }, { 179, 24 }, { 180, 25 }, { 181, 26 }, { 182, 5 }, { 183, 5 },
        { 184, 6 }, { 185, 6 }, { 186, 7 }, { 187, 7 }, { 188, 8 }, { 189, 8 }, { 190, 21 }, { 191, 21 }, { 192, 22 },
        { 193, 22 }, { 194, 23 }, { 195, 23 }, { 196, 24 }, { 197, 24 }, { 198, 25 }, { 199, 25 }, { 200, 26 },
        { 201, 26 }, { 202, 17 }, { 203, 18 }, { 204, 19 }, { 205, 20 }, { 206, 21 }, { 207, 22 }, { 208, 24 },
        { 209, 25 }, { 210, 96 }, { 211, 97 }, { 212, 98 }, { 213, 99 }, { 214, 100 }, { 215, 101 }, { 216, 102 },
        { 217, 103 }, { 218, 104 }, { 219, 22 }, { 220, 22 }, { 221, 22 }, { 222, 22 }, { 223, 22 }, { 224, 23 },
        { 225, 23 }, { 226, 23 }, { 227, 23 }, { 228, 24 }, { 229, 24 }, { 230, 24 }, { 231, 24 }, { 232, 24 },
        { 233, 25 }, { 234, 25 }, { 235, 25 }, { 236, 25 }, { 237, 25 }, { 238, 26 }, { 239, 26 }, { 240, 26 },
        { 241, 26 }, { 248, 105 }, { 249, 106 }, { 250, 107 }, { 251, 108 }, { 252, 23 }, { 253, 10 }, { 254, 109 },
        { 255, 110 }, { 256, 111 }, { 257, 6 }, { 258, 80 }, { 259, 113 }, { 260, 114 }, { 261, 115 }, { 262, 26 },
        { 263, 116 }, { 264, 17 }, { 265, 21 }, { 266, 22 }, { 267, 23 }, { 268, 24 }, { 269, 25 }, { 270, 26 },
        { 271, 116 }, { 272, 118 }, { 273, 119 }, { 274, 120 }, { 275, 121 }, { 276, 122 }, { 277, 14 }, { 278, 1 },
        { 279, 2 }, { 280, 3 }, { 281, 4 }, { 282, 5 }, { 283, 6 }, { 284, 7 }, { 285, 8 }, { 286, 9 }, { 287, 10 },
        { 288, 11 }, { 289, 12 }, { 290, 13 }, { 291, 14 }, { 292, 15 }, { 293, 16 }, { 294, 17 }, { 295, 18 },
        { 296, 19 }, { 297, 20 }, { 298, 21 }, { 299, 21 }, { 300, 21 }, { 301, 21 }, { 302, 21 }, { 303, 21 },
        { 304, 22 }, { 305, 22 }, { 306, 22 }, { 307, 22 }, { 308, 22 }, { 309, 22 }, { 310, 23 }, { 311, 23 },
        { 312, 23 }, { 313, 23 }, { 314, 23 }, { 315, 23 }, { 316, 24 }, { 317, 24 }, { 318, 24 }, { 319, 24 },
        { 320, 24 }, { 321, 24 }, { 322, 25 }, { 323, 25 }, { 324, 25 }, { 325, 25 }, { 326, 25 }, { 327, 25 },
        { 328, 26 }, { 329, 26 }, { 330, 26 }, { 331, 26 }, { 332, 26 }, { 333, 26 }, { 334, 26 }, { 335, 27 },
        { 336, 30 }, { 337, 31 }, { 338, 74 }, { 339, 75 }, { 340, 4 }, { 341, 123 }, { 342, 124 }, { 343, 125 },
        { 344, 20 }, { 345, 126 }, { 346, 127 }, { 347, 128 }, { 348, 11 }, { 349, 129 }, { 900, 1 }, { 901, 2 },
        { 902, 3 }, { 903, 4 }, { 904, 5 }, { 905, 6 }, { 906, 1 }, { 907, 4 }, { 908, 5 }, { 909, 6 },
        { 900000, 900000 }
    };

    public static readonly Dictionary<int, string> CharacterIdToName = new()
    {
        { 1, "一歌" }, { 2, "咲希" }, { 3, "穗波" }, { 4, "志步" },
        { 5, "实乃理" }, { 6, "遥" }, { 7, "爱莉" }, { 8, "雫" },
        { 9, "心羽" }, { 10, "杏" }, { 11, "彰人" }, { 12, "冬弥" },
        { 13, "司" }, { 14, "笑梦" }, { 15, "宁宁" }, { 16, "类" },
        { 17, "奏" }, { 18, "真冬" }, { 19, "绘名" }, { 20, "瑞希" },
        { 21, "MIKU" }, { 22, "RIN" }, { 23, "LEN" }, { 24, "LUKA" }, { 25, "MEIKO" }, { 26, "KAITO" },
        { 27, "MIKU_LN" }, { 28, "MIKU_MMJ" }, { 29, "MIKU_VBS" }, { 30, "MIKU_WS" }, { 31, "MIKU_25" }
    };

    public static readonly Dictionary<string, int> DisNameToId = new();
}