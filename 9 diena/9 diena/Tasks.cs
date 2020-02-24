using System;
using System.Collections.Generic;
using System.Text;

namespace _9_diena
{
    class Tasks
    {
        //Uztaisīt masīvu, kuram garumu ievada lietotājs
        //Pēc tam, lai lietotājs, šo masīvu aizpilda ar izvēlētām vērtībām
        //Masīva aizpildīšanai izmanto FOR ciklu
        //Izvada masīvu
        public static void Ex2()
        {
            Console.WriteLine("Ievadi masīva garumu");
            int masGar = Convert.ToInt32(Console.ReadLine());
            int [] value = new int[masGar];
            for (int i = 0; i<value.Length; i++)
            {
                Console.WriteLine("Ievadi " + (i+1) + " elementu");
                value[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <value.Length; i++)
            {
                Console.Write(value[i] + " ");
            }
        }
        public static void Ex3()
            //Masīvs ar 5 elementiem
            //Tas ir string tipa
            //Pirmos 4 aizpilda cilvēks
            //5 elementā glabājas pārējo elementu summa
        {
            Console.WriteLine("Ievadi masīva garumu");
            int masGar = Convert.ToInt32(Console.ReadLine());
            String[] value = new String[masGar];
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine("Ievadi " + (i + 1) + " elementu");
                value[i] = Console.ReadLine();
                //value[i] = value[i] + value[i];
            }
            for (int i = 0; i < value.Length; i++)
            {
                Console.Write(value[i] + " ");
            }
        }

    }
}
