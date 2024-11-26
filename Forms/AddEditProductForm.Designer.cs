namespace gerenciador.Forms
{
    partial class AddEditProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxUN;
        private Button buttonSave;
        private Label labelName;
        private Label labelPrice;
        private Label labelUN;

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
            this.textBoxPrice = new TextBox();
            this.textBoxUN = new TextBox();
            this.buttonSave = new Button();
            this.labelName = new Label();
            this.labelPrice = new Label();
            this.labelUN = new Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 48);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Preço";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 64);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(260, 20);
            this.textBoxPrice.TabIndex = 1;
            // 
            // labelUN
            // 
            this.labelUN.AutoSize = true;
            this.labelUN.Location = new System.Drawing.Point(12, 87);
            this.labelUN.Name = "labelUN";
            this.labelUN.Size = new System.Drawing.Size(26, 13);
            this.labelUN.TabIndex = 6;
            this.labelUN.Text = "UN";
            // 
            // textBoxUN
            // 
            this.textBoxUN.Location = new System.Drawing.Point(12, 103);
            this.textBoxUN.Name = "textBoxUN";
            this.textBoxUN.Size = new System.Drawing.Size(260, 20);
            this.textBoxUN.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(197, 129);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // AddEditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 164);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxUN);
            this.Controls.Add(this.labelUN);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "AddEditProductForm";
            this.Text = "Adicionar/Editar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}