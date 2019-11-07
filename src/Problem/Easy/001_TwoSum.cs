using System.Collections.Generic;

namespace Algorithms.Problem.Easy
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// Example:
    /// Given nums = [2, 7, 11, 15], target = 9,
    /// Because nums[0] + nums[1] = 2 + 7 = 9,
    /// return [0, 1].
    /// </summary>
    public class _001_TwoSum
    {
        #region Public Methods

        public int[] TwoSum(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>(nums.Length);

            for (var i = 0; i < nums.Length; i++)
            {
                if (!hash.ContainsKey(nums[i]))
                {
                    hash.Add(nums[i], i);
                }

                var needed = target - nums[i];

                if (hash.ContainsKey(needed) && hash[needed] != i)
                {
                    return new[] { i, hash[needed] };
                }
            }

            return default(int[]);
        }

        #endregion Public Methods
    }
}