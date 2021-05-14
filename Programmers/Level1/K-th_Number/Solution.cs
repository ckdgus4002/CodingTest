using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        List<int> answer = new List<int>();
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            List<int> list = array.ToList();
            list = list.GetRange(commands[i, 0] - 1, commands[i, 1] - commands[i, 0] + 1);
            list.Sort();
            answer.Add(list[commands[i, 2] - 1]);
        }

        return answer.ToArray();
    }
}