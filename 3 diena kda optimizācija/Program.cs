using System;

namespace _3_diena_kda_optimizācija
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cilveks ievada tris skaitlus- int
            //Jaizvada lielakais
            int skaitlis1 = ievade();
            int skaitlis2 = ievade();
            int skaitlis3 = ievade();

            int biggest = biggestNumber(skaitlis1, skaitlis2);
            Console.WriteLine("Lielākais ksiatlis ir " + biggest);
        }
        static int ievade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);
            return skaitlis;
        }
        static int size()
        {
            Console.WriteLine("Ievadiet skaitli!");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int biggestNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}