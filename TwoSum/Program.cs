    namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] result=TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }
                if (!numDict.ContainsKey(nums[i]))
                {
                    numDict[nums[i]] = i;
                }
            }

            throw new ArgumentException("No two sum solution");
        }
    }

}

