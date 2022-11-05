using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public class Program
    {
        public static bool EstPremier(int p)
        {
            if (p < 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < p; i++)
                {
                    if (p % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }


        }
        static void Main(string[] args)
        {


            int p = 0;
            do
            {
                Console.WriteLine("Veuillez entrez un nombre :");

            } while (!int.TryParse(Console.ReadLine(), out p));

            if (EstPremier(p))
            {
                Console.WriteLine("Le nombre est premier");
            }
            else
            {
                Console.WriteLine("Le nombre n'est premier");
            }


        }
    }
}
