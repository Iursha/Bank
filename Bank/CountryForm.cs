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
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();
        }

        private void CountryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'countryDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.countryDataSet.Country);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.countryBindingSource.EndEdit();
                this.countryTableAdapter.Update(this.countryDataSet.Country);
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
