using System;

namespace L11
{
    class Program
    {
        private double a;
        private double b;
        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
            
        }

        public  double B
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }
        

        public static double Min(double a, double b)
        {
            if (a > b)
                return b;
            else
                return a;
        }
        static void Main(string[] args)
        {
            Program bi = new Program();
            bi.A = Convert.ToDouble(Console.ReadLine());
            bi.B = Convert.ToDouble(Console.ReadLine());
            double u = Min(bi.A, bi.B);
            double v = Min(bi.A * bi.B, bi.B) * Min(u + Math.Pow(bi.A, 2), Math.PI);
            Console.WriteLine(u+"\n"+v);
        }
    }
}