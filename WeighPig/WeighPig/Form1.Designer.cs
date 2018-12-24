using System.Drawing;
using System.Windows.Forms;

namespace WeighPig
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.label1 = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.Button();
            this.input_remarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_weights = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_reports = new System.Windows.Forms.DataGridView();
            this.report_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_button = new System.Windows.Forms.Panel();
            this.input_level = new System.Windows.Forms.TextBox();
            this.label_readonly = new System.Windows.Forms.Label();
            this.com_setting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前重量";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label_weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_weight.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_weight.Location = new System.Drawing.Point(12, 110);
            this.label_weight.Name = "label_weight";
            this.label_weight.Padding = new System.Windows.Forms.Padding(20);
            this.label_weight.Size = new System.Drawing.Size(158, 90);
            this.label_weight.TabIndex = 2;
            this.label_weight.Text = "0.00";
            // 
            // setting
            // 
            this.setting.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setting.Location = new System.Drawing.Point(539, 177);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(52, 23);
            this.setting.TabIndex = 9;
            this.setting.Text = "设置";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // input_remarks
            // 
            this.input_remarks.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_remarks.Location = new System.Drawing.Point(67, 204);
            this.input_remarks.Name = "input_remarks";
            this.input_remarks.Size = new System.Drawing.Size(524, 26);
            this.input_remarks.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "备注:";
            // 
            // grid_weights
            // 
            this.grid_weights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_weights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sn,
            this.create_time,
            this.weight,
            this.level,
            this.type,
            this.remarks,
            this.upload});
            this.grid_weights.Location = new System.Drawing.Point(15, 244);
            this.grid_weights.Name = "grid_weights";
            this.grid_weights.RowHeadersVisible = false;
            this.grid_weights.RowTemplate.Height = 23;
            this.grid_weights.Size = new System.Drawing.Size(576, 194);
            this.grid_weights.TabIndex = 16;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // sn
            // 
            this.sn.DataPropertyName = "sn";
            this.sn.HeaderText = "顺序号";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            this.sn.Width = 70;
            // 
            // create_time
            // 
            this.create_time.DataPropertyName = "create_time";
            this.create_time.HeaderText = "时间";
            this.create_time.Name = "create_time";
            this.create_time.ReadOnly = true;
            this.create_time.Width = 120;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "重量";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 60;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "级别";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Width = 60;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "工艺";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 60;
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "备注";
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // upload
            // 
            this.upload.HeaderText = "上传";
            this.upload.Name = "upload";
            this.upload.ReadOnly = true;
            this.upload.Width = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(618, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "时间";
            // 
            // input_date
            // 
            this.input_date.Location = new System.Drawing.Point(666, 13);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(197, 21);
            this.input_date.TabIndex = 14;
            this.input_date.ValueChanged += new System.EventHandler(this.input_date_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(717, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "统计";
            // 
            // grid_reports
            // 
            this.grid_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.report_level,
            this.report_count,
            this.report_weight});
            this.grid_reports.Location = new System.Drawing.Point(602, 244);
            this.grid_reports.Name = "grid_reports";
            this.grid_reports.RowHeadersVisible = false;
            this.grid_reports.RowTemplate.Height = 23;
            this.grid_reports.Size = new System.Drawing.Size(261, 194);
            this.grid_reports.TabIndex = 17;
            // 
            // report_level
            // 
            this.report_level.DataPropertyName = "report_level";
            this.report_level.HeaderText = "级别";
            this.report_level.Name = "report_level";
            this.report_level.Width = 55;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel_button
            // 
            this.panel_button.Location = new System.Drawing.Point(220, 110);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(313, 90);
            this.panel_button.TabIndex = 19;
            // 
            // input_level
            // 
            this.input_level.Location = new System.Drawing.Point(540, 150);
            this.input_level.Name = "input_level";
            this.input_level.Size = new System.Drawing.Size(51, 21);
            this.input_level.TabIndex = 20;
            this.input_level.Visible = false;
            // 
            // label_readonly
            // 
            this.label_readonly.AutoSize = true;
            this.label_readonly.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_readonly.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_readonly.Location = new System.Drawing.Point(616, 110);
            this.label_readonly.Name = "label_readonly";
            this.label_readonly.Size = new System.Drawing.Size(223, 29);
            this.label_readonly.TabIndex = 21;
            this.label_readonly.Text = "当前为查询状态";
            this.label_readonly.Visible = false;
            // 
            // com_setting
            // 
            this.com_setting.Location = new System.Drawing.Point(71, 25);
            this.com_setting.Name = "com_setting";
            this.com_setting.Size = new System.Drawing.Size(75, 23);
            this.com_setting.TabIndex = 22;
            this.com_setting.Text = "设置COM";
            this.com_setting.UseVisualStyleBackColor = true;
            this.com_setting.Click += new System.EventHandler(this.com_setting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.com_setting);
            this.Controls.Add(this.label_readonly);
            this.Controls.Add(this.input_level);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grid_reports);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_weights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_remarks);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "计重";
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private Label label1;
        private Label label_weight;
        //private Button A1;
        //private Button A2;
        //private Button A3;
        //private Button A4;
        //private Button A5;
        private Button setting;
        private TextBox input_remarks;
        private Label label3;
        private DataGridView grid_weights;
        private Label label4;
        private DateTimePicker input_date;
        private Label label5;
        private DataGridView grid_reports;
        private PictureBox pictureBox1;
        private Panel panel_button;
        private TextBox input_level;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn sn;
        private DataGridViewTextBoxColumn create_time;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn remarks;
        private DataGridViewTextBoxColumn upload;
        private DataGridViewTextBoxColumn report_level;
        private DataGridViewTextBoxColumn report_count;
        private DataGridViewTextBoxColumn report_weight;
        private Label label_readonly;
        private Button com_setting;
    }
}

