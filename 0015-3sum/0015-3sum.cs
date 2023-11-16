    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> triplets = new List<List<int>>();

            HashSet<List<int>> uniquetriplets = new HashSet<List<int>>(new ListComparer());

            Dictionary<int,int> uniqueNumbers = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                uniqueNumbers[nums[i]] = i;
            }

            for(int i = 0;i<nums.Length;i++)
            {
                for(int j = i+1;j < nums.Length;j++)
                {
                    
                    if (uniqueNumbers.TryGetValue(0 - (nums[i] + nums[j]), out int value) && value != i && value != j)
                    {
                        List<int> list = new List<int>() { nums[i], nums[j], 0 - (nums[i] + nums[j]) };
                        list.Sort((a, b) => b.CompareTo(a));
                        uniquetriplets.Add(list);
                    }
                }
            }
            foreach(List<int> list in  uniquetriplets)
            {
                triplets.Add(list);
            }
            return triplets.Cast<IList<int>>().ToList();
        }
    }
    class ListComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(List<int> obj)
        {
            int hash = 17;
            foreach (int item in obj)
            {
                hash = hash * 31 + item.GetHashCode();
            }
            return hash;
        }
    }