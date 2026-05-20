// See https://aka.ms/new-console-template for more information
using LeetCodes;

Console.WriteLine("Hello, World!");

ArrayProblems arrayProblems = new ArrayProblems();
// Utility.PrintArray(arrayProblems.TwoSum(new int[]{3, 2, 4}, 6));
//Console.WriteLine("Max profit:" + arrayProblems.MaxProfit(new int[] { 2, 4, 1}).ToString());
//IntegerProblems problems = new();
//Console.WriteLine("Is -121 palindrome?: " + problems.IsPalindrome(-121));
//string roman = "MCMXCIV";
//Console.WriteLine("Integer for " + roman + " is: " + problems.RomanToInt(roman));

//Utility.PrintDictionary(arrayProblems.GetSubArray(new int[] { 1, 2, 3 }));
// Utility.PrintDictionary(new Dictionary<int, int[]> { { 1, new int[] { 1, 2, 3 } } });
// int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
// Console.WriteLine("Max sum of Subarrays: " + arrayProblems.GetSubArrayMaxSum(arr));
/*
int[] arr = { 0, 0, 1 };
Utility.PrintArray(arr);
Console.WriteLine("After moving zeroes: ");
Utility.PrintArray(arrayProblems.MoveZeroesToEnd(arr));
*/
/*
int[] arr = { -2, 0, 3, -5, 2, -1 };
Utility.PrintArray(arrayProblems.GetPrefixSumArray(arr));
int left = 0, right = 2;
Console.WriteLine("Sum between Indices: {left: " + left + ", right: " + right + "} is: " + arrayProblems.SumRange(left, right, arr));
*/
/*
int[] arr = { 1, 2, 3 };
arrayProblems.GetAllSubArrays(arr);
*/
// int[] arr = { 1, 2, 3, 4, 5 };
// Console.WriteLine("Largest element: " + arrayProblems.FindLargestInArray(arr));
// Console.WriteLine("2nd Largest element: " + arrayProblems.Find2ndLargest(arr));
// arrayProblems.FindFirst2Largest(arr);
// Console.WriteLine("Is arr sorted?: " + arrayProblems.IsArraySorted(arr));
// Utility.PrintArray(arrayProblems.LeftRotateArrayBy1(arr));
// Utility.PrintArray(arrayProblems.ReverseArray(arr, 0, 2));
// Utility.PrintArray(arrayProblems.LeftRotateArrayByDPlaces(arr, 3));
// Utility.PrintArray(arrayProblems.RightRotateArrayByDPlaces(arr, 2));
/*
int[] arr = { 1, 0, 2, 3, 2, 0, 0, 4, 5, 1 };
Utility.PrintArray(arrayProblems.MoveZeroesToEndOptimal(arr));
*/
/*
int[] arr1 = { 1, 2, 3, 4, 4, 5 }, arr2 = { 1, 3, 6, 9 };
Utility.PrintArray(arrayProblems.UnionOfArrays(arr1, arr2));
*/
/*
int[] arr1 = { 1, 2, 3, 4, 4, 5 }, arr2 = { 1, 3, 6, 9 };
Utility.PrintArray(arrayProblems.UnionOfSortedArrays(arr1, arr2));
*/
/*
int[] arr1 = { 1, 2, 2, 3, 3, 4, 5, 6 }, arr2 = { 2, 3, 3, 5, 6, 6, 7 };
Utility.PrintArray(arrayProblems.InterSectionOfSortedArrays(arr1, arr2));
*/
/*
int[] arr = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine("Missing number: " + arrayProblems.FindMissingNumber(arr, arr.Length+1));
*/
/*
int[] arr = { 1, 1, 0, 1, 1, 1, 0, 1, 1 };
Console.WriteLine("Max 1s: " + arrayProblems.FindMaximumConsecutiveOnes(arr));
*/ //
/*
int[] arr = { 1, 1, 2, 2, 3, 4, 4 };
Console.WriteLine("Element with only 1 occurrence(s): " + arrayProblems.FindElementWith1Occurrence(arr));
*/
/*
int[] arr = {1, 2, 3, 1, 1, 3, 3};
int requiredSum = 6;
Console.WriteLine("Longest subarray with sum: " + requiredSum + " is: " + arrayProblems.FindLengthofLongestSubArrayWtihSumK(arr, requiredSum));
*/
/*
int[] arr = {1, 2, 3, 5, 6, 8, 11};
int requiredSum = 15;
Console.WriteLine("Sum: " + requiredSum + " exists for 2 elements: " + arrayProblems.IsTwoSumExistsInSortedArray(arr, requiredSum));
*/
/*
int[] arr = {5, 7, 5, 5, 7, 1, 5, 5, 7, 7, 1, 1, 1, 2};
Console.WriteLine("Majority element: " + arrayProblems.GetMajorityElement(arr));
*/
/*
int[] arr = {-2, -3, 4, -1, -2, -3, 5, -3};
Console.WriteLine("Max sum of the subarray: " + arrayProblems.GetMaxmimumSumOfSubArray(arr));
*/
/*
int[] arr = {2, 0, 1, 1, 0, 2, 1, 2, 1, 0, 1};
arrayProblems.SortArryaOf012s(arr);
Utility.PrintArray(arr);
*/
/*
int[] arr = {-3, 1, -2, 5, 2, -4};
Utility.PrintArray(arrayProblems.ReArrageElementsBySign(arr));
*/

int[] arr = {2, 1, 5, 4, 3, 0, 0};
Console.WriteLine("Next permutation: ");
Utility.PrintArray(arrayProblems.FindNextPermutation(arr));
