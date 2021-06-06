using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int n)
    {
        var answer = 0;
        for (var i = 2; i <= n; i++)
        {
            if (IsPrimeNumber(i)) answer++;
        }

        return answer;
    }

    private bool IsPrimeNumber(int n)
    {
        var end = (int)Math.Sqrt(n);
        
        for (var i = 2; i <= end; i++)
        {
            if (0 == n % i) return false;
        }

        return true;
    }
}