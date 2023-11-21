    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int[] elements = new int[nums.Length];
            int size = nums.Length;
            for(int i = 0; i < nums.Length; i++)
            {
                elements[(i+k)% size] = nums[i];
            }
            for(int i =0; i<elements.Length; i++)
            {
                nums[i] = elements[i];
            }
        }
    }