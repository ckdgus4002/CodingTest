using System;

public class Solution {
    public string solution(string s)
    {
        var charArray = s.ToCharArray();
        Array.Sort(charArray, (a, b) => b.CompareTo(a));
        return new string(charArray);
    }
}