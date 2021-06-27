using System;
using System.Diagnostics;
using System.Text;

public class Solution
{
    public string solution(string s, int n)
    {
        var answer = new StringBuilder();
        foreach (var c in s)
        {
            int append = c;
            if ('A' <= c && c <= 'Z')
            {
                append += n;
                if ('Z' < append) append -= 26;  
            }
            else if ('a' <= c && c <= 'z')
            {
                append += n;
                if ('z' < append) append -= 26;
            }
            
            answer.Append((char)append);
        }

        return answer.ToString();
    }
}