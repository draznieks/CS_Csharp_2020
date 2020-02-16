using System;
using System.Collections.Generic;
using System.Text;

namespace _7_dienas_MD_klases
{
    public class Darb2
    {
        private static Double a = 0;
        public static void sask(Double rez)
        {
            a = SK1.getA() + SK1.getB();
        }
        public static void min(Double rez)
        {
            a = SK1.getA() - SK1.getB();
        }
        public static void reiz(Double rez)
        {
            a = SK1.getA() * SK1.getB();
        }
        public static void dal(Double rez)
        {
            a = SK1.getA() / SK1.getB();
        }
        public static Double getA()
        {
            return a;
        }

    }
}
