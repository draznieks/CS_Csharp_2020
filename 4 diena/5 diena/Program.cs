using System;

namespace _5_diena
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Paskatīties kā strādā while cikls un uztaisīt kalkulatoru ar menu, kad no programmas iziet tikai, kad lietotājs to izvēlas
            //(Var jautāt pēc katras rezultāta izvades)
            while (skaitlaIevade == "q")
            {
                Console.WriteLine("Šī programma ir kalkulātors");
                Console.WriteLine("Lai izietu, nospied Q");
                Console.WriteLine("Ievadi pirmo skaitli");
                int sk1 = ievade();
                Console.WriteLine("Ievadi darbību, ko gribi ar to skaitli darīt");
                Console.WriteLine("+ saskaitīt; - atņemt; * reizināt; / dalīt");
                String darb = Console.ReadLine();
                Console.WriteLine("Ievadi otro skaitli");
                int sk2 = ievade();
                if (darb == "+")
                {
                    Console.WriteLine("Rezultāts ir " + (sk1 + sk2));
                }
                else if (darb == "-")
                {
                    Console.WriteLine("Rezultāts ir " + (sk1 - sk2));
                }
                else if (darb == "*")
                {
                    Console.WriteLine("Rezultāts ir " + (sk1 * sk2));
                }
                else if (darb == "/")
                {
                    Console.WriteLine("Rezultāts ir " + (sk1 / sk2));
                }
            }

            static int ievade()
            {
                String skaitlaIevade = Console.ReadLine();
                int skaitlis = Convert.ToInt32(skaitlaIevade);
                return skaitlis;
            }

            /*for (int i = 0; i<0; i++)
            {
                Console.WriteLine("Raksti B");
                String input = Console.ReadLine();
                input = input.ToUpper();
                if(input =="y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/
            static void faktorial() //1.uzdevums 5tai dienai;
            {
                Console.WriteLine("Ievadi skaitli, no kura gribi dabūt FAKtoriāli");
                String ievade = Console.ReadLine();
                int fak = Convert.ToInt32(ievade);
                int baze = 1;
                for (int i = 1; i <= fak; i++)
                {
                    baze = baze * i;
                    Console.WriteLine(baze);
                }
            }
        }
    }
}
