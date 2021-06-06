using System;

public class Solution {
    public bool solution(string s) {
        if (s.Length == 4 || s.Length ==  6)
        {
            foreach (var a in s)
            {
                if (a < 48 || 57 < a) return false;
            }

            return true;
        }
        else
        {
            return false;
        }
    }
}