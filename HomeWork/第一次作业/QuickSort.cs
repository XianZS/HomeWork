using System.Windows.Markup;

namespace HomeWork
{
    class QuickSort
    {
        public int[] nums;
        public QuickSort(int[] InputNums)
        {
            nums = InputNums;
        }
        public bool Run()
        {
            try
            {
                int L = nums.Length;
                Quick(0, L-1);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        private void Quick(int L, int R)
        {
            if (L < R)
            {
                int number = Partition(L, R);
                Quick(L, number - 1);
                Quick(number + 1, R);
            }
        }
        private int Partition(int L,int R)
        {
            int number = nums[R];
            int index = L - 1;
            for(int x = L; x < R; x++)
            {
                if (nums[x] <= number)
                {
                    index++;
                    int value = nums[index];
                    nums[index]= nums[x];
                    nums[x] = value;
                }
            }
            int nowNum = nums[index + 1];
            nums[index + 1] = nums[R];
            nums[R] = nowNum;
            return index + 1;
        }
    }
}