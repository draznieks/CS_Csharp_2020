using System;
using System.Collections.Generic;
using System.Text;

namespace _10_diena_masivi
{
    public class burbulis
    {
        public static void burb()
        {
            int ms = 0;
            int gar = 1000; //Nodefinē masīvu garumu
            int[] arr = new int[gar];
            int temp;

            DateTime dt = DateTime.Now;
            int ms1 = dt.Millisecond;

            for (int i = 0; i < gar; i++)
            {
                //Console.WriteLine("Ievadi " + (i + 1) + " elementu");
                arr[i] = Program.rand();
            }
            for (int j = 0; j <= gar - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            DateTime dt2 = DateTime.Now;
            int ms2 = dt2.Millisecond;
            ms = ms2 - ms1;
            Console.Write(ms);
            //Console.WriteLine("Sorted:");
            //foreach (int p in arr)
            //Console.Write(p + " ");
        }
    }
}
