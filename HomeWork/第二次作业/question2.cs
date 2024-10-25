//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace HomeWork
//{
//    class question2
//    {
//        static void Main(string[] args)
//        {
//            int t = 0; int k = 1;
//            Console.Write("请输入全班同学的人数:");
//            t = Convert.ToInt32(Console.ReadLine());
//            score[] stu = new score[t];
//            Console.WriteLine("请输入全班同学的信息:");
//            for (int i = 0; i < t; i++)
//            {
//                Console.WriteLine("请输入第{0}个学生信息：", k++);
//                stu[i] = new score();
//                stu[i].init();
//                stu[i].AVG();
//            }
//            Console.WriteLine("按学号排序学生信息:");
//            Console.WriteLine("|\t姓名\t|\t学号\t|\tC++\t|\t英语\t|\t数学\t|\t平均成绩\t|");
//            for (int j = 0; j < t; j++)
//            {
//                stu[j].display();
//            }
//            Console.WriteLine("排序后的学生信息:");
//            paixu(t, stu);
//            Console.Read();
//        }
//        public static void paixu(int t, score[] stu)
//        {
//            score stud = new score();
//            if (stu.Length <= 0)
//                return;
//            for (int i = 0; i < t; i++)
//            {
//                for (int j = 0; j < t - i - 1; j++)
//                {
//                    if (stu[j].Avg > stu[j + 1].Avg)
//                    { stud = stu[j + 1]; stu[j + 1] = stu[j]; stu[j] = stud; }
//                }
//            }
//            Console.WriteLine("|\t姓名\t|\t学号\t|\tC++\t|\t英语\t|\t数学\t|\t平均成绩\t|");
//            foreach (score x in stu)
//                x.display();
//        }
//    }
//    class score
//    {
//        private string name;
//        private int ID;
//        private double c;
//        private double english;
//        private double math;
//        double avg;
//        public score()
//        { this.avg = 0; }
//        public string Name
//        { get { return name; } set { name = value; } }
//        public int id
//        { get { return ID; } set { ID = value; } }
//        public double C
//        { get { return c; } set { c = value; } }
//        public double English
//        { get { return english; } set { english = value; } }
//        public double Math
//        { get { return math; } set { math = value; } }
//        public double Avg
//        { get { return avg; } set { avg = value; } }
//        public void init()
//        {
//            Console.Write("学号:");
//            this.ID = Convert.ToInt32(Console.ReadLine());
//            Console.Write("姓名:");
//            this.name = Convert.ToString(Console.ReadLine());
//            Console.Out.Write("c++:");
//            this.c = Convert.ToDouble(Console.ReadLine());
//            Console.Write("英语:");
//            this.english = Convert.ToDouble(Console.ReadLine());
//            Console.Write("数学:");
//            this.math = Convert.ToDouble(Console.ReadLine());
//        }
//        public void AVG()
//        {
//            avg = (math + english + c) / 3;
//        }
//        public void display()
//        {
//            Console.WriteLine("|\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}\t|\t{5}\t|", name, ID, c, english, math, avg);
//        }
//    }
//}
