using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_franck_cours
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            Console.WriteLine("Est-ce qu'il fera beau? O/N");
            reponse = (Console.ReadLine()).ToUpper();
            //reponse = reponse.ToUpper();
            if (reponse=="O")
            {
                Console.WriteLine("Je plante des tulipes!!!");
            }
            else
            {
                Console.WriteLine("J'ecoute de la musique !");
            }
            

	}





            Console.ReadKey();

        }

    }
}




