using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeighPig
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 { get; set; }
        public delegate void Displaydelegate(byte[] InputBuf);
        Byte[] OutputBuf = new Byte[128];
        public Displaydelegate disp_delegate;

        List<LabelItem> buttons { get; set; }
        public Form1()
        {
            InitializeComponent();

            this.input_date.Value = DateTime.Now;

            this.data_buttons();

            this.dataSource_weights();

            this.dataSource_reports();

            this.KeyPreview = true;

            this.open_port();
        }

        /// <summary>
        /// 点击设置com
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void com_setting_Click(object sender, EventArgs e)
        {
            FormSettingCom form = new FormSettingCom();
            form.Owner = this;
            form.ShowDialog();
        }
        /// <summary>
        /// 开启port
        /// </summary>
        private void open_port()
        {
            try
            {
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
        /// 点击按钮设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setting_Click(object sender, EventArgs e)
        {
            FormSettingLabels form = new FormSettingLabels();
            form.Owner = this;
            form.ShowDialog();
        }

        /// <summary>
        /// 改变日期控件的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_date_ValueChanged(object sender, EventArgs e)
        {
            this.dataSource_weights();
            this.dataSource_reports();
            this.label_readonly.Visible = this.input_date.Value.Date != DateTime.Now.Date;
        }

        /// <summary>
        /// 获取port数据信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Byte[] InputBuf = new Byte[10];

            try
            {
                serialPort1.Read(InputBuf, 0, serialPort1.BytesToRead);                                //读取缓冲区的数据直到“}”即0x7D为结束符  
                //InputBuf = UnicodeEncoding.Default.GetBytes(strRD);             //将得到的数据转换成byte的格式  
                this.Invoke(disp_delegate, InputBuf);

            }
            catch (TimeoutException ex)         //超时处理  
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 解析并回显数据
        /// </summary>
        /// <param name="InputBuf"></param>
        private void DispUI(byte[] InputBuf)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string str = encoding.GetString(InputBuf);
            if(str.Length == 12)
            {
                double p = double.Parse(str.Substring(8, 1));
                double num = double.Parse(str.Substring(2, 6));
                double result = num / Math.Pow(10, p);
                if(result > 15)
                {
                    this.label_weight.Text = result.ToString("0.00");
                    save_weight();
                }
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
                if (!string.IsNullOrWhiteSpace(item.name)) { 
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
            this.grid_weights.DataSource = DbUtil.queryWeights("select * from t_weights where DATE(create_time) = '" + this.input_date.Value.ToString("yyyy-MM-dd") + "' order by id;");
        }

        /// <summary>
        /// 初始化统计grid
        /// </summary>
        private void dataSource_reports()
        {
            this.grid_reports.DataSource = DbUtil.queryReports("select level, count(1), sum(weight) from t_weights where DATE(create_time) = '" + this.input_date.Value.ToString("yyyy-MM-dd") + "' group by level; ");
        }

        /// <summary>
        /// 点击类别按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_btn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.input_level.Text = button.Text;
            if (double.Parse(this.label_weight.Text) > 15)
            {
                update_weight();
            }
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
                            this.input_level.Text = button.Text;
                            if (double.Parse(this.label_weight.Text) > 15)
                            {
                                update_weight();
                            }
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 保存明细数据
        /// </summary>
        private void save_weight()
        {
            if(this.input_date.Value.Date == DateTime.Now.Date)
            {
                Weights weights = new Weights();
                weights.sn = this.grid_weights.RowCount + 1;
                weights.create_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                weights.weight = this.label_weight.Text;
                weights.level = this.input_level.Text;
                weights.remarks = this.input_remarks.Text;
                weights.type = "白条";
                if (DbUtil.insertWeight(weights))
                {
                    this.dataSource_weights();
                    this.dataSource_reports();
                    MessageBox.Show("操作成功");
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
                this.input_level.Text = "";
            }
        }
        /// <summary>
        /// 下一条数据前更新明细数据
        /// </summary>
        private void update_weight()
        {
            Weights weights = new Weights();
            weights.sn = this.grid_weights.RowCount;
            weights.weight = this.label_weight.Text;
            weights.level = this.input_level.Text;
            weights.remarks = this.input_remarks.Text;
            weights.type = "白条";
            //if (DbUtil.updateWeight(weights, "where sn='" + weights.sn + "' and  DATE(create_time) = '" + this.input_date.Value.ToString("yyyy-MM-dd") + "'"))
            //{
            //    this.dataSource_weights();
            //    this.dataSource_reports();
            //    MessageBox.Show("操作成功");
            //}
            //else
            //{
            //    MessageBox.Show("操作失败");
            //}
            this.input_level.Text = "";
        }
    }
}
