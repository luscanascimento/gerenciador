using System;

namespace gerenciador.Models
{
    public class SaleReport
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}