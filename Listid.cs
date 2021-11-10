using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Listid
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadLine();

            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);
            
            LinkedList<int>.Enumerator ahel = loetelu.GetEnumerator();
            while (ahel.MoveNext())
            {
                Console.WriteLine(ahel.Current);
            }
            Console.ReadKey();

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);




            LinkedList<int>.Enumerator uus_ahel = loetelu.GetEnumerator();
            while (uus_ahel.MoveNext())
            {
                Console.WriteLine(ahel.Current);
            }
            Console.ReadKey();
            loetelu.AddRange(new int[] { 111, 1111, 111111, 11111 });

            Console.ReadKey();

        }

    }
}
