namespace SoccerRobotScoreboard2
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPortBluetooth = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRed
            // 
            this.labelRed.BackColor = System.Drawing.SystemColors.Control;
            this.labelRed.Font = new System.Drawing.Font("MS UI Gothic", 700F);
            this.labelRed.ForeColor = System.Drawing.Color.Red;
            this.labelRed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRed.Location = new System.Drawing.Point(0, 69);
            this.labelRed.Margin = new System.Windows.Forms.Padding(0);
            this.labelRed.Name = "labelRed";
            this.labelRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRed.Size = new System.Drawing.Size(770, 934);
            this.labelRed.TabIndex = 0;
            this.labelRed.Text = "0";
            this.labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBlue
            // 
            this.labelBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBlue.BackColor = System.Drawing.SystemColors.Control;
            this.labelBlue.Font = new System.Drawing.Font("MS UI Gothic", 700F);
            this.labelBlue.ForeColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(1150, 69);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(770, 934);
            this.labelBlue.TabIndex = 0;
            this.labelBlue.Text = "0";
            this.labelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 500F);
            this.label1.Location = new System.Drawing.Point(654, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 667);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 150F);
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1920, 199);
            this.label2.TabIndex = 4;
            this.label2.Text = "サッカーロボット";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPortBluetooth
            // 
            this.serialPortBluetooth.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortBluetooth_DataReceived);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPort.TabIndex = 5;
            this.comboBoxPort.Text = "COMポート選択";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(139, 10);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "ポート開放";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "サッカーロボット得点板";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPortBluetooth;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonConnect;
    }
}

