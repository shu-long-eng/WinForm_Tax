
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BikeComboBox = new System.Windows.Forms.ComboBox();
            this.truckComboBox = new System.Windows.Forms.ComboBox();
            this.BigCar = new System.Windows.Forms.ComboBox();
            this.smCar = new System.Windows.Forms.ComboBox();
            this.BusinessCar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.DatePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(316, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全年度";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(395, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "依期間";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.Location = new System.Drawing.Point(24, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(378, 33);
            this.Title.TabIndex = 2;
            this.Title.Text = "使用牌照稅應納稅額試算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "貼心小叮嚀：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. 本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(3, 19);
            this.linkLabel1.Location = new System.Drawing.Point(24, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(314, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "2. 使用牌照稅稅額對照表及電動車應納稅額表";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "使用期間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(24, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "用途";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(24, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "汽缸CC數／馬達馬力";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(25, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "試算結果";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.comboBox1.Location = new System.Drawing.Point(316, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BikeComboBox
            // 
            this.BikeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BikeComboBox.DropDownWidth = 241;
            this.BikeComboBox.FormattingEnabled = true;
            this.BikeComboBox.Items.AddRange(new object[] {
            "150以下 / 12HP以下(12.2PS以下)",
            "151-250 / 12.1-20HP(12.3-20.3PS)",
            "251-500 / 20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.BikeComboBox.Location = new System.Drawing.Point(0, 44);
            this.BikeComboBox.Name = "BikeComboBox";
            this.BikeComboBox.Size = new System.Drawing.Size(240, 23);
            this.BikeComboBox.TabIndex = 11;
            this.BikeComboBox.SelectedIndexChanged += new System.EventHandler(this.BikeComboBox_SelectedIndexChanged);
            // 
            // truckComboBox
            // 
            this.truckComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.truckComboBox.DropDownWidth = 241;
            this.truckComboBox.FormattingEnabled = true;
            this.truckComboBox.Items.AddRange(new object[] {
            "500以下",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801-2400",
            "2401-3000 / 138HP以下(140.1PS以下)",
            "3001-3600",
            "3601-4200 / 138.1-200HP(140.2-203.0PS)",
            "4201-4800",
            "4801-5400 / 200.1-247HP(203.1-250.7PS)",
            "5401-6000",
            "6001-6600 / 247.1-286HP(250.8-290.3PS)",
            "6601-7200",
            "7201-7800 / 286.1-336HP(290.4-341.0PS)",
            "7801-8400",
            "8401-9000 / 336.1-361HP(341.1-366.4PS)",
            "9001-9600",
            "9601-10200 / 361.1HP以上(366.5PS以上)",
            "10201以上"});
            this.truckComboBox.Location = new System.Drawing.Point(0, 44);
            this.truckComboBox.Name = "truckComboBox";
            this.truckComboBox.Size = new System.Drawing.Size(240, 23);
            this.truckComboBox.TabIndex = 12;
            this.truckComboBox.SelectedIndexChanged += new System.EventHandler(this.truckComboBox_SelectedIndexChanged);
            // 
            // BigCar
            // 
            this.BigCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BigCar.DropDownWidth = 241;
            this.BigCar.FormattingEnabled = true;
            this.BigCar.Items.AddRange(new object[] {
            "600以下",
            "601-1200",
            "1201-1800",
            "1801-2400",
            "2401-3000 / 138HP以下(140.1PS以下)",
            "3001-3600",
            "3601-4200 / 138.1-200HP(140.2-203.0PS)",
            "4201-4800",
            "4801-5400 / 200.1-247HP(203.1-250.7PS)",
            "5401-6000",
            "6001-6600 / 247.1-286HP(250.8-290.3PS)",
            "6601-7200",
            "7201-7800 / 286.1-336HP(290.4-341.0PS)",
            "7801-8400",
            "8401-9000 / 336.1-361HP(341.1-366.4PS)",
            "9001-9600",
            "9601-10200 / 361.1HP以上(366.5PS以上)",
            "10201以上"});
            this.BigCar.Location = new System.Drawing.Point(0, 44);
            this.BigCar.Name = "BigCar";
            this.BigCar.Size = new System.Drawing.Size(240, 23);
            this.BigCar.TabIndex = 13;
            this.BigCar.SelectedIndexChanged += new System.EventHandler(this.BigCar_SelectedIndexChanged);
            // 
            // smCar
            // 
            this.smCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smCar.DropDownWidth = 241;
            this.smCar.FormattingEnabled = true;
            this.smCar.Items.AddRange(new object[] {
            "500以下 / 38HP以下(38.6PS以下)",
            "501~600 / 38.1-56HP(38.7-56.8PS)",
            "601~1200 / 56.1-83HP(56.9-84.2PS)",
            "1201~1800 / 83.1-182HP(84.3-184.7PS)",
            "1801~2400 / 182.1-262HP(184.8-265.9PS)",
            "2401~3000 / 262.1-322HP(266-326.8PS)",
            "3001-4200 / 322.1-414HP(326.9-420.2PS",
            "4201-5400 / 414.1-469HP(420.3-476.0PS)",
            "5401-6600 / 469.1-509HP(476.1-516.6PS)",
            "6601-7800 / 509.1HP以上(516.7PS以上)",
            "7801以上"});
            this.smCar.Location = new System.Drawing.Point(0, 44);
            this.smCar.Name = "smCar";
            this.smCar.Size = new System.Drawing.Size(240, 23);
            this.smCar.TabIndex = 14;
            this.smCar.SelectedIndexChanged += new System.EventHandler(this.smCar_SelectedIndexChanged);
            // 
            // BusinessCar
            // 
            this.BusinessCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusinessCar.DropDownWidth = 241;
            this.BusinessCar.FormattingEnabled = true;
            this.BusinessCar.Items.AddRange(new object[] {
            "500以下 / 38HP以下(38.6PS以下)",
            "501~600 / 38.1-56HP(38.7-56.8PS)",
            "601~1200 / 56.1-83HP(56.9-84.2PS)",
            "1201~1800 / 83.1-182HP(84.3-184.7PS)",
            "1801~2400 / 182.1-262HP(184.8-265.9PS)",
            "2401~3000 / 262.1-322HP(266-326.8PS)",
            "3001-4200 / 322.1-414HP(326.9-420.2PS)",
            "4201-5400 / 414.1-469HP(420.3-476.0PS)",
            "5401-6600 / 469.1-509HP(476.1-516.6PS)",
            "6601-7800 / 509.1HP以上(516.7PS以上)",
            "7801以上"});
            this.BusinessCar.Location = new System.Drawing.Point(0, 44);
            this.BusinessCar.Name = "BusinessCar";
            this.BusinessCar.Size = new System.Drawing.Size(240, 23);
            this.BusinessCar.TabIndex = 15;
            this.BusinessCar.SelectedIndexChanged += new System.EventHandler(this.BusinessCar_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.smCar);
            this.panel1.Controls.Add(this.BikeComboBox);
            this.panel1.Controls.Add(this.BigCar);
            this.panel1.Controls.Add(this.truckComboBox);
            this.panel1.Controls.Add(this.BusinessCar);
            this.panel1.Location = new System.Drawing.Point(316, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 87);
            this.panel1.TabIndex = 16;
            // 
            // DatePanel
            // 
            this.DatePanel.Controls.Add(this.dateTimePicker2);
            this.DatePanel.Controls.Add(this.dateTimePicker1);
            this.DatePanel.Controls.Add(this.label8);
            this.DatePanel.Controls.Add(this.label7);
            this.DatePanel.Location = new System.Drawing.Point(474, 120);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(406, 130);
            this.DatePanel.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(215, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "至";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "從";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(741, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(741, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(741, 545);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 49);
            this.button3.TabIndex = 19;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(3, 10);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(280, 15);
            this.result.TabIndex = 20;
            this.result.Text = "555555555555555555555555555555555555555";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.result);
            this.panel2.Location = new System.Drawing.Point(316, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 157);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "label9";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile
            // 
            this.OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFile.Location = new System.Drawing.Point(741, 380);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(121, 49);
            this.OpenFile.TabIndex = 23;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFile.Location = new System.Drawing.Point(741, 325);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(121, 49);
            this.SaveFile.TabIndex = 24;
            this.SaveFile.Text = "SaveFile";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 605);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.DatePanel.ResumeLayout(false);
            this.DatePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox BikeComboBox;
        private System.Windows.Forms.ComboBox truckComboBox;
        private System.Windows.Forms.ComboBox BigCar;
        private System.Windows.Forms.ComboBox smCar;
        private System.Windows.Forms.ComboBox BusinessCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
    }
}

