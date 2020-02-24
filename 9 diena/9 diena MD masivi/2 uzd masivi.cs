using System;
using System.Collections.Generic;
using System.Text;

namespace _9_diena_MD_masivi
{
    class _2_uzd_masivi
    {
        public static void uzd2()
        {
            //A();
            B();
        }
        public static void A() //Šajā uzdevumā izmanto vienu masīvu un rindu garumu izvada kā STRING predefinētus simbolus
        {
            String[] a = new String[6];
            for (int i = 0; i < 6; i++)
            {
                a[i] = "######";
                Console.WriteLine(a[i]);
            }
        }
        public static void B() //Šajā uzdevumā izmanto divus masīvus
        {
            int plat = 6; //Nodefinē masīvu garumu
            int gar = 6; //Nodefinē masīvu platumu
            String[] a = new String[plat];
            String[] b = new String[gar];
            for (int j = 0; j < plat; j++)
            {
                for (int i = 0; i < gar; i++) 
                {
                    b[i] = "#";
                    Console.Write(b[i]); //Izdrukā masīva platumu
                }
                Console.WriteLine(""); //Pārness nākamajā līnijā
            }                    
        }
    }
}
