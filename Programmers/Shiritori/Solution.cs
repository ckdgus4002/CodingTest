using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        string prev = "";
        List<string> closeWords = new List<string>();
        int wrong = 0;
        foreach(string current in words)
        {
            if (string.IsNullOrWhiteSpace(prev)
                || (prev[prev.Length - 1] == current[0] && !closeWords.Contains(current))
                )
            {
                closeWords.Add(prev = current);
                wrong++;
            }
            else
            {
                break;
            }
        }

        int[] answer = new int[2];
        answer[0] = words.Length <= wrong ? 0 : wrong % n + 1;
        answer[1] = words.Length <= wrong ? 0 : wrong / n + 1;
        return answer;
    }
}