using HW5._5_ShayanMadahi_mk97.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW5._5_ShayanMadahi_mk97.Interface
{
    public class StockRepository : IStockRepository
    {
        public List<Stock> stocks=new List<Stock>();
        public string stockPath = @"D:\HW5.5_ShayanMadahi_mk97\HW5.5_ShayanMadahi_mk97\DataBase\Stock.json";
        public StockRepository()
        {
            FileStream JsonStock = File.Open(stockPath, FileMode.OpenOrCreate);
            stocks = JsonSerializer.Deserialize<List<Stock>>(JsonStock);
            JsonStock.Close();
        }
        public string BuyProduct(Stock productInStock)
        {
            bool Quantity=stocks.Any(x=>x.Name==productInStock.Name);
            if (!Quantity)
            {
                stocks.Add(productInStock);
            }
            else
            {
                stocks.Where(s => s.Name == productInStock.Name).SingleOrDefault().ProductQuantity += productInStock.ProductQuantity;
            }
            StockWiter();
            return "ok";

        }

        //public List<SockProductViewModel> GetSalesProductList()
        //{
        //    throw new NotImplementedException();
        //}

        public string SaleProduct(int productId, int cnt)
        {
            throw new NotImplementedException();
        }

        public void StockWiter()
        {
            string stockSerialize = JsonSerializer.Serialize(stocks);
            File.WriteAllText(stockPath,stockSerialize);
        }
    }
}
