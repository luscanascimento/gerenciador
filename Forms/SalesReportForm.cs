using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using gerenciador.Models;

namespace gerenciador.Forms
{
    public partial class SalesReportForm : Form
    {
        private Database database;

        public SalesReportForm()
        {
            InitializeComponent();
            database = new Database();
            LoadClientsAndProducts();
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

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            int? clientId = comboBoxClient.SelectedValue as int?;
            int? productId = comboBoxProduct.SelectedValue as int?;

            List<SaleReport> sales = database.GetSalesReport(clientId, productId);
            ReportDataSource rds = new ReportDataSource("SalesDataSet", sales);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = "SalesReport.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}