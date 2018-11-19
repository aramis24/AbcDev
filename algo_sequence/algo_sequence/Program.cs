using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_sequence
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("hello world bienvenue !");

            Console.Write("veuillez saisir un nombre A:");

            int a = int.Parse(Console.ReadLine());

            Console.Write("veuillez saisir un nombre B:");

            int b = int.Parse(Console.ReadLine());

            //Calcul de la moyenne;

            double moy = (a + b) / (double)2;

            Console.WriteLine("la moyenne des 2 nombres est :" + moy);


            Console.ReadKey();
        }
    }
}
