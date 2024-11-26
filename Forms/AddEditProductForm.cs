using System;
using System.Windows.Forms;

namespace gerenciador.Forms
{
    public partial class AddEditProductForm : Form
    {
        private Database database;
        private Product product;

        public AddEditProductForm(Product product = null)
        {
            InitializeComponent();
            database = new Database();
            this.product = product;

            if (product != null)
            {
                textBoxName.Text = product.Name;
                textBoxPrice.Text = product.Price.ToString();
                textBoxUN.Text = product.UN.ToString();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (product == null)
            {
                database.CreateProduct(textBoxName.Text, decimal.Parse(textBoxPrice.Text), decimal.Parse(textBoxUN.Text));
            }
            else
            {
                database.UpdateProduct(product.Id, textBoxName.Text, decimal.Parse(textBoxPrice.Text), decimal.Parse(textBoxUN.Text));
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}