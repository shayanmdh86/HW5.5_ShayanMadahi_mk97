using HW5._5_ShayanMadahi_mk97.Domain;
using HW5._5_ShayanMadahi_mk97.Interface.Exception;
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
        private bool Test;
        public List<Product>products= new List<Product>();
        public string FilePath ="D:\\HW5.5_ShayanMadahi_mk97\\HW5.5_ShayanMadahi_mk97\\DataBase\\ProductJson.json";
        string Nameproduct;

        public ProductRepository()
        {

            FileStream JsonSeri = File.Open(FilePath, FileMode.OpenOrCreate);
            products = JsonSerializer.Deserialize<List<Product>>(JsonSeri);
            JsonSeri.Close();
        }
        public string AddProduct(Product product)
        {
            try
            {
                CheckName(product.Name);
            }
            catch(IncorrectProductNameFormat Exception)
            {
                Console.WriteLine(Exception.Message);
            }
            if (Test)
            {
                products.Add(product);
                JsonWriter();
            }

            return product.Name;
        }

        public string GetProductById(int id)
        {
            var result = products.Where(x => x.ProductId == id).Select(x => x.Name).ToList();
            if (result.Count==0)
            {
                throw new UnsuccessfulSearch();
            }
            foreach (var item in result)
            {
                Nameproduct = item;
            }
            return Nameproduct;
        }

        public List<Product> GetProductList()
        {
            if (products.Count==0)
            {
                throw new OutOfStockException();
            }
            return products;
        }
        
        public bool CheckName(string name) 
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{3}[1-9]{1}[_]{1}[1-9]{2}$");
            Test = regex.IsMatch(name);
            if (!Test)
                throw new IncorrectProductNameFormat();
            return Test;    
        }
        public void JsonWriter()
        {
            string JsonSerie=JsonSerializer.Serialize(products);
            File.WriteAllText(FilePath, JsonSerie);
        }

    }
}
