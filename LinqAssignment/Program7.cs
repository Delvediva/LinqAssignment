using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program7
    {
        public static void Execute()
        {
            List<Product> products = ProductList.ListOfProducts();

            int fPrice;
            int tPrice;

            Console.WriteLine("Enter From price:");
            bool val1 = int.TryParse(Console.ReadLine(), out fPrice);

            Console.WriteLine("Enter to price:");
            bool val2 = int.TryParse(Console.ReadLine(), out tPrice);

            var qr1 = products.Where(x => x.Price >= fPrice && x.Price <= tPrice).Select(x => new { x.Name, x.Brand, x.Price }).ToList();

            foreach (var item in qr1)
            {
                Console.WriteLine($"{item.Name} {item.Brand} {item.Price}");
            }
        }
    }
}
