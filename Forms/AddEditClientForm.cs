using System;
using System.Windows.Forms;

namespace gerenciador.Forms
{
    public partial class AddEditClientForm : Form
    {
        private Database database;
        private Client client;

        public AddEditClientForm(Client client = null)
        {
            InitializeComponent();
            database = new Database();
            this.client = client;

            if (client != null)
            {
                textBoxName.Text = client.Name;
                textBoxEmail.Text = client.Email;
                textBoxTel.Text = client.Tel;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                database.CreateClient(textBoxName.Text, textBoxEmail.Text, textBoxTel.Text);
            }
            else
            {
                database.UpdateClient(client.Id, textBoxName.Text, textBoxEmail.Text, textBoxTel.Text);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}