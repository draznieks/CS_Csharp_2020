using System;

namespace _3_dienas_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.MD
            //Cilvēks ievada skaitli, izvadīt vai skaitlis ir pozitīvs/negatīvs vai nulle.
            Console.WriteLine("Šajā uzdevumā tev jāievada skaitlis un jānospiež ENTER");
            Console.WriteLine("Pēc ENTER nospiešanas tev sistēma parādīs vai skaitlis ir pozitīvs, negatīvs vai nulle");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu ievadīji " + skaitlis); //Pārbaude, vai sistēma pareiz saprot ievadīto skaitli
            if (skaitlis > 0)
            {
                Console.WriteLine("Tavs ievadītais skaitlis " + skaitlis + " ir pozitīvs");
            }
            else if (skaitlis <0)
            {
                Console.WriteLine("Tavs ievadītais skaitlis " + skaitlis + " ir negatīvs");
            }
            else
            {
                Console.WriteLine("Tavs ievadītais skaitlis " + skaitlis + " ir nulle");
            }
        }
    }
}
