using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        #region Solution 1
        /*
        // Time Complexity O(n2)
        public int[] TwoSum(int[] nums, int target)
        {
            int index1 = 0, index2 = 0;
            for (int i = 0; i < nums.Length - 1; i++) 
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        //return new int[] { i, j };
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }

            return new int[] { index1, index2 };

            //throw new ArgumentException("No two sum solution found.");
        }
        */
        #endregion

        #region Solution 2
        /*

        // Time Complexity O(n), Space Complexity O(n)

        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map[complement] != i)
                {
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { i, map[complement] };
                    }
                }
            }

            return new int[] { };
        }
        */



        #endregion

        #region Solution 3

        // Time Complexity O(n), Space Complexity O(n)

        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     map[nums[i]] = i;
            // }

            for (int i = 0; i < nums.Length; i++)
            {
                // map[nums[i]] = i;
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { i, map[complement] };
                }
                map[nums[i]] = i;
            }

            return new int[] { };
        }
        #endregion
    }

}
