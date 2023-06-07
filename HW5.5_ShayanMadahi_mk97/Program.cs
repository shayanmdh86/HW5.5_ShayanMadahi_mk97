using HW5._5_ShayanMadahi_mk97.Domain;
using HW5._5_ShayanMadahi_mk97.Interface;

namespace HW5._5_ShayanMadahi_mk97
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository servic=new ProductRepository();
            servic.GetProductById(1);
      
            
        }
    }
}