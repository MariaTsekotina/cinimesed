using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsekotina_cpspiski
{
    class Program
    {
        static void Main(string[] args)
        {

            List<inimene> inimesed = new List<inimene>();
            inimesed.Add(new inimene() { Nimi = "Madis" });
            inimesed.Add(new inimene() { Nimi = "Kelli" });

            foreach (inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi);
            }




            string[] nimed0 = new string[3] { "Mati", "Kati", "Juki" };
            List<string> nimed = new List<string>(nimed0);

            Console.WriteLine("Sisesta nime listisse");
            nimed.Add(Console.ReadLine());
            nimed.Insert(0, "Maria");
            if (nimed.Contains("Maria"))
            {
                Console.WriteLine("Sellina nimi on olemas"+"ta on {0} kohal",nimed.IndexOf("Maria"));
            }
            else
            {
                Console.WriteLine("Selline nimi puudub nimekirjas");
            }
            foreach (string item in nimed)
            {
                Console.WriteLine(nimed);
            }

            Console.ReadKey();
        }
    }
}
