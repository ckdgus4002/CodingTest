using System;

namespace LCH
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] lottos = new int[] { 44, 1, 0, 0, 31, 25 };
            int[] win_nums = new int[] { 31, 10, 45, 1, 6, 19 };
            int[] result = solution.solution(lottos, win_nums);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
