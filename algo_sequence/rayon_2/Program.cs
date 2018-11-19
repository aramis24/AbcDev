using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rayon_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("veuillez saisir le rayon R:");

            int Rayon = int.Parse(Console.ReadLine());


            double aire = (Math.PI) * 4 * Math.Pow(Rayon, 2);
            Console.WriteLine("résultat aire : " + aire);
           
            double volume = (Math.PI*4/3)*(Math.Pow(Rayon, 3));
            Console.WriteLine("résultat volume : " + volume);
            
            Console.ReadKey();

        }
    }
}
