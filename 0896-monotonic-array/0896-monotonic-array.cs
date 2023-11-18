    public class Solution
    {
        public bool IsMonotonic(int[] nums)
        {
            Func<int, int, bool> DecreasingCheck = (x, y) => x < y;
            Func<int, int, bool> IncreasingCheck = (x, y) => x > y;
            return CheckTwoSides(nums, DecreasingCheck) || CheckTwoSides(nums, IncreasingCheck);
        }
        private bool CheckTwoSides(int[] nums, Func<int,int,bool> condtion )
        {
            for(int i = 0; i < nums.Length-1; i++) 
            {
                if (condtion(nums[i], nums[i+1])) return false;
            }
            return true;
        }
    }