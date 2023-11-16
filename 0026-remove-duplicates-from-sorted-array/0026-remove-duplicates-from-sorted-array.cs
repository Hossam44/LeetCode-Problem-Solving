    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            HashSet<int> mySet = new HashSet<int>();
            int counter=0;

            foreach (int num in nums)
            {
                mySet.Add(num);
            }

            foreach (var item in mySet)
            {
                nums[counter++] = item;
            }

            return mySet.Count;
        }
    }