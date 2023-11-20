    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            List<int> list = new List<int>();
            foreach (int i in nums)
            {
                if(i != val) list.Add(i);
            }

            for(int i=0; i< list.Count; i++)
            {
                nums[i] = list[i];
            }
            return list.Count;
        }
    }