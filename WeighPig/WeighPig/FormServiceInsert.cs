using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeighPig
{
    public partial class FormServiceInsert : Form
    {
        public FormServiceInsert()
        {
            InitializeComponent();

            this.dataSource_labels();

            this.dataSource_weights();
        }

        /// <summary>
        /// 初始化级别
        /// </summary>
        private void dataSource_labels()
        {
            this.combobox_labels.DataSource = DbUtil.queryButtons("select * from t_labels order by id");
            this.combobox_labels.DisplayMember = "name";
        }

        /// <summary>
        /// 初始化明细grid
        /// </summary>
        private void dataSource_weights()
        {
            this.grid_weights.DataSource = DbUtil.queryWeights("select * from t_weights where life_cycle=1 and DATE(create_time) = '" + this.input_date.Value.ToString("yyyy-MM-dd") + "' order by sn;");
            this.grid_weights.ClearSelection();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Weights weights = new Weights();
            string sn = this.input_sn.Text;
            int sn_result;
            if (sn != "" && int.TryParse(sn, out sn_result))
            {
                weights.sn = sn_result;
            }
            else
            {
                MessageBox.Show("流水号必须为整数数字");
                return;
            }
            string weight = this.input_weight.Text;
            double weight_result;
            if (weight != "" && double.TryParse(weight, out weight_result))
            {
                weights.weight = weight_result.ToString("0.00");
            }
            else
            {
                MessageBox.Show("重量必须为数字");
                return;
            }
            weights.create_time = this.input_date.Value.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss");
            weights.level = this.combobox_labels.Text;
            weights.remarks = this.input_remarks.Text;
            weights.type = "白条";
            weights.is_upload = 0;
            weights.life_cycle = 1;
            weights.is_handwrite = 1;
            if (DbUtil.insertWeight(weights))
            {
                this.dataSource_weights();
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void FormServiceInsert_Load(object sender, EventArgs e)
        {
            this.grid_weights.ClearSelection();
        }

        private void FormServiceInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain f1 = (FormMain)this.Owner;
            f1.dataSource_weights();
        }
    }
}
