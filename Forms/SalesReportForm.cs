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
            LoadProducts();
        }

        private void LoadProducts()
        {
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
    int? productId = comboBoxProduct.SelectedValue as int?;

    List<SaleReport> sales = database.GetSalesReport(productId);
    ReportDataSource rds = new ReportDataSource("SalesDataSet", sales);
    this.reportViewer1.LocalReport.DataSources.Clear();
    this.reportViewer1.LocalReport.DataSources.Add(rds);
    this.reportViewer1.LocalReport.ReportPath = "Reports/SalesReport.rdlc";
    this.reportViewer1.RefreshReport();
}
    }
}