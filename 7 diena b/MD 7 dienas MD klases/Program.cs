using System;

namespace _7_dienas_MD_klases
{
    class Program //Uztaisam vienu statisku klasi, kas atgriež skaitli
    {
        static void Main(string[] args)
        {

            Double skaitlis1 = input();
            Double skaitlis2 = input();
            Double rez = 0;
            SK1.setA(skaitlis1);
            SK1.setB(skaitlis2);
            Console.WriteLine("Ievadi darbību, ko darīsi ar skaitļiem");
            Console.WriteLine("+ - * /");
            String darbiba = Console.ReadLine();
            if (darbiba == "+")
            {
                Darb2.sask(rez);
            }
            if (darbiba == "-")
            {
                Darb2.min(rez);
            }
            if (darbiba == "*")
            {
                Darb2.reiz(rez);
            }
            if (darbiba == "/")
            {
                Darb2.dal(rez);
            }
            Console.WriteLine(Darb2.getA());
            //Console.WriteLine(SK1.getA());
            //Console.WriteLine(SK1.getB());
        }
        static Double input()
        {
            Console.WriteLine("Ievadi skaitli");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            return skaitlis;
        }

    }
}
