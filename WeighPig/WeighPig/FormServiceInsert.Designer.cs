namespace WeighPig
{
    partial class FormServiceInsert
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
            this.grid_weights = new System.Windows.Forms.DataGridView();
            this.button_save = new System.Windows.Forms.Button();
            this.input_remarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_labels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_sn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_weight = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_weights
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_weights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_weights.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_weights.Location = new System.Drawing.Point(15, 37);
            this.grid_weights.MultiSelect = false;
            this.grid_weights.Name = "grid_weights";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_weights.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_weights.RowHeadersVisible = false;
            this.grid_weights.RowTemplate.Height = 23;
            this.grid_weights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_weights.Size = new System.Drawing.Size(870, 447);
            this.grid_weights.TabIndex = 37;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(976, 309);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 36;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // input_remarks
            // 
            this.input_remarks.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_remarks.Location = new System.Drawing.Point(976, 174);
            this.input_remarks.Multiline = true;
            this.input_remarks.Name = "input_remarks";
            this.input_remarks.Size = new System.Drawing.Size(155, 110);
            this.input_remarks.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(923, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "备注";
            // 
            // combobox_labels
            // 
            this.combobox_labels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_labels.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeighPig.Properties.Settings.Default, "comParity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.combobox_labels.FormattingEnabled = true;
            this.combobox_labels.Location = new System.Drawing.Point(976, 126);
            this.combobox_labels.Name = "combobox_labels";
            this.combobox_labels.Size = new System.Drawing.Size(155, 20);
            this.combobox_labels.TabIndex = 33;
            this.combobox_labels.Text = global::WeighPig.Properties.Settings.Default.comParity;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(923, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "级别";
            // 
            // input_date
            // 
            this.input_date.Enabled = false;
            this.input_date.Location = new System.Drawing.Point(60, 10);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(197, 21);
            this.input_date.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(907, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "流水号";
            // 
            // input_sn
            // 
            this.input_sn.Location = new System.Drawing.Point(976, 32);
            this.input_sn.Name = "input_sn";
            this.input_sn.Size = new System.Drawing.Size(155, 21);
            this.input_sn.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(923, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "重量";
            // 
            // input_weight
            // 
            this.input_weight.Location = new System.Drawing.Point(976, 77);
            this.input_weight.Name = "input_weight";
            this.input_weight.Size = new System.Drawing.Size(155, 21);
            this.input_weight.TabIndex = 41;
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
            // FormServiceInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 495);
            this.Controls.Add(this.input_weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_sn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_weights);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.input_remarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_labels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormServiceInsert";
            this.Text = "补录数据";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormServiceInsert_FormClosed);
            this.Load += new System.EventHandler(this.FormServiceInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_weights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_weights;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox input_remarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_labels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_sn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_weight;
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