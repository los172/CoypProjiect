using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcm.CoypProjiect.Constant {
    internal class PublicConstant {

        //public readonly String[] sitre = new string[] { "1350", "PCBI", "C", "OQC","C NEP","OQC NEP", "TS", 
        //"1450", "1380", "1805", "1820", "1850", "3100", "3300", "3800","GX","-GX" };
        public const String DP = "DP";
        public const String NP = "NP";
        public const String IVO = "IVO";
        public const String NO = "无";
        public const String BMP = ".bmp";
        public const char SPACE = ' ';

       public readonly String[] sitre = new string[] { };
       public readonly String[] pre = new string[] { "IVO", "无", "DP IVO", "NP IVO" };
       public readonly String[] proName = new string[] { "Program", "Power", "Pattern", "Timing"};
       public readonly String[] folderPath= new string[] { "LVDS", "EDP", "GX","AOI" };


        public readonly Dictionary<string, string> pro27014;
        public readonly Dictionary<string, string> proPath;
        public PublicConstant() {
            pro27014 = new Dictionary<string, string> {
                {proName[0],"27g" },
                {proName[1],"27w" },
                {proName[2],"27t" },
                {proName[3],"27m"}
            };
            proPath = new Dictionary<string, string> {
                {folderPath[0],"Chroma27014" },
                {folderPath[1],"Chroma27014EDP" },
                {folderPath[2],"27014GX" },
                {folderPath[3],"AOI" }
            };
        }
    }
}
