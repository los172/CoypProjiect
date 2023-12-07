using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace lcm.CoypProjiect.Config {
    public static class FormInit {
        //声明默认配置文件路径
        public static string INIPath = Convert.ToString(System.AppDomain.CurrentDomain.BaseDirectory) + "Config.ini";
        public static String IP = "10.10.2.92";
        public static String User = "lcmtest";
        public static String Password = "lcmtest";
        public static String ServerPath = "";
        public static String LocalPath = "C:\\Program Files\\chroma\\FPD Tester 27014";
        public static String ServerTp = "TP_TEST";
        public static String LocalTp = "C:\\";
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sitreBox">站点列表</param>
        //public static void Init() {
        //    //读取config
        //    Init();
        //}

        /// <summary>
        /// 读取配置
        /// </summary>
        public static String Init() {
            ReadConfig readConfig =  new ReadConfig();
            IP = readConfig.INIRead("path", "ftpUrl",  INIPath)=="" ? IP : readConfig.INIRead("path", "ftpUrl", INIPath);
            User = readConfig.INIRead("path", "user", INIPath)=="" ? User : readConfig.INIRead("path", "user", INIPath);
            Password = readConfig.INIRead("path", "password", INIPath)=="" ? Password : readConfig.INIRead("path", "password", INIPath);
            //获取的配置文件为null时，不变
            ServerPath = readConfig.INIRead("path", "serverPath", INIPath) == "" ? ServerPath : readConfig.INIRead("path", "serverPath", INIPath);
            LocalPath = readConfig.INIRead("path", "localPath", INIPath) == "" ? LocalPath : readConfig.INIRead("path", "localPath", INIPath);
            ServerTp = readConfig.INIRead("path", "serverTp", INIPath) == "" ? ServerTp : readConfig.INIRead("path", "serverTp", INIPath);
            LocalTp = readConfig.INIRead("path", "localTp", INIPath) == "" ? LocalTp : readConfig.INIRead("path", "localTp", INIPath);
            return null;
        }


        /// <summary>
        /// 站点列表,后缀
        /// </summary>
        /// <param name="box"></param>
        //private static void SitreBoxInit(System.Windows.Forms.ComboBox box) {
        //    box.DataSource = sitre;
        //}
        //private static void NamePreInit(System.Windows.Forms.ComboBox box) {
        //    box.DataSource = pre;
        //}
    }
}
