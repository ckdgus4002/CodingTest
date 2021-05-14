using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {

        int zeroNumber = 0;
        for (int i = 0; i < lottos.Length; i++) zeroNumber += lottos[i] == 0 ? 1 : 0;

        List<int> correct = new List<int>();
        for (int i = 0; i < lottos.Length; i++)
        {
            for (int j = 0; j < win_nums.Length; j++)
            {
                if (lottos[i] == win_nums[j]) correct.Add(lottos[i]);
            }
        }

        int[] answer = new int[]
        {
            Clamp(7 - correct.Count - zeroNumber, 1, 6),
            Math.Min(7 - correct.Count, 6)
        };

        return answer;
    }

    public int Clamp(int value, int min, int max)
    {
        if (value <= min) return min;
        else if (max <= value) return max;
        else return value;
    }
}