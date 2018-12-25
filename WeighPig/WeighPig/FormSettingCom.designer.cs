namespace WeighPig
{
    partial class FormSettingCom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.comBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "奇偶校验";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comParity
            // 
            this.comParity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comParity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeighPig.Properties.Settings.Default, "comParity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comParity.FormattingEnabled = true;
            this.comParity.Items.AddRange(new object[] {
            "无",
            "奇",
            "偶"});
            this.comParity.Location = new System.Drawing.Point(114, 105);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(121, 20);
            this.comParity.TabIndex = 5;
            this.comParity.Text = global::WeighPig.Properties.Settings.Default.comParity;
            // 
            // comBaudRate
            // 
            this.comBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBaudRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeighPig.Properties.Settings.Default, "comBaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comBaudRate.FormattingEnabled = true;
            this.comBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comBaudRate.Location = new System.Drawing.Point(114, 58);
            this.comBaudRate.Name = "comBaudRate";
            this.comBaudRate.Size = new System.Drawing.Size(121, 20);
            this.comBaudRate.TabIndex = 3;
            this.comBaudRate.Text = "9600";
            // 
            // cmbPort
            // 
            this.cmbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeighPig.Properties.Settings.Default, "cmbPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(114, 13);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 20);
            this.cmbPort.TabIndex = 1;
            this.cmbPort.Text = global::WeighPig.Properties.Settings.Default.cmbPort;
            // 
            // FormSettingCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comParity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSettingCom";
            this.Text = "串口设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.Button button1;
    }
}