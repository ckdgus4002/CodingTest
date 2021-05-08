using System;
using System.Linq;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        Array.Sort(A, (a, b) => b.CompareTo(a));
        Array.Sort(B, (a, b) => b.CompareTo(a));

        int answer = 0;
        foreach (int a in A)
        {
            if (a < B[answer]) answer++;
        }

        return answer;
    }
}