using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program6
    {
        public static void Execute()
        {
            List<Product> products = ProductList.ListOfProducts();

            Console.WriteLine("Enter First Brand Name:");
            string b1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter Second Brand Name:");
            string b2 = Console.ReadLine().ToLower();

            var qr1 = products.Where(x => x.Brand == b1).Select(x => x.Name).ToList();

            var qr2 = products.Where(x => x.Brand == b2).Select(x => x.Name).ToList();


            Console.WriteLine("Products are:");
            foreach (var item in qr1)
            {
                Console.WriteLine(item);
            }
            foreach (var item in qr2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
