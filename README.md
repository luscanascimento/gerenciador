# Gerenciador de Vendas

Este projeto é um sistema de gerenciamento de vendas desenvolvido em C# utilizando Windows Forms e PostgreSQL.

## Requisitos

- .NET 6.0
- C#
- Windows Forms
- PostgreSQL
- Npgsql
- Git
- ReportViewer

## Estrutura do Projeto

- `Database/Database.cs`: Contém a lógica de acesso ao banco de dados.
- `Models/Client.cs`: Modelo que representa um cliente.
- `Models/Product.cs`: Modelo que representa um produto.
- `Models/Sale.cs`: Modelo que representa uma venda.
- `Models/SaleReport.cs`: Modelo que representa um relatório de venda.
- `Forms/ClientForm.cs`: Formulário para gerenciar clientes.
- `Forms/ProductForm.cs`: Formulário para gerenciar produtos.
- `Forms/SaleForm.cs`: Formulário para gerenciar vendas.
- `Forms/SalesReportForm.cs`: Formulário para exibir relatórios.
- `Program.cs`: Ponto de entrada da aplicação.
- `App.config`: Arquivo de configuração da aplicação.

## Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu_usuario/gerenciador.git

2. Configure a string de conexão no arquivo Database/Database.cs:
                  ```bash
   private string connectionString = "Host=localhost;Username=seu_usuario;Password=sua_senha;Database=gerenciador";

3. Abra o projeto no Visual Studio e restaure os pacotes NuGet:
   ```bash 
   dotnet restore

4. Compile e execute o projeto: 
   ```bash
   dotnet build
   dotnet run

# Funcionalidades
- Gerenciamento de Clientes: Cadastro, edição e remoção de clientes.
- Gerenciamento de Produtos: Cadastro, edição e remoção de produtos.
- Gerenciamento de Vendas: Registro de vendas, associando clientes e produtos.
- Relatórios: Geração de relatórios de vendas utilizando o ReportViewer.

# Script SQL para Configuração Inicial
- Encontra-se no arquivo .sql