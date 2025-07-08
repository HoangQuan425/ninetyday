using System.Drawing;

namespace Day4Leetcode
{
	internal class Program
	{
		static void inputArray(int[] a)
		{
			for (int i = 0; i<a.Length;i++)
			{
				Console.WriteLine($"input element {i}: ");
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		static int MinimumSizeSubarraySum(int[] nums, int target)
		{
			int left = 0;
			int minLen = int.MaxValue;
			int sum = 0;
			for (int right = 0; right < nums.Length; right++)
			{
				sum += nums[right];
				while (sum >= target)
				{
					minLen = Math.Min(right - left + 1, minLen);
					sum -= nums[left];
					left++;
				}
				
			}
			if(minLen == int.MaxValue)
			{
				return 0;
			} 
			return minLen;
		}
		static int MaximumSumSubarrayofSizeK(int[] nums, int k)
		{
			if (k >= nums.Length)
			{
				throw new ArgumentException("Invalid");
			}
			int left = 0;
			int maxSum = 0;
			int sum = 0;
			for(int i=0;i<k; i++)
			{
				sum += nums[i];
			}
			for(int right = k; right < nums.Length; right++)
			{
				sum += nums[right] - nums[right-k];
				maxSum = Math.Max(maxSum, sum);
			}
			if(maxSum == 0)
			{
				return 0;
			}
			return maxSum;
		}
		static int LongestSubstringWithoutRepeatingCharacters(string s)
		{
			int left = 0;
			int maxLen = 0;
			HashSet<char> chars = new HashSet<char>();
			for(int right =0; right < s.Length; right++)
			{
				while (chars.Contains(s[right]))
				{
					chars.Remove(s[left]);
					left++;
				}
				chars.Add(s[right]);
				maxLen = Math.Max(maxLen, right - left + 1);
			}
			return maxLen;
		}
		static int[] RunningSum(int[] nums)
		{
			int left = 0;
			int runingSum = 0;
			var list = new List<int>();
			for (int right = 0; right < nums.Length; right++)
			{
				runingSum += nums[right];
				list.Add(runingSum);
			}
			return list.ToArray();
		}
		public static int SubarraySum(int[] nums, int k)
		{
			int prefixSum = 0;
			var dict = new Dictionary<int, int>() { { 0,1} };
			int count = 0;
			foreach (int num in nums) {
				prefixSum += num;
				if (dict.ContainsKey(prefixSum - k))
				{
					count+= dict[prefixSum - k];
				}
				if (dict.ContainsKey(prefixSum))
				{
					dict[prefixSum]++;
				}
				else
				{
					dict[prefixSum] = 1;
				}
			}
			return count;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("input size: ");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			Console.WriteLine("input k: ");
			int t = int.Parse(Console.ReadLine());
			inputArray(a);

			Console.WriteLine(SubarraySum(a, t));
			//Console.WriteLine("Hello, World!");
			//Console.WriteLine("input string: ");
			//string s = Console.ReadLine();
			//int r = LongestSubstringWithoutRepeatingCharacters(s);
			//Console.WriteLine(r);
		}
	}
}
