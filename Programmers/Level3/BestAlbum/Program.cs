using System;

namespace LCH
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] result = solution.solution(
                new string[] { "classic", "pop", "classic", "classic", "pop" },
                new int[] { 500, 600, 150, 800, 2500 }
                );

            foreach (var item in result) Console.WriteLine(item);
        }
    }
}
