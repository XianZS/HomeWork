namespace HomeWork
{
    class 停车场
    {
        static void Main(string[] args)
        {
            MyStack mystack = new MyStack(6);
            Console.WriteLine(mystack.JudgeEmpty());
            Console.WriteLine(mystack.JudgeFull());
            for(int i = 0; i < 6; i++)
            {
                mystack.PushChild(i+1);
            }
            Console.WriteLine(mystack.JudgeFull());
            for(int i = 0;i < 6; i++)
            {
                Console.WriteLine(mystack.ShowTopChild());
            }
            for(int i = 0;i < 6; i++)
            {
                Console.Write("{0} ",mystack.PopChild());
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
        public int ShowTopChild()
        {
            if (JudgeEmpty() || top == -1)
            {
                Console.WriteLine("栈为空");
                return -1;
            }
            return nums[top];
        }
    }
}