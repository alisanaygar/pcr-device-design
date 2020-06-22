namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TimerSerial = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Connection = new System.Windows.Forms.GroupBox();
            this.PictureBoxConnectionInd = new System.Windows.Forms.PictureBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.GroupBox();
            this.PictureBoxConnectionInd2 = new System.Windows.Forms.PictureBox();
            this.PictureBoxRecordInd = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonStopRecording = new System.Windows.Forms.Button();
            this.ButtonStartRecording = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProgressBarProcess = new System.Windows.Forms.ProgressBar();
            this.ButtonSaveToExcel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Set_Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerDataLogRecord = new System.Windows.Forms.Timer(this.components);
            this.Graph = new System.Windows.Forms.GroupBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.setBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.denaturationProcess = new System.Windows.Forms.ProgressBar();
            this.annealingProcess = new System.Windows.Forms.ProgressBar();
            this.extensionProcess = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cycleNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cycleText = new System.Windows.Forms.Label();
            this.saniyeText = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionInd)).BeginInit();
            this.Record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionInd2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(7, 37);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(130, 38);
            this.ButtonConnect.TabIndex = 0;
            this.ButtonConnect.Text = "CONNECT";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(142, 37);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(123, 38);
            this.ButtonDisconnect.TabIndex = 1;
            this.ButtonDisconnect.Text = "DISCONNECT";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Temp:";
            // 
            // TimerSerial
            // 
            this.TimerSerial.Interval = 1000;
            this.TimerSerial.Tick += new System.EventHandler(this.TimerSerial_Tick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(590, 613);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "°C";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desired Temp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "°C";
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.PictureBoxConnectionInd);
            this.Connection.Controls.Add(this.LabelStatus);
            this.Connection.Controls.Add(this.ButtonConnect);
            this.Connection.Controls.Add(this.ButtonDisconnect);
            this.Connection.Controls.Add(this.comboBox1);
            this.Connection.Location = new System.Drawing.Point(12, 12);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(414, 100);
            this.Connection.TabIndex = 10;
            this.Connection.TabStop = false;
            this.Connection.Text = "Connection";
            // 
            // PictureBoxConnectionInd
            // 
            this.PictureBoxConnectionInd.Image = global::WindowsFormsApp4.Properties.Resources.red;
            this.PictureBoxConnectionInd.Location = new System.Drawing.Point(377, 0);
            this.PictureBoxConnectionInd.Name = "PictureBoxConnectionInd";
            this.PictureBoxConnectionInd.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxConnectionInd.TabIndex = 12;
            this.PictureBoxConnectionInd.TabStop = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(245, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(126, 17);
            this.LabelStatus.TabIndex = 6;
            this.LabelStatus.Text = "Status: Disconnect";
            // 
            // Record
            // 
            this.Record.Controls.Add(this.PictureBoxConnectionInd2);
            this.Record.Controls.Add(this.PictureBoxRecordInd);
            this.Record.Controls.Add(this.ButtonClear);
            this.Record.Controls.Add(this.ButtonStopRecording);
            this.Record.Controls.Add(this.ButtonStartRecording);
            this.Record.Location = new System.Drawing.Point(12, 118);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(414, 151);
            this.Record.TabIndex = 11;
            this.Record.TabStop = false;
            this.Record.Text = "Data Record";
            // 
            // PictureBoxConnectionInd2
            // 
            this.PictureBoxConnectionInd2.Image = global::WindowsFormsApp4.Properties.Resources.red;
            this.PictureBoxConnectionInd2.Location = new System.Drawing.Point(377, 0);
            this.PictureBoxConnectionInd2.Name = "PictureBoxConnectionInd2";
            this.PictureBoxConnectionInd2.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxConnectionInd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxConnectionInd2.TabIndex = 13;
            this.PictureBoxConnectionInd2.TabStop = false;
            // 
            // PictureBoxRecordInd
            // 
            this.PictureBoxRecordInd.AutoSize = true;
            this.PictureBoxRecordInd.Location = new System.Drawing.Point(298, 0);
            this.PictureBoxRecordInd.Name = "PictureBoxRecordInd";
            this.PictureBoxRecordInd.Size = new System.Drawing.Size(73, 17);
            this.PictureBoxRecordInd.TabIndex = 3;
            this.PictureBoxRecordInd.Text = "Recording";
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(7, 80);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(401, 45);
            this.ButtonClear.TabIndex = 2;
            this.ButtonClear.Text = "Clear DataGridView and Graph";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonStopRecording
            // 
            this.ButtonStopRecording.Location = new System.Drawing.Point(212, 34);
            this.ButtonStopRecording.Name = "ButtonStopRecording";
            this.ButtonStopRecording.Size = new System.Drawing.Size(196, 40);
            this.ButtonStopRecording.TabIndex = 1;
            this.ButtonStopRecording.Text = "Stop Recording";
            this.ButtonStopRecording.UseVisualStyleBackColor = true;
            this.ButtonStopRecording.Click += new System.EventHandler(this.ButtonStopRecording_Click);
            // 
            // ButtonStartRecording
            // 
            this.ButtonStartRecording.Location = new System.Drawing.Point(7, 34);
            this.ButtonStartRecording.Name = "ButtonStartRecording";
            this.ButtonStartRecording.Size = new System.Drawing.Size(199, 40);
            this.ButtonStartRecording.TabIndex = 0;
            this.ButtonStartRecording.Text = "Start Recording";
            this.ButtonStartRecording.UseVisualStyleBackColor = true;
            this.ButtonStartRecording.Click += new System.EventHandler(this.ButtonStartRecording_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgressBarProcess);
            this.groupBox1.Controls.Add(this.ButtonSaveToExcel);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // ProgressBarProcess
            // 
            this.ProgressBarProcess.Location = new System.Drawing.Point(7, 65);
            this.ProgressBarProcess.Maximum = 10;
            this.ProgressBarProcess.Name = "ProgressBarProcess";
            this.ProgressBarProcess.Size = new System.Drawing.Size(401, 16);
            this.ProgressBarProcess.TabIndex = 1;
            this.ProgressBarProcess.Visible = false;
            // 
            // ButtonSaveToExcel
            // 
            this.ButtonSaveToExcel.Location = new System.Drawing.Point(7, 21);
            this.ButtonSaveToExcel.Name = "ButtonSaveToExcel";
            this.ButtonSaveToExcel.Size = new System.Drawing.Size(401, 60);
            this.ButtonSaveToExcel.TabIndex = 0;
            this.ButtonSaveToExcel.Text = "Save To MS Excel";
            this.ButtonSaveToExcel.UseVisualStyleBackColor = true;
            this.ButtonSaveToExcel.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 609);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Grid View ";
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.CurrentTemp,
            this.Set_Temp,
            this.TIME,
            this.DATE});
            this.DataGridView1.Location = new System.Drawing.Point(7, 21);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(401, 580);
            this.DataGridView1.TabIndex = 0;
            // 
            // No
            // 
            this.No.FillWeight = 66.84492F;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            // 
            // CurrentTemp
            // 
            this.CurrentTemp.FillWeight = 112.8061F;
            this.CurrentTemp.HeaderText = "Current Temp";
            this.CurrentTemp.MinimumWidth = 6;
            this.CurrentTemp.Name = "CurrentTemp";
            // 
            // Set_Temp
            // 
            this.Set_Temp.FillWeight = 94.73684F;
            this.Set_Temp.HeaderText = "Set Temp";
            this.Set_Temp.MinimumWidth = 6;
            this.Set_Temp.Name = "Set_Temp";
            // 
            // TIME
            // 
            this.TIME.FillWeight = 112.8061F;
            this.TIME.HeaderText = "TIME";
            this.TIME.MinimumWidth = 6;
            this.TIME.Name = "TIME";
            // 
            // DATE
            // 
            this.DATE.FillWeight = 112.8061F;
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 6;
            this.DATE.Name = "DATE";
            // 
            // TimerDataLogRecord
            // 
            this.TimerDataLogRecord.Interval = 1000;
            this.TimerDataLogRecord.Tick += new System.EventHandler(this.TimerDataLogRecord_Tick);
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.Controls.Add(this.Chart1);
            this.Graph.Location = new System.Drawing.Point(442, 12);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(1470, 577);
            this.Graph.TabIndex = 14;
            this.Graph.TabStop = false;
            this.Graph.Text = "Graph";
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(6, 21);
            this.Chart1.Name = "Chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Current Temp";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Set Temp";
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(1458, 550);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "chart1";
            // 
            // setBox
            // 
            this.setBox.Location = new System.Drawing.Point(577, 641);
            this.setBox.Name = "setBox";
            this.setBox.Size = new System.Drawing.Size(52, 22);
            this.setBox.TabIndex = 15;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(664, 641);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 16;
            this.setButton.Text = "SET";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click_1);
            // 
            // denaturationProcess
            // 
            this.denaturationProcess.Location = new System.Drawing.Point(448, 827);
            this.denaturationProcess.Name = "denaturationProcess";
            this.denaturationProcess.Size = new System.Drawing.Size(487, 23);
            this.denaturationProcess.TabIndex = 17;
            // 
            // annealingProcess
            // 
            this.annealingProcess.Location = new System.Drawing.Point(932, 827);
            this.annealingProcess.Name = "annealingProcess";
            this.annealingProcess.Size = new System.Drawing.Size(487, 23);
            this.annealingProcess.TabIndex = 18;
            // 
            // extensionProcess
            // 
            this.extensionProcess.Location = new System.Drawing.Point(1419, 827);
            this.extensionProcess.Name = "extensionProcess";
            this.extensionProcess.Size = new System.Drawing.Size(487, 23);
            this.extensionProcess.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 789);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Denaturation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1169, 789);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Annealing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1642, 788);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Extension";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 676);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cycle Number:";
            // 
            // cycleNumber
            // 
            this.cycleNumber.Location = new System.Drawing.Point(577, 676);
            this.cycleNumber.Name = "cycleNumber";
            this.cycleNumber.Size = new System.Drawing.Size(52, 22);
            this.cycleNumber.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 884);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cycles:";
            // 
            // cycleText
            // 
            this.cycleText.AutoSize = true;
            this.cycleText.Location = new System.Drawing.Point(504, 884);
            this.cycleText.Name = "cycleText";
            this.cycleText.Size = new System.Drawing.Size(16, 17);
            this.cycleText.TabIndex = 27;
            this.cycleText.Text = "0";
            // 
            // saniyeText
            // 
            this.saniyeText.AutoSize = true;
            this.saniyeText.Location = new System.Drawing.Point(574, 916);
            this.saniyeText.Name = "saniyeText";
            this.saniyeText.Size = new System.Drawing.Size(16, 17);
            this.saniyeText.TabIndex = 28;
            this.saniyeText.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 916);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Cycle Time(sn):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saniyeText);
            this.Controls.Add(this.cycleText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cycleNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.extensionProcess);
            this.Controls.Add(this.annealingProcess);
            this.Controls.Add(this.denaturationProcess);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.setBox);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionInd)).EndInit();
            this.Record.ResumeLayout(false);
            this.Record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConnectionInd2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer TimerSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Connection;
        private System.Windows.Forms.GroupBox Record;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonStopRecording;
        private System.Windows.Forms.Button ButtonStartRecording;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.PictureBox PictureBoxConnectionInd;
        private System.Windows.Forms.PictureBox PictureBoxConnectionInd2;
        private System.Windows.Forms.Label PictureBoxRecordInd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ProgressBarProcess;
        private System.Windows.Forms.Button ButtonSaveToExcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Timer TimerDataLogRecord;
        private System.Windows.Forms.GroupBox Graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.TextBox setBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Set_Temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.ProgressBar denaturationProcess;
        private System.Windows.Forms.ProgressBar annealingProcess;
        private System.Windows.Forms.ProgressBar extensionProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cycleNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cycleText;
        private System.Windows.Forms.Label saniyeText;
        private System.Windows.Forms.Label label10;
    }
}

