﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Report3Form : Form
    {
        public Report3Form()
        {
            InitializeComponent();
        }

        private void Report3Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Report3DataSet.Loan' table. You can move, or remove it, as needed.
            this.LoanTableAdapter.Fill(this.Report3DataSet.Loan);

            this.reportViewer1.RefreshReport();
        }
    }
}
