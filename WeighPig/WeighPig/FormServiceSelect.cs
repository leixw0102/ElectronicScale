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
            this.grid_weights.DataSource = DbUtil.queryWeights("select w.*, (@i:=@i+1) i from t_weights w,(select @i:=0) t2 where life_cycle=1 and DATE(create_time) = '" + this.input_date.Value.ToString("yyyy-MM-dd") + "' order by sn;");
            this.grid_weights.ClearSelection();
        }

        /// <summary>
        /// 初始化统计grid
        /// </summary>
        private void dataSource_reports()
        {
            List<Reports> list = DbUtil.queryReports("select level, count(1), FORMAT(sum(weight),2), FORMAT(sum(weight)/count(1),2)  from t_weights where life_cycle=1 and DATE(create_time) = '" + this.input_date.Value.ToString("yyyy-MM-dd") + "' group by level; ");
            Reports reports = new Reports();
            reports.report_level = "累计";
            reports.report_count = list.Sum(t => t.report_count);
            reports.report_weight = double.Parse(list.Sum(t => t.report_weight).ToString("0.00"));
            reports.report_average = double.Parse((reports.report_weight / reports.report_count).ToString("0.00"));
            list.Add(reports);
            this.grid_reports.DataSource = list;
            this.grid_reports.ClearSelection();
        }

        private void FormServiceSelect_Load(object sender, EventArgs e)
        {
            this.grid_weights.ClearSelection();
            this.grid_reports.ClearSelection();
        }
    }
}
