using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeighPig
{
    public partial class FormSettingLabels : Form
    {
        List<LabelItem> buttons { get; set; }
        public FormSettingLabels()
        {
            InitializeComponent();

            dataSource_labels();
        }

        /// <summary>
        /// 初始化按钮grid
        /// </summary>
        private void dataSource_labels()
        {
            string sql = "select * from t_labels where life_cycle = 1 order by id";
            buttons = DbUtil.queryButtons(sql);
            this.dataGridView1.DataSource = DbUtil.queryButtons(sql);
            this.dataGridView1.ClearSelection();
            this.toAdd();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                int r = this.dataGridView1.SelectedCells[0].RowIndex;
                this.input_name.Text = this.dataGridView1.Rows[r].Cells["name"].Value?.ToString();
                this.input_btn.Text = this.dataGridView1.Rows[r].Cells["btn"].Value?.ToString();
                this.button_add.Visible = false;
                this.button_del.Visible = true;
                this.button_save.Visible = true;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                int r = this.dataGridView1.SelectedCells[0].RowIndex;
                string name = this.input_name.Text;
                string btn = this.input_btn.Text;
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (i != r)
                    {
                        if (!string.IsNullOrWhiteSpace(name) && name == buttons[i].name)
                        {
                            this.input_name.Text = buttons[r].name;
                            MessageBox.Show("级别名称重复，请重新输入。");
                            return;
                        }
                    }
                }
                if (btn.Length > 1 || (btn.Length == 1 && !Regex.IsMatch(btn, "^[0-9a-zA-Z]+$")))
                {
                    this.input_btn.Text = buttons[r].btn;
                    MessageBox.Show("快捷键只能设置一个数字或字母");
                    return;
                }
                else
                {
                    for (int i = 0; i < buttons.Count; i++)
                    {
                        if (i != r)
                        {
                            if (!string.IsNullOrWhiteSpace(btn) && btn == buttons[i].btn)
                            {
                                this.input_btn.Text = buttons[r].btn;
                                MessageBox.Show("快捷键重复，请重新输入。");
                                return;
                            }
                        }
                    }
                }
                LabelItem labelItem = new LabelItem();
                labelItem.id = (int)this.dataGridView1.Rows[r].Cells["id"].Value;
                labelItem.name = name;
                labelItem.btn = btn;
                labelItem.life_cycle = 1;
                if (DbUtil.updateLabelItem(labelItem))
                {
                    this.dataSource_labels();
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

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_del_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                int r = this.dataGridView1.SelectedCells[0].RowIndex;
                LabelItem labelItem = new LabelItem();
                labelItem.id = (int)this.dataGridView1.Rows[r].Cells["id"].Value;
                labelItem.name = this.input_name.Text;
                labelItem.btn = this.input_btn.Text;
                labelItem.life_cycle = -1;
                if (DbUtil.updateLabelItem(labelItem))
                {
                    this.dataSource_labels();
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

        private void FormSettingLabels_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }

        /// <summary>
        /// 清除选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            this.toAdd();
        }

        private void toAdd()
        {
            this.button_add.Visible = true;
            this.button_del.Visible = false;
            this.button_save.Visible = false;
            this.input_name.Text = "";
            this.input_btn.Text = "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = this.input_name.Text;
            string btn = this.input_btn.Text;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(name) && name == buttons[i].name)
                {
                    this.input_name.Text = "";
                    MessageBox.Show("级别名称重复，请重新输入。");
                    return;
                }
            }
            if (btn.Length > 1 || (btn.Length == 1 && !Regex.IsMatch(btn, "^[0-9a-zA-Z]+$")))
            {
                this.input_btn.Text = "";
                MessageBox.Show("快捷键只能设置一个数字或字母");
                return;
            }
            else
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (!string.IsNullOrWhiteSpace(btn) && btn == buttons[i].btn)
                    {
                        this.input_btn.Text = "";
                        MessageBox.Show("快捷键重复，请重新输入。");
                        return;
                    }
                }
            }
            LabelItem labelItem = new LabelItem();
            labelItem.name = name;
            labelItem.btn = btn;
            labelItem.life_cycle = 1;
            if (DbUtil.insertLabelItem(labelItem))
            {
                this.dataSource_labels();
                MessageBox.Show("操作成功");
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void FormSettingLabels_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain f1 = (FormMain)this.Owner;
            f1.data_buttons();
        }
    }
}
