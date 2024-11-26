namespace gerenciador.Forms
{
    partial class SaleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelDataSale;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataSale;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button buttonAddSale;

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
            this.labelClientId = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelDataSale = new System.Windows.Forms.Label();
            this.dateTimePickerDataSale = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.buttonAddSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(12, 15);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(39, 13);
            this.labelClientId.TabIndex = 0;
            this.labelClientId.Text = "Cliente";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(65, 12);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(207, 21);
            this.comboBoxClient.TabIndex = 1;
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(12, 41);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(44, 13);
            this.labelProductId.TabIndex = 2;
            this.labelProductId.Text = "Produto";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(65, 38);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(207, 21);
            this.comboBoxProduct.TabIndex = 3;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 67);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(62, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantidade";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(80, 64);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(192, 20);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // labelDataSale
            // 
            this.labelDataSale.AutoSize = true;
            this.labelDataSale.Location = new System.Drawing.Point(12, 93);
            this.labelDataSale.Name = "labelDataSale";
            this.labelDataSale.Size = new System.Drawing.Size(30, 13);
            this.labelDataSale.TabIndex = 6;
            this.labelDataSale.Text = "Data";
            // 
            // dateTimePickerDataSale
            // 
            this.dateTimePickerDataSale.Location = new System.Drawing.Point(65, 90);
            this.dateTimePickerDataSale.Name = "dateTimePickerDataSale";
            this.dateTimePickerDataSale.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerDataSale.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(197, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewSales.TabIndex = 9;
            // 
            // buttonAddSale
            // 
            this.buttonAddSale.Location = new System.Drawing.Point(12, 451);
            this.buttonAddSale.Name = "buttonAddSale";
            this.buttonAddSale.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSale.TabIndex = 10;
            this.buttonAddSale.Text = "Adicionar Venda";
            this.buttonAddSale.UseVisualStyleBackColor = true;
            this.buttonAddSale.Click += new System.EventHandler(this.ButtonAddSale_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 486);
            this.Controls.Add(this.buttonAddSale);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerDataSale);
            this.Controls.Add(this.labelDataSale);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClientId);
            this.Name = "SaleForm";
            this.Text = "Gerenciar Vendas";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}