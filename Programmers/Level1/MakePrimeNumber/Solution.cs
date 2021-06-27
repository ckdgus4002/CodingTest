using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        List<int> sums = new List<int>();
        for (int start = 0; start < nums.Length - 2; start++)
        {
            for (int mid = start + 1; mid < nums.Length - 1; mid++)
            {
                for (int end = mid + 1; end < nums.Length; end++)
                {
                    int sum = nums[start] + nums[mid] + nums[end];
                    sums.Add(sum);
                }
            }
        }

        for (int i = 0; i < sums.Count; i++)
        {
            answer += IsPrimeNumber(sums[i]) ? 1 : 0;
        }

        return answer;
    }

    private bool IsPrimeNumber(int number)
    {
        if (number == 2 || number == 3)
        {
            return true;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}