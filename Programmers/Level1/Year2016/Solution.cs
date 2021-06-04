using System;

public class Solution
{
    public string solution(int a, int b)
    {
        DateTime dateTime = new DateTime(2016, a, b);
        return dateTime.DayOfWeek.ToString().Substring(0, 3).ToUpper();
    }
}