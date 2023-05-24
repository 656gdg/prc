﻿/*
Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.
*/
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int l = 0;
        int r = nums.Length;

        while (l < r)
        {
            if (nums[l] == val)
            {
                nums[l] = nums[r - 1];
                r--;
            }
            else
            {
                l++;
            }
        }

        return l;
    }
}