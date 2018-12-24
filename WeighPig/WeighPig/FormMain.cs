using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        SerialPort serialPort1 { get; set; }
        public delegate void Displaydelegate(byte[] InputBuf);
        Byte[] OutputBuf = new Byte[128];
        public Displaydelegate disp_delegate;

        List<LabelItem> buttons { get; set; }
        string today = DateTime.Now.ToString("yyyy-MM-dd");
        int ssn { get; set; }

        public FormMain()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.data_buttons();

            this.dataSource_weights();

            ssn = this.grid_weights.RowCount;

            this.open_port();
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
                disp_delegate = new Displaydelegate(DispUI);
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(Comm_DataReceived);
                serialPort1.ErrorReceived += new SerialErrorReceivedEventHandler(Comm_ErrorReceived);
                serialPort1.PinChanged += new SerialPinChangedEventHandler(Comm_PinChangedReceived);
                serialPort1.Open();
                this.pictureBox1.Image = Image.FromFile(@".\lv.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pictureBox1.Image = Image.FromFile(@".\hui.png");
            }
        }

        /// <summary>
        /// 获取port数据信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] InputBuf = new Byte[12];

            try
            {
                serialPort1.Read(InputBuf, 0, serialPort1.BytesToRead);

                string weightStr = "";
                try
                {
                    Thread.Sleep(100);
                    string str = encoding.GetString(InputBuf);
                    if (str.Substring(0, 1) == "+")
                    {
                        double p = double.Parse(str.Substring(7, 1));
                        double num = double.Parse(str.Substring(1, 6));
                        double result = num / Math.Pow(10, p);
                        weightStr = result.ToString("0.00");
                    }
                    if (str.Substring(1, 1) == "+")
                    {
                        double p = double.Parse(str.Substring(8, 1));
                        double num = double.Parse(str.Substring(2, 6));
                        double result = num / Math.Pow(10, p);
                        weightStr = result.ToString("0.00");
                    }
                    this.save_weight(weightStr);


                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                this.Invoke(disp_delegate, InputBuf);

            }
            catch (TimeoutException ex)         //超时处理  
            {
                MessageBox.Show(ex.Message);
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
        /// 解析并回显数据
        /// </summary>
        /// <param name="InputBuf"></param>
        private void DispUI(Byte[] InputBuf)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string weightStr = "";
            this.textBox1.Text = this.textBox1.Text + encoding.GetString(InputBuf);
            try
            {
                string str = encoding.GetString(InputBuf);
                if (str.Substring(0, 1) == "+")
                {
                    double p = double.Parse(str.Substring(7, 1));
                    double num = double.Parse(str.Substring(1, 6));
                    double result = num / Math.Pow(10, p);
                    weightStr = result.ToString("0.00");
                }
                if (str.Substring(1, 1) == "+")
                {
                    double p = double.Parse(str.Substring(8, 1));
                    double num = double.Parse(str.Substring(2, 6));
                    double result = num / Math.Pow(10, p);
                    weightStr = result.ToString("0.00");
                }
                this.label_weight.Text = weightStr;
            }
            catch
            {

            }
        }

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
            this.grid_weights.DataSource = DbUtil.queryWeights("select * from t_weights where life_cycle=1 and DATE(create_time) = '" + today + "' order by sn desc;");
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
                Weights weights = new Weights();
                weights.sn = ssn;
                weights.create_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                weights.weight = weightStr;
                weights.level = "";
                weights.remarks = this.input_remarks.Text;
                weights.type = "白条";
                weights.is_upload = 0;
                weights.life_cycle = 1;
                if (DbUtil.insertWeight(weights))
                {
                    this.dataSource_weights();
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
                this.dataSource_weights();
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
                    this.dataSource_weights();
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
    }
}
