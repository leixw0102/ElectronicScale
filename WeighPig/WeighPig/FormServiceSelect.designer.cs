namespace WeighPig
{
    partial class FormServiceSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_reports = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_weights = new System.Windows.Forms.DataGridView();
            this.report_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.row_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_upload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_handwrite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.life_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).BeginInit();
            this.SuspendLayout();
            // 
            // input_date
            // 
            this.input_date.Location = new System.Drawing.Point(60, 7);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(197, 21);
            this.input_date.TabIndex = 16;
            this.input_date.ValueChanged += new System.EventHandler(this.input_date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "时间";
            // 
            // grid_reports
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grid_reports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.report_level,
            this.report_count,
            this.report_weight,
            this.report_average});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_reports.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_reports.Location = new System.Drawing.Point(910, 55);
            this.grid_reports.Name = "grid_reports";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_reports.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_reports.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grid_reports.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_reports.RowTemplate.Height = 23;
            this.grid_reports.Size = new System.Drawing.Size(394, 447);
            this.grid_reports.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(907, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "统计";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "明细";
            // 
            // grid_weights
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_weights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_weights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_weights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.row_num,
            this.sn,
            this.create_time,
            this.weight,
            this.level,
            this.type,
            this.remarks,
            this.is_upload,
            this.is_handwrite,
            this.life_cycle});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_weights.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_weights.Location = new System.Drawing.Point(12, 55);
            this.grid_weights.Name = "grid_weights";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_weights.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_weights.RowHeadersVisible = false;
            this.grid_weights.RowTemplate.Height = 23;
            this.grid_weights.Size = new System.Drawing.Size(870, 447);
            this.grid_weights.TabIndex = 25;
            // 
            // report_level
            // 
            this.report_level.DataPropertyName = "report_level";
            this.report_level.HeaderText = "级别";
            this.report_level.Name = "report_level";
            this.report_level.Width = 70;
            // 
            // report_count
            // 
            this.report_count.DataPropertyName = "report_count";
            this.report_count.HeaderText = "累计数量";
            this.report_count.Name = "report_count";
            // 
            // report_weight
            // 
            this.report_weight.DataPropertyName = "report_weight";
            this.report_weight.HeaderText = "累计重量";
            this.report_weight.Name = "report_weight";
            // 
            // report_average
            // 
            this.report_average.DataPropertyName = "report_average";
            this.report_average.HeaderText = "平均重量";
            this.report_average.Name = "report_average";
            this.report_average.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // row_num
            // 
            this.row_num.DataPropertyName = "row_num";
            this.row_num.HeaderText = "序号";
            this.row_num.Name = "row_num";
            this.row_num.ReadOnly = true;
            this.row_num.Width = 70;
            // 
            // sn
            // 
            this.sn.DataPropertyName = "sn";
            this.sn.HeaderText = "顺序号";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            this.sn.Width = 90;
            // 
            // create_time
            // 
            this.create_time.DataPropertyName = "create_time";
            this.create_time.HeaderText = "时间";
            this.create_time.Name = "create_time";
            this.create_time.ReadOnly = true;
            this.create_time.Width = 180;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "重量";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "级别";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "工艺";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 80;
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "备注";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            this.remarks.Width = 80;
            // 
            // is_upload
            // 
            this.is_upload.DataPropertyName = "is_upload";
            this.is_upload.HeaderText = "上传";
            this.is_upload.Name = "is_upload";
            this.is_upload.ReadOnly = true;
            this.is_upload.Width = 70;
            // 
            // is_handwrite
            // 
            this.is_handwrite.DataPropertyName = "is_handwrite";
            this.is_handwrite.HeaderText = "补录";
            this.is_handwrite.Name = "is_handwrite";
            this.is_handwrite.ReadOnly = true;
            this.is_handwrite.Width = 70;
            // 
            // life_cycle
            // 
            this.life_cycle.DataPropertyName = "life_cycle";
            this.life_cycle.HeaderText = "生命周期";
            this.life_cycle.Name = "life_cycle";
            this.life_cycle.Visible = false;
            this.life_cycle.Width = 50;
            // 
            // FormServiceSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 514);
            this.Controls.Add(this.grid_weights);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grid_reports);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormServiceSelect";
            this.Text = "查询数据";
            this.Load += new System.EventHandler(this.FormServiceSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_reports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_weights;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_average;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn row_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_upload;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_handwrite;
        private System.Windows.Forms.DataGridViewTextBoxColumn life_cycle;
    }
}