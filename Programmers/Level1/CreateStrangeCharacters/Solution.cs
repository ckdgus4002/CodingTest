using System.Text;

public class Solution {
    public string solution(string s) {
        
        var split = s.Split(' ');
        var answer = new StringBuilder();
        for (var i = 0; i < split.Length; i++)
        {
            for (var j = 0; j < split[i].Length; j++)
            {
                var append = split[i][j];
                if (j % 2 == 0 && 'a' <= append) append = (char)(append - 32);
                else if (j % 2 == 1 && append <= 'Z') append = (char) (append + 32);
                
                answer.Append(append);
            }
            
            if (i < split.Length - 1) answer.Append(' ');
        }
        
        return answer.ToString();
    }
}