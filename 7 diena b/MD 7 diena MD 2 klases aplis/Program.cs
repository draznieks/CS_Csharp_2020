using System;

namespace _7_diena_MD_2_klases_aplis
{
    class Program
    {
        static void Main(string[] args)
        {
            Double skaitlis = input();
            Aplis.setR(skaitlis);
            Aplis.getS();
        }

        static Double input()
        {
            Console.WriteLine("Ievadi skaitli");
            Double skaitlis = Convert.ToDouble(Console.ReadLine());
            return skaitlis;
        }
    }
}
