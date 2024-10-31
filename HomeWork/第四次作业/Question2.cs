//using System;
//namespace HomeWork
//{
//    class CPerson
//    {
//        public string sName;
//        public string sNumber;
//        public string Sex;
//        public void Set()
//        {
//            Console.Write("sName : ");
//            this.sName = Console.ReadLine();
//            Console.Write("sNumber : ");
//            this.sNumber = Console.ReadLine();
//            Console.Write("Sex : ");
//            this.Sex = Console.ReadLine();
//        }
//        public void Get()
//        {
//            Console.WriteLine();
//            Console.Write("sName:" + sName);
//            Console.Write("，sNumber:" + sNumber);
//            Console.Write("，Sex:" + Sex);
//        }
//    }
//    class CStudent : CPerson
//    {
//        public float Score;
//        public new void Set()
//        {
//            Console.WriteLine("CStudent！");
//            base.Set();
//            Console.Write("Score为:");
//            this.Score = Convert.ToInt32(Console.ReadLine());
//        }
//        public new void Get()
//        {
//            base.Get();
//            Console.WriteLine("，Score：" + Score);
//        }
//    }
//    class CTeacher : CPerson
//    {
//        public int age;
//        public new void Set()
//        {
//            Console.WriteLine("CTeacher!");
//            base.Set();
//            Console.Write("TimeAge：");
//            this.age = Convert.ToInt32(Console.ReadLine());
//        }
//        public new void Get()
//        {
//            base.Get();
//            Console.WriteLine("，TimeAge：" + age);
//        }
//    }
//    class Question2
//    {
//        static void Main(string[] args)
//        {
//            CStudent stu = new CStudent();
//            CTeacher tea = new CTeacher();
//            stu.Set();
//            stu.Get();
//            Console.WriteLine();
//            tea.Set();
//            tea.Get();
//            Console.ReadLine();
//        }
//    }
//}
