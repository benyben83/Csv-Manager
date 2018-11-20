using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal somme = 0.97m;
            Console.WriteLine(rendreMonnaie(somme));
            Console.ReadKey();

            string rendreMonnaie(decimal prix)
            {
                decimal piece50 = 0.5m;
                decimal piece20 = 0.2m;
                decimal piece10 = 0.1m;
                decimal piece5 = 0.05m;
                decimal piece2 = 0.02m;
                decimal piece1 = 0.01m;

                StringBuilder builder = new StringBuilder("Le monsieur te rend :");

               
                    while (prix >= piece50)
                    {
                        prix -= piece50;
                        builder.Append("une piece de 50 centimes, ");
                    } while (prix >= piece20)
                    {
                        prix -= piece20;
                        builder.Append("une piece de 20 centimes, ");
                    } while (prix >= piece10)
                    {
                        prix -= piece10;
                        builder.Append("une piece de 10 centimes, ");
                    } while (prix >= piece5)
                    {
                        prix -= piece5;
                        builder.Append("une piece de 5 centimes, ");
                    } while (prix >= piece2)
                    {
                        prix -= piece2;
                        builder.Append("une piece de 2 centimes, ");
                    } while (prix >= piece1)
                    {
                        prix -= piece1;
                        builder.Append("une piece de 1 centimes, ");
                    

                }
                return builder.ToString();

            }
        }
    }
}
