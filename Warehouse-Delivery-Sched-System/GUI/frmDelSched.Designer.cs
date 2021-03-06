namespace Warehouse_Delivery_Sched_System.GUI
{
    partial class frmDelSched
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelSched));
            this.dgvSched = new System.Windows.Forms.DataGridView();
            this.cmbDT = new System.Windows.Forms.ComboBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvInsertDel = new System.Windows.Forms.DataGridView();
            this.shipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcNbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnADD = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbSelectAll = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtSchedDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnViewSum = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBrgy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPerCase = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInvcNum = new System.Windows.Forms.ComboBox();
            this.cmbCustID = new System.Windows.Forms.Label();
            this.cmbCUST = new System.Windows.Forms.ComboBox();
            this.lblShipVia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSched
            // 
            this.dgvSched.AllowUserToAddRows = false;
            this.dgvSched.AllowUserToDeleteRows = false;
            this.dgvSched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSched.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSched.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSched.Location = new System.Drawing.Point(10, 53);
            this.dgvSched.Name = "dgvSched";
            this.dgvSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSched.Size = new System.Drawing.Size(1207, 283);
            this.dgvSched.TabIndex = 2;
            // 
            // cmbDT
            // 
            this.cmbDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDT.FormattingEnabled = true;
            this.cmbDT.Location = new System.Drawing.Point(61, 423);
            this.cmbDT.Name = "cmbDT";
            this.cmbDT.Size = new System.Drawing.Size(139, 32);
            this.cmbDT.TabIndex = 5;
            this.cmbDT.SelectedIndexChanged += new System.EventHandler(this.cmbDT_SelectedIndexChanged);
            // 
            // lblDT
            // 
            this.lblDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDT.AutoSize = true;
            this.lblDT.BackColor = System.Drawing.Color.White;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(57, 396);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(52, 24);
            this.lblDT.TabIndex = 2;
            this.lblDT.Text = ".......";
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(134, 11);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(164, 32);
            this.cmbCity.TabIndex = 100;
            this.cmbCity.Visible = false;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CITY:";
            this.label1.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.White;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.Red;
            this.lblCompany.Location = new System.Drawing.Point(279, 620);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(118, 24);
            this.lblCompany.TabIndex = 5;
            this.lblCompany.Text = "COMPANY:";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Red;
            this.btnFilter.Location = new System.Drawing.Point(639, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(93, 35);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Clear";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvInsertDel
            // 
            this.dgvInsertDel.AllowUserToAddRows = false;
            this.dgvInsertDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInsertDel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsertDel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInsertDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsertDel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipName,
            this.invcNbr,
            this.Amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsertDel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInsertDel.Location = new System.Drawing.Point(445, 342);
            this.dgvInsertDel.Name = "dgvInsertDel";
            this.dgvInsertDel.ReadOnly = true;
            this.dgvInsertDel.Size = new System.Drawing.Size(772, 302);
            this.dgvInsertDel.TabIndex = 7;
            this.dgvInsertDel.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvInsertDel_UserDeletedRow);
            this.dgvInsertDel.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvInsertDel_UserDeletingRow);
            // 
            // shipName
            // 
            this.shipName.HeaderText = "Ship To";
            this.shipName.Name = "shipName";
            this.shipName.ReadOnly = true;
            // 
            // invcNbr
            // 
            this.invcNbr.HeaderText = "Invoice #";
            this.invcNbr.Name = "invcNbr";
            this.invcNbr.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.Green;
            this.btnADD.Location = new System.Drawing.Point(540, 10);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(93, 35);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lblSum
            // 
            this.lblSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.Color.Transparent;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSum.Location = new System.Drawing.Point(965, 6);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(91, 42);
            this.lblSum.TabIndex = 9;
            this.lblSum.Text = "0.00";
            this.lblSum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSum_MouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(891, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "TOTAL:";
            // 
            // chkbSelectAll
            // 
            this.chkbSelectAll.AutoSize = true;
            this.chkbSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbSelectAll.Location = new System.Drawing.Point(18, 16);
            this.chkbSelectAll.Name = "chkbSelectAll";
            this.chkbSelectAll.Size = new System.Drawing.Size(48, 24);
            this.chkbSelectAll.TabIndex = 11;
            this.chkbSelectAll.Text = "All";
            this.chkbSelectAll.UseVisualStyleBackColor = true;
            this.chkbSelectAll.CheckedChanged += new System.EventHandler(this.chkbSelectAll_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(747, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "OUTLET:";
            // 
            // lblOutCount
            // 
            this.lblOutCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutCount.AutoSize = true;
            this.lblOutCount.BackColor = System.Drawing.Color.Transparent;
            this.lblOutCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOutCount.Location = new System.Drawing.Point(834, 6);
            this.lblOutCount.Name = "lblOutCount";
            this.lblOutCount.Size = new System.Drawing.Size(39, 42);
            this.lblOutCount.TabIndex = 12;
            this.lblOutCount.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "DT:";
            // 
            // dtSchedDate
            // 
            this.dtSchedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtSchedDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSchedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSchedDate.Location = new System.Drawing.Point(9, 494);
            this.dtSchedDate.Name = "dtSchedDate";
            this.dtSchedDate.Size = new System.Drawing.Size(329, 29);
            this.dtSchedDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "SCHEDULE DATE:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Green;
            this.btnConfirm.Location = new System.Drawing.Point(9, 547);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(216, 45);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnViewSum
            // 
            this.btnViewSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSum.ForeColor = System.Drawing.Color.Green;
            this.btnViewSum.Location = new System.Drawing.Point(9, 598);
            this.btnViewSum.Name = "btnViewSum";
            this.btnViewSum.Size = new System.Drawing.Size(216, 45);
            this.btnViewSum.TabIndex = 99;
            this.btnViewSum.Text = "View Summary";
            this.btnViewSum.UseVisualStyleBackColor = true;
            this.btnViewSum.Click += new System.EventHandler(this.btnViewSum_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Brgy:";
            this.label6.Visible = false;
            // 
            // cmbBrgy
            // 
            this.cmbBrgy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBrgy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBrgy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrgy.FormattingEnabled = true;
            this.cmbBrgy.Location = new System.Drawing.Point(370, 11);
            this.cmbBrgy.Name = "cmbBrgy";
            this.cmbBrgy.Size = new System.Drawing.Size(164, 32);
            this.cmbBrgy.TabIndex = 101;
            this.cmbBrgy.Visible = false;
            this.cmbBrgy.SelectedIndexChanged += new System.EventHandler(this.cmbBrgy_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Case Count:";
            // 
            // lblPerCase
            // 
            this.lblPerCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPerCase.AutoSize = true;
            this.lblPerCase.BackColor = System.Drawing.Color.Transparent;
            this.lblPerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPerCase.Location = new System.Drawing.Point(299, 567);
            this.lblPerCase.Name = "lblPerCase";
            this.lblPerCase.Size = new System.Drawing.Size(39, 42);
            this.lblPerCase.TabIndex = 19;
            this.lblPerCase.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Invc#: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbInvcNum
            // 
            this.cmbInvcNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbInvcNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbInvcNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInvcNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvcNum.FormattingEnabled = true;
            this.cmbInvcNum.Location = new System.Drawing.Point(70, 355);
            this.cmbInvcNum.Name = "cmbInvcNum";
            this.cmbInvcNum.Size = new System.Drawing.Size(130, 32);
            this.cmbInvcNum.TabIndex = 1;
            this.cmbInvcNum.SelectedIndexChanged += new System.EventHandler(this.cmbInvcNum_SelectedIndexChanged);
            // 
            // cmbCustID
            // 
            this.cmbCustID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCustID.AutoSize = true;
            this.cmbCustID.BackColor = System.Drawing.Color.Transparent;
            this.cmbCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustID.Location = new System.Drawing.Point(206, 426);
            this.cmbCustID.Name = "cmbCustID";
            this.cmbCustID.Size = new System.Drawing.Size(79, 24);
            this.cmbCustID.TabIndex = 104;
            this.cmbCustID.Text = "Cust ID :";
            // 
            // cmbCUST
            // 
            this.cmbCUST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCUST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCUST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCUST.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCUST.FormattingEnabled = true;
            this.cmbCUST.Location = new System.Drawing.Point(291, 426);
            this.cmbCUST.Name = "cmbCUST";
            this.cmbCUST.Size = new System.Drawing.Size(140, 32);
            this.cmbCUST.TabIndex = 4;
            this.cmbCUST.SelectedIndexChanged += new System.EventHandler(this.cmbCUST_SelectedIndexChanged);
            // 
            // lblShipVia
            // 
            this.lblShipVia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblShipVia.AutoSize = true;
            this.lblShipVia.BackColor = System.Drawing.Color.White;
            this.lblShipVia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipVia.ForeColor = System.Drawing.Color.Red;
            this.lblShipVia.Location = new System.Drawing.Point(206, 358);
            this.lblShipVia.Name = "lblShipVia";
            this.lblShipVia.Size = new System.Drawing.Size(52, 24);
            this.lblShipVia.TabIndex = 105;
            this.lblShipVia.Text = ".......";
            // 
            // frmDelSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 656);
            this.Controls.Add(this.lblShipVia);
            this.Controls.Add(this.cmbCustID);
            this.Controls.Add(this.cmbCUST);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbInvcNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPerCase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBrgy);
            this.Controls.Add(this.btnViewSum);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtSchedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOutCount);
            this.Controls.Add(this.chkbSelectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.dgvInsertDel);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.cmbDT);
            this.Controls.Add(this.dgvSched);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDelSched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Schedule Delivery";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDelSched_FormClosed);
            this.Load += new System.EventHandler(this.frmDelSched_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSched;
        public System.Windows.Forms.ComboBox cmbDT;
        public System.Windows.Forms.Label lblDT;
        public System.Windows.Forms.ComboBox cmbCity;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnFilter;
        public System.Windows.Forms.DataGridView dgvInsertDel;
        private System.Windows.Forms.Button btnADD;
        public System.Windows.Forms.Label lblSum;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbSelectAll;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblOutCount;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtSchedDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnViewSum;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbBrgy;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblPerCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invcNbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbInvcNum;
        public System.Windows.Forms.Label cmbCustID;
        public System.Windows.Forms.ComboBox cmbCUST;
        public System.Windows.Forms.Label lblShipVia;
    }
}