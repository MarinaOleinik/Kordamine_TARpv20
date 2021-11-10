using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Program
    {       
        static int Saali_suurus()
        {
            Console.WriteLine("Vali saali suurus: 1,2,3");
            int suurus = int.Parse(Console.ReadLine());
            return suurus;
        }
        static int[,] saal = new int[,] { };
        static int[] ost = new int[] { };
        static int kohad, read, mitu, mitu_veel;
        static void Saali_taitmine(int suurus)
        {              
            Random rnd = new Random();           
            if (suurus==1)
            {kohad = 20;read = 10;}
            else if (suurus==2)
            {kohad = 20;read = 20;}
            else
            {kohad = 30;read = 20;}
            saal = new int[read, kohad];
            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
        }
        static void Saal_ekraanile()
        {
            Console.Write("     ");
            for (int koht = 0; koht < kohad; koht++)
            {
                if (koht.ToString().Length == 2)
                { Console.Write(" {0}", koht + 1); }
                else 
                { Console.Write("  {0}", koht + 1); }
            } 
 
            Console.WriteLine();
            for (int rida = 0; rida < read; rida++)
            {
                Console.Write("Rida "+ (rida+1).ToString()+":");
                for (int koht = 0; koht < kohad; koht++)
                {
                    
                    Console.Write(saal[rida, koht]+"  ");
                }
                Console.WriteLine();
            }
        }
        static bool Muuk_ise()
        {
            Console.WriteLine("Rida:");
            int pileti_rida = int.Parse(Console.ReadLine());
            Console.WriteLine("Koht:");
            int pileti_koht = int.Parse(Console.ReadLine());
            if (saal[pileti_rida, pileti_koht] ==0)
            {
                saal[pileti_rida, pileti_koht] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Muuk()
        {   Console.WriteLine("Rida:");
            int pileti_rida = int.Parse(Console.ReadLine());
            Console.WriteLine("Mitu piletid:");
            mitu = int.Parse(Console.ReadLine());
            ost = new int[mitu];
            int p =(kohad-mitu)/2;
            bool t = false;
            int k = 0;               
                do {
                    if (saal[pileti_rida, p ] == 0)
                    {ost[k] = p ;
                    Console.WriteLine("koht {0} on vaba", p);
                    t = true;}
                    else 
                    {Console.WriteLine("koht {0} kinni", p);
                    t = false;
                    ost = new int[mitu];
                    k = 0;
                    p = (kohad - mitu) / 2;
                    break;}
                    p++;
                    k++;
                } while (mitu!=k);
            if (t==true)
            {
                Console.WriteLine("Sinu kohad on:");
                foreach (var koh in ost)
                {
                    Console.WriteLine("{0}\n", koh);
                }
                
            }
            else
            {
                Console.WriteLine("Selles reas ei ole vabu kohti. Kas tahad teises reas otsida?");
            }
            return t;
        }
        public static void Main(string[] args)
        {
            int suurus = Saali_suurus();
            Saali_taitmine(suurus);
            while (true)
            {
                Saal_ekraanile();
                Console.WriteLine("1-ise valik, 2-masina valik");
                int valik = int.Parse(Console.ReadLine());
                if (valik==1)
                {
                    int koh = 1;
                    Console.WriteLine("Mitu pileteid tahad osta?");
                    int kogus = int.Parse(Console.ReadLine());
                    bool muuk = true;
                    while (muuk)
                    {
                        for (int i = 0; i < (kohad)*(read); i++)//kui valime 0-d
                        {
                            muuk=Muuk_ise();
                            if (muuk) {koh++;}
                            Console.WriteLine("{0}: {1}", kogus,koh);
                            if (koh == kogus) { break; }
                        }
                    } 
                }
                else 
                {
                    bool muuk = false;
                    while (muuk!=true)
                    {
                        muuk=Muuk();
                    } 
                }   
            }            
            //Console.ReadLine();
        }
    }
}
