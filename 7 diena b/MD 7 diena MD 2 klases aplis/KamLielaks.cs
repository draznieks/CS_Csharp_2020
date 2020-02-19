using System;
using System.Collections.Generic;
using System.Text;

namespace _7_diena_MD_2_klases_aplis
{
    class KamLielaks
    {
        private int a_;
        private int b_;

        public KamLielaks(int a, int b)
        {
            //Konstruktors

            this.a_ = a;
            this.b_ = b;
        }
        public int generate()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            return number;
        }

        public void print()
        {
            Console.WriteLine("Sistēma saģenerēja " + "a" + "un" + "b");
        }
    }
}
