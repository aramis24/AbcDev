using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_4_1_enonce_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("lecture de l'enonce ");
            Console.WriteLine(" Avez vous compris l'enonce ?(o/n)");
            reponse = Console.ReadLine();

            if (reponse == "n")
            {
                Console.WriteLine("relecture de l'enonce");
                Console.WriteLine("avez vous compris l'enonce?(o/n)");
                reponse = Console.ReadLine();
                if (reponse == "n")
                {
                    Console.WriteLine("appel le formateur");


                }
                else
                {
                    Console.WriteLine("passer a l'ennonce suivant");
                }
            }

            else
            {
                Console.WriteLine("passer a l'enonce suivant");
            }
            Console.ReadKey();

        }
    }
}
