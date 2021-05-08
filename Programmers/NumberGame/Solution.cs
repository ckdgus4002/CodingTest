using System;
using System.Linq;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        //int bMax = B.Max();
        //Array.Sort(B);
        int answer = 0;
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < B.Length /*&& A[i] < bMax*/; j++)
            {
                if (0 < B[j] && A[i] < B[j])
                {
                    answer++;
                    B[j] = 0;
                    break;
                }
            }
        }

        return answer;
    }
}