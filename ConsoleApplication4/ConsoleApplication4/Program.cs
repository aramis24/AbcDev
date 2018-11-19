using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string beau;

            Console.WriteLine("Fait-il beau ? (o/n)");
            beau = Console.ReadLine();

            if (beau == "o")
            {
                Console.WriteLine("je plante des tulipes");
                Console.WriteLine("j'enlève les mauvaises herbes");

            }
            else
            {
                Console.WriteLine("j'écoute de la musique");

            }
            Console.ReadKey();
        }
    }
}
