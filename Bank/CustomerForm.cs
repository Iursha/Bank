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
    public partial class CustomerForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.customerTableAdapter.Update(this.customerDataSet.Customer);
                MessageBox.Show("Изменение прошло успешно!");
                logger.Trace("logger.Trace - Изменение прошло успешно!");
                logger.Debug("logger.Debug");
                logger.Info("logger.Info");
                logger.Warn("logger.Warn");
                logger.Error("logger.Error");
                logger.Fatal("logger.Fatal");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При изменении произошла ошибка!");
                logger.Trace("logger.Trace - При изменении произошла ошибка!");
                logger.Debug("logger.Debug");
                logger.Info("logger.Info");
                logger.Warn("logger.Warn");
                logger.Error("logger.Error");
                logger.Fatal("logger.Fatal");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
