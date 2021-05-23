using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] pattern = new int[] { 1, 2, 3, 4, 5 };
        int[] pattern2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] pattern3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        Dictionary<int, int> dict = new Dictionary<int, int>()
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
        };

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == pattern[i % pattern.Length]) dict[1]++;
            if (answers[i] == pattern2[i % pattern2.Length]) dict[2]++;
            if (answers[i] == pattern3[i % pattern3.Length]) dict[3]++;
        }

        int max = dict.Max(a => a.Value);
        List<int> answer = new List<int>();
        foreach (var item in dict)
        {
            if (item.Value == max) answer.Add(item.Key);
        }

        return answer.ToArray();
    }
}