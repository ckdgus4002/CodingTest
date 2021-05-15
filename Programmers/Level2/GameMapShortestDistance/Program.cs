using System;

namespace LCH
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.solution(new int[,]
            {
                { 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 0, 1, 1, 1 },
                { 1, 1, 1, 0, 0 },
                { 0, 0, 0, 0, 1 },
            });
            Console.WriteLine(result);
        }
    }
}
