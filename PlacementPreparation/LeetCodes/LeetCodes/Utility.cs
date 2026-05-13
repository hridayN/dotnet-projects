using System;
namespace LeetCodes
{
	public static class Utility
	{
		public static void PrintArray(int[] arr)
		{
			foreach(int item in arr)
			{
				Console.Write(item + ", ");
			}
		}

		public static void PrintDictionary(Dictionary<int, int[]> keyValues)
		{
            Console.Write("{ ");
            foreach (var item in keyValues)
			{
				Console.Write("{ " + item.Key + ", [");
				PrintArray(item.Value);
                Console.Write("]}, ");
            }
            Console.Write(" }");
        }
	}
}

