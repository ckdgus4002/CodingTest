using System;

namespace LCH
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int [,] road = new int[,]
            {
                { 1, 2, 1 },
                { 2, 3, 3 },
                { 5, 2, 2 },
                { 1, 4, 2 },
                { 5, 3, 1 },
                { 5, 4, 2 },
            };

            Console.WriteLine(solution.solution(5, road, 3));
        }
    }
}
