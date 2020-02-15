using System;
using System.Collections.Generic;
using System.Text;

namespace _7_diena_objekti
{
    public class trinity
    {
        private static int a = 0;
        private static int b = 0;
        private static int c = 0;

        public static void setA(int par1)
        {
            a = par1;
        }
        public static int getA()
        {
            return a;
        }

        public static void setB(int par1)
        {
            b = par1;
        }
        public static int getB()
        {
            return b;
        }
        public static void setC(int par1)
        {
            c = par1;
        }
        public static int getC()
        {
            return c;
        }
        public static void Summa()
        {
            Console.WriteLine("Malu summa ir " + (a + b + c));
        }
    }
}
