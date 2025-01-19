using System.Numerics;

namespace CSharpPractice
{
    internal class Solution
    {
        /*Find ratio of positive numbers, negative numbers, and number of zeors from a list*/
        public static void PlusMinus(List<int> arr)
        {
            double totalNumbers = arr.Count;
            var zeros = arr.Where(e => e == 0).Count() / totalNumbers;
            var positives = arr.Where(e => e > 0).Count() / totalNumbers;
            var negatives = arr.Where(e => e < 0).Count() / totalNumbers;

            Console.WriteLine($"Number of zeros ratio: {zeros:F6}\nPositive numbers ratio{positives:F6}\nNegative numbers ratio{negatives:F6}");
        }

        /*Find the absolute difference between a square matrix diagonals*/
        public static int DiagonalDifference(List<List<int>> arr)
        {
            var leftToRight = 0;
            var rightToLeft = 0;

            for (int i = 0, j = arr.Count - 1; i < arr.Count; i++, j--)
            {
                leftToRight += arr[i][i];
                rightToLeft += arr[j][i];
            }
            return Math.Abs(leftToRight - rightToLeft);
        }

        /*Find the number that appears only once in an array*/
        public static void SingleNumber(int[] nums)
        {
            Console.Write("Single Number occured in an array: ");
            Console.WriteLine(nums.GroupBy(g => g)
                                  .Where(g => g.Count() == 1)
                                  .Select(n => n.Key)
                                  .First());
        }

        /*Find the indices of two numbers that add up to a target number*/
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = Array.Empty<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        result = [i, j];
                    }
                    continue;
                }
            }
            return result;
        }

        /*Add one to the number made with combining all the digits of an array*/

        public static void PlusOne(int[] digits)
        {
            var x = BigInteger.Parse(string.Join("", digits)) + 1;
            Console.WriteLine($"Number by combining digits + 1 : {x} ");
        }
    }
}
