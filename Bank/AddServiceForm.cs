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
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addServiceDataSet.Additional_services' table. You can move, or remove it, as needed.
            this.additional_servicesTableAdapter.Fill(this.addServiceDataSet.Additional_services);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.additionalservicesBindingSource.EndEdit();
                this.additional_servicesTableAdapter.Update(this.addServiceDataSet.Additional_services);
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
