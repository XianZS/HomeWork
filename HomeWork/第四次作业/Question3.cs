//namespace HomeWork
//{
//    class Cpoint
//    {
//        private double x;//坐标x轴的值
//        public double X
//        {
//            get { return x; }
//            set { x = value; }
//        }
//        private double y;//坐标y轴的值
//        public double Y
//        {
//            get { return y; }
//            set { y = value; }
//        }
//        public Cpoint()
//        {
//            this.X = 0;
//            this.Y = 0;
//        }
//        public Cpoint(double x, double y)
//        {
//            this.X = x;
//            this.Y = y;
//        }
//    }
//    class Cline : Cpoint
//    {
//        private Cpoint a = new Cpoint();//直线的一个端点
//        public Cpoint A
//        {
//            get { return a; }
//            set { a = value; }
//        }
//        private Cpoint b = new Cpoint();//直线的另一个端点
//        public Cpoint B
//        {
//            get { return b; }
//            set { b = value; }
//        }
//        public Cline(double a1, double a2, double b1, double b2)
//        {
//            A.X = a1;
//            A.Y = a2;
//            B.X = b1;
//            B.Y = b2;
//        }
//        //求直线长度
//        public double GetLength()
//        {
//            double m = A.X - B.X;
//            double n = A.Y - B.Y;
//            return Math.Sqrt(Math.Pow(m, 2) + Math.Pow(n, 2));
//        }
//    }
//    class Crect : Cpoint
//    {
//        private Cpoint a = new Cpoint();
//        public Cpoint A
//        {
//            get { return a; }
//            set { a = value; }
//        }
//        private Cpoint b = new Cpoint();
//        public Cpoint B
//        {
//            get { return b; }
//            set { b = value; }
//        }
//        public Crect(double a1, double a2, double b1, double b2)
//        {
//            A.X = a1;
//            A.Y = a2;
//            B.X = b1;
//            B.Y = b2;
//        }
//        //求周长
//        public double GetLength()
//        {
//            double m = Math.Abs(A.X - B.X);
//            double n = Math.Abs(A.Y - B.Y);
//            return 2.0 * (m + n);
//        }
//        //求面积
//        public double GetArea()
//        {
//            double m = Math.Abs(A.X - B.X);
//            double n = Math.Abs(A.Y - B.Y);
//            return m * n;
//        }
//    }
//    class Question3
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("请输入x : ");
//            int x = Convert.ToInt32(Console.ReadLine());
//            Console.Write("请输入y : ");
//            int y = Convert.ToInt32(Console.ReadLine());
//            Cpoint cpoint = new Cpoint(x, y);
//            Console.WriteLine("你输入的坐标为 ({0},{1})", cpoint.X, cpoint.Y);
//            Console.Write("请输入(x1,y1)和(x2,y2)，每个数字使用空格隔开 : ");
//            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
//            Cline cline = new Cline(nums[0], nums[1], nums[2], nums[3]);
//            Console.WriteLine("两点间距离为 {0}", cline.GetLength());
//            Console.Write("请输入矩形两个对角的坐标，每个数字使用空格隔开 : ");
//            int[] some = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
//            Crect crect = new Crect(some[0], some[1], some[2], some[3]);
//            Console.WriteLine("矩形的周长为 {0},面积为 {1}", crect.GetLength(), crect.GetArea());
//        }
//    }
//}