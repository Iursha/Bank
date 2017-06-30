namespace Bank
{
    partial class CurrencyForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currencyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripyionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyDataSet = new Bank.CurrencyDataSet();
            this.currencyTableAdapter = new Bank.CurrencyDataSetTableAdapters.CurrencyTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyidDataGridViewTextBoxColumn,
            this.currencynameDataGridViewTextBoxColumn,
            this.descripyionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.currencyBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // currencyidDataGridViewTextBoxColumn
            // 
            this.currencyidDataGridViewTextBoxColumn.DataPropertyName = "currency_id";
            this.currencyidDataGridViewTextBoxColumn.HeaderText = "currency_id";
            this.currencyidDataGridViewTextBoxColumn.Name = "currencyidDataGridViewTextBoxColumn";
            // 
            // currencynameDataGridViewTextBoxColumn
            // 
            this.currencynameDataGridViewTextBoxColumn.DataPropertyName = "currency_name";
            this.currencynameDataGridViewTextBoxColumn.HeaderText = "currency_name";
            this.currencynameDataGridViewTextBoxColumn.Name = "currencynameDataGridViewTextBoxColumn";
            // 
            // descripyionDataGridViewTextBoxColumn
            // 
            this.descripyionDataGridViewTextBoxColumn.DataPropertyName = "descripyion";
            this.descripyionDataGridViewTextBoxColumn.HeaderText = "descripyion";
            this.descripyionDataGridViewTextBoxColumn.Name = "descripyionDataGridViewTextBoxColumn";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.currencyDataSet;
            // 
            // currencyDataSet
            // 
            this.currencyDataSet.DataSetName = "CurrencyDataSet";
            this.currencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 262);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CurrencyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Валюта";
            this.Load += new System.EventHandler(this.CurrencyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CurrencyDataSet currencyDataSet;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private CurrencyDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripyionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}