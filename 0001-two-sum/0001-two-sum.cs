    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> myMap = new Dictionary<int, int>();
            int[] resultofTwoElements = new int[] { }; 
            for(int i=0; i<nums.Length; i++) 
            {
                myMap[nums[i]] = i;
            }

            for(int i=0;i<nums.Length;i++)
            {
                if (myMap.TryGetValue(target - nums[i], out int value) && value != i)
                {
                    resultofTwoElements =  new[] { value, i };
                    break;
                }
            }
            return resultofTwoElements;

        }
    }