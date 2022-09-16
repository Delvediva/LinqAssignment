using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program3
    {
        public static void Execute()
        {
            List<Product> products = ProductList.ListOfProducts();

            Console.WriteLine("Enter Brand Name:");
            string b = Console.ReadLine().ToLower();


            var qr2 = products.Where(x => x.Brand == b).OrderBy(x => x.Price).FirstOrDefault();

            Console.WriteLine("Minimum Price:");
            Console.WriteLine($"{qr2.Name} {qr2.Brand} {qr2.Price}");
        }
    }
}
