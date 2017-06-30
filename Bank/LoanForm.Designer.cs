namespace Bank
{
    partial class LoanForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanDataSet = new Bank.LoanDataSet();
            this.loanTableAdapter = new Bank.LoanDataSetTableAdapters.LoanTableAdapter();
            this.loanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateopenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkcustomeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuancedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkemployeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkbranchidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkcurrencyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOk);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1344, 476);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 10);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanidDataGridViewTextBoxColumn,
            this.accountidDataGridViewTextBoxColumn,
            this.dateopenDataGridViewTextBoxColumn,
            this.datecloseDataGridViewTextBoxColumn,
            this.fkcustomeridDataGridViewTextBoxColumn,
            this.interestrateDataGridViewTextBoxColumn,
            this.penaltyDataGridViewTextBoxColumn,
            this.delayDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.issuancedateDataGridViewTextBoxColumn,
            this.fkemployeeidDataGridViewTextBoxColumn,
            this.fkbranchidDataGridViewTextBoxColumn,
            this.fkcurrencyidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1344, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.loanDataSet;
            // 
            // loanDataSet
            // 
            this.loanDataSet.DataSetName = "LoanDataSet";
            this.loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // loanidDataGridViewTextBoxColumn
            // 
            this.loanidDataGridViewTextBoxColumn.DataPropertyName = "loan_id";
            this.loanidDataGridViewTextBoxColumn.HeaderText = "loan_id";
            this.loanidDataGridViewTextBoxColumn.Name = "loanidDataGridViewTextBoxColumn";
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            this.accountidDataGridViewTextBoxColumn.DataPropertyName = "account_id";
            this.accountidDataGridViewTextBoxColumn.HeaderText = "account_id";
            this.accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            // 
            // dateopenDataGridViewTextBoxColumn
            // 
            this.dateopenDataGridViewTextBoxColumn.DataPropertyName = "date_open";
            this.dateopenDataGridViewTextBoxColumn.HeaderText = "date_open";
            this.dateopenDataGridViewTextBoxColumn.Name = "dateopenDataGridViewTextBoxColumn";
            // 
            // datecloseDataGridViewTextBoxColumn
            // 
            this.datecloseDataGridViewTextBoxColumn.DataPropertyName = "date_close";
            this.datecloseDataGridViewTextBoxColumn.HeaderText = "date_close";
            this.datecloseDataGridViewTextBoxColumn.Name = "datecloseDataGridViewTextBoxColumn";
            // 
            // fkcustomeridDataGridViewTextBoxColumn
            // 
            this.fkcustomeridDataGridViewTextBoxColumn.DataPropertyName = "fk_customer_id";
            this.fkcustomeridDataGridViewTextBoxColumn.HeaderText = "fk_customer_id";
            this.fkcustomeridDataGridViewTextBoxColumn.Name = "fkcustomeridDataGridViewTextBoxColumn";
            // 
            // interestrateDataGridViewTextBoxColumn
            // 
            this.interestrateDataGridViewTextBoxColumn.DataPropertyName = "interest_rate";
            this.interestrateDataGridViewTextBoxColumn.HeaderText = "interest_rate";
            this.interestrateDataGridViewTextBoxColumn.Name = "interestrateDataGridViewTextBoxColumn";
            // 
            // penaltyDataGridViewTextBoxColumn
            // 
            this.penaltyDataGridViewTextBoxColumn.DataPropertyName = "penalty";
            this.penaltyDataGridViewTextBoxColumn.HeaderText = "penalty";
            this.penaltyDataGridViewTextBoxColumn.Name = "penaltyDataGridViewTextBoxColumn";
            // 
            // delayDataGridViewTextBoxColumn
            // 
            this.delayDataGridViewTextBoxColumn.DataPropertyName = "delay";
            this.delayDataGridViewTextBoxColumn.HeaderText = "delay";
            this.delayDataGridViewTextBoxColumn.Name = "delayDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // issuancedateDataGridViewTextBoxColumn
            // 
            this.issuancedateDataGridViewTextBoxColumn.DataPropertyName = "issuance_date";
            this.issuancedateDataGridViewTextBoxColumn.HeaderText = "issuance_date";
            this.issuancedateDataGridViewTextBoxColumn.Name = "issuancedateDataGridViewTextBoxColumn";
            // 
            // fkemployeeidDataGridViewTextBoxColumn
            // 
            this.fkemployeeidDataGridViewTextBoxColumn.DataPropertyName = "fk_employee_id";
            this.fkemployeeidDataGridViewTextBoxColumn.HeaderText = "fk_employee_id";
            this.fkemployeeidDataGridViewTextBoxColumn.Name = "fkemployeeidDataGridViewTextBoxColumn";
            // 
            // fkbranchidDataGridViewTextBoxColumn
            // 
            this.fkbranchidDataGridViewTextBoxColumn.DataPropertyName = "fk_branch_id";
            this.fkbranchidDataGridViewTextBoxColumn.HeaderText = "fk_branch_id";
            this.fkbranchidDataGridViewTextBoxColumn.Name = "fkbranchidDataGridViewTextBoxColumn";
            // 
            // fkcurrencyidDataGridViewTextBoxColumn
            // 
            this.fkcurrencyidDataGridViewTextBoxColumn.DataPropertyName = "fk_currency_id";
            this.fkcurrencyidDataGridViewTextBoxColumn.HeaderText = "fk_currency_id";
            this.fkcurrencyidDataGridViewTextBoxColumn.Name = "fkcurrencyidDataGridViewTextBoxColumn";
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 476);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредиты";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private LoanDataSet loanDataSet;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private LoanDataSetTableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateopenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkcustomeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuancedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkemployeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkbranchidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkcurrencyidDataGridViewTextBoxColumn;
    }
}