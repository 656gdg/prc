 /*Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
You must write an algorithm that runs in linear time and uses linear extra space.
*/
public class Solution
{
    public int MaximumGap(int[] nums)
    {
        int result = 0;

        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i++)
        {
            result = Math.Max(result, nums[i] - nums[i - 1]);
        }
        return result;
    }
}