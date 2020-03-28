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
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TimerSerial = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerDataLogRecord = new System.Windows.Forms.Timer(this.components);
            this.Graph = new System.Windows.Forms.GroupBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(504, 679);
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
            this.label2.Location = new System.Drawing.Point(649, 679);
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(507, 620);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(814, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desired Temp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 710);
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
            this.No.FillWeight = 42.78075F;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            // 
            // CurrentTemp
            // 
            this.CurrentTemp.FillWeight = 119.0731F;
            this.CurrentTemp.HeaderText = "Current Temp";
            this.CurrentTemp.MinimumWidth = 6;
            this.CurrentTemp.Name = "CurrentTemp";
            // 
            // TIME
            // 
            this.TIME.FillWeight = 119.0731F;
            this.TIME.HeaderText = "TIME";
            this.TIME.MinimumWidth = 6;
            this.TIME.Name = "TIME";
            // 
            // DATE
            // 
            this.DATE.FillWeight = 119.0731F;
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
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(6, 21);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Current Temp";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(1458, 550);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.Timer TimerDataLogRecord;
        private System.Windows.Forms.GroupBox Graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
    }
}

