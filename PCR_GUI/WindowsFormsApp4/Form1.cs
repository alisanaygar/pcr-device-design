using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using Microsoft.Office.Interop;
using System.Xml.XPath;
using System.Data;
using System.Xml;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Office.Interop.Excel;
using Constants = Microsoft.Office.Interop.Excel.Constants;
using Microsoft.JScript;
using TextBox = System.Windows.Forms.TextBox;
using System.Windows.Forms.DataVisualization.Charting;
using Convert = System.Convert;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        
        string[] ports = SerialPort.GetPortNames();
        //int maksm = 5, minm = 0, i=0;
        bool isConnected = false;
        //string sonuc;
        private string LDR_1;
        private string LDR_2 = "90";
        //private int LDR_1L;
        private int Limit = 10;
        private string FilePathAndName;
        int saniye = 0;       
        int cycleNum = 0;
        public Form1()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            denaturationProcess.Maximum = 30;
            annealingProcess.Maximum = 30;
            extensionProcess.Maximum = 30;

            ButtonSaveToExcel.Height = 50;

            for (var i = 0; i <= 30; i += 1)
            {
                Chart1.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), 0);
                if (Chart1.Series[0].Points.Count == Limit)
                    Chart1.Series[0].Points.RemoveAt(0);
                Chart1.ChartAreas[0].AxisY.Maximum = 100;

                Chart1.Series[1].Points.AddXY(DateTime.Now.ToLongTimeString(), 0);
                if (Chart1.Series[1].Points.Count == Limit)
                    Chart1.Series[1].Points.RemoveAt(0);
                //Chart1.ChartAreas[1].AxisY.Maximum = 100;
            }
            Chart1.ChartAreas[0].AxisY.Maximum = 100;
            //Chart1.ChartAreas[1].AxisY.Maximum = 100;

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

       /*private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            sonuc = serialPort1.ReadLine();
            System.Threading.Thread.Sleep(1000);
            label2.Text = sonuc + " °C";
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                try
                {
                    isConnected = true;
                    serialPort1.Open();
                    TimerSerial.Start();
                    ButtonConnect.Enabled = false;
                    PictureBoxConnectionInd.Image = Properties.Resources.green;
                    LabelStatus.Text = "Status : Connected";

                }
                catch (Exception hata)
                {
                    MessageBox.Show("hata:" + hata.Message);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    TimerSerial.Stop();
                    ButtonConnect.Enabled = true;
                    PictureBoxConnectionInd.Image = Properties.Resources.red;
                    PictureBoxConnectionInd.Visible = true;
                    LabelStatus.Text = "Status : Disconnect";

                }
                catch (Exception hata)
                {
                    MessageBox.Show("hata:" + hata.Message);

                }

            }
        }

        private void ButtonStartRecording_Click(object sender, EventArgs e)
        {
            saniye = 0;
            cycleText.Text = cycleNumber.Text;
            cycleNum = Convert.ToInt32(cycleNumber.Text);

            ButtonStartRecording.Enabled = false;
            ButtonStopRecording.Enabled = true;
            ButtonSaveToExcel.Enabled = false;
            PictureBoxConnectionInd2.Image = Properties.Resources.green;
            TimerDataLogRecord.Start();
        }

        private void ButtonStopRecording_Click(object sender, EventArgs e)
        {
            ButtonStartRecording.Enabled = true;
            ButtonStopRecording.Enabled = false;
            ButtonSaveToExcel.Enabled = true;
            PictureBoxConnectionInd2.Image = Properties.Resources.red;
            TimerDataLogRecord.Stop();
            
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            for (var i = 0; i <= 30; i += 1)
            {
                Chart1.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), 0);
                if (Chart1.Series[0].Points.Count == Limit)
                    Chart1.Series[0].Points.RemoveAt(0);
                Chart1.ChartAreas[0].AxisY.Maximum = 100;

                Chart1.Series[1].Points.AddXY(DateTime.Now.ToLongTimeString(), 0);
                if (Chart1.Series[1].Points.Count == Limit)
                    Chart1.Series[1].Points.RemoveAt(0);
                //Chart1.ChartAreas[1].AxisY.Maximum = 100;
            }
            DataGridView1.Rows.Clear();
        }

        private void ButtonSaveToExcel_Click(object sender, EventArgs e)
        {
            ButtonSaveToExcel.Height = 37;
            ButtonSaveToExcel.Text = "Please Wait...";
            ButtonSaveToExcel.Enabled = false;
            ButtonStartRecording.Enabled = false;
            ProgressBarProcess.Visible = true;
            ProgressBarProcess.Value = 1;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            int i;
            int j;

            ProgressBarProcess.Value = 3;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item("Sayfa1");

            ProgressBarProcess.Value = 5;

            for (i = 0; i <= DataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= DataGridView1.ColumnCount - 1; j++)
                {
                    for (int k = 1; k <= DataGridView1.Columns.Count; k++)
                    {
                        xlWorkSheet.Cells[1, k] = DataGridView1.Columns[k - 1].HeaderText;
                        xlWorkSheet.Cells[i + 2, j + 1] = DataGridView1[j, i].Value.ToString();
                    }
                }
            }

            ProgressBarProcess.Value = 8;

            FilePathAndName = System.Windows.Forms.Application.StartupPath + "\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xlsx";
            if (File.Exists(FilePathAndName))
                File.Delete(FilePathAndName);

            xlWorkSheet.SaveAs(FilePathAndName);
            xlWorkBook.Close();
            xlApp.Quit();

            releaseObject(xlApp);
            releaseObject(xlWorkBook);
            releaseObject(xlWorkSheet);

            ProgressBarProcess.Value = 10;

            Interaction.MsgBox("Successfully saved" + "\r\n" + "File are saved at : " + FilePathAndName, MsgBoxStyle.Information, "Information");

            ProgressBarProcess.Visible = false;

            Process.Start(FilePathAndName);

            ButtonSaveToExcel.Height = 50;
            ButtonSaveToExcel.Text = "Save To MS Excel";
            ButtonSaveToExcel.Enabled = true;
            ButtonStartRecording.Enabled = true;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void TimerDataLogRecord_Tick(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            string LDR_1Log = LDR_1;
            string LDR_2Log = LDR_2;
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";
            double set_temp = Convert.ToDouble(LDR_2Log, provider);
            double cur_temp = Convert.ToDouble(LDR_1Log, provider);
            serialPort1.WriteLine(LDR_2Log);

            if (cycleNum != 0)
            {
                saniye++;
                saniyeText.Text = saniye.ToString();
                cycleText.Text = cycleNum.ToString();
                //label11.Text = cur_temp.ToString();

                if (saniye > 90 && saniye <= 120)
                {
                    denaturationProcess.Value = saniye - 90;
                    if (saniye == 120)
                    {
                        LDR_2 = "55";
                        serialPort1.WriteLine(LDR_2);
                    }
                }

                else if (saniye > 190 && saniye <= 220)
                {
                    annealingProcess.Value = saniye - 190;
                    if (saniye == 220)
                    {
                        LDR_2 = "72";
                        serialPort1.WriteLine(LDR_2);
                    }
                }

                else if (saniye > 280 && saniye <= 310)
                {
                    extensionProcess.Value = saniye - 280;
                    if (saniye == 310)
                    {
                        LDR_2 = "90";
                        serialPort1.WriteLine(LDR_2);
                        cycleNum--;
                        saniye = 0;
                        denaturationProcess.Value = 0;
                        annealingProcess.Value = 0;
                        extensionProcess.Value = 0;
                    }
                }

                /*if (saniye > 120)
                {
                    
                }*/
            }

            

            DataGridView1.Rows.Add(new string[] { DataGridView1.RowCount.ToString(), LDR_1Log, LDR_2Log, DT.ToLongTimeString(), DT.ToString("dd-MM-yyyy") });
            this.DataGridView1.FirstDisplayedScrollingRowIndex = this.DataGridView1.RowCount - 1;

            Chart1.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), LDR_1Log);
            Chart1.Series[1].Points.AddXY(DateTime.Now.ToLongTimeString(), LDR_2Log);

            /*if (Chart1.Series[0].Points.Count == Limit)
                Chart1.Series[0].Points.RemoveAt(0);

            if (Chart1.Series[1].Points.Count == Limit)
                Chart1.Series[1].Points.RemoveAt(0);*/

            if (PictureBoxConnectionInd2.Visible == true)
                PictureBoxConnectionInd2.Visible = false;
            else if (PictureBoxConnectionInd2.Visible == false)
                PictureBoxConnectionInd2.Visible = true;
        }

        private void TimerSerial_Tick(object sender, EventArgs e)
        {

            try
            {

                LDR_1 = serialPort1.ReadLine();
                

                if (PictureBoxConnectionInd.Visible == true)
                    PictureBoxConnectionInd.Visible = false;               
                else if (PictureBoxConnectionInd.Visible == false)
                    PictureBoxConnectionInd.Visible = true;

                label2.Text = LDR_1;
                
            }
            catch (Exception ex)
            {

            }


        }

        private void setButton_Click_1(object sender, EventArgs e)
        {
            
                LDR_2 = setBox.Text;
                serialPort1.WriteLine(LDR_2);
            
            
        }

        






        /*private void trackBar1_Scroll(object sender, EventArgs e)
            {
                int sicaklik = trackBar1.Value;
                label4.Text = "" + sicaklik + "" + "°C";
                if (serialPort1.IsOpen)
                {
                    byte[] b = BitConverter.GetBytes(sicaklik);
                    serialPort1.Write(b, 0, 4);
                }
            }*/

    }
}
