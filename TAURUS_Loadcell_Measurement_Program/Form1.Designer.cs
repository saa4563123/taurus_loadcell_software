namespace TAURUS_Loadcell_Measurement_Program
{
    partial class LoadCellProgram
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadCellProgram));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startbutton = new System.Windows.Forms.Button();
            this.serialConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTitle = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.subData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SerialBox = new System.Windows.Forms.ComboBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.convertExcel = new System.Windows.Forms.Button();
            this.TimeCorrectionButton = new System.Windows.Forms.Button();
            this.TimeCorrectionBox = new System.Windows.Forms.TextBox();
            this.TimeCorrectionLabel = new System.Windows.Forms.Label();
            this.NtoKgConvertBtn = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(503, 9);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "LoadcellData";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(744, 293);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startbutton.Location = new System.Drawing.Point(503, 308);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(744, 38);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "측정시작";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // serialConnect
            // 
            this.serialConnect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.serialConnect.Location = new System.Drawing.Point(1062, 595);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(75, 21);
            this.serialConnect.TabIndex = 3;
            this.serialConnect.Text = "연결";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.serialConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(460, 537);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "측정시간(Day | HH:mm:SS)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "무게(N)";
            this.columnHeader2.Width = 130;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.Location = new System.Drawing.Point(79, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(419, 28);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "한국교통대학교 항공우주동아리";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(475, 79);
            this.vScrollBar1.Maximum = 10;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 537);
            this.vScrollBar1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(791, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "(NULL)Kg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(507, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "now load cell data →";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveButton.Location = new System.Drawing.Point(1062, 568);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 21);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "적용";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // subData
            // 
            this.subData.Location = new System.Drawing.Point(735, 568);
            this.subData.Name = "subData";
            this.subData.Size = new System.Drawing.Size(321, 21);
            this.subData.TabIndex = 12;
            this.subData.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(499, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial Port Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(499, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Correction Factor (Kg)";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reset.Location = new System.Drawing.Point(1143, 595);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(104, 21);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TAURUS_Loadcell_Measurement_Program.Properties.Resources.TaurusV1;
            this.pictureBox1.Image = global::TAURUS_Loadcell_Measurement_Program.Properties.Resources.TaurusV1;
            this.pictureBox1.InitialImage = global::TAURUS_Loadcell_Measurement_Program.Properties.Resources.TaurusV1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(79, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "KNUT TAURUS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Software Developted by Lee SeungHwan for KNUT TAURUS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(960, 623);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "ⓒ 2022. KNUT TAURUS all rights reserved.";
            // 
            // SerialBox
            // 
            this.SerialBox.FormattingEnabled = true;
            this.SerialBox.Location = new System.Drawing.Point(702, 596);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(354, 20);
            this.SerialBox.TabIndex = 20;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.versionLabel.Location = new System.Drawing.Point(323, 43);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(74, 16);
            this.versionLabel.TabIndex = 21;
            this.versionLabel.Text = "v.NULL";
            // 
            // convertExcel
            // 
            this.convertExcel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.convertExcel.Location = new System.Drawing.Point(1143, 568);
            this.convertExcel.Name = "convertExcel";
            this.convertExcel.Size = new System.Drawing.Size(100, 21);
            this.convertExcel.TabIndex = 22;
            this.convertExcel.Text = "convert .csv";
            this.convertExcel.UseVisualStyleBackColor = true;
            this.convertExcel.Click += new System.EventHandler(this.convertExcel_Click);
            // 
            // TimeCorrectionButton
            // 
            this.TimeCorrectionButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeCorrectionButton.Location = new System.Drawing.Point(1062, 541);
            this.TimeCorrectionButton.Name = "TimeCorrectionButton";
            this.TimeCorrectionButton.Size = new System.Drawing.Size(75, 21);
            this.TimeCorrectionButton.TabIndex = 23;
            this.TimeCorrectionButton.Text = "적용";
            this.TimeCorrectionButton.UseVisualStyleBackColor = true;
            this.TimeCorrectionButton.Click += new System.EventHandler(this.TimeCorrectionButton_Click);
            // 
            // TimeCorrectionBox
            // 
            this.TimeCorrectionBox.Location = new System.Drawing.Point(723, 541);
            this.TimeCorrectionBox.Name = "TimeCorrectionBox";
            this.TimeCorrectionBox.Size = new System.Drawing.Size(333, 21);
            this.TimeCorrectionBox.TabIndex = 24;
            // 
            // TimeCorrectionLabel
            // 
            this.TimeCorrectionLabel.AutoSize = true;
            this.TimeCorrectionLabel.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeCorrectionLabel.Location = new System.Drawing.Point(499, 545);
            this.TimeCorrectionLabel.Name = "TimeCorrectionLabel";
            this.TimeCorrectionLabel.Size = new System.Drawing.Size(218, 17);
            this.TimeCorrectionLabel.TabIndex = 25;
            this.TimeCorrectionLabel.Text = "Time Correction (ms)";
            // 
            // NtoKgConvertBtn
            // 
            this.NtoKgConvertBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NtoKgConvertBtn.Location = new System.Drawing.Point(1143, 541);
            this.NtoKgConvertBtn.Name = "NtoKgConvertBtn";
            this.NtoKgConvertBtn.Size = new System.Drawing.Size(100, 21);
            this.NtoKgConvertBtn.TabIndex = 26;
            this.NtoKgConvertBtn.Text = "N ↔ Kg";
            this.NtoKgConvertBtn.UseVisualStyleBackColor = true;
            this.NtoKgConvertBtn.Click += new System.EventHandler(this.NtoKgConvertBtn_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "무게(Kg)";
            this.columnHeader3.Width = 130;
            // 
            // LoadCellProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 641);
            this.Controls.Add(this.NtoKgConvertBtn);
            this.Controls.Add(this.TimeCorrectionLabel);
            this.Controls.Add(this.TimeCorrectionBox);
            this.Controls.Add(this.TimeCorrectionButton);
            this.Controls.Add(this.convertExcel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subData);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.serialConnect);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadCellProgram";
            this.Text = "KNUT TAURUS _ 로드셀 데이터 측정 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button serialConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox subData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SerialBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button convertExcel;
        private System.Windows.Forms.Button TimeCorrectionButton;
        private System.Windows.Forms.TextBox TimeCorrectionBox;
        private System.Windows.Forms.Label TimeCorrectionLabel;
        private System.Windows.Forms.Button NtoKgConvertBtn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

