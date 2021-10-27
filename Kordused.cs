using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Kordused
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            /*int N = rnd.Next(2, 6);
            int M = rnd.Next(7, 14);
            int[] mass = new int[M+1 - N] ;
            Console.WriteLine(N);
            Console.WriteLine(M);
            for (int i = N; i < M+1; i++)
            {
                mass[i-N] = i;
                Console.Write( i * i);
            }
            foreach (var m in mass)
            {
                Console.Write(" {0} ",m);
            }
            string[] nimed = new string[8] {"A","B","C","D","E","F","G","H"};
            nimed[2] = "Anna";
            int nr = 0;
            while (nr<8)
            {               
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr = nr + 1;
            }
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[i]);
            }
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere, {0} õpilane", nimi);
            }
            nr = 0;
            do
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr ++;
            } while (nr!=nimed.Length);

            int A = rnd.Next(1, 25);//arvuti arv
            int AA; //kasutaja arv
            int K = 1;//katsed
            do
            {
                Console.WriteLine("{0}. Katse. Mis arv?", K);
                AA = int.Parse(Console.ReadLine());
                K++;
            } while (AA!=A && K!=6);
            if (AA==A)
            {
                Console.WriteLine("Palju õnne!");
            }
            else
            {
                Console.WriteLine("Proovi veel!");
            }*/
            int arv;
            int[] arvud = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sisesta {0} arv:",i+1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            
            int arv4=0;
            Array.Reverse(arvud);
            foreach (var a in arvud)
            {
                arv4 = arv4 *10+a;
            }
            Console.Write(arv4);
            Console.ReadLine();
        }
    }
}
