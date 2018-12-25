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
    public partial class FormServiceUpdate : Form
    {
        public FormServiceUpdate()
        {
            InitializeComponent();

            this.dataSource_labels();

            this.dataSource_weights();
        }

        /// <summary>
        /// 改变日期控件的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_date_ValueChanged(object sender, EventArgs e)
        {
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

        /// <summary>
        /// 选中行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_weights_Click(object sender, EventArgs e)
        {
            if (this.grid_weights.SelectedCells.Count != 0)
            {
                int r = this.grid_weights.SelectedCells[0].RowIndex;
                this.combobox_labels.Text = this.grid_weights.Rows[r].Cells["level"].Value?.ToString();
                this.input_remarks.Text = this.grid_weights.Rows[r].Cells["remarks"].Value?.ToString();
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.grid_weights.SelectedCells.Count != 0)
            {
                int r = this.grid_weights.SelectedCells[0].RowIndex;
                Weights weights = new Weights();
                weights.id = (int)this.grid_weights.Rows[r].Cells["id"].Value;
                weights.sn = (int)this.grid_weights.Rows[r].Cells["sn"].Value;
                weights.weight = (string)this.grid_weights.Rows[r].Cells["weight"].Value;
                weights.level = this.combobox_labels.Text;
                weights.remarks = this.input_remarks.Text;
                weights.type = (string)this.grid_weights.Rows[r].Cells["type"].Value;
                weights.is_upload = (int)this.grid_weights.Rows[r].Cells["is_upload"].Value;
                weights.life_cycle = 1;
                if (DbUtil.updateWeight(weights))
                {
                    this.dataSource_weights();
                    MessageBox.Show("操作成功");
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
            else
            {
                MessageBox.Show("请选择一条数据");
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (this.grid_weights.SelectedCells.Count != 0)
            {
                int r = this.grid_weights.SelectedCells[0].RowIndex;
                Weights weights = new Weights();
                weights.id = (int)this.grid_weights.Rows[r].Cells["id"].Value;
                weights.sn = (int)this.grid_weights.Rows[r].Cells["sn"].Value;
                weights.weight = (string)this.grid_weights.Rows[r].Cells["weight"].Value;
                weights.level = this.combobox_labels.Text;
                weights.remarks = this.input_remarks.Text;
                weights.type = (string)this.grid_weights.Rows[r].Cells["type"].Value;
                weights.is_upload = (int)this.grid_weights.Rows[r].Cells["is_upload"].Value;
                weights.life_cycle = -1;
                if (DbUtil.updateWeight(weights))
                {
                    this.dataSource_weights();
                    MessageBox.Show("操作成功");
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
            else
            {
                MessageBox.Show("请选择一条数据");
            }
        }

        private void FormServiceUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain f1 = (FormMain)this.Owner;
            f1.dataSource_weights();
        }

        private void FormServiceUpdate_Load(object sender, EventArgs e)
        {
            this.grid_weights.ClearSelection();
        }
    }
}
