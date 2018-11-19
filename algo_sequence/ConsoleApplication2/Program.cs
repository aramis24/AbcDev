using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)

        {Console.WriteLine("veuillez saisir le rayon R:");
        int R = int.Parse(Console.ReadLine());

        Console.WriteLine("veuillez saisir l'angle a:");
        int a = int.Parse(Console.ReadLine());

            //calcul aire 
        double aire = ((Math.PI * Math.Pow(R, 2)) / 360);
        Console.WriteLine("résultat aire du secteur circulaire:" + aire);

        Console.ReadKey();

        }
    }
}
