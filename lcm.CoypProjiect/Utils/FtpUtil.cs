using FluentFTP;
using FluentFTP.Helpers;
using lcm.CoypProjiect.Config;
using lcm.CoypProjiect.Constant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lcm.CoypProjiect.Utils {
    internal class FtpUtil {
        //private static  Task<FtpClient>  client1 = null;
        /// <summary>
        /// 创建连接
        /// </summary>
        /// <returns></returns>
        private  FtpClient GetIp(string host,string port,string userName, string passWord) {

            //Task<FtpClient> task =  Task.Run(() => {
            //    FtpClient client = new FtpClient($"ftp://{host}:{port}", userName, passWord) {
            //        EncryptionMode = FtpEncryptionMode.None,
            //        DataConnectionType = FtpDataConnectionType.PASV,
            //        Encoding = Encoding.UTF8,
            //    };
            //    return client;
            //});
            FtpClient client = new FtpClient($"ftp://{host}", userName, passWord) {
                EncryptionMode = FtpEncryptionMode.None,
                DataConnectionType = FtpDataConnectionType.PASV,
                Encoding = Encoding.UTF8,
            };

            return client;
        }
        //获取文件夹下的所有文件的名称
        public  void getFileNameList(string remotePath, Dictionary<string, SortedSet<string>> fileNamesBodyInit, Dictionary<string, SortedSet<string>> fileNamesSufInit) {
            List<string> fileNameList = new List<string>();
            try {
            using (var client =  GetIp(FormInit.IP, "21", FormInit.User, FormInit.Password)) {
                client.Connect();
                FtpListItem[] files = client.GetListing(remotePath);
                    
                    foreach (FtpListItem file in files) {
                    //判断是否是文件
                    if(file.Type == FtpObjectType.File) {
                        //添加文件名
                        fileNameList.Add(file.Name);
                        string[] splitName = splitFileName(file.Name, fileNamesBodyInit, fileNamesSufInit);
                    }
                }

            }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


        //获取image的名称
        public  void getImageList(string remotePath, SortedSet<string> imageSet) {
            try {
                using (var client = GetIp(FormInit.IP, "21", FormInit.User, FormInit.Password)) {
                    client.Connect();
                    FtpListItem[] files = client.GetListing(remotePath);
                    foreach (FtpListItem file in files) {
                        //判断是否是文件
                        if (file.Type == FtpObjectType.File && Path.GetExtension(file.Name) == PublicConstant.BMP) {
                            //添加文件名
                            imageSet.Add(Path.GetFileNameWithoutExtension(file.Name));
                        }
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        //获取文件夹下的所有文件夹的名称
        public  void getFolderNameList(string remotePath, SortedSet<string> folderNameSet) {
            try {
                using (var client = GetIp(FormInit.IP, "21", FormInit.User, FormInit.Password)) {
                    client.Connect();
                    FtpListItem[] files = client.GetListing(remotePath);
                    foreach (FtpListItem file in files) {
                        //判断是否是文件夹
                        if (file.Type == FtpObjectType.Directory) {
                            //添加文件名
                            folderNameSet.Add(file.Name);
                        }
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


        private async Task<bool> UploadFile() {
            //上传文件
            try {
                if(File.Exists("D:/Chorma27014/LOG/2023-11-28.txt")) {
                    MessageBox.Show("文件存在");
                } else {
                    MessageBox.Show("文件不存在");
                    return false;
                }


                using (var client =  GetIp("10.20.35.114", "21", "root", "my@ftp2023")) {
                    await client.ConnectAsync();
                    await client.UploadFileAsync("D:/Chorma27014/LOG/2023-11-28.txt", "/copy27014/2023-11-28.txt");
                    return true;
                }
            } catch (Exception ex) {
                if(ex.InnerException != null) {
                    MessageBox.Show(ex.InnerException.Message);
                } else {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }
        /// <summary>
        /// 下载单个文件
        /// </summary>
        /// <param name="host">ip</param>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <param name="localPath">本地路径</param>
        /// <param name="remotePath">服务器路径</param>
        /// <returns></returns>
        public async Task<bool> DownloadFile(string localPath, Dictionary<string, string> fileTypeNames, string folderPath,RichTextBox logBox) {
            try {
                using (var client =  GetIp(FormInit.IP, "21",FormInit.User, FormInit.Password)) {

                    await client.ConnectAsync();
                    foreach (KeyValuePair<string, string> item in fileTypeNames) {
                        string remotePath = folderPath +"/"+ item.Key+"/" + item.Value;
                        string path = localPath + "/" + item.Key + "/" + item.Value;
                        logBox.AppendText(PublicUtils.GetTime() + " " + item.Value);
                        //判断文件是否存在
                        if (!client.FileExists(remotePath)) {
                            logBox.AppendText(" 文件不存在\n");
                            MessageBox.Show(item.Value + "文件不存在");
                            
                            return false;
                        }
                        await client.DownloadFileAsync(path, remotePath);
                        logBox.AppendText( " 下载成功\n");
                    }

                    
                    return true;
                }
            } catch (Exception ex) {
                logBox.AppendText(ex.Message+"\n");
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 下载整个文件夹
        /// </summary>
        /// <param name="host"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <param name="localPath"></param>
        /// <param name="remotePath"></param>
        /// <returns></returns>
        public async Task<bool> DownloadFiles(string host, string userName, string passWord, string localPath, string remotePath) {
            try {
                using (var client =  GetIp(host, "21", userName, passWord)) {

                    await client.ConnectAsync();
                    //判断文件夹是否存在
                    if (!client.DirectoryExists(remotePath)) {
                        MessageBox.Show("文件夹不存在");
                        return false;
                    }
                    //获取文件夹下的所有文件
                    var files = client.GetListing(remotePath);
                    foreach (var file in files) {
                        //判断是否是文件夹

                        if (file.Type == FtpObjectType.Directory) {
                            //创建本地文件夹
                            System.IO.Directory.CreateDirectory(localPath + "\\" + file.Name);
                            //递归调用
                            await DownloadFiles(host, userName, passWord, localPath + "\\" + file.Name, remotePath + "/" + file.Name);
                           
                        } else {
                            //下载文件
                            await client.DownloadFileAsync(localPath + "\\" + file.Name, remotePath + "/" + file.Name);
                        }
                    }
                    return true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private string[] splitFileName(string fileName, Dictionary<string, SortedSet<string>> fileNamesBodyInit , Dictionary<string, SortedSet<string>> fileNamesSufInit) {
            //0:前缀 1:项目名称 2:后缀
            string[] resName = new string[3];
             fileName = Path.GetFileNameWithoutExtension(fileName).Trim();
            string[] str = fileName.Split(PublicConstant.SPACE);
         


            if (str.Length > 1) {
                switch (str[0]) {
                   
                    case PublicConstant.IVO:
                        //前缀是IVO
                        //前缀和项目名称
                        {
                            string key = str[0];
                            string name = SetVal(fileNamesBodyInit, str, key, 1, 2);
                            //后缀
                            if (str.Length >= 3) {
                                _ = SetVal(fileNamesSufInit, str, key + name, 3, -1);
                            } else {
                                _ = SetVal(fileNamesSufInit, str, key + name, -1, -1);
                            }
                        }


                        break;
                    case PublicConstant.DP: 
                        {
                            if (PublicConstant.IVO.Equals(str[1])) {//前缀是DP IVO
                                string key = PublicUtils.GetFileName(str.Skip(0).Take(2).ToArray());
                                string name = SetVal(fileNamesBodyInit, str, key, 2, 2);
                                if (str.Length >= 4) {
                                    _ = SetVal(fileNamesSufInit, str, key+name, 4, -1);
                                } else {
                                    _ = SetVal(fileNamesSufInit, str, key + name, -1, -1);
                                }
                            } else {//前缀是DP
                                string key = str[0];
                                string name = SetVal(fileNamesBodyInit, str, key, 1, 2);
                                if (str.Length >= 3) {
                                    _ = SetVal(fileNamesSufInit, str, key + name, 3, -1);
                                } else {
                                    _ = SetVal(fileNamesSufInit, str, key + name, -1, -1);
                                }
                            }
                        }
 
                        break;
                    case PublicConstant.NP: 
                        {
                            if (PublicConstant.IVO.Equals(str[1])) {//前缀是NP IVO
                                string key = PublicUtils.GetFileName(str.Skip(0).Take(2).ToArray());
                                string name = SetVal(fileNamesBodyInit, str, PublicUtils.GetFileName(str.Skip(0).Take(2).ToArray()), 2, 2);
                                if (str.Length >= 4) {
                                    _ = SetVal(fileNamesSufInit, str, key + name, 4, -1);
                                } else {
                                    _ = SetVal(fileNamesSufInit, str, key + name, -1, -1);
                                }
                            } else {//前缀是NP
                                string key = str[0];
                                string name = SetVal(fileNamesBodyInit, str, key, 1, 2);
                                if (str.Length >= 3) {
                                    _ = SetVal(fileNamesSufInit, str, key + name, 3, -1);
                                } else {
                                    _ = SetVal(fileNamesSufInit, str, key + name, -1, -1);
                                }
                            }

                        }
  
                        break;
                    default: 
                        {                        //前缀和项目名称
                            string key =PublicConstant.NO;
                            string name = SetVal(fileNamesBodyInit, str, key, 0, 2);
                            if (str.Length >= 3) {
                                _ = SetVal(fileNamesSufInit, str, key + name, 2, -1);
                            } else {
                                _ = SetVal(fileNamesSufInit, str, key + name, -1, -1);
                            }
                        }



                        break;
                }
            }
            return resName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileInit">文件名称map</param>
        /// <param name="str">分割后的文件名称</param>
        /// <param name="key">前缀</param>
        /// <param name="start">文件分割的开始</param>
        /// <param name="end">文件分割的结束,-1为截取到最后</param>
        private string SetVal(Dictionary<string, SortedSet<string>> fileInit,string[] str, string key,int start,int end) {
            string name = "";
            if(end == -1) { //取到最后
                end = str.Length;
            }
            if(start == -1) {
                name = "无";
            } else {
                name = PublicUtils.GetFileNameSuf(str.Skip(start).Take(end).ToArray());
            }
            if (fileInit.ContainsKey(key)) {//存在
                SortedSet<string> bodyName = fileInit[key];
                bodyName.Add(name);
            } else {//不存在
                SortedSet<string> bodyName = new SortedSet<string>();
                bodyName.Add(name);
                fileInit.Add(key, bodyName);
            }
            return name;
        }
      

    }
}
