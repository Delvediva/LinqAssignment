using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program5
    {
        public static void Execute()
        {
            List<Product> products = ProductList.ListOfProducts();

            Console.WriteLine("Enter First Brand Name:");
            string b1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter Second Brand Name:");
            string b2 = Console.ReadLine().ToLower();

            //var qr1 = products.Where(x => x.Brand == b1).Max(x => x.Price);
            var qr1 = products.Where(x => x.Brand == b1).OrderByDescending(x => x.Price).FirstOrDefault();

            //var qr2 = products.Where(x => x.Brand == b2).Max(x => x.Price);
            var qr2 = products.Where(x => x.Brand == b2).OrderByDescending(x => x.Price).FirstOrDefault();



            if (qr1.Price > qr2.Price)
            {
                Console.WriteLine($"Max Price: " + qr1);
            }
            else
            {
                Console.WriteLine($"Max Price: " + qr2);
            }

        }
    }
}
