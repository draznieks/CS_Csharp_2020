using System;
using System.Collections.Generic;
using System.Text;

namespace _7_diena_objekti
{
    public class skaitlusumma
    {/*
        //ExampleClass.test();
        //Console.WriteLine(ExampleClass.a);

        Console.WriteLine(skaitluSumma.getA());

            Console.WriteLine("Ievadi skaitli");
            String input = Console.ReadLine();
        int skaitlis = Convert.ToInt32(input);

        SavaKlase.setA(skaitlis);
            Console.WriteLine(SavaKlase.getA()); */
        private static int a = 0;
        private static int b = 0;

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
        public static void Summa()
        {
            Console.WriteLine("Summa ir " + (a + b));
        }
    }

}
