using System;
using System.Collections.Generic;
using System.Text;

namespace _9_diena_MD_masivi
{
    class _4_uzd_masivi
    {
        public static void uzd4() //4) Cilvēks izvēlas masīva garumu un aizpilda ar sevis izvēlētiem skaitļiem.
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
            Console.WriteLine("Lūk tavs masīvs ");
            for (int i = 0; i <gar; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.ResetColor();
        }
    }
}
