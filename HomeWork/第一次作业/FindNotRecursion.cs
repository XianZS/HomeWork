namespace HomeWork
{
    class FindNotRecursion
    {
        public int[] nums;
        public int FindNum;
        public FindNotRecursion(int[] InputNums, int InputFindNum)
        {
            nums = InputNums;
            FindNum = InputFindNum;
        }
        public bool Run()
        {
            try
            {
                int judge = Find();
                if (judge != -1)
                {
                    Console.WriteLine("\t{0}已找到，数组下表为{1}", FindNum, judge);
                }
                else
                {
                    Console.WriteLine("\t数组中不存在元素{0}", FindNum);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public int Find()
        {
            int R = nums.Length-1;
            int L = 0;
            while (L <= R)
            {
                int mid = (L + R) / 2;
                if (nums[mid] < FindNum)
                {
                    L = mid + 1;
                }
                else if (nums[mid] > FindNum)
                {
                    R = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
