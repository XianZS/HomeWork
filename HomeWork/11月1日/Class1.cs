using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Class1
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Pr();
        }
    }
    class A
    {
        public virtual void Pr()
        {
            Console.WriteLine("中文");
        }
    }
    class B : A
    {
        public override void Pr()
        {
            Console.WriteLine("英文");
        }
    }
}
