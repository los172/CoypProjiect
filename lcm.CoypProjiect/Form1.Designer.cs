namespace lcm.CoypProjiect {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bodyName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Allbutton = new System.Windows.Forms.Button();
            this.AllproCheck = new System.Windows.Forms.CheckedListBox();
            this.AllcheckBox = new System.Windows.Forms.CheckBox();
            this.preBox = new System.Windows.Forms.ComboBox();
            this.sufBox = new System.Windows.Forms.ComboBox();
            this.ButCopy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.singleCheckBox = new System.Windows.Forms.CheckBox();
            this.allPro = new System.Windows.Forms.Button();
            this.proCheck = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeFolderBox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.imageFlag = new System.Windows.Forms.CheckBox();
            this.imageName = new System.Windows.Forms.ComboBox();
            this.impImageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TPcheckBox = new System.Windows.Forms.CheckBox();
            this.TPName = new System.Windows.Forms.ComboBox();
            this.TPbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.imageGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bodyName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.preBox);
            this.groupBox1.Controls.Add(this.sufBox);
            this.groupBox1.Controls.Add(this.ButCopy);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.typeFolderBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "27014";
            // 
            // bodyName
            // 
            this.bodyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bodyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bodyName.FormattingEnabled = true;
            this.bodyName.Location = new System.Drawing.Point(112, 14);
            this.bodyName.Name = "bodyName";
            this.bodyName.Size = new System.Drawing.Size(127, 23);
            this.bodyName.TabIndex = 12;
            this.bodyName.SelectedIndexChanged += new System.EventHandler(this.bodyName_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Allbutton);
            this.groupBox2.Controls.Add(this.AllproCheck);
            this.groupBox2.Controls.Add(this.AllcheckBox);
            this.groupBox2.Location = new System.Drawing.Point(245, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 119);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Allbutton
            // 
            this.Allbutton.Location = new System.Drawing.Point(49, 90);
            this.Allbutton.Name = "Allbutton";
            this.Allbutton.Size = new System.Drawing.Size(45, 23);
            this.Allbutton.TabIndex = 13;
            this.Allbutton.Text = "全选";
            this.Allbutton.UseVisualStyleBackColor = true;
            this.Allbutton.Click += new System.EventHandler(this.Allbutton_Click);
            // 
            // AllproCheck
            // 
            this.AllproCheck.CheckOnClick = true;
            this.AllproCheck.FormattingEnabled = true;
            this.AllproCheck.Location = new System.Drawing.Point(3, 20);
            this.AllproCheck.Name = "AllproCheck";
            this.AllproCheck.Size = new System.Drawing.Size(85, 68);
            this.AllproCheck.TabIndex = 12;
            // 
            // AllcheckBox
            // 
            this.AllcheckBox.AutoSize = true;
            this.AllcheckBox.Location = new System.Drawing.Point(6, 0);
            this.AllcheckBox.Name = "AllcheckBox";
            this.AllcheckBox.Size = new System.Drawing.Size(71, 19);
            this.AllcheckBox.TabIndex = 11;
            this.AllcheckBox.Text = "ALL程式";
            this.AllcheckBox.UseVisualStyleBackColor = true;
            this.AllcheckBox.CheckedChanged += new System.EventHandler(this.AllcheckBox_CheckedChanged);
            // 
            // preBox
            // 
            this.preBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.preBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.preBox.FormattingEnabled = true;
            this.preBox.Location = new System.Drawing.Point(43, 14);
            this.preBox.Name = "preBox";
            this.preBox.Size = new System.Drawing.Size(63, 23);
            this.preBox.TabIndex = 10;
            this.preBox.SelectedIndexChanged += new System.EventHandler(this.preBox_SelectedIndexChanged);
            // 
            // sufBox
            // 
            this.sufBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sufBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sufBox.FormattingEnabled = true;
            this.sufBox.Location = new System.Drawing.Point(245, 14);
            this.sufBox.Name = "sufBox";
            this.sufBox.Size = new System.Drawing.Size(95, 23);
            this.sufBox.TabIndex = 9;
            // 
            // ButCopy
            // 
            this.ButCopy.Location = new System.Drawing.Point(10, 165);
            this.ButCopy.Name = "ButCopy";
            this.ButCopy.Size = new System.Drawing.Size(330, 23);
            this.ButCopy.TabIndex = 7;
            this.ButCopy.Text = "导入";
            this.ButCopy.UseVisualStyleBackColor = true;
            this.ButCopy.Click += new System.EventHandler(this.ButCopy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.singleCheckBox);
            this.groupBox3.Controls.Add(this.allPro);
            this.groupBox3.Controls.Add(this.proCheck);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(136, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 119);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // singleCheckBox
            // 
            this.singleCheckBox.AutoSize = true;
            this.singleCheckBox.Location = new System.Drawing.Point(6, 0);
            this.singleCheckBox.Name = "singleCheckBox";
            this.singleCheckBox.Size = new System.Drawing.Size(50, 19);
            this.singleCheckBox.TabIndex = 12;
            this.singleCheckBox.Text = "程式";
            this.singleCheckBox.UseVisualStyleBackColor = true;
            this.singleCheckBox.CheckedChanged += new System.EventHandler(this.singleCheckBox_CheckedChanged);
            // 
            // allPro
            // 
            this.allPro.Location = new System.Drawing.Point(52, 90);
            this.allPro.Name = "allPro";
            this.allPro.Size = new System.Drawing.Size(45, 23);
            this.allPro.TabIndex = 7;
            this.allPro.Text = "全选";
            this.allPro.UseVisualStyleBackColor = true;
            this.allPro.Click += new System.EventHandler(this.allPro_Click);
            // 
            // proCheck
            // 
            this.proCheck.CheckOnClick = true;
            this.proCheck.FormattingEnabled = true;
            this.proCheck.Location = new System.Drawing.Point(6, 20);
            this.proCheck.Name = "proCheck";
            this.proCheck.Size = new System.Drawing.Size(91, 68);
            this.proCheck.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称";
            // 
            // typeFolderBox
            // 
            this.typeFolderBox.Location = new System.Drawing.Point(9, 40);
            this.typeFolderBox.Name = "typeFolderBox";
            this.typeFolderBox.Size = new System.Drawing.Size(121, 119);
            this.typeFolderBox.TabIndex = 1;
            this.typeFolderBox.TabStop = false;
            this.typeFolderBox.Text = "类型";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.logBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 99);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "日志";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(6, 20);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(333, 73);
            this.logBox.TabIndex = 3;
            this.logBox.Text = "";
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.imageFlag);
            this.imageGroupBox.Controls.Add(this.imageName);
            this.imageGroupBox.Controls.Add(this.impImageButton);
            this.imageGroupBox.Controls.Add(this.label2);
            this.imageGroupBox.Location = new System.Drawing.Point(12, 194);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(346, 77);
            this.imageGroupBox.TabIndex = 2;
            this.imageGroupBox.TabStop = false;
            // 
            // imageFlag
            // 
            this.imageFlag.AutoSize = true;
            this.imageFlag.Location = new System.Drawing.Point(9, 1);
            this.imageFlag.Name = "imageFlag";
            this.imageFlag.Size = new System.Drawing.Size(54, 16);
            this.imageFlag.TabIndex = 4;
            this.imageFlag.Text = "image";
            this.imageFlag.UseVisualStyleBackColor = true;
            this.imageFlag.CheckedChanged += new System.EventHandler(this.imageFlag_CheckedChanged);
            // 
            // imageName
            // 
            this.imageName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.imageName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.imageName.FormattingEnabled = true;
            this.imageName.Location = new System.Drawing.Point(43, 20);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(297, 20);
            this.imageName.TabIndex = 13;
            // 
            // impImageButton
            // 
            this.impImageButton.Location = new System.Drawing.Point(222, 46);
            this.impImageButton.Name = "impImageButton";
            this.impImageButton.Size = new System.Drawing.Size(117, 23);
            this.impImageButton.TabIndex = 9;
            this.impImageButton.Text = "导入图片";
            this.impImageButton.UseVisualStyleBackColor = true;
            this.impImageButton.Click += new System.EventHandler(this.impImageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "编号";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TPcheckBox);
            this.groupBox4.Controls.Add(this.TPName);
            this.groupBox4.Controls.Add(this.TPbutton);
            this.groupBox4.Location = new System.Drawing.Point(12, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 80);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // TPcheckBox
            // 
            this.TPcheckBox.AutoSize = true;
            this.TPcheckBox.Location = new System.Drawing.Point(9, 1);
            this.TPcheckBox.Name = "TPcheckBox";
            this.TPcheckBox.Size = new System.Drawing.Size(36, 16);
            this.TPcheckBox.TabIndex = 4;
            this.TPcheckBox.Text = "TP";
            this.TPcheckBox.UseVisualStyleBackColor = true;
            this.TPcheckBox.CheckedChanged += new System.EventHandler(this.TPcheckBox_CheckedChanged);
            // 
            // TPName
            // 
            this.TPName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TPName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TPName.FormattingEnabled = true;
            this.TPName.Location = new System.Drawing.Point(9, 20);
            this.TPName.Name = "TPName";
            this.TPName.Size = new System.Drawing.Size(331, 20);
            this.TPName.TabIndex = 13;
            // 
            // TPbutton
            // 
            this.TPbutton.Location = new System.Drawing.Point(222, 46);
            this.TPbutton.Name = "TPbutton";
            this.TPbutton.Size = new System.Drawing.Size(117, 23);
            this.TPbutton.TabIndex = 9;
            this.TPbutton.Text = "导入TP";
            this.TPbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 460);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.imageGroupBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "27014程式导入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.imageGroupBox.ResumeLayout(false);
            this.imageGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox typeFolderBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButCopy;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox sufBox;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button impImageButton;
        private System.Windows.Forms.CheckedListBox proCheck;
        private System.Windows.Forms.Button allPro;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ComboBox preBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox bodyName;
        private System.Windows.Forms.ComboBox imageName;
        private System.Windows.Forms.CheckBox imageFlag;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox TPcheckBox;
        private System.Windows.Forms.ComboBox TPName;
        private System.Windows.Forms.Button TPbutton;
        private System.Windows.Forms.CheckBox AllcheckBox;
        private System.Windows.Forms.Button Allbutton;
        private System.Windows.Forms.CheckedListBox AllproCheck;
        private System.Windows.Forms.CheckBox singleCheckBox;
    }
}

