using System;

namespace Kth_Number
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] result = solution.solution(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,]
            {
                { 2, 5, 3 },
                { 4, 4, 1 },
                { 1, 7, 3 },
            });

            foreach (var r in result) Console.WriteLine(r);
        }
    }
}
