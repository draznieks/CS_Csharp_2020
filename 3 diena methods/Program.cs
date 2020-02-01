using System;

namespace _3_diena_methods
{
    class Program
    {
        static void Main(string[] args)
        {
             /* piemers1();
             piemers2();
             piemers3(3,7);
             int c = piemers4();*/

            //1. Saskaitīšana
            //Ievads Main metodē, padodam skaitļus uz mūsu izveidotu ka parametru
            //izvade notiek tur

            //2. Saskaitīšana
            //Ievads notiek mūsu izveidotā metodē
            //Rezultātu atgriežam ar return un izvadam main

            //3. Apvienojam 1 un 2.
            //Mūsu izveidotā metodē notiek darbība
            //Visa ievade/izvade notiek main (gan parametri, gan return)

            /*Uzdeums1
            Console.WriteLine("Ievadi skaitli");
            String ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade1);

            Console.WriteLine("Ievadi otru skaitli");
            String ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade2);

            int a = skaitlis1 + skaitlis2;

            Console.WriteLine("Abu skaitļu summa ir " + a); */

            //Uzdevums3
            Console.WriteLine("Ievadi skaitli");
            String ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade1);

            Console.WriteLine("Ievadi otru skaitli");
            String ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade2);
            Uzdevums3(skaitlis1, skaitlis2);
            Console.WriteLine("Abu skaitļu summa ir " + Uzdevums3());
        }
        static int ievads()
        {
            Console.WriteLine("Ievadi skaitli");
            String ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt32(ievade1);

            Console.WriteLine("Ievadi otru skaitli");
            String ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt32(ievade2);

            return skaitlis1 + skaitlis2;

        }
        
        static int Uzdevums3(int a, int b)
        {
            return a + b;
        }

        static void uzdevums1()
        {
            Console.WriteLine("Ievadi skaitli");
        }

        static void piemers1()

        {
            Console.WriteLine("Parasta void metode");
        }
        static void piemers2()

        {
            //Metodes jāizsauc. Ja nē, lieka koda rinda. Tā jāizsauc no main, vai no citas rindas
            Console.WriteLine("Otrā void metode");
        }

        static void piemers3(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static int piemers4()
        {
            int sk1 = 6;
            int sk2 = 7;

            return sk1 + sk2;
        }
        static String piemers5()
        {
            Console.WriteLine("Ievadi kādu skaitli");
            String ievads = Console.ReadLine();

            return ievads;
        }
    }
}
