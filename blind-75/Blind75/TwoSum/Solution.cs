using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
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
    }
}
