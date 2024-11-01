using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Class2
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(10, "kom");
            Person p2 = p1;
            p1.Id += 1;
            Console.WriteLine(p1.Id);
            Console.WriteLine(p2.Id);
        }
    }
    struct Person
    {
        public int Id = 10;
        public string Name = "jom";
        public Person(int i, string name)
        {
            Id = i;
            Name = name;
        }

    }
}
