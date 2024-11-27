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
                product = new Product();
            }

            product.Name = textBoxName.Text;
            product.Price = decimal.Parse(textBoxPrice.Text);
            product.UN = decimal.Parse(textBoxUN.Text);

            if (product.Id == 0)
            {
                database.CreateProduct(product.Name, product.Price, product.UN);
            }
            else
            {
                database.UpdateProduct(product.Id, product.Name, product.Price, product.UN);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}