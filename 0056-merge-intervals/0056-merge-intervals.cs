    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (X, Y) => X[0].CompareTo(Y[0]));
            int start = intervals[0][0], end= intervals[0][1];
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < intervals.Length - 1; i++)
            {

                if (intervals[i+1][0] >= start && intervals[i+1][0] <= end)
                {
                    end = Math.Max(Math.Max(intervals[i + 1][1], intervals[i][1]),end);
                }
                else
                {
                    List<int> list = new List<int>() { start, end };

                    result.Add(list);
                    start = intervals[i + 1][0];
                    end = intervals[i + 1][1];
                }
            }
            List<int> lastlist = new List<int>() { start, end };

            result.Add(lastlist);

            int[][] non_overlappingIntervals = new int[result.Count][];

            for(int i = 0;i< result.Count;i++)
            {
                non_overlappingIntervals[i] = new int[] { result[i][0], result[i][1] };
            }

            return non_overlappingIntervals;
        }
    }