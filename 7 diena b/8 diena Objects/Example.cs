using System;
using System.Collections.Generic;
using System.Text;

namespace _8_diena_Objects
{
    public class Example

    {
        private int a;
        private int b;
        public Example(int a, int b)
        {
            //Konstruktors
            this.a = a;
            this.b = b;
        }
        public void print()
        {
            Console.WriteLine("a= " + a + "b = " + b);
            privatePrint();
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public int getA()
        {
            return a;
        }

        private void privatePrint()
        {
            Console.WriteLine("Šito iekšienē");
        }
    }
}
