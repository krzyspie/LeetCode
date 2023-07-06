static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> temp = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int valueToSearch = target - nums[i];

        bool hasValue = temp.TryGetValue(valueToSearch, out int val);

        if (hasValue)
        {
            return new int[2] { val, i };
        }

        temp.TryAdd(nums[i], i);
    }

    return Array.Empty<int>();
}

var first = TwoSum(new int[5] { 2, 3, 7, 11, 15 }, 9);
var second = TwoSum(new int[4] { -3, 4, 3, 90 }, 0);
var third = TwoSum(new int[2] { 3, 3 }, 6);

Console.WriteLine($"[{first[0]}, {first[1]}]");
Console.WriteLine($"[{second[0]}, {second[1]}]");
Console.WriteLine($"[{third[0]}, {third[1]}]");