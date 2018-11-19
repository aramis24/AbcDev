using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir la valeur de a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la valeur de b:");
            double b = double.Parse(Console.ReadLine());

             Console.WriteLine("Veuillez saisir la valeur de c:");
            double c = double.Parse(Console.ReadLine());

            double p = a + b + c;
            Console.WriteLine("Valeur du perimetre est de: {0:#,###.#} cm", p);

            double aire = Math.Sqrt((p/2)*(p/2 - a)*(p/2 - b)*(p/2 - c));
            Console.WriteLine("Valeur de l'aire est de:" + aire+);

            Console.ReadKey();



        }
    }
}
