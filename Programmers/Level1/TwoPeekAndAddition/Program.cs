using System;

namespace LCH
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new Solution().solution(new int[] { 2, 1, 3, 4, 1 }))
            {
                Console.WriteLine(item);    
            }
        }
    }
}