using System;

namespace _7_diena_kalkulators
{
    class Program
    {
        static void Main(string[] args)
        {
            kalk();
        }
        static void kalk()
        {
            //Uztaisīt statisku klasi, kur ir metodes: saskaitīt, atmest, reizināt, dalīt 
            //Padodam skaitļus iekšā kā parametrus katrai metodei atsevišķi
            Console.WriteLine("Šī programma ir kalkulātors");
            Console.WriteLine("Tev jāievada skaitlis, pēc tam jāspiež Enter, tad ievadīsi, kas ar to skaitli ir jādara");
            Console.WriteLine("Ievadi skaitli");

            Double skaitlis1 = input();
            Console.WriteLine("Ievadi darbību, ko ar šo skaitli darīsi +, -, *, /");
            String ievade2 = Console.ReadLine();
            Console.WriteLine("Ievadi otru skaitli");
            Double skaitlis2 = input();

            if (ievade2 == "-")
            {
                Console.WriteLine(skaitlis1 - skaitlis2);
            }
            else if (ievade2 == "+")
            {
                Console.WriteLine(skaitlis1 + skaitlis2);
            }
            else if (ievade2 == "*")
            {
                Console.WriteLine(skaitlis1 * skaitlis2);
            }
            else if (ievade2 == "/")
            {
                Console.WriteLine(skaitlis1 / skaitlis2);
            }
            else
            {
                Console.WriteLine("Tu nespēlē pēc spēles nosacījumiem!");
            }

        }
        static double input()
        {
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            return skaitlis;
        }

    }
}
