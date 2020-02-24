using System;
using System.Collections.Generic;
using System.Text;

namespace _9_diena_MD_masivi
{
    class _5_uzd_masivi
    {
        public static void uzd5() //5) Izmantojot 4. uzdevuma masīvu izvadīt visus nepāra skaitļus.
        {
            int gar = 0; //Nodefinē masīvu garumu
            Console.WriteLine("Ievadi cik garš būs masīvs ");
            gar = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[gar];
            for (int i = 0; i < gar; i++)
            {
                Console.WriteLine("Ievadi " + (i + 1) + " elementu");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lūk tavs masīvs tikai ar NEpāra skaitļiem");
            for (int i = 0; i < gar; i++)
            {
                if (b[i] % 2 == 1)
                {
                    Console.Write(b[i] + " ");
                }
            }
            Console.ResetColor();
        }
    }
}
