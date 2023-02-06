using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meow_UwU
{
    class MyClass
    {
        double a;
        double b;

        public MyClass()
        {
            a = 1;
            b = 2;
        }
        public MyClass(double aa, double bb)
        {
            a = aa;
            b = bb;
        }
        public double A
        {
            get { return a; }
            set {
                if (value >= 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
            }
        }
        public void kerület()
        {
            Console.WriteLine(2*(a+b));
        }
        public void terület()
        {
            Console.WriteLine(a*b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
