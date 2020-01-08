using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio r = new Radio();
            bool quit = false;
            
            Console.WriteLine("Would you like to turn on the radio? Yes or No"); 
            string choice = Console.ReadLine();
            
            if (choice.ToLower().Contains("yes"))
            {
                r.toggle();
                Console.WriteLine("You hear the satisfying click of the switch and the static of the radio");
                //do
                //{
                    r.tune();
                 //   Console.WriteLine("Wanna continue? Yes or No");
                 //   string response = Console.ReadLine();

                    
                 //   if (response.ToLower().Contains("no"))
                 //   {
                 //       quit = true;
                 //   }

              //  } while (!quit);
                
            }
            else
            {
                Console.WriteLine("You've chosen poorly!");
                Environment.Exit(0);
            }

        }
    }
}
