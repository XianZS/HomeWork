namespace HomeWork
{
    class SelectionSort
    {
        public int[] nums;
        public SelectionSort(int[] InputNums)
        {
            nums = InputNums;
        }
        public bool Run()
        {
            try
            {
                int L = nums.Length;
                for (int i = 0; i < L; i++)
                {
                    int minNum = nums[i];
                    int minIndex = i;
                    for (int j = i + 1; j < L; j++)
                    {
                        if (nums[j] < minNum)
                        {
                            minNum = nums[j];
                            minIndex = j;
                        }
                    }
                    int value = nums[i];
                    nums[i] = nums[minIndex];
                    nums[minIndex] = value;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }
    }
}