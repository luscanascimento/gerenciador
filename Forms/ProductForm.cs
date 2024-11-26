using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace gerenciador.Forms
{
    public partial class ProductForm : Form
    {
        private Database database;

        public ProductForm()
        {
            InitializeComponent();
            database = new Database();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = database.GetProducts();
            dataGridViewProducts.DataSource = products;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var addEditProductForm = new AddEditProductForm();
            if (addEditProductForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                var addEditProductForm = new AddEditProductForm(selectedProduct);
                if (addEditProductForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                database.DeleteProduct(selectedProduct.Id);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Selecione um produto para deletar.");
            }
        }
    }
}