using System;

namespace Istaa_day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ģēnijs ievada 3 skaitļus - int
            //Jāizvada lielākais

            Console.WriteLine("Šī programma pateiks tev kurš skaitlis ir lielāks");
            Console.WriteLine("Tev jāievada skaitlis, pēc tam jāspiež Enter, tad ievadīsi, otro skaitli.");
            Console.WriteLine("Ievadi skaitli");
            String ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade1);
            Console.WriteLine("Ievadi otru skaitli");
            String ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade3);
            String ievade3 = Console.ReadLine();
            int skaitlis3 = Convert.ToInt32(ievade3);

            if (skaitlis1 >= skaitlis2)
            {
                Console.WriteLine("Lielākais skaitlis ir "+ skaitlis1);
            }
            else if (skaitlis1 <= skaitlis2)
            {
                Console.WriteLine("Lielākais skaitlis ir " + skaitlis2);
            }
            else
            {
                Console.WriteLine("Lielākais skaitlis ir "+ skaitlis2);
            }
        }

        static void uzd1()
        {
            //Kalkulātors
            //Humanoīds ievada divus skaitļus
            //Humanoīds ievada ko grib darīt ar skaitļiem // +, -, *, /
            //Uz ekrāna izvada rezultātu
            //Ja humanoīds 
            Console.WriteLine("Šī programma ir kalkulātors");
            Console.WriteLine("Tev jāievada skaitlis, pēc tam jāspiež Enter, tad ievadīsi, kas ar to skaitli ir jādara");
            Console.WriteLine("Ievadi skaitli");
            String ievade1 = Console.ReadLine();
            Double skaitlis1 = Convert.ToDouble(ievade1);
            Console.WriteLine("Ievadi darbīb, ko ar šo šmurguli darīsi +, -, *, /");
            String ievade2 = Console.ReadLine();
            Console.WriteLine("Ievadi otru šrmuguļa skaitli");
            String ievade3 = Console.ReadLine();
            Double skaitlis2 = Convert.ToDouble(ievade3);

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
                Console.WriteLine("Šmurguli! Tu nespēlē pēc spēles nosacījumiem!");
            }
        }


        static void piemers()
        {
            int a = 5;
            int b = 6;
            // && tas nozīmē UN
            // Jāizpildas abiem nosacījumiem
            if(a > 5 && b ==6)
            {

            }
            // ||
            //Jāizpildas vienam nosacījumam
            if (a > 5 || b == 6)
            {

            }

            //int skaitlis = 5;
            //#
            //##
            //###
            //>5, <5, ==5
            Console.WriteLine("Ievadi skaitli");
            String ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(ievade);

            if(skaitlis >5)
            {
                Console.WriteLine("Skaitlis ir lielāks par 5");
            }
            else if(skaitlis <5)
            {
                Console.WriteLine("Skaitlis ir mazāks par 5");
            }
            else
            {
                Console.WriteLine("skaitlis ir vienāds ar 5");
            }
        }
    }
}
