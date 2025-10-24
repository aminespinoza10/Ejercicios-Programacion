int[] TwoSum(int[] nums, int target) {
    var map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (map.ContainsKey(complement))
        {
            return new int[] { map[complement], i };
        }
        map[nums[i]] = i;
    }
    return new int[0];
}

//Ejemplo de uso 1
int[] nums1 = { 2, 7, 11, 15 };
int target1 = 9;
int[] result1 = TwoSum(nums1, target1);
Console.WriteLine($"Output: [{result1[0]}, {result1[1]}]");

//Ejemplo de uso 2
int[] nums2 = { 3, 2, 4 };
int target2 = 6;
int[] result2 = TwoSum(nums2, target2);
Console.WriteLine($"Output: [{result2[0]}, {result2[1]}]");

