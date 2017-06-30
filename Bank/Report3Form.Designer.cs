namespace Bank
{
    partial class Report3Form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Report3DataSet = new Bank.Report3DataSet();
            this.LoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoanTableAdapter = new Bank.Report3DataSetTableAdapters.LoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Report3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Report3DataSet";
            reportDataSource1.Value = this.LoanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bank.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(724, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // Report3DataSet
            // 
            this.Report3DataSet.DataSetName = "Report3DataSet";
            this.Report3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoanBindingSource
            // 
            this.LoanBindingSource.DataMember = "Loan";
            this.LoanBindingSource.DataSource = this.Report3DataSet;
            // 
            // LoanTableAdapter
            // 
            this.LoanTableAdapter.ClearBeforeFill = true;
            // 
            // Report3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведомость выданных кредитов";
            this.Load += new System.EventHandler(this.Report3Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Report3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoanBindingSource;
        private Report3DataSet Report3DataSet;
        private Report3DataSetTableAdapters.LoanTableAdapter LoanTableAdapter;
    }
}