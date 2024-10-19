using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4};
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                int n = nums.Length;
                int[] arr = Enumerable.Range(1, n).ToArray();
                nums = nums.Distinct().ToArray();
                int[] arr2 = arr.Except(nums).ToArray();
                return arr2; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                List<int> arr = new List<int>();
                foreach (int i in nums)
                {
                    if (i % 2 == 0)
                    {
                        arr.Add(i);
                    }
                }
                foreach (int i in nums)
                {
                    if (i % 2 != 0) { arr.Add(i); }
                }
                int[] arr1 = arr.ToArray();
                return arr1; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                int[] arr = new int[2];
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target) { arr[0] = i; arr[1] = j; }
                    }
                }
                return arr; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                int n = nums.Length;
                List<int> products = new List<int>();
                for (int i = 0; i < n-2; i++)
                {
                    for (int j = i + 1; j < n-1; j++)
                    {
                        for (int k = i + 2; k < n; k++)
                        {
                            products.Add(nums[i] * nums[j] * nums[k]);
                        }

                    }
                }
                int[] arr1 = products.ToArray();
                return arr1.Max();  // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                string x = Convert.ToString(decimalNumber, 2);
                return x; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                int x = nums.Min();
                return x; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                string y = x.ToString();
                int n = y.Length;
                string y1;
                string y2;
                if (n % 2 == 0) 
                { 
                    y1 = y.Substring(0, n / 2); 
                    y2 = y.Substring(n / 2, n/2);
                    if (y1.CompareTo(y2) == 0) { return true; }
                    else { return false; }
                }
                else
                { 
                    y1 = y.Substring(0, (n-1)/ 2); 
                    y2 = y.Substring((n+1) / 2, (n-1)/2);
                    y2 = new string(y2.Reverse().ToArray());
                    if (y1.CompareTo(y2) == 0) { return true; } 
                    else { return false; }
                }
                
                     // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                int[] Fib = new int[n+1];
                Fib[0] = 0;
                Fib[1] = 1;
                for (int i = 2; i < n+1; i++)
                {
                    Fib[i] = Fib[i - 2] + Fib[i - 1];                
                }
                return Fib[n]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
