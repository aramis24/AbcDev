using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_42
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

                Console.WriteLine("Bicyclette en etat ? (o/n)");
                reponse = Console.ReadLine();

                if (reponse == "o")
                {
                    Console.WriteLine(" je fais une balade à vélo ");

                    if (reponse == "o")
                    {
                        Console.WriteLine("je fais une balade à vélo");
                    }
                    else
                    {
                        Console.WriteLine("je marche à pieds");

                       
                    }
                }
                else
	            {
                    Console.WriteLine("je vais chez le garagiste");
                    Console.WriteLine("réparation rapide??? (o/n)");
                    reponse = Console.ReadLine();
	            }
            } // FIN reponse == "o" 1er if
            else
            {
                Console.WriteLine("je lis un livre à la maison");
                Console.WriteLine("M.Bovary dans le salon?? o/n");
                reponse = Console.ReadLine();

                if (reponse == "o")
                {
                    Console.WriteLine("je lis le livre M.Bo");
                     
                }
                else
                {
                    Console.WriteLine("MadameBovary à la bibliothèque?? (o/n)");
                    reponse = Console.ReadLine();

                      
                }
                if (reponse == "o")
                {
                    Console.WriteLine("je lis le livre de madame bovary");
                }
                else
	            {
                    Console.WriteLine("je lis un bouquin policier");
                    
	            }
            }
            Console.ReadKey();


               
            {
              
                {
                    
                }

            
                
            }

        }
    }
}
