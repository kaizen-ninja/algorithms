using System;

namespace Algorithms.Problem.Hard
{
    public class _004_MedianOfTwoSortedArrays
    {
        #region Public Methods

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums = new int[nums1.Length + nums2.Length];
            var result = default(double);

            nums1.CopyTo(nums, 0);
            nums2.CopyTo(nums, nums1.Length);

            Array.Sort(nums);

            if (nums.Length % 2 == 1)
            {
                result = nums[nums.Length / 2];
            }
            else
            {
                result = 0.5 * (nums[nums.Length / 2 - 1] + nums[nums.Length / 2]);
            }

            return result;
        }

        #endregion Public Methods
    }
}