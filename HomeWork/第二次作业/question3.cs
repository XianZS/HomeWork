//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    class question3
//    {
//        static void Main(string[] args)
//        {
//            Student[] nums = new Student[3]; // 构建三个示例学生
//            for (int i = 0; i < nums.Length; i++)
//            {
//                nums[i] = new Student();
//                Console.Write("请输入第{0}个学生的学号:", i + 1);
//                nums[i].Id = Convert.ToInt32(Console.ReadLine());
//                Console.Write("请输入第{0}个学生的姓名:", i + 1);
//                nums[i].Name = Console.ReadLine();
//                Console.Write("请依次输入C++、英语和数学成绩，使用空格隔开:");
//                int[] MyGrade = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
//                nums[i].Grade = MyGrade;
//            }
//            for (int i = 0; i < nums.Length; i++)
//            {
//                nums[i].PrintAllThings();
//                Console.WriteLine("总成绩:{0},平均成绩:{1}", nums[i].AllGrade(), nums[i].AveGrade());
//            }
//        }
//    }
//    class Student
//    {
//        private string name;
//        private int id;
//        private int[] grade;
//        public Student() // 无参构造函数
//        {
//            name = "姓名未输入";
//            id = 0;
//            grade = [];
//        }
//        public Student(string InputName, int InputId, int[] InputGrade) // 有参构造函数
//        {
//            name = InputName;
//            id = InputId;
//            grade = InputGrade;
//        }
//        public string Name // 设置姓名
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public int Id // 设置学号
//        {
//            get { return id; }
//            set { id = value; }
//        }
//        public int[] Grade //设置成绩数组
//        {
//            get { return grade; }
//            set { grade = value; }
//        }
//        public void PrintAllThings() //输出基本信息
//        {
//            Console.WriteLine("{0}学号为{1},C++成绩为:{2},英语成绩为:{3},数学成绩为:{4}", name, id, grade[0], grade[1], grade[2]);
//        }
//        public int AllGrade() // 求总成绩
//        {
//            int sumNum = grade.Sum();
//            return sumNum;
//        }
//        public double AveGrade() //求平均成绩
//        {
//            int sumNum = grade.Sum();
//            return sumNum / 3.0;
//        }
//    }
//}
