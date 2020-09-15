namespace demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_StartRec = new System.Windows.Forms.Button();
            this.button_StopRec = new System.Windows.Forms.Button();
            this.button_StartPlay = new System.Windows.Forms.Button();
            this.button_StopPlay = new System.Windows.Forms.Button();
            this.button_LineBusy = new System.Windows.Forms.Button();
            this.button_LineFree = new System.Windows.Forms.Button();
            this.button_DisconnectPhone = new System.Windows.Forms.Button();
            this.button_ConnectPhone = new System.Windows.Forms.Button();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.button_Dial = new System.Windows.Forms.Button();
            this.checkBox_DetBusytone = new System.Windows.Forms.CheckBox();
            this.checkBox_Chinese = new System.Windows.Forms.CheckBox();
            this.groupBox_VolSetting = new System.Windows.Forms.GroupBox();
            this.comboBox_PlayVol = new System.Windows.Forms.ComboBox();
            this.label_PlayVol = new System.Windows.Forms.Label();
            this.comboBox_RecVol = new System.Windows.Forms.ComboBox();
            this.label_RecVol = new System.Windows.Forms.Label();
            this.groupBox_VoiceTriggerSetting = new System.Windows.Forms.GroupBox();
            this.checkBox_VoiceTrigger = new System.Windows.Forms.CheckBox();
            this.button_Set = new System.Windows.Forms.Button();
            this.textBox_TimeDetSilence = new System.Windows.Forms.TextBox();
            this.textBox_TimeDetVoice = new System.Windows.Forms.TextBox();
            this.comboBox_SilenceLevel = new System.Windows.Forms.ComboBox();
            this.label_SilenceLevel = new System.Windows.Forms.Label();
            this.comboBox_VoiceLevel = new System.Windows.Forms.ComboBox();
            this.label_TimeDetSilence = new System.Windows.Forms.Label();
            this.label_TimeDetVoice = new System.Windows.Forms.Label();
            this.label_VoiceLevel = new System.Windows.Forms.Label();
            this.button_pop = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox_VolSetting.SuspendLayout();
            this.groupBox_VoiceTriggerSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(649, 176);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Channel";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Device SN";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Line Status";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Line Voltage";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Voice Trigger";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Caller Id";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dialed";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Device Ver";
            this.columnHeader8.Width = 80;
            // 
            // button_StartRec
            // 
            this.button_StartRec.Location = new System.Drawing.Point(5, 186);
            this.button_StartRec.Name = "button_StartRec";
            this.button_StartRec.Size = new System.Drawing.Size(85, 23);
            this.button_StartRec.TabIndex = 1;
            this.button_StartRec.Text = "Start Rec";
            this.button_StartRec.UseVisualStyleBackColor = true;
            this.button_StartRec.Click += new System.EventHandler(this.button_StartRec_Click);
            // 
            // button_StopRec
            // 
            this.button_StopRec.Location = new System.Drawing.Point(93, 186);
            this.button_StopRec.Name = "button_StopRec";
            this.button_StopRec.Size = new System.Drawing.Size(85, 23);
            this.button_StopRec.TabIndex = 1;
            this.button_StopRec.Text = "Stop Rec";
            this.button_StopRec.UseVisualStyleBackColor = true;
            this.button_StopRec.Click += new System.EventHandler(this.button_StopRec_Click);
            // 
            // button_StartPlay
            // 
            this.button_StartPlay.Location = new System.Drawing.Point(194, 186);
            this.button_StartPlay.Name = "button_StartPlay";
            this.button_StartPlay.Size = new System.Drawing.Size(85, 23);
            this.button_StartPlay.TabIndex = 1;
            this.button_StartPlay.Text = "Start Play";
            this.button_StartPlay.UseVisualStyleBackColor = true;
            this.button_StartPlay.Click += new System.EventHandler(this.button_StartPlay_Click);
            // 
            // button_StopPlay
            // 
            this.button_StopPlay.Location = new System.Drawing.Point(283, 186);
            this.button_StopPlay.Name = "button_StopPlay";
            this.button_StopPlay.Size = new System.Drawing.Size(85, 23);
            this.button_StopPlay.TabIndex = 1;
            this.button_StopPlay.Text = "Stop Play";
            this.button_StopPlay.UseVisualStyleBackColor = true;
            this.button_StopPlay.Click += new System.EventHandler(this.button_StopPlay_Click);
            // 
            // button_LineBusy
            // 
            this.button_LineBusy.Location = new System.Drawing.Point(381, 186);
            this.button_LineBusy.Name = "button_LineBusy";
            this.button_LineBusy.Size = new System.Drawing.Size(85, 23);
            this.button_LineBusy.TabIndex = 1;
            this.button_LineBusy.Text = "Line Busy";
            this.button_LineBusy.UseVisualStyleBackColor = true;
            this.button_LineBusy.Click += new System.EventHandler(this.button_LineBusy_Click);
            // 
            // button_LineFree
            // 
            this.button_LineFree.Location = new System.Drawing.Point(470, 185);
            this.button_LineFree.Name = "button_LineFree";
            this.button_LineFree.Size = new System.Drawing.Size(85, 23);
            this.button_LineFree.TabIndex = 1;
            this.button_LineFree.Text = "Line Free";
            this.button_LineFree.UseVisualStyleBackColor = true;
            this.button_LineFree.Click += new System.EventHandler(this.button_LineFree_Click);
            // 
            // button_DisconnectPhone
            // 
            this.button_DisconnectPhone.Location = new System.Drawing.Point(381, 228);
            this.button_DisconnectPhone.Name = "button_DisconnectPhone";
            this.button_DisconnectPhone.Size = new System.Drawing.Size(117, 23);
            this.button_DisconnectPhone.TabIndex = 1;
            this.button_DisconnectPhone.Text = "Disconnect Phone";
            this.button_DisconnectPhone.UseVisualStyleBackColor = true;
            this.button_DisconnectPhone.Click += new System.EventHandler(this.button_DisconnectPhone_Click);
            // 
            // button_ConnectPhone
            // 
            this.button_ConnectPhone.Location = new System.Drawing.Point(501, 228);
            this.button_ConnectPhone.Name = "button_ConnectPhone";
            this.button_ConnectPhone.Size = new System.Drawing.Size(117, 23);
            this.button_ConnectPhone.TabIndex = 1;
            this.button_ConnectPhone.Text = "Connect Phone";
            this.button_ConnectPhone.UseVisualStyleBackColor = true;
            this.button_ConnectPhone.Click += new System.EventHandler(this.button_ConnectPhone_Click);
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(5, 225);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(100, 22);
            this.textBox_Num.TabIndex = 2;
            // 
            // button_Dial
            // 
            this.button_Dial.Location = new System.Drawing.Point(111, 223);
            this.button_Dial.Name = "button_Dial";
            this.button_Dial.Size = new System.Drawing.Size(66, 24);
            this.button_Dial.TabIndex = 3;
            this.button_Dial.Text = "Dial";
            this.button_Dial.UseVisualStyleBackColor = true;
            this.button_Dial.Click += new System.EventHandler(this.button_Dial_Click);
            // 
            // checkBox_DetBusytone
            // 
            this.checkBox_DetBusytone.Location = new System.Drawing.Point(194, 215);
            this.checkBox_DetBusytone.Name = "checkBox_DetBusytone";
            this.checkBox_DetBusytone.Size = new System.Drawing.Size(129, 18);
            this.checkBox_DetBusytone.TabIndex = 4;
            this.checkBox_DetBusytone.Text = "Detect Busytone";
            this.checkBox_DetBusytone.UseVisualStyleBackColor = true;
            // 
            // checkBox_Chinese
            // 
            this.checkBox_Chinese.Location = new System.Drawing.Point(194, 234);
            this.checkBox_Chinese.Name = "checkBox_Chinese";
            this.checkBox_Chinese.Size = new System.Drawing.Size(136, 17);
            this.checkBox_Chinese.TabIndex = 5;
            this.checkBox_Chinese.Text = "Language(Chinese)";
            this.checkBox_Chinese.UseVisualStyleBackColor = true;
            this.checkBox_Chinese.CheckedChanged += new System.EventHandler(this.checkBox_Chinese_CheckedChanged);
            // 
            // groupBox_VolSetting
            // 
            this.groupBox_VolSetting.Controls.Add(this.comboBox_PlayVol);
            this.groupBox_VolSetting.Controls.Add(this.label_PlayVol);
            this.groupBox_VolSetting.Controls.Add(this.comboBox_RecVol);
            this.groupBox_VolSetting.Controls.Add(this.label_RecVol);
            this.groupBox_VolSetting.Location = new System.Drawing.Point(5, 266);
            this.groupBox_VolSetting.Name = "groupBox_VolSetting";
            this.groupBox_VolSetting.Size = new System.Drawing.Size(173, 129);
            this.groupBox_VolSetting.TabIndex = 6;
            this.groupBox_VolSetting.TabStop = false;
            this.groupBox_VolSetting.Text = "Volume Setting";
            // 
            // comboBox_PlayVol
            // 
            this.comboBox_PlayVol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PlayVol.FormattingEnabled = true;
            this.comboBox_PlayVol.Location = new System.Drawing.Point(91, 76);
            this.comboBox_PlayVol.Name = "comboBox_PlayVol";
            this.comboBox_PlayVol.Size = new System.Drawing.Size(65, 20);
            this.comboBox_PlayVol.TabIndex = 1;
            this.comboBox_PlayVol.SelectedIndexChanged += new System.EventHandler(this.comboBox_PlayVol_SelectedIndexChanged);
            this.comboBox_PlayVol.Click += new System.EventHandler(this.comboBox_PlayVol_Click);
            // 
            // label_PlayVol
            // 
            this.label_PlayVol.Location = new System.Drawing.Point(7, 79);
            this.label_PlayVol.Name = "label_PlayVol";
            this.label_PlayVol.Size = new System.Drawing.Size(78, 17);
            this.label_PlayVol.TabIndex = 0;
            this.label_PlayVol.Text = "Play Vol:";
            // 
            // comboBox_RecVol
            // 
            this.comboBox_RecVol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RecVol.FormattingEnabled = true;
            this.comboBox_RecVol.Location = new System.Drawing.Point(91, 39);
            this.comboBox_RecVol.Name = "comboBox_RecVol";
            this.comboBox_RecVol.Size = new System.Drawing.Size(65, 20);
            this.comboBox_RecVol.TabIndex = 1;
            this.comboBox_RecVol.SelectedIndexChanged += new System.EventHandler(this.comboBox_RecVol_SelectedIndexChanged);
            this.comboBox_RecVol.Click += new System.EventHandler(this.comboBox_RecVol_Click);
            // 
            // label_RecVol
            // 
            this.label_RecVol.Location = new System.Drawing.Point(7, 42);
            this.label_RecVol.Name = "label_RecVol";
            this.label_RecVol.Size = new System.Drawing.Size(78, 15);
            this.label_RecVol.TabIndex = 0;
            this.label_RecVol.Text = "Rec Vol:";
            // 
            // groupBox_VoiceTriggerSetting
            // 
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.checkBox_VoiceTrigger);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.button_Set);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.textBox_TimeDetSilence);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.textBox_TimeDetVoice);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.comboBox_SilenceLevel);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.label_SilenceLevel);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.comboBox_VoiceLevel);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.label_TimeDetSilence);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.label_TimeDetVoice);
            this.groupBox_VoiceTriggerSetting.Controls.Add(this.label_VoiceLevel);
            this.groupBox_VoiceTriggerSetting.Location = new System.Drawing.Point(194, 266);
            this.groupBox_VoiceTriggerSetting.Name = "groupBox_VoiceTriggerSetting";
            this.groupBox_VoiceTriggerSetting.Size = new System.Drawing.Size(436, 129);
            this.groupBox_VoiceTriggerSetting.TabIndex = 7;
            this.groupBox_VoiceTriggerSetting.TabStop = false;
            this.groupBox_VoiceTriggerSetting.Text = "Voice Trigger Setting";
            // 
            // checkBox_VoiceTrigger
            // 
            this.checkBox_VoiceTrigger.Location = new System.Drawing.Point(21, 25);
            this.checkBox_VoiceTrigger.Name = "checkBox_VoiceTrigger";
            this.checkBox_VoiceTrigger.Size = new System.Drawing.Size(121, 16);
            this.checkBox_VoiceTrigger.TabIndex = 4;
            this.checkBox_VoiceTrigger.Text = "Voice Trigger";
            this.checkBox_VoiceTrigger.UseVisualStyleBackColor = true;
            this.checkBox_VoiceTrigger.CheckedChanged += new System.EventHandler(this.checkBox_VoiceTrigger_CheckedChanged);
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(349, 78);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(75, 32);
            this.button_Set.TabIndex = 3;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // textBox_TimeDetSilence
            // 
            this.textBox_TimeDetSilence.Location = new System.Drawing.Point(284, 91);
            this.textBox_TimeDetSilence.Name = "textBox_TimeDetSilence";
            this.textBox_TimeDetSilence.Size = new System.Drawing.Size(50, 22);
            this.textBox_TimeDetSilence.TabIndex = 2;
            // 
            // textBox_TimeDetVoice
            // 
            this.textBox_TimeDetVoice.Location = new System.Drawing.Point(284, 55);
            this.textBox_TimeDetVoice.Name = "textBox_TimeDetVoice";
            this.textBox_TimeDetVoice.Size = new System.Drawing.Size(50, 22);
            this.textBox_TimeDetVoice.TabIndex = 2;
            // 
            // comboBox_SilenceLevel
            // 
            this.comboBox_SilenceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SilenceLevel.FormattingEnabled = true;
            this.comboBox_SilenceLevel.Location = new System.Drawing.Point(89, 90);
            this.comboBox_SilenceLevel.Name = "comboBox_SilenceLevel";
            this.comboBox_SilenceLevel.Size = new System.Drawing.Size(55, 20);
            this.comboBox_SilenceLevel.TabIndex = 1;
            // 
            // label_SilenceLevel
            // 
            this.label_SilenceLevel.Location = new System.Drawing.Point(19, 94);
            this.label_SilenceLevel.Name = "label_SilenceLevel";
            this.label_SilenceLevel.Size = new System.Drawing.Size(101, 15);
            this.label_SilenceLevel.TabIndex = 0;
            this.label_SilenceLevel.Text = "Silence Level:";
            // 
            // comboBox_VoiceLevel
            // 
            this.comboBox_VoiceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VoiceLevel.FormattingEnabled = true;
            this.comboBox_VoiceLevel.Location = new System.Drawing.Point(89, 56);
            this.comboBox_VoiceLevel.Name = "comboBox_VoiceLevel";
            this.comboBox_VoiceLevel.Size = new System.Drawing.Size(55, 20);
            this.comboBox_VoiceLevel.TabIndex = 1;
            // 
            // label_TimeDetSilence
            // 
            this.label_TimeDetSilence.Location = new System.Drawing.Point(151, 94);
            this.label_TimeDetSilence.Name = "label_TimeDetSilence";
            this.label_TimeDetSilence.Size = new System.Drawing.Size(164, 14);
            this.label_TimeDetSilence.TabIndex = 0;
            this.label_TimeDetSilence.Text = "Time(Det silence)(S):";
            // 
            // label_TimeDetVoice
            // 
            this.label_TimeDetVoice.Location = new System.Drawing.Point(151, 58);
            this.label_TimeDetVoice.Name = "label_TimeDetVoice";
            this.label_TimeDetVoice.Size = new System.Drawing.Size(164, 15);
            this.label_TimeDetVoice.TabIndex = 0;
            this.label_TimeDetVoice.Text = "Time(Det voice)(100MS):";
            // 
            // label_VoiceLevel
            // 
            this.label_VoiceLevel.Location = new System.Drawing.Point(19, 59);
            this.label_VoiceLevel.Name = "label_VoiceLevel";
            this.label_VoiceLevel.Size = new System.Drawing.Size(101, 15);
            this.label_VoiceLevel.TabIndex = 0;
            this.label_VoiceLevel.Text = "Voice Level:";
            // 
            // button_pop
            // 
            this.button_pop.Location = new System.Drawing.Point(555, 181);
            this.button_pop.Name = "button_pop";
            this.button_pop.Size = new System.Drawing.Size(75, 32);
            this.button_pop.TabIndex = 8;
            this.button_pop.Text = "彈窗測試1";
            this.button_pop.UseVisualStyleBackColor = true;
            this.button_pop.Click += new System.EventHandler(this.button_pop_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(660, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(363, 393);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "來電號碼";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "客戶名稱";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "來電時間";
            this.columnHeader12.Width = 140;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "來電顯示";
            this.notifyIcon1.BalloonTipTitle = "來電顯示";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "來電顯示";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 415);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button_pop);
            this.Controls.Add(this.groupBox_VoiceTriggerSetting);
            this.Controls.Add(this.groupBox_VolSetting);
            this.Controls.Add(this.checkBox_Chinese);
            this.Controls.Add(this.checkBox_DetBusytone);
            this.Controls.Add(this.button_Dial);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.button_ConnectPhone);
            this.Controls.Add(this.button_DisconnectPhone);
            this.Controls.Add(this.button_LineFree);
            this.Controls.Add(this.button_LineBusy);
            this.Controls.Add(this.button_StopPlay);
            this.Controls.Add(this.button_StartPlay);
            this.Controls.Add(this.button_StopRec);
            this.Controls.Add(this.button_StartRec);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "高端商行來電顯示";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox_VolSetting.ResumeLayout(false);
            this.groupBox_VoiceTriggerSetting.ResumeLayout(false);
            this.groupBox_VoiceTriggerSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button_StartRec;
        private System.Windows.Forms.Button button_StopRec;
        private System.Windows.Forms.Button button_StartPlay;
        private System.Windows.Forms.Button button_StopPlay;
        private System.Windows.Forms.Button button_LineBusy;
        private System.Windows.Forms.Button button_LineFree;
        private System.Windows.Forms.Button button_DisconnectPhone;
        private System.Windows.Forms.Button button_ConnectPhone;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.Button button_Dial;
        private System.Windows.Forms.CheckBox checkBox_DetBusytone;
        private System.Windows.Forms.CheckBox checkBox_Chinese;
        private System.Windows.Forms.GroupBox groupBox_VolSetting;
        private System.Windows.Forms.ComboBox comboBox_PlayVol;
        private System.Windows.Forms.Label label_PlayVol;
        private System.Windows.Forms.ComboBox comboBox_RecVol;
        private System.Windows.Forms.Label label_RecVol;
        private System.Windows.Forms.GroupBox groupBox_VoiceTriggerSetting;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.TextBox textBox_TimeDetSilence;
        private System.Windows.Forms.TextBox textBox_TimeDetVoice;
        private System.Windows.Forms.ComboBox comboBox_SilenceLevel;
        private System.Windows.Forms.Label label_SilenceLevel;
        private System.Windows.Forms.ComboBox comboBox_VoiceLevel;
        private System.Windows.Forms.Label label_TimeDetSilence;
        private System.Windows.Forms.Label label_TimeDetVoice;
        private System.Windows.Forms.Label label_VoiceLevel;
        private System.Windows.Forms.CheckBox checkBox_VoiceTrigger;
        private System.Windows.Forms.Button button_pop;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

