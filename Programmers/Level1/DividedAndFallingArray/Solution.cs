using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor)
    {
        var answer = arr.Where(a => a % divisor == 0).ToArray();

        Array.Sort(answer);
        
        return answer.Length < 1 ? new[] {-1} : answer.ToArray();
    }
}