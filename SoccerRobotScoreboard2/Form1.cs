using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SoccerRobotScoreboard2
{
    public partial class FormMain : Form
    {
        SerialPort myPort = null;
        String rData = null;
        int RedPoint = 0;
        int BluePoint = 0;

        public FormMain()
        {
            InitializeComponent();
            this.buttonConnect.Focus();
        }

        public void SerialInit()
        {
            myPort = new SerialPort();
            myPort.PortName = comboBoxPort.SelectedItem.ToString();
            myPort.BaudRate = int.Parse("9600");
            myPort.DataBits = 8;
            myPort.NewLine = "\r\n";
            myPort.ReceivedBytesThreshold = 1;
            myPort.Encoding = System.Text.Encoding.UTF8;
        }

        private void DispPoint()
        {
            labelRed.Text = RedPoint.ToString();
            labelBlue.Text = BluePoint.ToString();
        }

        private void Exit()
        {
            if (myPort != null)
            {
                myPort.Close();
            }
        }

        private void receivedDataAdd(object sender, EventArgs e)
        {
            if (rData.Equals("AR"))
            {
                RedPoint = 0;
                BluePoint = 0;
                DispPoint();
            }
            else if (rData.Equals("RR"))
            {
                RedPoint = 0;
                DispPoint();
            }
            else if (rData.Equals("BR"))
            {
                BluePoint = 0;
                DispPoint();
            }

            else if (rData.Equals("RI"))
            {
                RedPoint++;
                if (RedPoint >= 10) RedPoint = 9;
                DispPoint();
            }
            else if (rData.Equals("RD"))
            {
                RedPoint--;
                if (RedPoint < 0) RedPoint = 0;
                DispPoint();
            }
            else if (rData.Equals("BI"))
            {
                BluePoint++;
                if (BluePoint >= 10) BluePoint = 9;
                DispPoint();
            }
            else if (rData.Equals("BD"))
            {
                BluePoint--;
                if (BluePoint < 0) BluePoint = 0;
                DispPoint();
            }
            else if (rData.Substring(0, 1) == "T")
            {
                label2.Text = rData.Substring(1, rData.Length-1);
            }
        }

        private void serialPortBluetooth_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            myPort = (SerialPort)sender;
            rData = myPort.ReadExisting();
            this.Invoke(new EventHandler(receivedDataAdd));
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            foreach (var port in SerialPort.GetPortNames())
            {
                comboBoxPort.Items.Add(port);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.SelectedIndex == -1)
            {
                MessageBox.Show("COMポートを選択してください");
            }
            else
            {
                SerialInit();
                myPort.Open();
                if (myPort.IsOpen.Equals(false))
                {
                    MessageBox.Show("ポート開放に失敗しました", "ポート解放エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    myPort.DataReceived += new SerialDataReceivedEventHandler(serialPortBluetooth_DataReceived);
                    MessageBox.Show("ポート開放完了", "ポート開放", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxPort.Visible = false;
                    buttonConnect.Visible = false;
                }
            }
        }


    }
}
