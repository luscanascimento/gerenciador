using gerenciador.Models;
using Npgsql;
using System;
using System.Collections.Generic;

namespace gerenciador
{
    public class Database
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=1103;Database=gerenciador";

        public void CreateClient(string name, string email, string tel)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO clients (name, email, tel) VALUES (@name, @email, @tel)", conn))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("tel", tel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateClient(int clientId, string name, string email, string tel)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE clients SET name = @name, email = @email, tel = @tel WHERE id = @clientId", conn))
                {
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("tel", tel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteClient(int clientId)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE clients SET IsDeleted = TRUE WHERE id = @clientId", conn))
                {
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Client> GetClients()
        {
            var clients = new List<Client>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id, name, email, tel FROM clients WHERE IsDeleted = FALSE", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2),
                                Tel = reader.GetString(3)
                            });
                        }
                    }
                }
            }
            return clients;
        }

        public void CreateProduct(string name, decimal price, decimal un)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO products (name, price, un) VALUES (@name, @price, @un)", conn))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("price", price);
                    cmd.Parameters.AddWithValue("un", un);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(int productId, string name, decimal price, decimal un)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE products SET name = @name, price = @price, un = @un WHERE id = @productId", conn))
                {
                    cmd.Parameters.AddWithValue("productId", productId);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("price", price);
                    cmd.Parameters.AddWithValue("un", un);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int productId)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE products SET IsDeleted = TRUE WHERE id = @productId", conn))
                {
                    cmd.Parameters.AddWithValue("productId", productId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id, name, price, un FROM products WHERE IsDeleted = FALSE", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                UN = reader.GetDecimal(3)
                            });
                        }
                    }
                }
            }
            return products;
        }

        public void CreateSale(int clientId, int productId, int quantity, DateTime dataSale)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO sales (client_id, data_sale) VALUES (@clientId, @dataSale) RETURNING id", conn))
                {
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    cmd.Parameters.AddWithValue("dataSale", dataSale);
                    int saleId = (int)cmd.ExecuteScalar();

                    using (var cmdItem = new NpgsqlCommand("INSERT INTO sales_items (sale_id, product_id, quantity, price) VALUES (@saleId, @productId, @quantity, (SELECT price FROM products WHERE id = @productId))", conn))
                    {
                        cmdItem.Parameters.AddWithValue("saleId", saleId);
                        cmdItem.Parameters.AddWithValue("productId", productId);
                        cmdItem.Parameters.AddWithValue("quantity", quantity);
                        cmdItem.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<Sale> GetSales()
        {
            var sales = new List<Sale>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT s.id, s.client_id, si.product_id, si.quantity, s.data_sale " +
                            "FROM sales s " +
                            "JOIN sales_items si ON s.id = si.sale_id " +
                            "WHERE s.IsDeleted = FALSE AND si.IsDeleted = FALSE";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sales.Add(new Sale
                            {
                                Id = reader.GetInt32(0),
                                ClientId = reader.GetInt32(1),
                                ProductId = reader.GetInt32(2),
                                Quantity = reader.GetInt32(3),
                                DataSale = reader.GetDateTime(4)
                            });
                        }
                    }
                }
            }
            return sales;
        }
        public List<SaleReport> GetSalesReport(int? clientId = null, int? productId = null)
        {
            var sales = new List<SaleReport>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT s.id, c.name AS client_name, p.name AS product_name, si.quantity, si.price, (si.quantity * si.price) AS total " +
                            "FROM sales s " +
                            "JOIN clients c ON s.client_id = c.id " +
                            "JOIN sales_items si ON s.id = si.sale_id " +
                            "JOIN products p ON si.product_id = p.id " +
                            "WHERE s.IsDeleted = FALSE AND si.IsDeleted = FALSE " +
                            "AND (@clientId IS NULL OR s.client_id = @clientId) " +
                            "AND (@productId IS NULL OR si.product_id = @productId)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("clientId", clientId.HasValue ? (object)clientId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("productId", productId.HasValue ? (object)productId.Value : DBNull.Value);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sales.Add(new SaleReport
                            {
                                Id = reader.GetInt32(0),
                                ClientName = reader.GetString(1),
                                ProductName = reader.GetString(2),
                                Quantity = reader.GetInt32(3),
                                Price = reader.GetDecimal(4),
                                Total = reader.GetDecimal(5)
                            });
                        }
                    }
                }
            }
            return sales;
        }
    }
}