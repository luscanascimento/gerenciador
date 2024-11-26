namespace gerenciador.Forms
{
    partial class SalesReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox comboBoxClient;
        private ComboBox comboBoxProduct;
        private Button buttonFilter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxClient = new ComboBox();
            this.comboBoxProduct = new ComboBox();
            this.buttonFilter = new Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 12);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(200, 21);
            this.comboBoxClient.TabIndex = 1;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(218, 12);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProduct.TabIndex = 2;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(424, 10);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "Filtrar";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalesReportForm";
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            this.ResumeLayout(false);

        }
    }
}