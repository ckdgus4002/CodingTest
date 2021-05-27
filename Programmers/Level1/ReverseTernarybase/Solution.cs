using System;
using System.Text;

public class Solution
{
    public int solution(int n)
    {
        StringBuilder sb = new StringBuilder();
        while (2 <= n)
        {
            sb.Append(n % 3);
            n /= 3;
        }
        sb.Append(n);
        
        int answer = 0;
        for (int i = 0; i < sb.Length; i++)
        {
            int add = (sb[i] - '0') * Pow(3, sb.Length - i - 1);
            answer += add;
        }

        return answer;
    }

    private int Pow(int x, int y)
    {
        int pow = 1;
        if (0 < y)
        {
            for (int i = 0; i < y; i++)
            {
                pow *= x;
            }
        }

        return pow;
    }
}