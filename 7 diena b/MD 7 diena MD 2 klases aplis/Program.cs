using System;

namespace _7_diena_MD_2_klases_aplis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot jaunu klasi
            //Jābūt laukam, kur glabāsies int
            //1-10 (konstruktorā)
            //getNumber, kas atgriež šo skaitli
            //regenerate Number() - no jauna uzģenerē gadījuma skaitli

            //uztaisam vienu objektu
            //uztaisam otru objektu
            //Whilecikls
            //Salīdzinam abu objektu gadījuma skaitļus
            //Kam lielāks, tas uzvar
            //kā piefiksēt uzvaras - freestyle
            //apstājamies, kad viens objekts uzvarējis 3 reizes
            int a = generate();
            int b = generate();
            Console.WriteLine(a);
            Console.WriteLine(b);

            int generate()
            {
                Random random = new Random();
                int number = random.Next(1, 10);
                return number;
            }

        }
        /*{
            Double skaitlis = input();
            Aplis ex = new Aplis(1);
            //Aplis.setR(skaitlis);
            Aplis print = new Aplis(2);
        }

        static Double input()
        {
            Console.WriteLine("Ievadi skaitli");
            Double skaitlis = Convert.ToDouble(Console.ReadLine());
            return skaitlis;
        }*/
    }
}
