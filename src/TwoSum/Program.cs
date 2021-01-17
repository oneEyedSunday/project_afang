using System;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = new int[] { 2, 7, 11, 15 };
            var  pairs = new Program().Pairs(new int [] { 2, 7, 11, 15 });
            Array.Sort(input);
            Console.ReadLine();
        }


        public int[][] Pairs(int[] nums)
        {
            int[][] jaggedpairs = new int[nums.Length - 1][];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                jaggedpairs[i] = new int[2];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (j == i)
                        continue;
                    jaggedpairs[i][0] = nums[i];
                    jaggedpairs[i][1] = nums[j];
                }
                //for (int j = 0; j < nums.Length - 1; j++)
                //{
                //    pairs[i, j] = nums[i];
                    //jaggedpairs[i] = nums.Where((value, index) => i != index)
                    //.Select(value => new int[] { nums[i], value })
                    //.ToArray();
                //    Console.WriteLine($"pairs[{i}{j}] = {nums[i]}");
                //}
            }

            return jaggedpairs;
        }
    }
}
