using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;

        List<int> list = d.ToList();
        list.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            budget -= list[i];

            if (budget < 0)
            {
                break;
            }
            else
            {
                answer++;
            }
        }

        return answer;
    }
}