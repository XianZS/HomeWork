
namespace HomeWork
{
    class BubbleSort
    {
        public int[] nums;
        public BubbleSort(int[] InputNums)
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
                    for (int j = 0; j < L; j++)
                    {
                        if (nums[j] > nums[i])
                        {
                            int value = nums[j];
                            nums[j] = nums[i];
                            nums[i] = value;
                        }
                    }
                }
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
