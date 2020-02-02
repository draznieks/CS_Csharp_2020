using System;

namespace _3_dienas_MD_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atrast kā ģenerēt random skaitļus (gadījuma skaitļus) diapazonā no 1 - 7. Un izvadīt pretī attiecīgo dienu. (tiek ģenerēts 5- izvadam piektdiena, 2- Otrdiena, utt)

            Random rnd = new Random();
            int num = rnd.Next(1, 7);
            //String day = Convert.ToString(num);
            if (num == 1)
            {
                Console.WriteLine("Sistēma saģenerēja skaitli " + num + " kas ir " + "Pirmdiena");
            }
            else if (num == 2)
            {
                Console.WriteLine("Sistēma saģenerēja skaitli " + num + " kas ir " + "Otrdiena");
            }
            else if (num == 3)
            {
                Console.WriteLine("Sistēma saģenerēja skaitli " + num + " kas ir " + "Trešdiena");
            }
            else if (num == 4)
            {
                Console.WriteLine("Sistēma saģenerēja skaitli " + num + " kas ir " + "Ceturtdiena");
            }
            else if (num == 5)
            {
                Console.WriteLine("Sistēma saģenerēja skaitli " + num + " kas ir " + "Piektdiena");
            }
            else if (num == 6)
            {
                Console.WriteLine("Sistēma saģenerēja skaitli " + num + " kas ir " + "Sestdiena");
            }
            else
            {
                Console.WriteLine("Sistēma saģenerēja skaitli " + num + " kas ir " + "Svētdiena");
            }

        }
    }
}
