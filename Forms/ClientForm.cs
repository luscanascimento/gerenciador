using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace gerenciador.Forms
{
    public partial class ClientForm : Form
    {
        private Database database;

        public ClientForm()
        {
            InitializeComponent();
            database = new Database();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = database.GetClients();
            dataGridViewClients.DataSource = clients;
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            var addEditClientForm = new AddEditClientForm();
            if (addEditClientForm.ShowDialog() == DialogResult.OK)
            {
                LoadClients();
            }
        }

        private void ButtonEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                var selectedClient = (Client)dataGridViewClients.SelectedRows[0].DataBoundItem;
                var addEditClientForm = new AddEditClientForm(selectedClient);
                if (addEditClientForm.ShowDialog() == DialogResult.OK)
                {
                    LoadClients();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }
        }

        private void ButtonDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                var selectedClient = (Client)dataGridViewClients.SelectedRows[0].DataBoundItem;
                database.DeleteClient(selectedClient.Id);
                LoadClients();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para deletar.");
            }
        }
    }
}