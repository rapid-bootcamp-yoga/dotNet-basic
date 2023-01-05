using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product()
        {

        }

        public Product(String name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        //toString
        public override string ToString()
        {
            return "Product { Name: " + this.Name + ", Price: Rp. " + this.Price + "}";
        }

        public static List<Product> GetData()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Ayam opor", 34000),
            new Product("Sop Buah", 15000),
                new Product("Jus Alpukat", 15000),
                new Product("Ikan gurame", 55000),
                new Product{Name = "Jus Mangga", Price = 22000},
            };
            return products;
        }

        public static void SampleFilterProduct()
        {
            //1. buat data source
            List<Product> products = GetData();

            //2. buat query
            IEnumerable<Product> productFilter = from item in products
                                                 where item.Price >= 30000
                                                 select item;
            //3. jalankan query
            foreach (var product in productFilter)
            {
                Console.WriteLine(product);
            }
        }

        public static void SampleFilterByName()
        {
            List<Product> products = GetData();

            IEnumerable<Product> productFilter = from product in products
                                                 where product.Name.Contains("Jus")
                                                 select product;
            foreach (var product in productFilter)
            {
                Console.WriteLine(product);
            }
        }

      
    }

   

    
}
