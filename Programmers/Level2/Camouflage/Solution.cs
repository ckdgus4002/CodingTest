using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[,] clothes)
    {
        var dict = new Dictionary<string, List<string>>();
        for (var i = 0; i < clothes.GetLength(0); i++)
        {
            var key = clothes[i, 1];
            var value = clothes[i, 0];
            if (dict.ContainsKey(key)) dict[key].Add(value);
            else dict.Add(key, new List<string> { value }); 
        }

        var answer = 1;
        foreach (var key in dict.Keys) answer *= dict[key].Count + 1;
        return answer - 1;
    }
} 