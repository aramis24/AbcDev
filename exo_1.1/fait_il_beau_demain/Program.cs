using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fait_il_beau_demain
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;

            Console.WriteLine("Fait-il beau demain ? (o/n)");
            reponse = Console.ReadLine().ToLower();
            if (reponse == "o")
            {
                Console.WriteLine("je fais une balade");
                Console.WriteLine(" bicyclette en bonne état ??? (o/n)");
                reponse = Console.ReadLine();
                if (reponse == "o")
                {
                    Console.WriteLine("je me balade en vélo"); 
                }
                else
                {
                    Console.WriteLine("je vais chez le garagiste");
                    Console.WriteLine("réparations rapides ? (o/n)");
                    reponse = Console.ReadLine();
                    if (reponse == "o")
                    {
                        Console.WriteLine("je me promène en vélo");
                    }
                    else
                    {
                        Console.WriteLine("je me balade à pieds");
                    }
                }
            
      
            }
            else
            {
                Console.WriteLine("je lis un livre à la maison");
                Console.WriteLine("M.Bovary dans le salon ?? (o/n)");
                reponse = Console.ReadLine();
                if (reponse =="o")
                {
                    Console.WriteLine("je lis le livre Madame Bovary");
                }
                else
                {
                    Console.WriteLine("Madame Bovary à la bibliothèque (o/n)");
                    reponse = Console.ReadLine();
                    if (reponse =="o")
                    {
                        Console.WriteLine("je relis le livre M.Bo");
                    }
                    else
                    {
                        Console.WriteLine("je lis un roman policier");
                    }
                }


            } Console.ReadKey();
        }

    }
}
