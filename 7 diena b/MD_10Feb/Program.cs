using System;

namespace MD_10Feb
{
    class Program // ŠĪ programma piedāvā ievadīt 6 skaitļus un izvada lielāko
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Šis uzdevums jums piedāvās ievadīt 6us skaitļus un izvadīs lielāko skaitli");
            int a = input();
            int b = input();
            int c = input();
            int d = input();
            int e = input();
            int f = input();
            //Math.Max var tikai salīdzināt divus skaiļus
            int max = Math.Max(f, Math.Max(e, Math.Max(d, Math.Max(c, Math.Max(a, b)))));
            Console.WriteLine("Lielākais skaitlis ir " + max);

        }
        static int input()
        {
            Console.WriteLine("Ievadi skaitli");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            return skaitlis;
        }
    }
}
