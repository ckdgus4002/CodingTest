using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        while (1 < n)
        {
            if (0 < n % 2)
            {
                answer++;
                n--;
            }

            n /= 2;
        }

        return answer + 1;
    }
}