using System;
using System.Collections.Generic;
using System.Text;

namespace _9_diena
{
    class Class1
    {
        public static void Ex1()
        {
            int[] a = new int[6];
            a[0] = 4;
            a[1] = 88;
            a[2] = 93;
            a[3] = 1;
            a[4] = 6;
            a[5] = 5;

            string[] b = new string[3];
            b[0] = "Dada";
            b[1] = "Joban";
            b[2] = "kaktuss";

            Console.WriteLine(a[0]);
            Console.WriteLine(b[1]);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
               //Console.WriteLine(b[i]);
            }

        }
    }
}
