namespace Day6
{
	internal class Program
	{
		static int LongestSubstringWithoutRepeatingCharacters(string s)
		{
			int left = 0;
			int maxCount = 0;
			var set = new HashSet<char>();
			for (int right = 0; right < s.Length; right++)
			{
				while (!set.Contains(s[right]))
				{
					set.Add(s[right]);
					maxCount = Math.Max(maxCount, set.Count);
				}
				set.Remove(s[left]);
				left++;
			}
			return maxCount;
		}
		static int MaximumSubArray(int[] nums)
		{
			int maxEnding = nums[0];
			int max = nums[0];
			for (int i=1; i<nums.Length;i++)
			{
				maxEnding = Math.Max(nums[i], maxEnding + nums[i]);
				max = Math.Max(maxEnding, max);
			}
			return max;
		}
		static void Main(string[] args)
		{
			//Console.WriteLine("nhap s: ");
			//string s = Console.ReadLine();
			//Console.WriteLine(LongestSubstringWithoutRepeatingCharacters(s));
			Console.WriteLine("int size: ");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i=0; i<n;i++)
			{
				Console.WriteLine($"input element {i}");
				a[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine(MaximumSubArray(a));
		}
	}
}
