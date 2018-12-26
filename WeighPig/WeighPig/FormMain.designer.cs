namespace WeighPig
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.业务操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.service_update = new System.Windows.Forms.ToolStripMenuItem();
            this.service_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.上传数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.service_select = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_labels = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_com = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.label_weight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grid_weights = new System.Windows.Forms.DataGridView();
            this.panel_button = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.input_remarks = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.button_excel = new System.Windows.Forms.Button();
            this.row_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_upload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_handwrite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.life_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.业务操作ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 业务操作ToolStripMenuItem
            // 
            this.业务操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.service_update,
            this.service_insert,
            this.上传数据ToolStripMenuItem,
            this.service_select});
            this.业务操作ToolStripMenuItem.Name = "业务操作ToolStripMenuItem";
            this.业务操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.业务操作ToolStripMenuItem.Text = "业务操作";
            // 
            // service_update
            // 
            this.service_update.Name = "service_update";
            this.service_update.Size = new System.Drawing.Size(124, 22);
            this.service_update.Text = "修改数据";
            this.service_update.Click += new System.EventHandler(this.service_update_Click);
            // 
            // service_insert
            // 
            this.service_insert.Name = "service_insert";
            this.service_insert.Size = new System.Drawing.Size(124, 22);
            this.service_insert.Text = "补录数据";
            this.service_insert.Click += new System.EventHandler(this.service_insert_Click);
            // 
            // 上传数据ToolStripMenuItem
            // 
            this.上传数据ToolStripMenuItem.Name = "上传数据ToolStripMenuItem";
            this.上传数据ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.上传数据ToolStripMenuItem.Text = "上传数据";
            // 
            // service_select
            // 
            this.service_select.Name = "service_select";
            this.service_select.Size = new System.Drawing.Size(124, 22);
            this.service_select.Text = "查询数据";
            this.service_select.Click += new System.EventHandler(this.service_select_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setting_labels,
            this.setting_com,
            this.setting_restart});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // setting_labels
            // 
            this.setting_labels.Name = "setting_labels";
            this.setting_labels.Size = new System.Drawing.Size(148, 22);
            this.setting_labels.Text = "级别设置";
            this.setting_labels.Click += new System.EventHandler(this.setting_labels_Click);
            // 
            // setting_com
            // 
            this.setting_com.Name = "setting_com";
            this.setting_com.Size = new System.Drawing.Size(148, 22);
            this.setting_com.Text = "串口设置";
            this.setting_com.Click += new System.EventHandler(this.setting_com_Click);
            // 
            // setting_restart
            // 
            this.setting_restart.Name = "setting_restart";
            this.setting_restart.Size = new System.Drawing.Size(148, 22);
            this.setting_restart.Text = "重新连接串口";
            this.setting_restart.Click += new System.EventHandler(this.setting_restart_Click);
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label_weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_weight.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_weight.Location = new System.Drawing.Point(12, 88);
            this.label_weight.Name = "label_weight";
            this.label_weight.Padding = new System.Windows.Forms.Padding(20);
            this.label_weight.Size = new System.Drawing.Size(158, 90);
            this.label_weight.TabIndex = 3;
            this.label_weight.Text = "0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // grid_weights
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_weights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_weights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_weights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row_num,
            this.id,
            this.sn,
            this.create_time,
            this.weight,
            this.level,
            this.type,
            this.remarks,
            this.is_upload,
            this.is_handwrite,
            this.life_cycle});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_weights.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_weights.Location = new System.Drawing.Point(12, 229);
            this.grid_weights.Name = "grid_weights";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_weights.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_weights.RowHeadersVisible = false;
            this.grid_weights.RowTemplate.Height = 23;
            this.grid_weights.Size = new System.Drawing.Size(870, 492);
            this.grid_weights.TabIndex = 20;
            // 
            // panel_button
            // 
            this.panel_button.Location = new System.Drawing.Point(926, 88);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(313, 135);
            this.panel_button.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(923, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "备注:";
            // 
            // input_remarks
            // 
            this.input_remarks.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_remarks.Location = new System.Drawing.Point(926, 254);
            this.input_remarks.Multiline = true;
            this.input_remarks.Name = "input_remarks";
            this.input_remarks.Size = new System.Drawing.Size(313, 193);
            this.input_remarks.TabIndex = 23;
            this.input_remarks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_remarks_KeyUp);
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(1271, 28);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(467, 0);
            this.txtData.TabIndex = 24;
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(13, 194);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(75, 23);
            this.button_excel.TabIndex = 25;
            this.button_excel.Text = "导出excel";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // row_num
            // 
            this.row_num.DataPropertyName = "row_num";
            this.row_num.HeaderText = "序号";
            this.row_num.Name = "row_num";
            this.row_num.ReadOnly = true;
            this.row_num.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1252, 733);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.input_remarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.grid_weights);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "国泰精诚一屠宰车间白条打级过磅管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 业务操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem service_update;
        private System.Windows.Forms.ToolStripMenuItem service_insert;
        private System.Windows.Forms.ToolStripMenuItem 上传数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem service_select;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setting_labels;
        private System.Windows.Forms.ToolStripMenuItem setting_com;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grid_weights;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_remarks;
        private System.Windows.Forms.ToolStripMenuItem setting_restart;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn row_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
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