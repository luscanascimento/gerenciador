using System;
using System.Windows.Forms;
using gerenciador.Forms;

namespace gerenciador
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.Show();
        }

        private void RelatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportForm SalesReportForm = new SalesReportForm();
            SalesReportForm.Show();
        }
    }
}