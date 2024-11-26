using System;

namespace gerenciador
{
    public class Sale
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DataSale { get; set; }
    }
}