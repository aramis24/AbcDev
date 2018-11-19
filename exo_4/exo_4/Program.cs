using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisr le rayon R:");
            int R = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir l'angle A:");
            int A = int.Parse(Console.ReadLine());

            double aire = ((Math.PI*Math.Pow(R,2)*A)/(360);
            Console.WriteLine("résultat aire du secteur circulaire:" + aire);

            Console.ReadKey();


        }
    }
}
