using TwoSum;

int[] nums = [2, 7, 11, 15];
int target = 9;

var solution = new Solution();
int[] result = solution.TwoSum(nums, target);
Console.WriteLine("[" + string.Join(",", result) + "]");