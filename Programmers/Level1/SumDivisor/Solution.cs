using System.Collections.Generic;

class Solution
{
    public int solution(int n)
    {
        var divisors = TakeDivisors(n);
        var answer = 0;
        foreach (var divisor in divisors) answer += divisor;
        
        return answer;
    }
    
    private List<int> TakeDivisors(int number)
    {
        var _return = new List<int>();
        if (0 < number)
        {
            for (var i = 1; i <= number; i++)
            {
                if (number % i == 0) _return.Add(i);
            }
        }
        
        return _return;
    }
}