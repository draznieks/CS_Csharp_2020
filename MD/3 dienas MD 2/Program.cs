﻿using System;

namespace _3_dienas_MD_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atrast kā ģenerēt random skaitļus (gadījuma skaitļus) diapazonā no 1 - 7. Un izvadīt pretī attiecīgo dienu. (tiek ģenerēts 5- izvadam piektdiena, 2- Otrdiena, utt)
            again:

            Random rnd = new Random();
            int num = rnd.Next(1, 7);
            //String day = Convert.ToString(num);
            if (num == 1)
            {
                Console.WriteLine(Teksts1() + num + Teksts2() + "Pirmdiena");
            }
            else if (num == 2)
            {
                Console.WriteLine(Teksts1() + num + Teksts2() + "Otrdiena");
            }
            else if (num == 3)
            {
                Console.WriteLine(Teksts1() + num + Teksts2() + "Trešdiena");
            }
            else if (num == 4)
            {
                Console.WriteLine(Teksts1() + num + Teksts2() + "Ceturtdiena");
            }
            else if (num == 5)
            {
                Console.WriteLine(Teksts1() + num + Teksts2() + "Piektdiena");
            }
            else if (num == 6)
            {
                Console.WriteLine(Teksts1() + num + Teksts2() + "Sestdiena");
            }
            else
            {
                Console.WriteLine(Teksts1() + num + Teksts2() + "Svētdiena");
            }
            
            Console.WriteLine("Vai atkārtot uzdevumu? y vai n");
            String input = Console.ReadLine();
            if (input == "y")
            {
                goto again;
            }
            else
            {
                Console.WriteLine("Press Any Key to exit.");
            }
            static String Teksts1()
            {
                string t1 = "Sistēma saģenerēja skaitli ";
                return t1;
            }
            static String Teksts2()
            {
                string t2 = " kas ir ";
                return t2;
            }
        }
    }
}
