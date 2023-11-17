    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int closest_to_target = 0, sumOfThreeInt=0, minDifferance =1000000, diferance = 0;

            for(int i = 0;i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    for(int k=j+1;k<nums.Length;k++)
                    {
                        sumOfThreeInt = nums[i] + nums[j] + nums[k];

                        diferance = Math.Abs(target - sumOfThreeInt);

                        if (minDifferance > diferance)
                        {
                            minDifferance = diferance;
                            closest_to_target = nums[i] + nums[j] + nums[k];

                        }
                    }    
                }


            }
            return closest_to_target;
        }
    }