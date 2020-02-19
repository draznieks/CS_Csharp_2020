using System;

namespace MD_8_diena_generate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot jaunu klasi
            //Jābūt laukam, kur glabāsies int
            //1-10 (konstruktorā)
            //getNumber, kas atgriež šo skaitli
            //regenerate Number() - no jauna uzģenerē gadījuma skaitli
            int Janis = 0;
            int Peteris = 0;
            int j = 0;
            int p = 0;
            int g = 0;
            int uzvaras = 10;
            while (Janis < uzvaras && uzvaras > Peteris)
            {
                generate a = new generate(g);
                j = a.gen();
                p = a.gen();
                Console.Write("Jānim " + j + " Pēterim " + p);
                if (j > p)
                {
                    Janis++;
                    Console.WriteLine(" Uzvarēja Jānis. Jānim " + Janis + " Uzvaras");
                }
                else if (j < p)
                {
                    Peteris++;
                    Console.WriteLine(" Uzvarēja Pēteris. Pēterim " + Peteris + " uzvaras");
                }
                else
                {
                    Console.WriteLine(" Neizšķirts");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            if (Janis > Peteris)

            {
                Console.WriteLine("Spēli uzvarēja Jānis ");
            }
            else
            {
                Console.WriteLine("Spēli uzvarēja Pēteris");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
