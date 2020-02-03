using System;

namespace _4_diena_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            forLoopUzdevums3();      
        }


        static void forLoopUzdevums3() //Uzdevums3 - ievada skaitli ko kāpināt. Ievada pakāpi. Izvada rezultātu.
        {
            Console.WriteLine("Ievadi skaitli");
            String sk1 = Console.ReadLine();
            int baze = Convert.ToInt32(sk1);
            Console.WriteLine("Ievadi pakāpi");
            String sk2 = Console.ReadLine();
            int pakape = Convert.ToInt32(sk2);
            int rez = 1;
            for (int i=0; i<pakape; i++)
            {
                //rez *= baze; 
                rez = rez * baze;
                //Console.WriteLine("Skaitļu summa =>" + b);
            }
            Console.WriteLine("Šo skaitļu summa ir =>" + rez);
        }
        static void forLoopUzdevums2() //Uzdevums2 - ievada 5 skaitļus. Izvadam summu.
        {
            int b = 0;
            for (int i = 1; i <= 5; i++) //i++ ir salīdzinājums ar i=i+1, i=i+29
            {
                Console.WriteLine("Ievadi skaitli");
                String c = Console.ReadLine();
                int g = Convert.ToInt32(c);
                b = b+g; //b = (b + i);
                //Console.WriteLine("Skaitļu summa =>" + b);
            }
            Console.WriteLine("Šo skaitļu summa ir =>" + b);
        }
        static void forLoopUzdevums1() //Uzdevums1 - ar for ciklu palīdzību sasummēt skaitļus no 1 līdz 10, izvadīt summu
        {
            int b = 0;
            for (int i = 1; i <= 10; i++) //i++ ir salīdzinājums ar i=i+1, i=i+29
            {
                //Console.WriteLine("Ievadi frāzi");
                //String fraze = Console.ReadLine();
                b += i; //b = (b + i);
                Console.WriteLine(i +" + ");
                //Console.WriteLine("Skaitļu summa =>" + b);
            }
            Console.WriteLine("Šo skaitļu summa ir =>" + b);
        }
        static void forLoopExample()
        {
            for(int i = 1; i<101; i++) //i++ ir salīdzinājums ar i=i+1, i=i+29
            {
                //Console.WriteLine("Ievadi frāzi");
                //String fraze = Console.ReadLine();
                Console.WriteLine("Cikla pielietojums =>" + i);
            }
        }
        static void whileDoWhile()
        {
            int a = 0;
            while(a<10)
            {
                Console.WriteLine("Izvadi ciklu ->" + a);
                a++;
            }

        }
        static void dowhil()
        {
            int a = 0;
            do
            {
                Console.WriteLine("Izvadi ciklu ->" + a);
                a++;
            }
            while (a < 10);
        }
    }
}
