using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeighPig
{
    public partial class FormSettingCom : Form
    {
        public FormSettingCom()
        {
            InitializeComponent();

            cmbPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            //Application.ExitThread();
            //Application.Exit();
            //Application.Restart();
            //Process.GetCurrentProcess().Kill();
            FormMain f1 = (FormMain)this.Owner;
            f1.open_port();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
