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

            if (result.Length < 12)
            {
                result += Encoding.ASCII.GetString(sp.Data);
            }
            if (result.Length == 12)
            {
                this.txtData.AppendText(result);
                this.txtData.AppendText(";");

                try
                {
                    double p = double.Parse(result.Substring(8, 1));
                    double num = double.Parse(result.Substring(2, 6));
                    double weight_result = (num / Math.Pow(10, p));
                    this.save_weight(weight_result);
                    this.showWeight(weight_result);
                }
                catch
                {

                }

                result = "";
            }

            Debug.Write(Encoding.ASCII.GetString(sp.Data));
        }

        private void showWeight(double weight_result)
        {
            this.label_weight.Text = weight_result.ToString("0.00");
        }
        private void addGridRow(Weights w)
        {
            w.row_num = this.grid_weights.RowCount + 1;
            weights.Add(w);
            this.grid_weights.DataSource = new List<Weights>();
            this.grid_weights.DataSource = weights;
            this.grid_weights.ClearSelection();
            this.grid_weights.FirstDisplayedScrollingRowIndex = this.grid_weights.Rows.Count - 1;
        }

        /// <summary>
        /// 开启port
        /// </summary>
        public void open_port()
        {
            try
            {
                if (serialPort1 != null && serialPort1.IsOpen)
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
        /// 初始化按钮
        /// </summary>
        public void data_buttons()
        {
            this.panel_button.Controls.Clear();
            buttons = DbUtil.queryButtons("select * from t_labels where life_cycle = 1 order by id");
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
        public void dataSource_weights()
        {
            weights = DbUtil.queryWeights("select w.*, (@i:=@i+1) i from t_weights w,(select @i:=0) t2 where life_cycle=1 and DATE(create_time) = '" + today + "' order by sn;");
            this.grid_weights.DataSource = weights;
            this.grid_weights.ClearSelection();
            if(this.grid_weights.RowCount > 0)
            {
                this.grid_weights.FirstDisplayedScrollingRowIndex = this.grid_weights.Rows.Count - 1;
            }

            if (this.grid_weights.RowCount > 0)
            {
                ssn = (int)this.grid_weights.Rows[this.grid_weights.RowCount - 1].Cells["sn"].Value;
            }
            else
            {
                ssn = 0;
            }
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
        private void save_weight(double weight_result)
        {
            if (weight_result > 15)
            {
                ssn++;
                Weights w = new Weights();
                w.id = Guid.NewGuid().ToString();
                w.sn = ssn;
                w.create_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                w.weight = weight_result.ToString("0.00");
                w.level = "";
                w.remarks = this.input_remarks.Text;
                w.type = "白条";
                w.is_upload = 0;
                w.life_cycle = 1;
                w.is_handwrite = 0;
                if (DbUtil.insertWeight(w))
                {
                    if (this.grid_weights.RowCount == 0)
                    {
                        this.dataSource_weights();
                    }
                    else
                    {
                        this.addGridRow(w);
                    }
                    //MessageBox.Show("操作成功");
                }
                else
                {
                    //MessageBox.Show("操作失败");
                }
            }
        }
        /// <summary>
        /// 更新级别
        /// </summary>
        private void update_weight_level(string levelStr)
        {
            string id = (string)this.grid_weights.Rows[this.grid_weights.RowCount - 1].Cells["id"].Value;
            string sql = "update t_weights set level='" + levelStr + "' where id = '" + id + "'";

            if (DbUtil.edit(sql))
            {
                this.grid_weights.Rows[this.grid_weights.RowCount - 1].Cells["level"].Value = levelStr;
                //MessageBox.Show("操作成功");
            }
            else
            {
                //MessageBox.Show("操作失败");
            }
        }

        /// <summary>
        /// 级别设置
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
                string id = (string)this.grid_weights.Rows[this.grid_weights.RowCount - 1].Cells["id"].Value;
                string sql = "update t_weights set remarks='" + test.Text + "' where id = '" + id + "'";

                if (DbUtil.edit(sql))
                {
                    this.grid_weights.Rows[this.grid_weights.RowCount - 1].Cells["remarks"].Value = test.Text;
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

        private void button_excel_Click(object sender, EventArgs e)
        {
            this.dataSource_weights();
            ExportExcels(today, this.grid_weights);
        }
        private void ExportExcels(string fileName, DataGridView myDGV)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0)
            {
                return; //被点了取消
            }
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
            List<Weights> list = DbUtil.queryWeights("select w.*, (@i:=@i+1) i from t_weights w,(select @i:=0) t2 where life_cycle=1 and DATE(create_time) = '" + today + "' order by sn;");                                                                                                    //写入标题
            worksheet.Cells[1, 1] = "序号";
            worksheet.Cells[1, 2] = "顺序号";
            worksheet.Cells[1, 3] = "时间";
            worksheet.Cells[1, 4] = "重量";
            worksheet.Cells[1, 5] = "级别";
            worksheet.Cells[1, 6] = "备注";
            worksheet.Cells[1, 7] = "工艺";
            worksheet.Cells[1, 8] = "上传";
            worksheet.Cells[1, 9] = "补录";
            for (int r = 0; r < list.Count; r++)
            {
                worksheet.Cells[r + 2, 1] = list[r].row_num;
                worksheet.Cells[r + 2, 2] = list[r].sn;
                worksheet.Cells[r + 2, 3] = list[r].create_time;
                worksheet.Cells[r + 2, 4] = list[r].weight;
                worksheet.Cells[r + 2, 5] = list[r].level;
                worksheet.Cells[r + 2, 6] = list[r].remarks;
                worksheet.Cells[r + 2, 7] = list[r].type;
                worksheet.Cells[r + 2, 8] = list[r].is_upload;
                worksheet.Cells[r + 2, 9] = list[r].is_handwrite;
            }
            //for (int i = 0; i < myDGV.ColumnCount; i++)
            //{
            //    if (myDGV.Columns[i].Visible)
            //    {
            //        worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
            //    }
            //}
            ////写入数值
            //for (int r = 0; r < myDGV.Rows.Count; r++)
            //{
            //    for (int i = 0; i < myDGV.ColumnCount; i++)
            //    {
            //        if (myDGV.Rows[r].Cells[i].Visible)
            //        {
            //            worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
            //        }
            //    }
            //    System.Windows.Forms.Application.DoEvents();
            //}
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int DeskHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Height = DeskHeight - 100;
            this.grid_weights.Height = DeskHeight - 400;
            this.grid_weights.ClearSelection();
        }

        /// <summary>
        /// 补录数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void service_insert_Click(object sender, EventArgs e)
        {
            FormServiceInsert form = new FormServiceInsert();
            form.Owner = this;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Weights w = new Weights();
            w.id = Guid.NewGuid().ToString();
            w.sn = ssn;
            w.create_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            w.weight = "0.00";
            w.level = "";
            w.remarks = this.input_remarks.Text;
            w.type = "白条";
            w.is_upload = 0;
            w.life_cycle = 1;
            w.is_handwrite = 0;
            this.addGridRow(w);
        }
    }
}
