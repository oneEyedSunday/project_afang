using System;

namespace ProductOfArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().ProductExceptSelf(new int[] { 1, 2, 3, 4});
            result = new Solution().ProductExceptSelf(new int[] { 0, 0 });

            Console.ReadLine();
        }
    }
}
