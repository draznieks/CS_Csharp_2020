using System;
using System.Collections.Generic;
using System.Text;

namespace _10_diena_masivi
{
    public class selection
    {
        public static void sel()
        {
            int ms = 0;
            int gar = 1000; //Nodefinē masīvu garumu
            int[] arr = new int[gar];

            DateTime dt = DateTime.Now;
            int ms01 = dt.Millisecond;

            for (int i = 0; i < gar; i++)
            {
                //Console.WriteLine("Ievadi " + (i + 1) + " elementu");
                arr[i] = Program.rand();
            }
            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < gar - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < gar; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            DateTime dt2 = DateTime.Now;
            int ms02 = dt2.Millisecond;
            ms = ms02 - ms01;
            Console.Write(ms);
            //{
            //    int n = gar;
            //    for (int i = 0; i < n; ++i)
            //        Console.Write(arr[i] + " ");
            //        Console.WriteLine();
            //}
        }
    }
}
