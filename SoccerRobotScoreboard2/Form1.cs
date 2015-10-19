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
        private SerialPort BT = null;
        int RedPoint = 0;
        int BluePoint = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void DispPoint()
        {
            labelRed.Text = RedPoint.ToString();
            labelBlue.Text = BluePoint.ToString();
        }

        private void Exit()
        {
            if (BT != null)
            {
                BT.Close();
            }
            this.Close();
        }

        private void ToolStripMenuItemSetting_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Exit();
            }

        }

    }
}
