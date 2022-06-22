namespace Warehouse_Delivery_Sched_System.GUI
{
    partial class frmViewSum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSum));
            this.dgvSum = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmbMainFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtSchedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDT = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSum
            // 
            this.dgvSum.AllowUserToAddRows = false;
            this.dgvSum.AllowUserToDeleteRows = false;
            this.dgvSum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSum.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSum.Location = new System.Drawing.Point(12, 47);
            this.dgvSum.Name = "dgvSum";
            this.dgvSum.Size = new System.Drawing.Size(944, 507);
            this.dgvSum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "FILTER: ";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(303, 9);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(179, 32);
            this.cmbFilter.TabIndex = 17;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // cmbMainFilter
            // 
            this.cmbMainFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMainFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMainFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMainFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainFilter.FormattingEnabled = true;
            this.cmbMainFilter.Items.AddRange(new object[] {
            "ShipViaID",
            "INVC#",
            "ScheduleDate"});
            this.cmbMainFilter.Location = new System.Drawing.Point(95, 9);
            this.cmbMainFilter.Name = "cmbMainFilter";
            this.cmbMainFilter.Size = new System.Drawing.Size(191, 32);
            this.cmbMainFilter.TabIndex = 19;
            this.cmbMainFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "DATE:";
            // 
            // dtSchedDate
            // 
            this.dtSchedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtSchedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSchedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSchedDate.Location = new System.Drawing.Point(319, 573);
            this.dtSchedDate.Name = "dtSchedDate";
            this.dtSchedDate.Size = new System.Drawing.Size(329, 29);
            this.dtSchedDate.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "DT:";
            // 
            // cmbDT
            // 
            this.cmbDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDT.FormattingEnabled = true;
            this.cmbDT.Location = new System.Drawing.Point(63, 573);
            this.cmbDT.Name = "cmbDT";
            this.cmbDT.Size = new System.Drawing.Size(164, 32);
            this.cmbDT.TabIndex = 51;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Green;
            this.btnUpdate.Location = new System.Drawing.Point(812, 565);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 45);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbTag
            // 
            this.cmbTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.ItemHeight = 24;
            this.cmbTag.Items.AddRange(new object[] {
            "IN-TRANSIT",
            "ON FLOOR"});
            this.cmbTag.Location = new System.Drawing.Point(667, 573);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(139, 32);
            this.cmbTag.TabIndex = 53;
            // 
            // frmViewSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(968, 617);
            this.Controls.Add(this.cmbTag);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtSchedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDT);
            this.Controls.Add(this.cmbMainFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dgvSum);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.frmViewSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSum;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbFilter;
        public System.Windows.Forms.ComboBox cmbMainFilter;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtSchedDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbDT;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox cmbTag;
    }
}