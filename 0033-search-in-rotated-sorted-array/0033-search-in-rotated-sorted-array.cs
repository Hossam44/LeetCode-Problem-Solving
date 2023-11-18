    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int indexOfMinNumber = getIndexOfMinNumber(nums);
            int result = getIndexOfTarget(nums, indexOfMinNumber, target);
            if (nums[result] != target) return -1;
            return result;
        }
        private int getIndexOfMinNumber(int[] nums)
        {
            int start = 0, end = nums.Length - 1,mid;

            while (start != end) 
            {
                mid = (start + end) / 2;
                if (midIsBigestOne(nums[mid], nums[start], nums[end])) {
                    start = mid +1;
                }
                else if(nums[mid] > nums[start] && nums[mid] < nums[end])
                {
                    end = mid -1;
                }
                else
                    end = mid;
            }
            return start;
        }
        private int getIndexOfTarget(int[] nums,int startIndex, int target)
        {
            int start=startIndex, end = startIndex + nums.Length-1, mid;
            while (start != end)
            {
                mid = (start + end + 1) / 2;
                if (nums[mid % nums.Length] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid;
                }
            }
            return start % nums.Length;
        }
        private bool midIsBigestOne(int mid, int start, int end)
        {
            return mid >= start && mid > end;
        }
    }