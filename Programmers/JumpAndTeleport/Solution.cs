using System;

class Solution
{
    public int solution(int n)
    {
        int teleport = (int)Math.Pow(2, (int)Math.Log(n, 2));
        int answer = 1 + (n - teleport);

        return answer;
    }
}