using System;

namespace _7_diena_objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            skaitlaIevade2();
        }
        static void skaitlaIevade2()
        {
            //Klases nosaukums ir trijstūris
            //Cilvēks ievada 3 malu vērtības - mainīgie jaunajā klasē
            //Metodi, kas izvada perimetru mala + mala + mala
            //Visa ievade un izvade notiek no main- WriteLine un ReadLine
            //Ja kāda mala ir 0, par to ir jāpaziņo
            Console.WriteLine("Šīs programmas nosaukums ir trijstūris");
            int sk1 = input();
            int sk2 = input();
            int sk3 = input();

            trinity.setA(sk1);
            trinity.setB(sk2);
            trinity.setC(sk3);

            trinity.Summa();
        }
        static void skaitlaIevade()
        {
            //Uztiasīt jaunu klasi ar nosaukumu Skaitļu summa - done
            //Cilvēks ievada 2 int skaitļus no main
            //Uztaisa lai būt Get Set un lai būtu publiska metode, kas izvada abu skaitļu summu
            //Abiem skaitļiem jābūt pieejamiem visā skaitļu summu klasē
            //Bet no programm CS klases tikai ar Get un Set
            Console.WriteLine("ŠĪ programma tev saskaitīs divus skaitļus");
            int sk1 = input();
            int sk2 = input();

            skaitlusumma.setA(sk1);
            skaitlusumma.setB(sk2);

            skaitlusumma.Summa();
        }
        static int input()
        {
            Console.WriteLine("Ievadi skaitli"); 
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);
            return skaitlis;
        }

    }
}
