using System;

namespace LCH
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(5, new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 }));
        }
    }
}