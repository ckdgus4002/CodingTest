using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int left, int right)
    {
        int answer = 0;
        for (int i = left; i <= right; i++)
        {
            List<int> divisors = TakeDivisors(i);
            answer += divisors.Count % 2 == 0 ? i : -i;
        }

        return answer;
    }



    private List<int> TakeDivisors(int number)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                int item = i;
                if (divisors.Contains(item)) break;
                else divisors.Add(item);

                item = number / i;
                if (divisors.Contains(item)) break;
                else divisors.Add(item);
            }
        }

        return divisors;
    }
}