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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.业务操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.补录数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.service_select = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_labels = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_com = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.label_weight = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grid_weights = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_upload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.life_cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_button = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.input_remarks = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(986, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 业务操作ToolStripMenuItem
            // 
            this.业务操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改数据ToolStripMenuItem,
            this.补录数据ToolStripMenuItem,
            this.上传数据ToolStripMenuItem,
            this.service_select});
            this.业务操作ToolStripMenuItem.Name = "业务操作ToolStripMenuItem";
            this.业务操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.业务操作ToolStripMenuItem.Text = "业务操作";
            // 
            // 修改数据ToolStripMenuItem
            // 
            this.修改数据ToolStripMenuItem.Name = "修改数据ToolStripMenuItem";
            this.修改数据ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改数据ToolStripMenuItem.Text = "修改数据";
            this.修改数据ToolStripMenuItem.Click += new System.EventHandler(this.service_update_Click);
            // 
            // 补录数据ToolStripMenuItem
            // 
            this.补录数据ToolStripMenuItem.Name = "补录数据ToolStripMenuItem";
            this.补录数据ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.补录数据ToolStripMenuItem.Text = "补录数据";
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
            this.setting_labels.Text = "标签设置";
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
            this.grid_weights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_weights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sn,
            this.create_time,
            this.weight,
            this.level,
            this.type,
            this.remarks,
            this.is_upload,
            this.life_cycle});
            this.grid_weights.Location = new System.Drawing.Point(12, 191);
            this.grid_weights.Name = "grid_weights";
            this.grid_weights.RowHeadersVisible = false;
            this.grid_weights.RowTemplate.Height = 23;
            this.grid_weights.Size = new System.Drawing.Size(606, 447);
            this.grid_weights.TabIndex = 20;
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
            this.level.HeaderText = "标签";
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
            // is_upload
            // 
            this.is_upload.DataPropertyName = "is_upload";
            this.is_upload.HeaderText = "上传";
            this.is_upload.Name = "is_upload";
            this.is_upload.ReadOnly = true;
            this.is_upload.Width = 60;
            // 
            // life_cycle
            // 
            this.life_cycle.DataPropertyName = "life_cycle";
            this.life_cycle.HeaderText = "生命周期";
            this.life_cycle.Name = "life_cycle";
            this.life_cycle.Visible = false;
            // 
            // panel_button
            // 
            this.panel_button.Location = new System.Drawing.Point(662, 88);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(313, 135);
            this.panel_button.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(659, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "备注:";
            // 
            // input_remarks
            // 
            this.input_remarks.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_remarks.Location = new System.Drawing.Point(662, 254);
            this.input_remarks.Multiline = true;
            this.input_remarks.Name = "input_remarks";
            this.input_remarks.Size = new System.Drawing.Size(313, 193);
            this.input_remarks.TabIndex = 23;
            this.input_remarks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.input_remarks_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(236, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 148);
            this.textBox1.TabIndex = 25;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(986, 650);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.input_remarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.grid_weights);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "国泰精诚一屠宰车间白条打级过磅管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem 修改数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 补录数据ToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_upload;
        private System.Windows.Forms.DataGridViewTextBoxColumn life_cycle;
        private System.Windows.Forms.TextBox textBox1;
    }
}