using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program2
    {
        public static void Execute()
        {
            List<Product> products = ProductList.ListOfProducts();

            Console.WriteLine("Enter string:");
            string b1 = Console.ReadLine().ToLower();

            var qr1 = products.Where(x => x.Brand.Contains(b1) && x.Price < 1000).Select(x => new { x.Name, x.Price }).ToList();
            foreach (var item in qr1)
            {
                Console.WriteLine($"{item.Name} {item.Price}");
            }
        }
    }
}
