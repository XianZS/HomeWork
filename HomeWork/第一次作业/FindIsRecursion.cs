namespace HomeWork
{
    class FindIsRecursion
    {
        public int[] nums;
        public int FindNum;
        public FindIsRecursion(int[] InputNums,int InputFindNum)
        {
            nums = InputNums;
            FindNum = InputFindNum;
        }
        public bool Run()
        {
            try
            {
                int L = nums.Length;
                int findIndex = Find(0, L - 1);
                if (findIndex != -1)
                {
                    Console.WriteLine("\t{0}已找到，数组下表为{1}", FindNum, findIndex);
                }
                else
                {
                    Console.WriteLine("\t数组中不存在元素{0}",FindNum);
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public int Find(int L,int R)
        {
            if (L <= R)
            {
                int mid = (L + R) / 2;
                if (nums[mid] < FindNum)
                {
                    return Find(mid + 1, R);
                }
                else if (nums[mid] > FindNum)
                {
                    return Find(L, mid - 1);
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
