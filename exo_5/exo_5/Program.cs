using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir la somme S:");
            double S = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir l'interet i:");
            double i = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le nbre d'annee n:");
            int n = int.Parse(Console.ReadLine());

            double interet_simple = S * (1 + n * (i/100));
            Console.WriteLine("placement :"+S+" interet simple:" + interet_simple);

            double interet_decompose = S*(Math.Pow(1 + (i/100), n));
            Console.WriteLine("placement:"+S+ "interet decompose:" + interet_decompose);

            Console.ReadKey();
        }
    }
}
