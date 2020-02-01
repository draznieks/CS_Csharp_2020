using System;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi burtu virkni");
            String input = Console.ReadLine();
            String compare = "aaaaaaa";
            if (input.Length >= 7 && input == "aaaaaaa")
              {
                  Console.WriteLine("Ievadīji pareizās vērtības");
              }
            else
              {
                  Console.WriteLine("Atkal esi losis. Ievadīji nepareizi!");
              }
        }

        static void piemers()
        {
            Console.WriteLine("Ievadiet skaitli");
            String input = Console.ReadLine();
            int skaitlis = Convert.ToInt32(input);
            if (skaitlis > 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("#");
            }
        }
    }
}
