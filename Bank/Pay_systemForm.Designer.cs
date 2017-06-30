namespace Bank
{
    partial class Pay_systemForm
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
            this.paysystemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysystemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pay_systemDataSet = new Bank.Pay_systemDataSet();
            this.pay_systemTableAdapter = new Bank.Pay_systemDataSetTableAdapters.Pay_systemTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pay_systemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paysystemidDataGridViewTextBoxColumn,
            this.paysystemnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paysystemBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // paysystemidDataGridViewTextBoxColumn
            // 
            this.paysystemidDataGridViewTextBoxColumn.DataPropertyName = "pay_system_id";
            this.paysystemidDataGridViewTextBoxColumn.HeaderText = "pay_system_id";
            this.paysystemidDataGridViewTextBoxColumn.Name = "paysystemidDataGridViewTextBoxColumn";
            // 
            // paysystemnameDataGridViewTextBoxColumn
            // 
            this.paysystemnameDataGridViewTextBoxColumn.DataPropertyName = "pay_system_name";
            this.paysystemnameDataGridViewTextBoxColumn.HeaderText = "pay_system_name";
            this.paysystemnameDataGridViewTextBoxColumn.Name = "paysystemnameDataGridViewTextBoxColumn";
            // 
            // paysystemBindingSource
            // 
            this.paysystemBindingSource.DataMember = "Pay_system";
            this.paysystemBindingSource.DataSource = this.pay_systemDataSet;
            // 
            // pay_systemDataSet
            // 
            this.pay_systemDataSet.DataSetName = "Pay_systemDataSet";
            this.pay_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pay_systemTableAdapter
            // 
            this.pay_systemTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Pay_systemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 262);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pay_systemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Платежные системы";
            this.Load += new System.EventHandler(this.Pay_systemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pay_systemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Pay_systemDataSet pay_systemDataSet;
        private System.Windows.Forms.BindingSource paysystemBindingSource;
        private Pay_systemDataSetTableAdapters.Pay_systemTableAdapter pay_systemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysystemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysystemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}