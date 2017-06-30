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
    public partial class CardsForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        public CardsForm()
        {
            InitializeComponent();
        }

        private void CardsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardsDataSet.Cards' table. You can move, or remove it, as needed.
            this.cardsTableAdapter.Fill(this.cardsDataSet.Cards);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cardsBindingSource.EndEdit();
                this.cardsTableAdapter.Update(this.cardsDataSet.Cards);
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cardsTableAdapter.FillBy(this.cardsDataSet.Cards);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
