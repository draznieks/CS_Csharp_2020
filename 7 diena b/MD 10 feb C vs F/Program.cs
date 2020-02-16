using System;

namespace MD_10_feb_C_vs_F
{
    class Program //ŠĪ programma pārkonvertēs F uz Celsiju
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Šī programma tev pārkonvertēs Fārenheitus uz Celsiju");
            Console.WriteLine("Ievadi grādus pēc F");
            Double F = Convert.ToDouble(Console.ReadLine());
            Double C = (F - 32) * 5 / 9;
            Console.WriteLine("Pēc celsija tas ir " + C);
        }
    }
}
