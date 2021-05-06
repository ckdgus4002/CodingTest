using System;

namespace Shiritori
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] result = solution.solution(3, new string[]
            {
                "tank", "kick", "know", "wheel", "land", "dream", "mother", "robot", "tank"
            });
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}