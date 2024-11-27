using System.Windows.Forms;

namespace gerenciador.Forms
{
    partial class AddEditClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxTel;
        private TextBox textBoxAddress; // Adicionado
        private Button buttonSave;
        private Label labelName;
        private Label labelEmail;
        private Label labelTel;
        private Label labelAddress; // Adicionado

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
            this.textBoxName = new TextBox();
            this.textBoxEmail = new TextBox();
            this.textBoxTel = new TextBox();
            this.textBoxAddress = new TextBox(); // Adicionado
            this.buttonSave = new Button();
            this.labelName = new Label();
            this.labelEmail = new Label();
            this.labelTel = new Label();
            this.labelAddress = new Label(); // Adicionado
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 65);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(12, 105);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(200, 20);
            this.textBoxTel.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 145);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 20);
            this.textBoxAddress.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 185);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 49);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(12, 89);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 13);
            this.labelTel.TabIndex = 7;
            this.labelTel.Text = "Telefone";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 129);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(53, 13);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Endereço";
            // 
            // AddEditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddEditClientForm";
            this.Text = "Adicionar/Editar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}