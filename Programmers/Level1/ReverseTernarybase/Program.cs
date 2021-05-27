using System;

namespace LCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(2));
        }
    }
}