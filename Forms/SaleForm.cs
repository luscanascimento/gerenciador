using System;
using System.Windows.Forms;

namespace gerenciador.Forms
{
    public partial class SaleForm : Form
    {
        private Database database;

        public SaleForm()
        {
            InitializeComponent();
            database = new Database();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadClientsAndProducts();
            LoadSales();
        }

        private void LoadClientsAndProducts()
        {
            var clients = database.GetClients();
            comboBoxClient.DataSource = clients;
            comboBoxClient.DisplayMember = "Name";
            comboBoxClient.ValueMember = "Id";

            var products = database.GetProducts();
            comboBoxProduct.DataSource = products;
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.ValueMember = "Id";
        }

        private void LoadSales()
        {
            var sales = database.GetSales();
            dataGridViewSales.DataSource = sales;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int clientId = (int)comboBoxClient.SelectedValue;
            int productId = (int)comboBoxProduct.SelectedValue;
            int quantity = int.Parse(textBoxQuantity.Text);
            DateTime dataSale = dateTimePickerDataSale.Value;

            database.CreateSale(clientId, productId, quantity, dataSale);
            MessageBox.Show("Venda salva com sucesso!");
            LoadSales();
        }

        private void ButtonAddSale_Click(object sender, EventArgs e)
        {
            comboBoxClient.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
            textBoxQuantity.Clear();
            dateTimePickerDataSale.Value = DateTime.Now;
        }
    }
}