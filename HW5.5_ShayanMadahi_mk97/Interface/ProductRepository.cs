using HW5._5_ShayanMadahi_mk97.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HW5._5_ShayanMadahi_mk97.Interface
{
    public class ProductRepository : IProductRepository
    {
        public bool Test;
        public List<Product>products= new List<Product>();
        private string FilePath= "D:\\HW5.5_ShayanMadahi_mk97\\HW5.5_ShayanMadahi_mk97\\DataBase\\ProductJson.json";
        //public ProductRepository()
        //{

        //    FileStream JsonSeri = File.Open(FilePath, FileMode.OpenOrCreate);
        //    products = JsonSerializer.Deserialize<List<Product>>(JsonSeri);
        //}
        public string AddProduct(Product product)
        {
            CheckName(product.Name);
            if (Test)
            {
                products.Add(product);
                JsonWriter();
            }
            return "done";
        }

        public string GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductList()
        {
            throw new NotImplementedException();
        }
        
        public bool CheckName(string name) 
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{3}[1-9]{1}[_]{1}[1-9]{2}$");
            Test = regex.IsMatch(name);
            if (!Test)
                Console.WriteLine("not Correct!!");
            return Test;    
        }
        public void JsonWriter()
        {
            string JsonSerie=JsonSerializer.Serialize(products);
            File.WriteAllText(FilePath, JsonSerie);
        }

    }
}
