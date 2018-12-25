﻿namespace WeighPig
{
    partial class FormServiceUpdate
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
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
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
            this.combobox_labels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_remarks = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).BeginInit();
            this.SuspendLayout();
            // 
            // input_date
            // 
            this.input_date.Location = new System.Drawing.Point(60, 7);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(197, 21);
            this.input_date.TabIndex = 18;
            this.input_date.ValueChanged += new System.EventHandler(this.input_date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "时间";
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
            this.grid_weights.Location = new System.Drawing.Point(12, 34);
            this.grid_weights.MultiSelect = false;
            this.grid_weights.Name = "grid_weights";
            this.grid_weights.RowHeadersVisible = false;
            this.grid_weights.RowTemplate.Height = 23;
            this.grid_weights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_weights.Size = new System.Drawing.Size(576, 362);
            this.grid_weights.TabIndex = 22;
            this.grid_weights.Click += new System.EventHandler(this.grid_weights_Click);
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
            // combobox_labels
            // 
            this.combobox_labels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_labels.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeighPig.Properties.Settings.Default, "comParity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.combobox_labels.FormattingEnabled = true;
            this.combobox_labels.Location = new System.Drawing.Point(672, 47);
            this.combobox_labels.Name = "combobox_labels";
            this.combobox_labels.Size = new System.Drawing.Size(155, 20);
            this.combobox_labels.TabIndex = 24;
            this.combobox_labels.Text = global::WeighPig.Properties.Settings.Default.comParity;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(623, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "级别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(623, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "备注";
            // 
            // input_remarks
            // 
            this.input_remarks.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_remarks.Location = new System.Drawing.Point(669, 104);
            this.input_remarks.Multiline = true;
            this.input_remarks.Name = "input_remarks";
            this.input_remarks.Size = new System.Drawing.Size(155, 230);
            this.input_remarks.TabIndex = 26;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(626, 373);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 27;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(749, 373);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 28;
            this.button_del.Text = "作废";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // FormServiceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 408);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.input_remarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_labels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_weights);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormServiceUpdate";
            this.Text = "修改数据";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormServiceUpdate_FormClosed);
            this.Load += new System.EventHandler(this.FormServiceUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_weights;
        private System.Windows.Forms.ComboBox combobox_labels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_remarks;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_upload;
        private System.Windows.Forms.DataGridViewTextBoxColumn life_cycle;
    }
}