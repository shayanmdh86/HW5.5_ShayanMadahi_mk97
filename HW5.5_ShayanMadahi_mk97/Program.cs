using HW5._5_ShayanMadahi_mk97.Domain;
using HW5._5_ShayanMadahi_mk97.Interface;
using HW5._5_ShayanMadahi_mk97.Interface.Exception;

namespace HW5._5_ShayanMadahi_mk97
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository servic = new ProductRepository();
            Stock stock = new Stock(1, "Telu1_36", 1, 1, 1000);
            StockRepository stockrep=new StockRepository();
            stockrep.BuyProduct(stock);
          

        }
    }
}