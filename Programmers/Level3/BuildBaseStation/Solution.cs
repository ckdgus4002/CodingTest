using System;

class Solution
{
    private int Ceiling(int length, int communication)
        => (length / communication) + (0 < length % communication ? 1 : 0);



    public int solution(int n, int[] stations, int w)
    {
        int communication = w * 2 + 1;
        int answer = 0;

        if (stations.Length == 0)
        {
            answer = Ceiling(stations.Length, communication);
        }
        else
        {
            int start = 1;
            foreach (int station in stations)
            {
                int end = station - w - 1;
                answer += Ceiling(end - start + 1, communication);

                start = station + w + 1;
            }

            if (start <= n)
            {
                answer += Ceiling(n - start + 1, communication);
            }
        }

        return answer;
    }
}