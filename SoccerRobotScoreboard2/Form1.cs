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
        private SerialPort myPort = null;
        int RedPoint = 0;
        int BluePoint = 0;

        public FormMain()
        {
            InitializeComponent();
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


        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    MessageBox.Show("ポート開放完了", "ポート開放", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxPort.Visible = false;
                    buttonConnect.Visible = false;
                }
            }
        }
    }
}
