using System;

namespace _2_diena
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 6;

            Console.WriteLine("Ievadi skaitli. Ja būs mazāks par 5, tad būs redzami simboli #. JA TU LOSI IEVADĪSI LIELĀKU, TAD HUJOVA.. DABŪSI VESELUS TIKAI DIVUS ##.");
            String a = Console.ReadLine();
            int ab = Convert.ToInt32(a);

            if (ab>5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("Losis! Dabūji tikai vienu #");
                a = Console.ReadLine();
                Console.WriteLine("Bē bē.. LOSIS! Dari ko gribi! Losis vienalga esi!");
            }
            //>
            //<
            //<=
            //>=
            //==
            /*String piem = "aaa";
            if(piem == "aaa")
            {

            }
                else
                    {

                    }
            int c= piem.Length; */
        }

        static void piemers()
        {
            //int a = 0;
            //int b = 0;

            //int c = a + b;

            Console.WriteLine("Ievadi esošo gadu");
            Console.WriteLine("Un tad nospied ENTER");
            String gads = Console.ReadLine();            
            int pieskirtsNr1 = Convert.ToInt32(gads);

            String vecums = Console.ReadLine();
            int pieskirtsNr2 = Convert.ToInt32(vecums);

            //int a = gads - vecums;

            //Console.WriteLine("Jūau vcums ir = " + a);
            //Console.WriteLine("Skaitlis b = " + b);
            //Console.WriteLine("Skaitlis a = " + a);

            //String virkne1 = "vertiba";
            //String virkne2 = " ir";

            //Console.WriteLine(c);
        }
        static void Uzdevums1()
        {
            //int a = 0;
            //Lietotājam paprasam kurš gads
            //Lietotājs ievada
            //Lietotājam paprasam kurā gadā dzimis
            //Lietotājs ievada
            //Atņemam skaitļus, lai izvadītu starpību
            //Izvadam vecums ir vērtība

            Console.WriteLine("Ievadi esošo gadu");
            Console.WriteLine("Un tad nospied ENTER");
            String gads = Console.ReadLine();
            int pieskirtsNr1 = Convert.ToInt32(gads);

            Console.WriteLine("Ievadi savu dzimšanas gadu");
            Console.WriteLine("Un tad nospied ENTER");
            //String vecums = Console.ReadLine();
            gads = Console.ReadLine();
            int pieskirtsNr2 = Convert.ToInt32(gads);

            int a = pieskirtsNr1 - pieskirtsNr2;

            Console.WriteLine("Jūsu vecums ir = " + a);
        }

    }
}
