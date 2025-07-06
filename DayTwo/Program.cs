namespace DayTwo
{
	internal class Program
	{
		static int SecondMinValue(int[] a)
		{
			int minValue = int.MaxValue;
			int secondMinValue = int.MaxValue;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] < minValue)
				{
					secondMinValue = minValue;
					minValue = a[i];
				}
				else if (a[i] < secondMinValue && a[i] != minValue)
				{
					secondMinValue = a[i];
				}
			}
			return secondMinValue;
		}
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			int i = m - 1;
			int j = n - 1;
			int k = m + n - 1;
			while (i >= 0 && j >= 0)
			{
				if (nums1[i] > nums2[j])
				{
					nums1[k] = nums1[i];
					i--;
				}
				else
				{
					nums1[k] = nums2[j];
					j--;
				}
				k--;
			}

			while (j >= 0)
			{
				nums1[k] = nums2[j];
				j--;
				k--;
			}
		}
		public static int LengthOfLongestSubstring(string s)
		{
			int left = 0;
			int j = 0;
			var dict = new Dictionary<char, int>();
			int maxLenght = 0;
			while (j < s.Length) // abcabcaa
			{
				if (dict.ContainsKey(s[j]))
				{
					left = Math.Max(left, dict[s[j]] + 1);
				}
				dict[s[j]] = j;
				maxLenght = Math.Max(maxLenght,j - left + 1);
				j++;
			}
			return maxLenght;
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine(SecondMinValue(arr));
			//for(int i = 0; i < n; i++)
			//{
			//	Console.WriteLine(arr[i]);
			//}
		}
	}
}
