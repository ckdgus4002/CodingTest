using System;
using System.Linq;

public class Solution {
    public long solution(long n)
    {
        var desc = n.ToString().Select(c => c - '0').OrderBy(a => a);
        var index = 0;
        long answer = 0;
        foreach (var d in desc)
        {
            answer += d * (long)Math.Pow(10, index);
            index++;
        }
        
        return answer;
    }
}