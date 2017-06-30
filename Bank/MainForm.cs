using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using NLog.Config; 

namespace Bank
{
    public partial class MainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        public MainForm()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerForm().Show();
           /* logger.Trace("logger.Trace");
            logger.Debug("logger.Debug");
            logger.Info("logger.Info");
            logger.Warn("logger.Warn");
            logger.Error("logger.Error");
            logger.Fatal("logger.Fatal");*/
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void кредитныеКартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CardsForm().Show();
            /*logger.Trace("Привет{0}", "!");
            logger.DebugException("Произошла ошибка", new ArgumentNullException());
            logger.Fatal("Пока");*/
        }

        private void кредитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoanForm().Show();
        }

        private void типыКарточекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TypeForm().Show();
        }

        private void платежныеСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pay_systemForm().Show();
        }

        private void дополнительныеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddServiceForm().Show();
        }

        private void страныгражданствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CountryForm().Show();
        }

        private void валютаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CurrencyForm().Show();
        }

        private void отделенияБанкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BranchForm().Show();
        }

        private void ведомостьЗаявленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Report1Form().Show();
        }

        private void ведомостьВыпущенныхКартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Report2Form().Show();
        }

        private void ведомостьВыданныхКредитовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Report3Form().Show();
        }
    }
}
