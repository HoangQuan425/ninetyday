using System.Text;

namespace NinetyDay
{
	internal class Program
	{
		static void ReverseArrayInPlace(int[] a)
		{
			//12345

			for (int i = 0; i < a.Length / 2; i++) //1 
			{
				(a[i], a[a.Length - i - 1]) = (a[a.Length - i - 1], a[i]);
			}
		}
		static int findMin(int[] a)
		{
			//12345
			if (a == null) return -1;
			int min = int.MaxValue;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] < min)
				{
					min = a[i];
				}
			}
			return min;
		}
		static int findMax(int[] a)
		{
			if (a == null) return -1;
			//12345
			int max = int.MinValue;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
				}
			}
			return max;
		}
		static int SumEven(int[] a)
		{
			if (a == null) return -1;
			int sum = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] % 2 == 0) sum += a[i];
			}
			return sum;
		}

		public static int CountChar(string a, char c)
		{
			int count = 0;
			foreach (char cr in a)
			{
				if (cr == c) count++;
			}
			return count;
		}
		public static bool isPalidrome(int s)
		{
			string a = s.ToString(); 
			if (a.Length == 0) return false;
			if (a.Length == 1) return true;

			for (int i = 0; i < a.Length / 2; i++)
			{
				if (!a[i].Equals(a[a.Length - i - 1]))
				{
					return false;
				}
			}
			return true;
		}
		public static string ReverseStringInPlace(string a)
		{
			char[] arr = a.ToCharArray();
			for (int i = 0; i < arr.Length / 2; i++)
			{
				(arr[i], arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);
			}
			return new string(arr);
		}
		public static int[] TwoSum(int[] numbers, int target)
		{
			/*for (int i=0; i<numbers.Length;i++)
			{
				for (int j = i +1; j<numbers.Length;j++)
				{
					if(target == (numbers[i] + numbers[j]))
					{
						return new int[] { i+1, j+1 };
					}
				}
			}
			return new int[] {-1,-1};*/
			int left = 0;
			int right = numbers.Length - 1;
			while (left < right)
			{
				if (target == (numbers[left] + numbers[right]))
				{
					return new int[] { left + 1, right + 1 };
				}
				else if (target > (numbers[left] + numbers[right]))
				{
					left++;
				}
				else
				{
					right--;
				}
			}
			return new int[] { -1, -1 };
		}

		public static int CountString(string a)
		{
			int count = 0;
			char[] word = a.ToCharArray();
			Console.WriteLine(word);
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] != ' ' && (i == 0 || a[i - 1] == ' '))
				{
					count++;
				}
			}
			return count;
		}
		public static void RemoveDuplicatesfromSortedArray(int[] a)
		{
			int i = 0;
			int j = 1;
			while(j < a.Length)
			{
				if (a[i] != a[j])
				{
					i++;
					a[i] = a[j];
				}
				j++;
			}
		}
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			Array.Sort(nums);
			List<IList<int>> result = new List<IList<int>>();
			for (int i = 0; i < nums.Length - 2; i++)
			{
				if (i > 0 && nums[i] == nums[i - 1]) continue;
				int left = i + 1;
				int right = nums.Length - 1;
				while (left < right)
				{
					int sum = nums[i] + nums[left] + nums[right];
					if (sum == 0)
					{
						result.Add(new List<int> { nums[i], nums[left], nums[right] });
						while (left < right && nums[left] == nums[left + 1]) left++;

						while (left < right && nums[right] == nums[right - 1]) right--;
						left++;
						right--;
					}
					else if (sum < 0)
					{
						left++;
					}
					else
					{
						right--;
					}
				}
			}

			return result;
		}

		public int MaxArea(int[] height)
		{
			int i = 0;
			int j = height.Length - 1;
			int max = 0;
			while (i < j)
			{
				int area = Math.Min(height[i], height[j]) * (j - i);
				if (area > max)
				{
					max = area;
				}else if (height[i] < height[j]) i++;
				else j--;
			}
			return max;

		}

		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine() ?? "0");
			int[] arr = new int[n];
			string srr = Console.ReadLine();
			//input
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine() ?? "0");
			}
			//reverse array
			//ReverseArrayInPlace(arr);\
			Console.WriteLine(arr);
			/*Console.WriteLine(CountString(srr));*/
			RemoveDuplicatesfromSortedArray(arr);
			//print
			for (int i = 0; i < n; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}
