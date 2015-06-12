﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KalkStats
{
    public class StatBuilder
    {
        public static int build(int level, bool trans)
        {
            if (level < 1 || level > 99)
            {
                return 0;
            }
            int stats=0;
            
            switch (level)
            {
                case 1: stats = 48;
                    break;
                case 2: stats = 51;
                    break;
                case 3: stats = 54;
                    break;
                case 4: stats = 57;
                    break;
                case 5: stats = 60;
                    break;
                case 6: stats = 64;
                    break;
                case 7: stats = 68;
                    break;
                case 8: stats = 72;
                    break;
                case 9: stats = 76;
                    break;
                case 10: stats = 80;
                    break;
                case 11: stats = 85;
                    break;
                case 12: stats = 90;
                    break;
                case 13: stats = 95;
                    break;
                case 14: stats = 100;
                    break;
                case 15: stats = 105;
                    break;
                case 16: stats = 111;
                    break;
                case 17: stats = 117;
                    break;
                case 18: stats = 123;
                    break;
                case 19: stats = 129;
                    break;
                case 20: stats = 135;
                    break;
                case 21: stats = 142;
                    break;
                case 22: stats = 149;
                    break;
                case 23: stats = 156;
                    break;
                case 24: stats = 163;
                    break;
                case 25: stats = 170;
                    break;
                case 26: stats = 178;
                    break;
                case 27: stats = 186;
                    break;
                case 28: stats = 194;
                    break;
                case 29: stats = 202;
                    break;
                case 30: stats = 210;
                    break;
                case 31: stats = 219;
                    break;
                case 32: stats = 228;
                    break;
                case 33: stats = 237;
                    break;
                case 34: stats = 246;
                    break;
                case 35: stats = 255;
                    break;
                case 36: stats = 265;
                    break;
                case 37: stats = 275;
                    break;
                case 38: stats = 285;
                    break;
                case 39: stats = 295;
                    break;
                case 40: stats = 305;
                    break;
                case 41: stats = 316;
                    break;
                case 42: stats = 327;
                    break;
                case 43: stats = 338;
                    break;
                case 44: stats = 349;
                    break;
                case 45: stats = 360;
                    break;
                case 46: stats = 372;
                    break;
                case 47: stats = 384;
                    break;
                case 48: stats = 396;
                    break;
                case 49: stats = 408;
                    break;
                case 50: stats = 420;
                    break;
                case 51: stats = 433;
                    break;
                case 52: stats = 446;
                    break;
                case 53: stats = 459;
                    break;
                case 54: stats = 472;
                    break;
                case 55: stats = 485;
                    break;
                case 56: stats = 499;
                    break;
                case 57: stats = 513;
                    break;
                case 58: stats = 527;
                    break;
                case 59: stats = 541;
                    break;
                case 60: stats = 555;
                    break;
                case 61: stats = 570;
                    break;
                case 62: stats = 585;
                    break;
                case 63: stats = 600;
                    break;
                case 64: stats = 615;
                    break;
                case 65: stats = 630;
                    break;
                case 66: stats = 646;
                    break;
                case 67: stats = 662;
                    break;
                case 68: stats = 678;
                    break;
                case 69: stats = 694;
                    break;
                case 70: stats = 710;
                    break;
                case 71: stats = 727;
                    break;
                case 72: stats = 744;
                    break;
                case 73: stats = 761;
                    break;
                case 74: stats = 778;
                    break;
                case 75: stats = 795;
                    break;
                case 76: stats = 813;
                    break;
                case 77: stats = 831;
                    break;
                case 78: stats = 849;
                    break;
                case 79: stats = 867;
                    break;
                case 80: stats = 885;
                    break;
                case 81: stats = 904;
                    break;
                case 82: stats = 923;
                    break;
                case 83: stats = 942;
                    break;
                case 84: stats = 961;
                    break;
                case 85: stats = 980;
                    break;
                case 86: stats = 1000;
                    break;
                case 87: stats = 1020;
                    break;
                case 88: stats = 1040;
                    break;
                case 89: stats = 1060;
                    break;
                case 90: stats = 1080;
                    break;
                case 91: stats = 1101;
                    break;
                case 92: stats = 1122;
                    break;
                case 93: stats = 1143;
                    break;
                case 94: stats = 1164;
                    break;
                case 95: stats = 1185;
                    break;
                case 96: stats = 1207;
                    break;
                case 97: stats = 1229;
                    break;
                case 98: stats = 1251;
                    break;
                case 99: stats = 1273;
                    break;
                default: stats = 0;
                    break;
            }
            if (trans)
            {
                stats += 52;
            }
            return stats;
        }
    }
}
