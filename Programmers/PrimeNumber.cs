using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        List<int[]> sums = TakeSums(nums);
        
        for (int i = 0; i < sums.Count; i++)
        {
            int sum = 0;
            for (int j = 0; j< sums[i].Count; j++)
            {
                Console.Write(sums[i][j] + ", ");
                sum += sums[i][j];
            }

            Console.WriteLine();

            answer = answer + (IsPrimeNumber(sum) ? 1 : 0);
        }

        Console.WriteLine(answer);

        return answer;
    }
    
    
    
    private void TakeSums(List<int> list, int start, int end, List<List<int>> result)
    {
        if (start == end)
        {
            result.Add(list.GetRange(0, list.Count));
        }
        else
        {
            for (int i = start; i <= end; ++i)
            {
                int temp = list[start];
                list[start] = list[i];
                list[i] = temp;

                TakePermutation(list, start + 1, end, result);

                temp = list[start];
                list[start] = list[i];
                list[i] = temp;
            }
        }
    }

    private bool IsPrimeNumber(int number)
    {
        if (number == 2 || number == 3)
        {
            Console.WriteLine(number);
            return true;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            Console.WriteLine(number);
            return true;
        }
    }
}