//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// 在进行运算符重载时，调用的方法，根据调用的对象来决定
//namespace HomeWork
//{
//    class Class4
//    {
//        static void Main(string[] args)
//        {
            
//        }
//    }
//    class Complex
//    {
//        double r, v;
//        public Complex(double a,double b)
//        {
//            this.r = a;
//            this.v = b;
//        }
//        public static Complex operator *(Complex a, Complex b) 
//        {
//            return new Complex(a.r * b.v - a.v * b.r, a.r * b.v + a.v * b.r);
//        }
//    }
//}
