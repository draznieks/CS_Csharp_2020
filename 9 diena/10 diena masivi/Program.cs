using System;

namespace _10_diena_masivi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Burbuļa metode aizņēma ");
            burbulis.burb();
            Console.WriteLine(" milisekundes");
            Console.Write("Selection metode aizņēma ");
            selection.sel();
            Console.WriteLine(" milisekundes");
        }
        public static int rand()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 1000);
            return num;
        }
        public void start()
        {
            DateTime dt = DateTime.Now;
            int ms1 = dt.Millisecond;
        }
        public void end()
        {
            DateTime dt2 = DateTime.Now;
            int ms2 = dt2.Millisecond;
            return;
        }
    }
}
