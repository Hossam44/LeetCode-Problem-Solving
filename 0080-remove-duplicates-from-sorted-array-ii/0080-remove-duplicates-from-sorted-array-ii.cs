    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            Dictionary<int,int > keyValuePairs = new Dictionary<int,int>();
            int LenghtOfResultElements = 0,counter=0;
            foreach (int num in nums)
            {
                if(keyValuePairs.TryGetValue(num, out int value))
                {
                    keyValuePairs[num] = value + 1;
                    if (value == 1)
                        LenghtOfResultElements++;
                }
                else
                {
                    keyValuePairs[num] = 1;
                    LenghtOfResultElements++;
                }
            }
            foreach ((int key,int value) in keyValuePairs)
            {
                nums[counter++] = key;

                if (value > 1)
                    nums[counter++] = key;
            }

            return counter;
        }
    }