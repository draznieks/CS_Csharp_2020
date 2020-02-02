using System;

namespace _3_dienas_MD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //MD 3. Šajā uzdevumā humanoīdam jāievada skaitlis un sistēma pateiks vai tas ir pāra vai nepāra skaitlis
            //Jāizmanto  "mod" un "div" sintakses (% un /)
            Console.WriteLine("Ievadi jebkādu skaitli un nospied ENTER");
            Console.WriteLine("Sistēma tev pateiks vai tas ir pāra vai nepāra skaitlis");
            String ievade = Console.ReadLine();
            int num = Convert.ToInt32(ievade);
            if (num % 2 == 0)
            {
                Console.WriteLine("Ievadītais skaitlis " + num + " ir pāra skaitlis");
            }
            else
            {
                Console.WriteLine("Ievadītais skaitlis " + num + " ir nepāra skaitlis");
            }
        }
    }
}
