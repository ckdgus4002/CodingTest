public class Solution {
    public string solution(string s)
    {
        var isOdd = s.Length % 2 == 1;
        var half = s.Length / 2;
        return isOdd ? s.Substring(half, 1) : s.Substring(half - 1, 2);
    }
}