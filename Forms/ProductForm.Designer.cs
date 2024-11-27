using System.Windows.Forms;

namespace gerenciador.Forms
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewProducts;
        private Button buttonAddProduct;
        private Button buttonEditProduct;
        private Button buttonDeleteProduct;

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
            this.dataGridViewProducts = new DataGridView();
            this.buttonAddProduct = new Button();
            this.buttonEditProduct = new Button();
            this.buttonDeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 418);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Adicionar";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(93, 418);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonEditProduct.TabIndex = 2;
            this.buttonEditProduct.Text = "Editar";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.ButtonEditProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(174, 418);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "Excluir";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ProductForm";
            this.Text = "Gerenciar Produtos";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
