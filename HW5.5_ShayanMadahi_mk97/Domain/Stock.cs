using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._5_ShayanMadahi_mk97.Domain
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPrice { get; set; }
        public Stock(int stockId, string name, int productId, int productQuantity, int productPrice)
        {
            StockId = stockId;
            Name = name;
            ProductId = productId;
            ProductQuantity = productQuantity;
            ProductPrice = productPrice;
        }
    }
}
