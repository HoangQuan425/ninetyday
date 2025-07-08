namespace Day3
{
	internal class Program
	{
		static string ReverseArrayTwoPointer(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				throw new ArgumentNullException("null");
			}
			char[] chars = s.ToCharArray();
			int left = 0;
			int right = s.Length - 1;
			while (left < right)
			{
				(chars[left], chars[right]) = (chars[right], chars[left]);
				left++;
				right--;
			}
			return new string(chars);
		}
		// Maximum Sum Subarray of Size K (Easy)
		/*Cho 1 mảng arr[] gồm N số nguyên và 1 số nguyên K.
		Tìm tổng lớn nhất của bất kỳ subarray nào có độ dài K.*/
		static int FindMaxSumSub(int[] a, int k)
		{
			int sum = 0;
			for (int i = 0; i < k; i++)
			{
				sum += a[i];
			}
			int maxSum = 0;
			for (int i = k; i < a.Length; i++)
			{
				sum += a[i] - a[i - k];
				maxSum = Math.Max(sum, maxSum);
			}
			return maxSum;
		}
		static int[] MergeTwoSortedArray(int[] a, int[] b)
		{
			int i = 0;
			int j = 0;
			int[] array = new int[a.Length + b.Length];
			int k = 0;
			while(i<a.Length && j < b.Length)
			{
				if (a[i] < b[j])
				{
					array[k] = a[i];
					k++;
					i++;
				}else if (a[i] > b[j])
				{
					array[k] = b[j];
					j++;
					k++;
				}
			}
			while (i<a.Length)
			{
				array[k] = a[i];
				k++;
				i++;
			}
			while (j < b.Length)
			{
				array[k] = b[j];
				j++;
				k++;
			}
			return array;
		}
		static void inputArray(int[] a)
		{
			for(int i = 0; i < a.Length; i++)
			{
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		static void outputArray(int[] a)
		{
			for(int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]+" ");
			}
		}
		static void Main(string[] args)
		{
			//string s = Console.ReadLine();
			//Console.WriteLine(s);
			//Console.WriteLine(ReverseArrayTwoPointer(s));
			Console.WriteLine("input size 1: ");
			int n1 = int.Parse(Console.ReadLine());
			int[] a = new int[n1];
			Console.WriteLine("input size 2: ");
			int n2 = int.Parse(Console.ReadLine());
			int[] b = new int[n2];
			inputArray(a);
			inputArray(b);
			int[] result = MergeTwoSortedArray(a, b);
			for (int i=0; i<result.Length;i++)
			{
				Console.WriteLine(result[i]+" ");
			}
		}
	}
}
