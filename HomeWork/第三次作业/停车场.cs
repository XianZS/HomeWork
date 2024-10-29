using System.Runtime.Intrinsics.Arm;

namespace HomeWork
{
    class 停车场
    {
        static void Main(string[] args)
        {
            Console.WriteLine("正在初始化停车场系统，请输入一个整数，表示停车场的最大容量");
            int L = Convert.ToInt32(Console.ReadLine());
            MyStack myStack = new MyStack(L);
            MyQueue myQueue = new MyQueue(L);
            Console.WriteLine("请输入一个数字，表示今天的车辆总数");
            int c = Convert.ToInt32(Console.ReadLine());
            // 设置车辆初始编号1001
            int IdBegin = 1001;
            for(int i = 0; i < c; i++)
            {
                myQueue.PushChild(IdBegin);
                IdBegin += 1;
            }
            // 开始买票：查看当前买票顺序-队列
            Console.WriteLine("开始买票：当前车辆进入买票亭的顺序为:");
            myQueue.ShowMyQueue();
            Console.WriteLine("开始停车：当前车辆进停车场的顺序为:");
            // 开始停车：查看当前停车的顺序-栈
            for (int i = 0;i < c; i++)
            {
                // 每次从“买票队列”中弹出弹出队首元素，push到栈之中
                myStack.PushChild(myQueue.PopChild());
            }
            // 查看当前停车顺序
            myStack.ShowMyStack();
            Console.Write("车辆开始离开：请输入离开的车辆数:");
            int newc=Convert.ToInt32(Console.ReadLine());
            Console.Write("车辆编号顺序为:");
            for(int i = 0; i < newc; i++)
            {
                Console.Write("{0} ", myStack.PopChild());
            }
            Console.WriteLine();
        }
    }
    class MyQueue
    {
        // 指针，指向队列首元素的下标
        private int font = 0;
        // 指针，指向队列末尾元素的下一个元素的下标
        private int rear = 0;
        private int maxSize;
        private int[] nums;
        public MyQueue(int InputMaxSize)
        {
            maxSize = InputMaxSize;
            nums = new int[InputMaxSize];
        }
        public MyQueue()
        {
            maxSize = 3;
            nums = new int[maxSize];
        }
        // 判断队列是否已满
        public bool JudgeFull()
        {
            if ((rear + 1) % maxSize == font)
            {
                return true;
            }
            return false;
        }
        // 判断队列是否为空
        public bool JudgeEmpty()
        {
            if (font == rear)
            {
                return true;
            }
            return false;
        }
        // 给队列末尾添加元素
        public bool PushChild(int pushNum)
        {
            if (JudgeFull())
            {
                Console.WriteLine("队列已满，无法加入");
                return false;
            }
            nums[rear] = pushNum;
            rear = (rear + 1) % maxSize;
            return true;
        }
        // 弹出队列首元素
        public int PopChild()
        {
            if(JudgeEmpty())
            {
                Console.WriteLine("队列为空");
                return -1;
            }
            int popNum = nums[font];
            font = (font + 1) % maxSize;
            return popNum;
        }
        // 查看当前队列末尾元素
        public void ShowMyQueue()
        {
            if (JudgeEmpty())
            {
                Console.WriteLine("队列为空");
                return ;
            }
            int index = font;
            while (true)
            {
                Console.Write("{0} ", nums[index]);
                index += 1;
                if (index >= rear)
                {
                    Console.WriteLine();
                    return ;
                }
                index = index % maxSize;
            }
        }
    }
    class MyStack // 栈
    {
        // 栈顶指针
        private int top = -1;
        // 栈最大长度
        private int maxSize;
        // 栈数组
        private int[] nums;
        // 构造器
        public MyStack(int InputMaxSize)
        {
            maxSize = InputMaxSize;
            nums = new int[maxSize];
        }
        public MyStack()
        {
            maxSize = 3;
            nums = new int[maxSize];
        }
        // 判断栈是否已满
        public bool JudgeFull()
        {
            if (top == maxSize - 1)
            {
                return true;
            }
            return false;
        }
        // 判断栈是否为空
        public bool JudgeEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        // 入栈push
        public bool PushChild(int pushNum)
        {
            if (JudgeFull())
            {
                Console.WriteLine("栈内元素已满");
                return false;
            }
            top += 1;
            nums[top] = pushNum;
            return true;
        }
        // 出栈pop
        public int PopChild()
        {
            if (JudgeEmpty())
            {
                Console.WriteLine("栈为空");
                return -1;
            }
            return nums[top--];
        }
        // 查看当前栈顶元素
        public void ShowMyStack()
        {
            if (JudgeEmpty() || top == -1)
            {
                Console.WriteLine("栈为空");
                return ;
            }
            for (int i = 0; i <= top; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
        }
    }
}