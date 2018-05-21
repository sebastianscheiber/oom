using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Asset[]
            {
                new Notebook("Dell", "A1B2C3", 12, 1400),
                new Notebook("Lenovo", "FF17B9", 13, 1200),
                new Desk("Schreibtisch", 105, 51, 900),
                new Desk("Sekretär", 309, 53, 500)
    
            };

            foreach (var x in items)
            {
                Console.WriteLine($"{x.Name} {x.PrintRestValue()}");
            }



        }
    }
}
