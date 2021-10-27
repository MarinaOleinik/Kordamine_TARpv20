using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Startclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            if (eesnimi.ToLower()=="juku")
            {
                Console.WriteLine("Tule minu juurde külla! Lähme kinno! Kui vana sa oled ? { }",eesnimi);
                int vanus = int.Parse(Console.ReadLine());
                if (vanus<0 || vanus>=120)
                {
                    Console.WriteLine("Viga andmetega!");
                }
                else if (vanus<=6)
                {
                    Console.WriteLine("Tasuta pilet!");
                }
                else if (vanus>6 && vanus<=14)
                {
                    Console.WriteLine("Lastepilet!");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }

            int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);

            Console.ReadLine();
        }
    }
}
