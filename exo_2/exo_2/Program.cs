using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir le rayon r:");
            double r = double.Parse(Console.ReadLine());

            double aire = Math.PI*Math.Pow(r,2)*4;
                Console.WriteLine("aire:" + aire);

                double volume = (Math.PI * 4) / 3 * Math.Pow(r, 3);
                Console.WriteLine("volume:" + volume);


            Console.ReadKey();

        }
    }
}
