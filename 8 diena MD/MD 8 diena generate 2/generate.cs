using System;
using System.Collections.Generic;
using System.Text;

namespace MD_8_diena_generate_2
{
    class generate
    {
        //private int a_;
        /*public generate(int a)
        {
            //Konstruktors
            //this.a_ = a;
            a = gen();
        }*/

        public int gen()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            return number;
        }
    }
}
