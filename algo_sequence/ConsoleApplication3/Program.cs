using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir la somme initiale S:");
            int S = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir l'interet i:");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le nombre d'annee n:");
            int n = int.Parse(Console.ReadLine());

            double interet_simple = S*((1+n*i));
            Console.WriteLine("interet simple:" + interet_simple);
            
            double interet_decompose = S * (Math.Pow(1+i, n));
            Console.WriteLine("interet_decompose:" + interet_decompose);
        
            
            
            Console.ReadKey();



        }
    }
}
