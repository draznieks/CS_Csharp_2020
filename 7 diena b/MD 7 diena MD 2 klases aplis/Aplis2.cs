using System;
using System.Collections.Generic;
using System.Text;

namespace _7_diena_MD_2_klases_aplis
{
    public class Aplis
    {
        private Double r = 0;
        private Double Pi = 3.14;
        private Double S = 0;

        //public static void setR(Double skaitlis)
        //{
        //    r = skaitlis;
        //}
        public Aplis(double r)
        {
            //Konstruktors
            this.r = r;
        }
        public Aplis(double Laukums, double print)
        {
            this.Laukums = Laukums;
            this.print = print;
        }
        private void Laukums()
        {
            S = Pi * r * r;
        }
        private void print()
        {
            Console.WriteLine("Rādius ir " + r + " un laukums ir " + S);
        }


    }
}
