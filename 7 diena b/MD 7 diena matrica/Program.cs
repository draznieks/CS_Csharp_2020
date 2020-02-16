using System;

namespace MD_7_diena_matrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ŠĪ programma tev izvadīs matricu");
            int a = input();
            int b = input();
            int i2 = 0;
            do
            {
                int i1 = 0;
                {
                    do
                    {
                        Console.Write("#", i1);
                        i1++;
                    } while (i1 < a);
                }
                i2++;
                Console.WriteLine();
            } while (i2 < b);
        }
        static int input()
        {
            Console.WriteLine("Ievadi skaitli");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            return skaitlis;
        }
    }
}
