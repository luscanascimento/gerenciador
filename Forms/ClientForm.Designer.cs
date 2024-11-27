using System.Windows.Forms;

namespace gerenciador.Forms
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewClients;
        private Button buttonAddClient;
        private Button buttonEditClient;
        private Button buttonDeleteClient;

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
            this.dataGridViewClients = new DataGridView();
            this.buttonAddClient = new Button();
            this.buttonEditClient = new Button();
            this.buttonDeleteClient = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(12, 418);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Adicionar";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(93, 418);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(75, 23);
            this.buttonEditClient.TabIndex = 2;
            this.buttonEditClient.Text = "Editar";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.ButtonEditClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(174, 418);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteClient.TabIndex = 3;
            this.buttonDeleteClient.Text = "Excluir";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.ButtonDeleteClient_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "ClientForm";
            this.Text = "Gerenciar Clientes";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }
    }
}