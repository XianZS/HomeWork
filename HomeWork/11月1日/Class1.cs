/*
 * 对于重写和覆盖
 * 如果想要实例化一个基类对象，但是使用子类去申请空间，那么会出现一下情况：
 * 对于子类中的重写的方法，当实例化基类、申请子类空间时，会使用子类中的方法
 * 对于子类中的覆盖的方法，当实例化基类、申请子类空间时，会使用基类中原本的方法
 */
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    class Class1
//    {
//        static void Main(string[] args)
//        {
//            A a = new B();
//            a.Pr();
//        }
//    }
//    class A
//    {
//        public virtual void Pr()
//        {
//            Console.WriteLine("中文");
//        }
//    }
//    class B : A
//    {
//        public override void Pr()
//        {
//            Console.WriteLine("英文");
//        }
//    }
//}
