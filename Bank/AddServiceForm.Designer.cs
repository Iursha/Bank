namespace Bank
{
    partial class AddServiceForm
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
            this.servicesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addServiceDataSet = new Bank.AddServiceDataSet();
            this.additional_servicesTableAdapter = new Bank.AddServiceDataSetTableAdapters.Additional_servicesTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addServiceDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicesidDataGridViewTextBoxColumn,
            this.servicesnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.additionalservicesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // servicesidDataGridViewTextBoxColumn
            // 
            this.servicesidDataGridViewTextBoxColumn.DataPropertyName = "services_id";
            this.servicesidDataGridViewTextBoxColumn.HeaderText = "services_id";
            this.servicesidDataGridViewTextBoxColumn.Name = "servicesidDataGridViewTextBoxColumn";
            // 
            // servicesnameDataGridViewTextBoxColumn
            // 
            this.servicesnameDataGridViewTextBoxColumn.DataPropertyName = "services_name";
            this.servicesnameDataGridViewTextBoxColumn.HeaderText = "services_name";
            this.servicesnameDataGridViewTextBoxColumn.Name = "servicesnameDataGridViewTextBoxColumn";
            // 
            // additionalservicesBindingSource
            // 
            this.additionalservicesBindingSource.DataMember = "Additional_services";
            this.additionalservicesBindingSource.DataSource = this.addServiceDataSet;
            // 
            // addServiceDataSet
            // 
            this.addServiceDataSet.DataSetName = "AddServiceDataSet";
            this.addServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // additional_servicesTableAdapter
            // 
            this.additional_servicesTableAdapter.ClearBeforeFill = true;
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
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 262);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительные услуги";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addServiceDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AddServiceDataSet addServiceDataSet;
        private System.Windows.Forms.BindingSource additionalservicesBindingSource;
        private AddServiceDataSetTableAdapters.Additional_servicesTableAdapter additional_servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}