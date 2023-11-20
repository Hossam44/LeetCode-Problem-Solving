    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] mergedArray = new int[m+n];
            int counter = 0;
            int Num1Pointer = 0, Num2Pointer = 0;
            while(Num1Pointer < m && Num2Pointer<n)
            {
                if (nums1[Num1Pointer] < nums2[Num2Pointer])
                {
                    mergedArray[counter++] = nums1[Num1Pointer];
                    Num1Pointer++;
                }
                else
                {
                    mergedArray[counter++] = nums2[Num2Pointer];
                    Num2Pointer++;
                }
            }

            if (Num1Pointer < m)
                merge(counter, Num1Pointer,m, nums1, mergedArray);
            if (Num2Pointer < n)
                merge(counter, Num2Pointer, n, nums2, mergedArray);

            for (int i = 0; i < n + m; i++)
                nums1[i] = mergedArray[i];

        }
        public void merge(int counter,int Num2Pointer,int len, int[]num1, int[]result)
        {

            for (int i = Num2Pointer; i< len; i++)
            {
                result[counter++] = num1[i];
            }
        }
    }