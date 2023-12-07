using FluentFTP.Helpers;
using lcm.CoypProjiect.Config;
using lcm.CoypProjiect.Constant;
using lcm.CoypProjiect.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lcm.CoypProjiect {
    public partial class Form1 : Form {

        PublicConstant publicConstant = new PublicConstant();
        //key:前缀；value：文件名
        Dictionary<string, SortedSet<string>> fileNamesBodyInit = new Dictionary<string, SortedSet<string>>();
        //key:文件名；value：后缀
        Dictionary<string, SortedSet<string>> fileNamesSufInit = new Dictionary<string, SortedSet<string>>();
        //图片名称路径列表
        SortedSet<string> imageSet = new SortedSet<string>();
        //TP文件夹路径列表
        SortedSet<string> tpSet = new SortedSet<string>();
        //单选按钮
        List<RadioButton> radioButtonList = new List<RadioButton>();
        //文件路径
        String folderPathDow = "";

        private void InitFrom() {
            FormInit.Init();
   

            //设置站点
            //sufBox.DataSource = publicConstant.sitre;
            ////设置前缀
            //preBox.DataSource = publicConstant.pre;
            //设置项目并全选
            proCheck.Items.AddRange(publicConstant.proName);
            for(int i = 0; i < proCheck.Items.Count; i++) {
                proCheck.SetItemChecked(i, true);
            }
            //添加All程式文件夹
            AllproCheck.Items.AddRange(publicConstant.proName);
            for (int i = 1; i < AllproCheck.Items.Count; i++) {
                AllproCheck.SetItemChecked(i, true);
            }

            //添加类型选项
            for (int i = 0; i < publicConstant.folderPath.Length; i++) {
                RadioButton radio =  new RadioButton();
                //if(i == 0) {
                //    radio.Checked = true;
                //}
                radio.Text = publicConstant.folderPath[i];
                radio.CheckedChanged += RadioButton1_CheckedChanged;
                radio.Location = new System.Drawing.Point(15, 20 + i * 20);
                radioButtonList.Add(radio);
                typeFolderBox.Controls.Add(radio);
                //folderPath.Items.Add(publicConstant.folderPath[i]);
            }

            //添加日志清除
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem clearmenuItem =  new ToolStripMenuItem("清除日志", null, new EventHandler(delegate (object sender, EventArgs e) {
                logBox.Clear();
            }));
            contextMenuStrip.Items.Add(clearmenuItem);
            logBox.ContextMenuStrip = contextMenuStrip;

            //添加图片导入不可选中
            setImageImpState(false);

            setAllProCheckState(false);

            setTpCheckState(false);

        }
        private void InitalData(string ftpPath) {
            try {
                ftpPath += "/Program";
                new FtpUtil().getFileNameList(ftpPath, fileNamesBodyInit, fileNamesSufInit);
                //设置前缀
                string[] preList = fileNamesBodyInit.Keys.ToArray();
                preBox.DataSource = preList;
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


        public Form1() {
            InitializeComponent();
            InitFrom();

            //读取config

            //设置站点



        }
        //设置单选按钮事件，选择不同的文件名称
        private void RadioButton1_CheckedChanged(object sender, EventArgs e) {
            RadioButton selectedReadioButton = sender as RadioButton;
            if(selectedReadioButton !=null && selectedReadioButton.Checked) {
                //清空数据
                fileNamesBodyInit.Clear();
                fileNamesSufInit.Clear();
                setImageImpState(false);
                folderPathDow = FormInit.ServerPath + publicConstant.proPath[selectedReadioButton.Text];
                InitalData(folderPathDow);
            }
        }

        private async void ButCopy_Click(object sender, EventArgs e) {
            //后缀
            int count = proCheck.CheckedItems.Count;
            if (count == 0) {
                MessageBox.Show("请选择项目");
                return;
            }

            //名称
            string name =  bodyName.Text;

            //站点
            string sitre = sufBox.Text;
            //if (sitre == null || sitre == "") {
            //    MessageBox.Show("站点不能为空");
            //    return;
            //}


       
            //前缀
            if (preBox.Text == null || preBox.Text == "") {
                MessageBox.Show("前缀不能为空");
                return;
            }
            string pre = preBox.Text == PublicConstant.NO ? "" : preBox.Text;

            //文件名
            Dictionary<string, string> fileTypeNames = new Dictionary<string, string>();
            try {


                for (int i = 0; i < count; i++) {
                    string type = proCheck.CheckedItems[i].ToString();
                    if (publicConstant.proName[0].Equals(type)){//program
                        fileTypeNames.Add(type, PublicUtils.GetFileName(pre, name, sitre, publicConstant.pro27014[type]));
                    } else {//其他
                        String preVal = pre.Split(PublicConstant.SPACE).Length > 1 ? pre.Split(PublicConstant.SPACE)[1] : pre;
                        fileTypeNames.Add(type, PublicUtils.GetFileName(preVal, name,  publicConstant.pro27014[type]));
                    }


                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            logBox.AppendText(PublicUtils.GetTime()+"本地路径"+FormInit.LocalPath+"\n");
            bool dowFlag =  await new FtpUtil().DownloadFile(FormInit.LocalPath, fileTypeNames, folderPathDow,logBox);
            if (dowFlag) {
                MessageBox.Show("下载完成");
            } 


        }





        private void allPro_Click(object sender, EventArgs e) {
            if (proCheck.CheckedItems.Count < 4) {//判断多项列表没有全选
                for (int i = 0; i < proCheck.Items.Count; i++) {
                    proCheck.SetItemChecked(i, true);
                }
            } else  {//全选了就全部取消
                for (int i = 0; i < proCheck.Items.Count; i++) {
                    proCheck.SetItemChecked(i, false);
                }
            }
        }

        //根据文件名的变化，改变后缀
        private void bodyName_SelectedIndexChanged(object sender, EventArgs e) {
            string pre = preBox.Text;
            string bodyVal = bodyName.Text;
            string[] strings = fileNamesSufInit[pre + bodyVal].ToArray();
            sufBox.DataSource = strings;
        }

        //根据前缀的变化，改变文件名的变化
        private void preBox_SelectedIndexChanged(object sender, EventArgs e) {
            string preVal = preBox.Text;
            string[] strings = fileNamesBodyInit[preVal].ToArray();
            bodyName.DataSource = strings;
        }

        private void logBox_TextChanged(object sender, EventArgs e) {
            logBox.SelectionStart = logBox.Text.Length; //Set the current caret position at the end
            logBox.ScrollToCaret(); //Now scroll it automatically
        }

        //导入图片
        private async void impImageButton_Click(object sender, EventArgs e) {
            string text = imageName.Text;
            if(text == null || text.Length <= 0) {
                MessageBox.Show("请选择图片");
                return;
            }
            //文件名
            Dictionary<string, string> fileTypeNames = new Dictionary<string, string>();
            fileTypeNames.Add("Image", text+PublicConstant.BMP);
            logBox.AppendText(PublicUtils.GetTime() + "本地路径" + FormInit.LocalPath + "\n");
            bool dowFlag = await new FtpUtil().DownloadFile(FormInit.LocalPath, fileTypeNames, folderPathDow, logBox);
            if (dowFlag) {
                MessageBox.Show("图片下载完成");
            }
        }

        private void imageFlag_CheckedChanged(object sender, EventArgs e) {
            if(imageFlag.Checked) {//选中时
                if(folderPathDow.Length <= 0) {
                    MessageBox.Show("先选中类型！");
                    imageFlag.Checked = false;
                    return;
                }
                imageSet.Clear();
                new FtpUtil().getImageList(FormInit.ServerPath + folderPathDow+"/Image", imageSet);
                setImageImpState(true);
            } else {
                
                imageSet.Clear();
                setImageImpState(false);
            }

        }
        private void AllcheckBox_CheckedChanged(object sender, EventArgs e) {
            if (AllcheckBox.Checked) {//选中时
                if (folderPathDow.Length <= 0) {
                    MessageBox.Show("先选中类型！");
                    AllcheckBox.Checked = false;
                    return;
                }

                setAllProCheckState(true);

            } else {

                setAllProCheckState(false);
            }
        }

        private void TPcheckBox_CheckedChanged(object sender, EventArgs e) {
            if (TPcheckBox.Checked) {
                tpSet.Clear();
                new FtpUtil().getFolderNameList(FormInit.ServerPath + FormInit.ServerTp, tpSet);
                logBox.AppendText(FormInit.ServerPath + FormInit.ServerTp + "\n");
                foreach (string item in tpSet) {
                    logBox.AppendText(item + "\n");
                }
                setTpCheckState(true);
            } else {
                setTpCheckState(false);
            }

        }


        private void setImageImpState(bool flag) {
            if (!flag) {
                imageSet.Clear();
                imageName.DataSource = null;
            } else {
                imageName.DataSource = imageSet.ToArray();
            }
            imageFlag.Checked = flag;
            imageName.Enabled = flag;
            impImageButton.Enabled = flag;



        }
        private void setAllProCheckState(bool flag) {
            //设置All程式文件夹
            AllproCheck.Enabled = flag;
            //设置All程式全选按钮
            Allbutton.Enabled = flag;
        }

        private void setTpCheckState(bool flag) {
            if(!flag) {
                tpSet.Clear();
                TPName.DataSource = null;
            } else {
                TPName.DataSource = tpSet.ToArray();
            }
            //设置All程式文件夹
            TPName.Enabled = flag;
            //设置All程式全选按钮
            TPbutton.Enabled = flag;
        }

    }
}
