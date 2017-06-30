using System;
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
    public partial class CurrencyForm : Form
    {
        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void CurrencyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'currencyDataSet.Currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.currencyDataSet.Currency);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.currencyBindingSource.EndEdit();
                this.currencyTableAdapter.Update(this.currencyDataSet.Currency);
                MessageBox.Show("Изменение прошло успешно!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При изменении произошла ошибка!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
