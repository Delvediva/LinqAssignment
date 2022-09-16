using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class ProductList
    {
        public static List<Product> ListOfProducts()
        {
            {
                List<Product> products = new List<Product>();

                Console.WriteLine("Enter number of product you want to add: ");
                int num;
                bool validNum = int.TryParse(Console.ReadLine(), out num);


                for (int i = 1; i <= num; i++)
                {
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();


                    Console.Write("Enter Brand Name: ");
                    string brand = Console.ReadLine();

                    int price;
                    Console.Write("Enter Price: ");
                    bool validPrice = int.TryParse(Console.ReadLine(), out price);

                    Product product = new Product() { Name = name, Brand = brand, Price = price };
                    products.Add(product);

                }

                return products;
            }
        }
    }
}
