using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("veuillez saisir une longueur A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("veuillez saisir une longueur B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("veuillez saisir une longueur C:");
            int c = int.Parse(Console.ReadLine());

            //calcul périmètre
            double perimetre =(a+b+c);
            Console.WriteLine("résultat périmètre:" + perimetre);
            Console.ReadKey();

            //calcul aire
            double aire = Math.Sqrt(((perimetre/2)*(perimetre/2- a)*(perimetre/2 - b)*(perimetre/2 - c)));

            aire = Math.Round(aire, 3);
            Console.WriteLine("résultat aire:" + aire);


            Console.ReadKey();

        }
    }
}
