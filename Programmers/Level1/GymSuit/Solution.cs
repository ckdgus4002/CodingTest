using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        List<int> list_lost = lost.ToList();
        List<int> list_reserve = reserve.ToList();
        int answer = 0;
        for (int i = 0; i < list_lost.Count;)
        {
            int item = list_lost[i];
            if (list_reserve.Contains(item))
            {
                list_lost.Remove(item);
                list_reserve.Remove(item);
                answer++;
            }
            else
            {
                i++;
            }
        }

        foreach (int l in list_lost)
        {
            if (list_reserve.Contains(l - 1))
            {
                list_reserve.Remove(l - 1);
                answer++;
            }
            else if (list_reserve.Contains(l + 1))
            {
                list_reserve.Remove(l + 1);
                answer++;
            }
        }

        answer += n - lost.Length;

        return answer;
    }
}