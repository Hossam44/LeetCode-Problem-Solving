    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int num1= nums[0], num2=0,count=1;

            for(int i=1;i<nums.Length; i++)
            {
                if (count == 1 && num1 < nums[i])
                {
                    count++;
                    num2 = nums[i];
                }
                else if(count == 1 && num1 > nums[i])
                {
                    num1 = nums[i];
                }

                if(count == 2 && num2 < nums[i])
                {
                    return true;
                }
                else if(count == 2 && num1 > nums[i] )
                {
                    num1 = nums[i];
                }
                else if(count == 2 && num2 > nums[i] && num1 != nums[i])
                {
                    num2 = nums[i];
                }
            }
            return false;
        }
    }