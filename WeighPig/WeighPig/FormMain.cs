using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeighPig
{
    public partial class FormMain : Form
    {
        static SerialPort serialPort1 { get; set; }
        public delegate void Displaydelegate(byte[] InputBuf);
        Byte[] OutputBuf = new Byte[128];

        /// <summary>
        /// 按钮集合
        /// </summary>
        List<LabelItem> buttons { get; set; }
        /// <summary>
        /// 明细集合
        /// </summary>
        List<Weights> weights { get; set; }
        /// <summary>
        /// 当前日期
        /// </summary>
        string today = DateTime.Now.ToString("yyyy-MM-dd");
        /// <summary>
        /// 当前流水号
        /// </summary>
        int ssn { get; set; }

        public static BackgroundWorker bw = new BackgroundWorker();

        public FormMain()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.data_buttons();

            this.dataSource_weights();

            ssn = this.grid_weights.RowCount;

            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;

            this.open_port();
        }

        private static void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var buffer = new byte[12];

            while (!bw.CancellationPending)
            {
                try
                {
                    var c = serialPort1.Read(buffer, 0, buffer.Length);

                    bw.ReportProgress(0, new SerialProgress() { Data = buffer.Take(c).ToArray() });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Debug.WriteLine("Bw1_DoWork complete");
        }
        string result = "";
        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var sp = e.UserState as SerialProgress;

            if(result.Length < 12)
            {
                result += Encoding.ASCII.GetString(sp.Data);
            }
            if(result.Length == 12)
            {
                this.txtData.AppendText(result);
                this.txtData.AppendText(";");

                string weightStr = "";
                try
                {
                    double p = double.Parse(result.Substring(8, 1));
                    double num = double.Parse(result.Substring(2, 6));
                    weightStr = (num / Math.Pow(10, p)).ToString("0.00");
                    this.save_weight(weightStr);
                    this.showWeight(weightStr);
                }
                catch
                {

                }

                result = "";
            }

            Debug.Write(Encoding.ASCII.GetString(sp.Data));
        }

        private void showWeight(string weightStr)
        {
            this.label_weight.Text = weightStr;
        }
        private void addGridRow(Weights w)
        {
            if (weights.Count == 0)
            {
                weights.Add(w);
            }
            else
            {
                weights.Insert(0, w);
            }
            this.grid_weights.DataSource = null;
            this.grid_weights.DataSource = weights;
        }

        /// <summary>
        /// 开启port
        /// </summary>
        public void open_port()
        {
            try
            {
                if(serialPort1 != null && serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                string port = global::WeighPig.Properties.Settings.Default.cmbPort;
                int baudRate = global::WeighPig.Properties.Settings.Default.comBaudRate;
                string parityStr = global::WeighPig.Properties.Settings.Default.comParity;
                Parity parity = Parity.None;
                if (parityStr == "奇")
                {
                    parity = Parity.Odd;
                }
                else if (parityStr == "偶")
                {
                    parity = Parity.Even;
                }

                serialPort1 = new SerialPort(port, baudRate, parity, 8, StopBits.One);
                //disp_delegate = new Displaydelegate(DispUI);
                //serialPort1.DataReceived += new SerialDataReceivedEventHandler(Comm_DataReceived);
                serialPort1.ErrorReceived += new SerialErrorReceivedEventHandler(Comm_ErrorReceived);
                serialPort1.PinChanged += new SerialPinChangedEventHandler(Comm_PinChangedReceived);
                serialPort1.Open();
                bw.RunWorkerAsync();
                this.pictureBox1.Image = Image.FromFile(@".\lv.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pictureBox1.Image = Image.FromFile(@".\hui.png");
            }
        }

        /// <summary>
        /// 接收错误信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Comm_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("端口发生错误，请重新连接");
        }
        private void Comm_PinChangedReceived(object sender, SerialPinChangedEventArgs e)
        {
            MessageBox.Show("端口发生错误，请重新连接");
        }

        /// <summary>
        /// 获取port数据信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void Comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{

        //    ASCIIEncoding encoding = new ASCIIEncoding();
        //    Byte[] InputBuf = new Byte[12];

        //    try
        //    {
        //        serialPort1.Read(InputBuf, 0, serialPort1.BytesToRead);

        //        string weightStr = "";
        //        try
        //        {
        //            Thread.Sleep(100);
        //            string str = encoding.GetString(InputBuf);
        //            if (str.Substring(0, 1) == "+")
        //            {
        //                double p = double.Parse(str.Substring(7, 1));
        //                double num = double.Parse(str.Substring(1, 6));
        //                double result = num / Math.Pow(10, p);
        //                weightStr = result.ToString("0.00");
        //            }
        //            if (str.Substring(1, 1) == "+")
        //            {
        //                double p = double.Parse(str.Substring(8, 1));
        //                double num = double.Parse(str.Substring(2, 6));
        //                double result = num / Math.Pow(10, p);
        //                weightStr = result.ToString("0.00");
        //            }
        //            this.save_weight(weightStr);


        //        }
        //        catch (Exception ex)
        //        {
        //            //MessageBox.Show(ex.Message);
        //        }
        //        this.Invoke(disp_delegate, InputBuf);

        //    }
        //    catch (TimeoutException ex)         //超时处理  
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        /// <summary>
        /// 解析并回显数据
        /// </summary>
        /// <param name="InputBuf"></param>
        //private void DispUI(Byte[] InputBuf)
        //{
        //    ASCIIEncoding encoding = new ASCIIEncoding();
        //    string weightStr = "";
        //    this.textBox1.Text = this.textBox1.Text + encoding.GetString(InputBuf);
        //    try
        //    {
        //        string str = encoding.GetString(InputBuf);
        //        if (str.Substring(0, 1) == "+")
        //        {
        //            double p = double.Parse(str.Substring(7, 1));
        //            double num = double.Parse(str.Substring(1, 6));
        //            double result = num / Math.Pow(10, p);
        //            weightStr = result.ToString("0.00");
        //        }
        //        if (str.Substring(1, 1) == "+")
        //        {
        //            double p = double.Parse(str.Substring(8, 1));
        //            double num = double.Parse(str.Substring(2, 6));
        //            double result = num / Math.Pow(10, p);
        //            weightStr = result.ToString("0.00");
        //        }
        //        this.label_weight.Text = weightStr;
        //    }
        //    catch
        //    {

        //    }
        //}

        /// <summary>
        /// 初始化按钮
        /// </summary>
        public void data_buttons()
        {
            this.panel_button.Controls.Clear();
            buttons = DbUtil.queryButtons("select * from t_labels order by id");
            int i = 0;
            foreach (LabelItem item in buttons)
            {
                if (!string.IsNullOrWhiteSpace(item.name))
                {
                    Button b = new Button();
                    b.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    b.Location = new System.Drawing.Point(60 * (i % 5), 30 * (i / 5));
                    b.Name = item.btn;
                    b.Size = new System.Drawing.Size(52, 23);
                    b.TabIndex = 3;
                    b.Text = item.name;
                    b.UseVisualStyleBackColor = true;
                    b.Click += new System.EventHandler(this.save_btn);
                    this.panel_button.Controls.Add(b);
                    i++;
                }
            }
        }

        /// <summary>
        /// 初始化明细grid
        /// </summary>
        private void dataSource_weights()
        {
            weights = DbUtil.queryWeights("select * from t_weights where life_cycle=1 and DATE(create_time) = '" + today + "' order by sn desc;");
            this.grid_weights.DataSource = weights;
            this.grid_weights.ClearSelection();
        }

        /// <summary>
        /// 点击类别按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_btn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            update_weight_level(button.Text);
        }

        /// <summary>
        /// 键盘操作
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (!this.input_remarks.Focused)
            {
                foreach (Control c in this.panel_button.Controls)
                {
                    //第一种情况：button在窗体上
                    Button button = c as Button;
                    if (button != null)
                    {
                        if (e.KeyCode.ToString() == button.Name.ToUpper() || e.KeyCode.ToString() == "D" + button.Name || e.KeyCode.ToString() == "NumPad" + button.Name)
                        {
                            update_weight_level(button.Text);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 保存明细数据
        /// </summary>
        private void save_weight(string weightStr)
        {
            if (double.Parse(weightStr) > 0)
            {
                ssn++;
                Weights w = new Weights();
                w.sn = ssn;
                w.create_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                w.weight = weightStr;
                w.level = "";
                w.remarks = this.input_remarks.Text;
                w.type = "白条";
                w.is_upload = 0;
                w.life_cycle = 1;
                if (DbUtil.insertWeight(w))
                {
                    this.addGridRow(w);
                    //MessageBox.Show("操作成功");
                }
                else
                {
                    //MessageBox.Show("操作失败");
                }
            }
        }
        /// <summary>
        /// 下一条数据前更新明细数据
        /// </summary>
        private void update_weight_level(string levelStr)
        {
            string sql = "update t_weights set level='" + levelStr + "' where sn = '" + ssn + "' and  DATE(create_time) = '" + today + "'";

            if (DbUtil.edit(sql))
            {
                this.grid_weights.Rows[0].Cells["level"].Value = levelStr;
                //MessageBox.Show("操作成功");
            }
            else
            {
                //MessageBox.Show("操作失败");
            }
        }

        /// <summary>
        /// 标签设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setting_labels_Click(object sender, EventArgs e)
        {
            FormSettingLabels form = new FormSettingLabels();
            form.Owner = this;
            form.ShowDialog();
        }

        /// <summary>
        /// 串口设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setting_com_Click(object sender, EventArgs e)
        {
            FormSettingCom form = new FormSettingCom();
            form.Owner = this;
            form.ShowDialog();
        }

        /// <summary>
        /// 重新连接串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setting_restart_Click(object sender, EventArgs e)
        {
            this.open_port();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void service_select_Click(object sender, EventArgs e)
        {
            FormServiceSelect form = new FormServiceSelect();
            form.ShowDialog();
        }


        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void service_update_Click(object sender, EventArgs e)
        {
            FormServiceUpdate form = new FormServiceUpdate();
            form.Owner = this;
            form.ShowDialog();
        }

        private void input_remarks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox test = (TextBox)sender;
                string sql = "update t_weights set remarks='" + test.Text + "' where sn = '" + ssn + "' and  DATE(create_time) = '" + today + "'";

                if (DbUtil.edit(sql))
                {
                    this.grid_weights.Rows[0].Cells["remarks"].Value = test.Text;
                    //MessageBox.Show("操作成功");
                }
                else
                {
                    //MessageBox.Show("操作失败");
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1 != null && serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weights w = new Weights();
            w.id = ssn++;
        }
    }
}
