using HW5._5_ShayanMadahi_mk97.Domain;
using HW5._5_ShayanMadahi_mk97.Interface;

namespace HW5._5_ShayanMadahi_mk97
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository servic=new ProductRepository();
            int ProductId = 1;
            string Name = "Telu1_36";
            string Barcode = "1";
            Product product = new Product(ProductId,Name,Barcode);
      
            servic.AddProduct(product);
        }
    }
}