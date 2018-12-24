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
            string sql = "select * from t_labels order by id";
            buttons = DbUtil.queryButtons(sql);
            this.dataGridView1.DataSource = DbUtil.queryButtons(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttons = (List < LabelItem >) this.dataGridView1.DataSource;
            DbUtil.saveButtons(buttons);
            FormMain f1 = (FormMain)this.Owner;
            f1.data_buttons();

            this.Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r > -1)
            {
                int c = e.ColumnIndex;
                if (c == 1)
                {
                    string name = dataGridView1.Rows[r].Cells[1].Value?.ToString();

                    for (int i = 0; i < buttons.Count; i++)
                    {
                        if (i != r)
                        {
                            if (!string.IsNullOrWhiteSpace(name) && name == buttons[i].name)
                            {
                                dataGridView1.Rows[r].Cells[1].Value = buttons[r].name;
                                MessageBox.Show("级别名称重复，请重新输入。");
                                break;
                            }
                        }
                    }
                }
                if (c == 2)
                {
                    string btn = dataGridView1.Rows[r].Cells[2].Value?.ToString();
                    if (!string.IsNullOrWhiteSpace(btn))
                    {
                        if(btn.Length > 1 || (btn.Length == 1 && !Regex.IsMatch(btn, "^[0-9a-zA-Z]+$")))
                        {
                            dataGridView1.Rows[r].Cells[2].Value = buttons[r].btn;
                            MessageBox.Show("快捷键只能设置一个数字或字母");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < buttons.Count; i++)
                        {
                            if (i != r)
                            {
                                if (!string.IsNullOrWhiteSpace(btn) && btn == buttons[i].btn)
                                {
                                    dataGridView1.Rows[r].Cells[2].Value = buttons[r].btn;
                                    MessageBox.Show("快捷键重复，请重新输入。");
                                    break;
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
