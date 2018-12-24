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
    public partial class FormServiceSelect : Form
    {
        public FormServiceSelect()
        {
            InitializeComponent();

            this.dataSource_weights();

            this.dataSource_reports();
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
        /// 初始化统计grid
        /// </summary>
        private void dataSource_reports()
        {
            this.grid_reports.DataSource = DbUtil.queryReports("select level, count(1), sum(weight) from t_weights where life_cycle=1 and DATE(create_time) = '" + this.input_date.Value.ToString("yyyy-MM-dd") + "' group by level; ");
            this.grid_reports.ClearSelection();
        }
    }
}
