public class Solution
{
    public int MaxArea(int[] height)
    {
        int start = 0; int end = height.Length-1,maxArea=0, calculatedArea = 0, heightOfRectangle, widthOfRectangle;

        while (start < end)
        {
            heightOfRectangle = (height[start] > height[end])? height[end] : height[start];
            widthOfRectangle = end - start;
            calculatedArea = CalculateArea(heightOfRectangle, widthOfRectangle);
            maxArea = (calculatedArea > maxArea) ? calculatedArea : maxArea;

            if (height[start] < height[end])
                start += 1;
            else
                end -= 1;
        }
        return maxArea;
    }
    private int CalculateArea(int height,int width)
    {
        return height * width;
    }
}