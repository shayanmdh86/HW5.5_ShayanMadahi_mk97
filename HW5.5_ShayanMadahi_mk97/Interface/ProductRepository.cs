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
        private List<Product> products;
        public ProductRepository()
        {
            string? solutionFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName;
            string solutionPath = Path.Combine(solutionFolderPath, "DataBase");
            string FilePath = Path.Combine(solutionPath, "ProductJson.json");
            FileStream JsonProductFile = File.Open(FilePath, FileMode.OpenOrCreate);

            products = JsonSerializer.Deserialize<List<Product>>(JsonProductFile);
        }
        public string AddProduct(Product product)
        {
            CheckName(product.Name);
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

    }
}
