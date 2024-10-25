//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    class question1
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.Write("输入:\n[1]:计算加法\n[2]:计算减法\n[3]:计算乘法\n[0]:退出\n请输入你选择的功能>>");
//                int i = int.Parse(Console.ReadLine());
//                if (i == 0)
//                {
//                    Console.WriteLine("退出程序！");
//                    break;
//                }
//                Console.Write("请输入第一个复数的实部：");
//                double a = double.Parse(Console.ReadLine());
//                Console.Write("请输入第一个复数的虚部：");
//                double b = double.Parse(Console.ReadLine());
//                Console.Write("请输入第二个复数的实部：");
//                double c = double.Parse(Console.ReadLine());
//                Console.Write("请输入第二个复数的虚部：");
//                double d = double.Parse(Console.ReadLine());
//                Complex m = new Complex(a, b);
//                Complex n = new Complex(c, d);
//                switch (i)
//                {
//                    case 1: Complex.print(Complex.AddThings(m, n)); break;
//                    case 2: Complex.print(Complex.SubThings(m, n)); break;
//                    case 3: Complex.print(Complex.MulThings(m, n)); break;
//                }
//            }
//            Console.Read();
//        }
//    }
//    public class Complex
//    {
//        private double real;
//        private double image;
//        public Complex(double Ireal, double Iimage)
//        {
//            real = Ireal;
//            image = Iimage;
//        }
//        public double Real
//        {
//            get { return real; }
//            set { real = value; }
//        }
//        public double Image
//        {
//            get { return image; }
//            set { image = value; }
//        }
//        public static Complex AddThings(Complex c1, Complex c2)
//        {
//            return new Complex(c1.real + c2.real, c1.image + c2.image);
//        }
//        public static Complex SubThings(Complex c1, Complex c2)
//        {
//            return new Complex(c1.real - c2.real, c1.image - c2.image);
//        }
//        public static Complex MulThings(Complex c1, Complex c2)
//        {
//            return new Complex(c1.real * c2.real - c1.image * c2.image, c1.image * c2.real + c1.real * c2.image);
//        }
//        public static void print(Complex c)
//        {
//            Console.WriteLine("结果为： {0}+{1}i", c.real, c.image);
//        }
//    }
//}
