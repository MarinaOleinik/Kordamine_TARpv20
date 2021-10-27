using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Abivahend
    {
        public static void Main(string[] arg)
        {
            int arv;
            int[] arvud = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sisesta {0} arv:", i + 1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            foreach (var a in arvud)
            {
                Console.Write(a);
            }
            int arv4 = 0;
            Array.Reverse(arvud);
            foreach (var a in arvud)
            {
                arv4 = arv4 * 10 + a;

            }
            Console.Write(arv4);
            Console.ReadLine();

            Console.WriteLine(Alamprogramm.Korruta(3, 6));
            Double arv1 = 5;
            Double arv2 = 6;
            string text = "AAAAA BBB RRR OOOOO";
            string[] texts=text.Split(' ');
            foreach (var t in texts)
            {
                Console.WriteLine(t);
            }
            
            Double result = Alamprogramm.Eval(arv1.ToString()+"+"+arv2.ToString());
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
