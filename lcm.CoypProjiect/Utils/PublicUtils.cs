using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcm.CoypProjiect.Utils {
    internal class PublicUtils {
        /// <summary>
        /// 获取当前时间
        /// </summary>
        /// <returns></returns>
        public static String GetTime() {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static String GetFileName(string pro,string body,string suf,string sitre) {
            if(!(pro == null || pro.Length <= 0)) {
                pro += " ";
            }
            if(!(suf == null || suf.Length <= 0)) {
                body += " ";
            }
            return pro + body + suf + "." + sitre;
           
        }

        public static String GetFileName(string pro, string body,  string sitre) {
          return GetFileName(pro, body, "", sitre); 
        }

        //public static String GetFileName( string body, string suf, string sitre) {
        //    return body + " " + suf + "." + sitre;
        //}

        /// <summary>
        /// 拼接文件名
        /// </summary>
        /// <param name="nameSuf"></param>
        /// <returns></returns>
        public static String GetFileName(string[] nameSuf) {
            string suf = "";
            foreach (string item in nameSuf) {
                //第一次不加空格
                if (suf.Length <= 0)
                    suf += item;
                else
                    suf += " "+item;
            }
            return suf;
        }

        /// <summary>
        /// 拼接文件名
        /// </summary>
        /// <param name="nameSuf"></param>
        /// <param name="sitre"></param>
        /// <returns></returns>
        public static String GetFileNameSuf(string[] nameSuf) {
            string suf = GetFileName(nameSuf);
            int index = suf.LastIndexOf(".");
            if(index == -1) {
                return suf;
            } else {
                return suf.Substring(0, index); 
            }
        }
    }
}
