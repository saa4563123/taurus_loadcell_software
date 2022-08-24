using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;

namespace TAURUS_Loadcell_Measurement_Program
{
    public partial class LoadCellProgram : Form
    {
        string Version = "v1.3";

        bool isbusy = false;
        bool NtoKg = false; // 단위변환, false = Kg, true = N

        int subDatas = 1000;
        double convWeight; // N 변환 값 변수

        // double weight = 10;

        public LoadCellProgram()
        {
            InitializeComponent();

            versionLabel.Visible = false;
            versionLabel.Text = Version;
            string[] PortNames = SerialPort.GetPortNames();

            foreach (string portnumber in PortNames)
            {
                SerialBox.Items.Add(portnumber);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startbutton.Text = "측정시작";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;

            chart1.Series[0].ChartType = SeriesChartType.Line;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && isbusy == false)
            {
                byte[] send = new byte[1];
                send[0] = 1;
                serialPort1.Write(send, 0, 1);
                isbusy = true;
            }

            // 테스트

            /*
            weight += 10;
            if (subDatas >= weight)
            {
                label1.Text = weight.ToString() + "N";
                chart1.Series[0].Points.Add(weight);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = DateTime.Now.ToString();
                lvi.SubItems.Add(label1.Text);
                listView1.Items.Add(lvi);
            }
            if (weight > 1500) weight = 1;
            */

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            // 측정 버튼 활성화 여부 판단
            if (timer1.Enabled)
            {
                timer1.Stop();
                startbutton.Text = "측정시작";
            }
            else
            {
                timer1.Start();
                startbutton.Text = "측정중단";
            }
        }

        private void serialConnect_Click(object sender, EventArgs e)
        {
            if (SerialBox.Text != "" && !serialPort1.IsOpen)
            {
                serialPort1.PortName = SerialBox.Text;
                serialPort1.Open();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                byte[] recv = new byte[2];
                serialPort1.Read(recv, 0, 2);
                double weight = ((recv[0] * 256) + recv[1]) / 100.0;
                convWeight = weight * 9.81;

                if (subDatas >= weight) {
                    if (NtoKg == false)
                    {
                        label1.Text = weight.ToString() + "Kg";
                        chart1.Series[0].Points.Add(weight);
                    }
                    else
                    {
                        label1.Text = convWeight.ToString() + "N";
                        chart1.Series[0].Points.Add(weight);
                    }
                }

                ListViewItem lvi = new ListViewItem();
                lvi.Text = DateTime.Now.ToString();
                lvi.SubItems.Add(convWeight.ToString());
                lvi.SubItems.Add(weight.ToString());
                listView1.Items.Add(lvi);

                if (weight > 10) return;
                vScrollBar1.Value = 10 - (int)weight;
                isbusy = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            subDatas = Convert.ToInt32(subData.Text);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Application.Exit();

            // 오류 수정중
            if (serialPort1.IsOpen)
            {
                label1.Text = "0Kg";
                ListViewItem lvi = new ListViewItem();
                lvi.Remove();
                chart1.Series.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // 로고 더블 클릭시 프로그램 버전 표출
        {
            versionLabel.Visible = true;
        }

        private void convertExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv File|*.csv";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        for (int i = 0; i<listView1.Items.Count; i++)
                        {
                            string sTmp = "";
                            for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                            {
                                sTmp += listView1.Items[i].SubItems[j].Text + ", ";
                            }
                            sTmp += "\n";
                            Byte[] Bytes = Encoding.UTF8.GetBytes(sTmp);
                            fs.Write(Bytes, 0, Bytes.Length);
                        }
                        break;
                }
                fs.Close();
            }
        }

        private void NtoKgConvertBtn_Click(object sender, EventArgs e)
        {
            if (NtoKg == false)
            {
                NtoKg = true;
                label1.Text = "(NULL)N";
            }
            else
            {
                NtoKg = false;
                label1.Text = "(NULL)Kg";

            }
        }

        private void TimeCorrectionButton_Click(object sender, EventArgs e)
        {
            TimeCorrectionBox.Text = "아두이노에서 데이터 조절하는 방식으로 연구 중";
        }
    }
}
