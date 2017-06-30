namespace Bank
{
    partial class CardsForm
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
            this.cardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsDataSet = new Bank.CardsDataSet();
            this.cardsTableAdapter = new Bank.CardsDataSetTableAdapters.CardsTableAdapter();
            this.cardsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkservicesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkcustomeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkcurrencyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkpaysystemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fktypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateopenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkbranchidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkemployeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(1244, 450);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 11);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 11);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardsidDataGridViewTextBoxColumn,
            this.termtoDataGridViewTextBoxColumn,
            this.fkservicesidDataGridViewTextBoxColumn,
            this.fkcustomeridDataGridViewTextBoxColumn,
            this.fkcurrencyidDataGridViewTextBoxColumn,
            this.fkpaysystemidDataGridViewTextBoxColumn,
            this.fktypeidDataGridViewTextBoxColumn,
            this.pincodeDataGridViewTextBoxColumn,
            this.givenDataGridViewTextBoxColumn,
            this.dateopenDataGridViewTextBoxColumn,
            this.fkbranchidDataGridViewTextBoxColumn,
            this.fkemployeeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cardsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // cardsBindingSource
            // 
            this.cardsBindingSource.DataMember = "Cards";
            this.cardsBindingSource.DataSource = this.cardsDataSet;
            // 
            // cardsDataSet
            // 
            this.cardsDataSet.DataSetName = "CardsDataSet";
            this.cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardsTableAdapter
            // 
            this.cardsTableAdapter.ClearBeforeFill = true;
            // 
            // cardsidDataGridViewTextBoxColumn
            // 
            this.cardsidDataGridViewTextBoxColumn.DataPropertyName = "cards_id";
            this.cardsidDataGridViewTextBoxColumn.HeaderText = "cards_id";
            this.cardsidDataGridViewTextBoxColumn.Name = "cardsidDataGridViewTextBoxColumn";
            // 
            // termtoDataGridViewTextBoxColumn
            // 
            this.termtoDataGridViewTextBoxColumn.DataPropertyName = "term_to";
            this.termtoDataGridViewTextBoxColumn.HeaderText = "term_to";
            this.termtoDataGridViewTextBoxColumn.Name = "termtoDataGridViewTextBoxColumn";
            // 
            // fkservicesidDataGridViewTextBoxColumn
            // 
            this.fkservicesidDataGridViewTextBoxColumn.DataPropertyName = "fk_services_id";
            this.fkservicesidDataGridViewTextBoxColumn.HeaderText = "fk_services_id";
            this.fkservicesidDataGridViewTextBoxColumn.Name = "fkservicesidDataGridViewTextBoxColumn";
            // 
            // fkcustomeridDataGridViewTextBoxColumn
            // 
            this.fkcustomeridDataGridViewTextBoxColumn.DataPropertyName = "fk_customer_id";
            this.fkcustomeridDataGridViewTextBoxColumn.HeaderText = "fk_customer_id";
            this.fkcustomeridDataGridViewTextBoxColumn.Name = "fkcustomeridDataGridViewTextBoxColumn";
            // 
            // fkcurrencyidDataGridViewTextBoxColumn
            // 
            this.fkcurrencyidDataGridViewTextBoxColumn.DataPropertyName = "fk_currency_id";
            this.fkcurrencyidDataGridViewTextBoxColumn.HeaderText = "fk_currency_id";
            this.fkcurrencyidDataGridViewTextBoxColumn.Name = "fkcurrencyidDataGridViewTextBoxColumn";
            // 
            // fkpaysystemidDataGridViewTextBoxColumn
            // 
            this.fkpaysystemidDataGridViewTextBoxColumn.DataPropertyName = "fk_pay_system_id";
            this.fkpaysystemidDataGridViewTextBoxColumn.HeaderText = "fk_pay_system_id";
            this.fkpaysystemidDataGridViewTextBoxColumn.Name = "fkpaysystemidDataGridViewTextBoxColumn";
            // 
            // fktypeidDataGridViewTextBoxColumn
            // 
            this.fktypeidDataGridViewTextBoxColumn.DataPropertyName = "fk_type_id";
            this.fktypeidDataGridViewTextBoxColumn.HeaderText = "fk_type_id";
            this.fktypeidDataGridViewTextBoxColumn.Name = "fktypeidDataGridViewTextBoxColumn";
            // 
            // pincodeDataGridViewTextBoxColumn
            // 
            this.pincodeDataGridViewTextBoxColumn.DataPropertyName = "pin_code";
            this.pincodeDataGridViewTextBoxColumn.HeaderText = "pin_code";
            this.pincodeDataGridViewTextBoxColumn.Name = "pincodeDataGridViewTextBoxColumn";
            // 
            // givenDataGridViewTextBoxColumn
            // 
            this.givenDataGridViewTextBoxColumn.DataPropertyName = "given";
            this.givenDataGridViewTextBoxColumn.HeaderText = "given";
            this.givenDataGridViewTextBoxColumn.Name = "givenDataGridViewTextBoxColumn";
            // 
            // dateopenDataGridViewTextBoxColumn
            // 
            this.dateopenDataGridViewTextBoxColumn.DataPropertyName = "date_open";
            this.dateopenDataGridViewTextBoxColumn.HeaderText = "date_open";
            this.dateopenDataGridViewTextBoxColumn.Name = "dateopenDataGridViewTextBoxColumn";
            // 
            // fkbranchidDataGridViewTextBoxColumn
            // 
            this.fkbranchidDataGridViewTextBoxColumn.DataPropertyName = "fk_branch_id";
            this.fkbranchidDataGridViewTextBoxColumn.HeaderText = "fk_branch_id";
            this.fkbranchidDataGridViewTextBoxColumn.Name = "fkbranchidDataGridViewTextBoxColumn";
            // 
            // fkemployeeidDataGridViewTextBoxColumn
            // 
            this.fkemployeeidDataGridViewTextBoxColumn.DataPropertyName = "fk_employee_id";
            this.fkemployeeidDataGridViewTextBoxColumn.HeaderText = "fk_employee_id";
            this.fkemployeeidDataGridViewTextBoxColumn.Name = "fkemployeeidDataGridViewTextBoxColumn";
            // 
            // CardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредитные карты";
            this.Load += new System.EventHandler(this.CardsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CardsDataSet cardsDataSet;
        private System.Windows.Forms.BindingSource cardsBindingSource;
        private CardsDataSetTableAdapters.CardsTableAdapter cardsTableAdapter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkservicesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkcustomeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkcurrencyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkpaysystemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fktypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn givenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateopenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkbranchidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkemployeeidDataGridViewTextBoxColumn;
    }
}