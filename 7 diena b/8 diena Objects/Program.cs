using System;

namespace _8_diena_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example(4,8);
            ex.print();
            int KautKadsMainigais = ex.getA();
        }
    }
}
