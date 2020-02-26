using System;
using System.Collections.Generic;
using System.Text;

namespace _9_diena_MD_masivi
{
    class _3_uzd_masivi
    {
        public static void uzd3() //3) Aizpildīt masīvu ar skaitļiem 2,4,6,8,10. To darīt ciklā.
        {
            int m = 5; //Nodefinē masīvu garumu un platumu
            int x = 2; //Sākotnējā vērtība skaitlim, ko izvadīsim
            //int[] a = new int[m];
            int[] b = new int[m];
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    b[i] = x;
                    Console.Write(b[i]);
                }
                Console.WriteLine("");
                x += 2;
            }
        }
    }
}
