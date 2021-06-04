using System;

public class Solution
{
    private struct Item
    {
        public int index;
        public string value;
    } 
    
    public string[] solution(string[] strings, int n)
    {
        var items = new Item[strings.Length];
        for (var i = 0; i < strings.Length; i++)
        {
            items[i].index = i;
            items[i].value = strings[i];
        }
        
        Array.Sort(items, (a,b) =>
        {
            if (a.value[n] < b.value[n]) return -1;
            return a.value[n] == b.value[n] ? string.Compare(a.value, b.value, StringComparison.Ordinal) : 1;
        });

        var answer = new string[items.Length];
        for (var i = 0; i < items.Length; i++) answer[i] = items[i].value;
        
        return answer;
    }
}