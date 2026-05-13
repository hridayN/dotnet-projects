using System;
namespace LeetCodes
{
	public class ArrayProblems
	{
		public ArrayProblems()
		{
		}

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (IsTargetExists(nums[i], nums[j], target))
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }

        private bool IsTargetExists(int num1, int num2, int target)
        {
            return (num1 + num2) == target;
        }

        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            Dictionary<int, int> priceHashMap = new();
            foreach (int value in prices)
            {
                if (!priceHashMap.ContainsValue(value))
                {
                    priceHashMap.Add(priceHashMap.Count()+1, value);
                }
            }

            int minValue = priceHashMap.Values.Min();
            int minValuePosition = priceHashMap.FirstOrDefault(x => x.Value == minValue).Key-1;

            for(int i = minValuePosition+1; i < priceHashMap.Values.Count(); i++)
            {
                int newMaxProfit = priceHashMap.Values.ElementAt(i) - priceHashMap.Values.ElementAt(minValuePosition);
                maxProfit = (newMaxProfit > maxProfit) ? newMaxProfit : maxProfit;
            }
            return maxProfit;
        }

        public Dictionary<int, int[]> GetSubArray(int[] arr)
        {
            Dictionary<int, int[]> subarrays = new();
            int key = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                subarrays.Add(key++, new int[] { arr[i] });
            }
            return subarrays;
        }

        public int GetSubArrayMaxSum(int[] nums)
        {
            int sum = 0;
            int maxSum = nums[0];
            for (int i=0; i < nums.Length; i++)
            {
                sum += nums[i];
                maxSum = (sum > maxSum) ? sum : maxSum;
                sum = (sum < 0) ? 0 : sum;
            }
            return maxSum;
        }

        public int[] MoveZeroesToEnd(int[] nums)
        {
            int zeros = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                zeros = (nums[i] == 0) ? zeros + 1 : zeros;
            }

            while (zeros > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        SetElements(nums, i);
                        nums[nums.Length - 1] = 0;
                    }
                }
                zeros--;
            }
            
            return nums;
        }

        public void SetElements(int[] nums, int startIndex)
        {
            for (int i = startIndex; i < nums.Length-1; i++)
            {
                nums[i] = nums[i + 1];
            }
        }

        public int[] GetPrefixSumArray(int[] arr)
        {
            int n = arr.Length;
            int[] prefixSumArray = new int[n];
            prefixSumArray[0] = arr[0];
            for (int i =1; i < n; i++)
            {
                prefixSumArray[i] = prefixSumArray[i - 1] + arr[i];
            }

            return prefixSumArray;
        }



        public int SumRange(int left, int right, int[] arr)
        {
            int n = arr.Length;
            int[] prefixSumArray = new int[n];
            prefixSumArray[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                prefixSumArray[i] = prefixSumArray[i - 1] + arr[i];
            }
            left = (left <= 0) ? 0 : left - 1;
            return prefixSumArray[right] - prefixSumArray[left];
        }

        public int FindMaxLength(int[] nums)
        {
            int sum = 0, zeroesSum = 0, onesSum = 0, n = nums.Length, i = 0;
            while (i < n) {
                if (nums[i] == 0)
                {
                    zeroesSum++;
                } else
                {
                    onesSum++;
                }
                i++;
            }
            sum = (zeroesSum > onesSum) ? onesSum : zeroesSum;
            return sum;
        }

        public void GetAllSubArrays(int[] arr)
        {
            int n = arr.Length;
            for (int i =0; i < n; i++)
            {
                Console.WriteLine("[" + arr[i] + "],");
                Console.Write("[");
                for (int j =i; j < n; j++)
                {
                    Console.Write(arr[j] + " ");
                }
                Console.Write("],");
                Console.WriteLine(" ");
            }
        }

        public int FindLargestInArray(int[] arr)
        {
            int n = arr.Length, largest = arr[0];
            for (int i=0; i < n; i++)
            {
                largest = (arr[i] > largest) ? arr[i] : largest;
            }
            return largest;
        }

        public int Find2ndLargest(int[] arr)
        {
            int secondLargest = int.MinValue, n = arr.Length, largest = FindLargestInArray(arr);
            for (int i=1; i < n; i++)
            {
                secondLargest = (arr[i] > secondLargest && arr[i] < largest) ? arr[i] : secondLargest;
            }
            return secondLargest;
        }

        public void FindFirst2Largest(int[] arr)
        {
            int n = arr.Length, largest = int.MinValue, secondLargest = int.MinValue, smallest = int.MaxValue, secondSmallest = int.MaxValue;
            for (int i =0; i < n; i++)
            {
                largest = (arr[i] > largest) ? arr[i] : largest;
                secondLargest = (arr[i] > secondLargest && arr[i] < largest) ? arr[i] : secondLargest;
                smallest = (arr[i] < smallest) ? arr[i] : smallest;
                secondSmallest = (arr[i] < secondSmallest && arr[i] > smallest) ? arr[i] : secondSmallest;
            }
            Console.WriteLine("Largest: " + largest);
            Console.WriteLine("2nd Largest: " + secondLargest);
            Console.WriteLine("Smallest: " + smallest);
            Console.WriteLine("2nd Smallest: " + secondSmallest);
        }

        public bool IsArraySorted(int[] arr)
        {
            int n = arr.Length;
            for (int i=1; i < n; i++)
            {
                if (arr[i] < arr[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public int[] LeftRotateArrayBy1(int[] arr)
        {
            int n = arr.Length, temp = arr[0];

            for (int i = 1; i < n; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[n-1] = temp;
            return arr;
        }

        public int[] ReverseArray(int[] arr, int start, int end)
        {
            while (start <= end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }

        public int[] LeftRotateArrayByDPlaces(int[] arr, int rotatingNumber)
        {
            arr = ReverseArray(arr, 0, rotatingNumber - 1);
            arr = ReverseArray(arr, rotatingNumber, arr.Length - 1);
            arr = ReverseArray(arr, 0, arr.Length - 1);
            return arr;
        }

        public int[] RightRotateArrayByDPlaces(int[] arr, int rotatingNumber)
        {
            int n = arr.Length;
            int[] temp = new int[rotatingNumber];
            int j = n - rotatingNumber;
            for (int i = 0; i < rotatingNumber; i++)
            {
                temp[i] = arr[j];
                j++;
            }
            for (int i =0; i < n-rotatingNumber; i++)
            {
                arr[i + rotatingNumber] = arr[i];
            }
            return arr;
        }

        public int[] MoveZeroesToEndOptimal(int[] arr)
        {
            int i = 0, j = 0, n = arr.Length;
            while (i < n)
            {
                if (arr[j] != 0)
                {
                    j++;
                }
                if (i > j && arr[i] != 0 && arr[j] == 0)
                {
                    // swap
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                i++;
            }
            return arr;
        }

        public int[] UnionOfArrays(int[] arr1, int[] arr2)
        {
            HashSet<int> uniques = new HashSet<int>();
            for (int i =0; i < arr1.Length; i++)
            {
                uniques.Add(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                uniques.Add(arr2[i]);
            }
            int[] arr = new int[uniques.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = uniques.ElementAt(i);
            }
            return arr;
        }

        public int[] UnionOfSortedArrays(int[] arr1, int[] arr2)
        {
            int[] unionArray;
            List<int> unionList = new();
            int i = 0, j = 0, n1 = arr1.Length, n2 = arr2.Length;
            while (i < n1 && j < n2)
            {
                if (arr1[i] <= arr2[j])
                {
                    if (!unionList.Any() || unionList.Last() != arr1[i])
                    {
                        unionList.Add(arr1[i]);
                    }
                    i++;
                } else
                {
                    if (!unionList.Any() || unionList.Last() != arr2[j])
                    {
                        unionList.Add(arr2[j]);
                    }
                    j++;
                }
            }

            while (j < n2)
            {
                if (!unionList.Any() || unionList.Last() != arr2[j])
                {
                    unionList.Add(arr2[j]);
                }
                j++;
            }

            while (i < n1)
            {
                if (!unionList.Any() || unionList.Last() != arr1[i])
                {
                    unionList.Add(arr1[i]);
                }
                i++;
            }
            unionArray = unionList.ToArray();
            return unionArray;
        }

        public int[] InterSectionOfSortedArrays(int[] arr1, int[] arr2)
        {
            List<int> unionList = new();
            int i = 0, j = 0, n1 = arr1.Length, n2 = arr2.Length;
            while (i < n1 && j < n2)
            {
                if (arr1[i] == arr2[j])
                {
                    unionList.Add(arr1[i]);
                    j++;
                }
                i++;
            }
            return unionList.ToArray();
        }

        public int FindMissingNumber(int[] arr, int N)
        {
            int arrXOR = 0, NXOR = 0, n = N - 1;
            for (int i = 0; i < n; i++)
            {
                NXOR ^= (i + 1); 
                arrXOR ^= arr[i];
            }
            NXOR ^= N;
            return arrXOR ^ NXOR;
        }

        public int FindMaximumConsecutiveOnes(int[] arr)
        {
            int n = arr.Length, maxCount = 0, i =0, currentCountOf1s = 0;
            while (i < n)
            {
                if (arr[i] == 1)
                {
                    currentCountOf1s++;
                }
                else
                {
                    currentCountOf1s = 0;
                }
                        
                maxCount = (currentCountOf1s > maxCount) ? currentCountOf1s : maxCount;
                i++;
            }
            

            return maxCount;
        }

        public long FindElementWith1Occurrence(int[] arr)
        {
            int n = arr.Length;
            /*
             * //Solution 1
            Dictionary<long, int> elementWithOccurrenceMap = new();
            for (int i=0; i < n; i++)
            {
                if (elementWithOccurrenceMap.ContainsKey(arr[i]))
                {
                    int value = elementWithOccurrenceMap.FirstOrDefault(x => x.Key == arr[i]).Value + 1;
                    elementWithOccurrenceMap[arr[i]] = value;
                }
                else
                {
                    elementWithOccurrenceMap.Add(arr[i], 1);
                }
            }

            return elementWithOccurrenceMap.FirstOrDefault(x => x.Value == 1).Key;
            */
            int arrXOR = 0;
            for (int i = 0; i < n; i++)
            {
                arrXOR ^= arr[i];
            }
            return arrXOR;
        }
    
        public int FindLengthofLongestSubArrayWtihSumK(int[] arr, int k)
        {
            int n = arr.Length, maxLength = 0, sum = 0, pointer1 = 0, pointer2 = 0;
           
            while (pointer2 < n)
            {
                sum += arr[pointer2];
                maxLength = SetMaxLength(sum, k, pointer1, pointer2, maxLength);
                while (sum > k && pointer1 <= pointer2)
                {
                    sum -= arr[pointer1];
                    pointer1++;
                    maxLength = SetMaxLength(sum, k, pointer1, pointer2, maxLength);
                }
                pointer2++;
            }
            return maxLength;
        }

        private int SetMaxLength(int sum, int k, int pointer1, int pointer2, int maxLength)
        {
            return (sum == k && (pointer2 - pointer1 + 1) > maxLength) ? pointer2 - pointer1 + 1 : maxLength;
        }
    }
}
