namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建长度为9的随机数组
            int L = 9;
            int[] nums = CreateArray(L);
            // 打印初始数组
            PrintArray(nums, "进行“排序”的数组");
            // 实例化冒泡排序对象
            BubbleSort bubbleSort = new BubbleSort(nums);
            if (bubbleSort.Run()) PrintArray(bubbleSort.nums, "1、冒泡排序之后的数组");
            else Console.WriteLine("ERROR");
            // 实例化选择排序对象
            SelectionSort selectionSort = new SelectionSort(nums);
            if (selectionSort.Run()) PrintArray(selectionSort.nums, "2、选择排序之后的数组");
            else Console.WriteLine("ERROR");
            // 实例化快速排序对象
            QuickSort quickSort = new QuickSort(nums);
            if (quickSort.Run()) PrintArray(quickSort.nums, "3、快速排序之后的数组");
            else Console.WriteLine("ERROR");
            // 二分查找-递归
            int[] array = { 32, 35, 43, 52, 66, 67, 68, 90, 102 };
            PrintArray(array,"\n进行“二分查找”的数组");
            Console.WriteLine("4、二分查找-递归:");
            FindIsRecursion findIsRecursion1 = new FindIsRecursion(array, 67);
            if (!findIsRecursion1.Run()) Console.WriteLine("ERROR"); 
            FindIsRecursion findIsRecursion2 = new FindIsRecursion(array, 333);
            if (!findIsRecursion2.Run()) Console.WriteLine("ERROR");
            // 二分查找-非递归
            Console.WriteLine("5、二分查找-非递归");
            FindNotRecursion findNotRecursion1 = new FindNotRecursion(array, 52);
            if (!findNotRecursion1.Run()) Console.WriteLine("ERROR");
            FindNotRecursion findNotRecursion2 = new FindNotRecursion(array, 333);
            if (!findNotRecursion2.Run()) Console.WriteLine("ERROR");
        }

        static int[] CreateArray(int L)
        {
            Random random = new Random();
            int[] nums = new int[L];
            for(int i = 0; i < L; i++)
            {
                nums[i] = random.Next(20, 80);
            }
            return nums;
        }
        static void PrintArray(int[] nums,string names)
        {
            Console.Write(names + "为 : ");
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
        }
    }
}