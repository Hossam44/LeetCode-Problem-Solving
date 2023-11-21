    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int lenght = nums.Length / 2;
            
            Dictionary<int,int>keyValuePairs = new Dictionary<int,int>();
            foreach (int i in nums)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i]++;
                    if(keyValuePairs[i] > lenght)
                        return i;
                }
                else
                    keyValuePairs[i] = 1;
            }
            return nums[0];
        }
    }