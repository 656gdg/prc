/*
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.
*/
public class Solution
{
    public int Trap(int[] height)
    {

        int leftMax = 0;
        int rightMax = 0;
        int left = 0;
        int right = height.Length - 1;
        int result = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] > leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    result += leftMax - height[left];
                }
                left++;
            }
            else
            {
                if (height[right] > rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    result += rightMax - height[right];
                }
                right--;
            }
        }

        return result;
    }
}