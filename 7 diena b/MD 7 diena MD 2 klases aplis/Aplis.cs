using System;
using System.Collections.Generic;
using System.Text;

namespace _7_diena_MD_2_klases_aplis
{
    public class Aplis
    {
        private static Double r = 0;
        private static Double Pi = 3.14;
        private static Double S = 0;

        public static void setR(Double skaitlis)
        {
            r = skaitlis;
        }
        public static void getS()
        {
            Laukums();
            print();
        }
        private static void Laukums()
        {
            S = Pi * r * r;
        }
        private static void print()
        {
            Console.WriteLine("Rādius ir " + r + " un laukums ir " + S);
        }


    }
}
