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
    public partial class TypeForm : Form
    {
        public TypeForm()
        {
            InitializeComponent();
        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'card_typeDataSet.Card_type' table. You can move, or remove it, as needed.
            this.card_typeTableAdapter.Fill(this.card_typeDataSet.Card_type);

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cardtypeBindingSource.EndEdit();
                this.card_typeTableAdapter.Update(this.card_typeDataSet.Card_type);
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
