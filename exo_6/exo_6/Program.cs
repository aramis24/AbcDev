using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir le nombre A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le nombre B:");
            int B = int.Parse(Console.ReadLine());
            int temp = A;
            A = B;
            B = temp;
            //concatenation
            Console.WriteLine("La nouvelle valeur de A est:" + A);
            Console.WriteLine("La nouvelle valeur de B est:" + B);

            Console.ReadKey();



        }
    }
}
