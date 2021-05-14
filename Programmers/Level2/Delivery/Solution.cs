using System;
using System.Collections.Generic;

class Solution
{
    private struct Destination
    {
        public int destination;
        public int distance;

        public Destination(int destination, int distance)
        {
            this.destination = destination;
            this.distance = distance;
        }
    }



    private int TakeMinimum(int[] array, bool[] closes)
    {
        int index = 0;
        int value = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < value && !closes[i]) value = array[index = i];
        }

        return index;
    }

    public int[] Dijkstra(int N, int[,] road)
    {
        int MAX_DISTANCE = N * 10000 + 1;
        int[,] distances = new int[N, N];
        for (int i = 0; i < distances.GetLength(0); i++)
        {
            for (int j = 0; j < distances.GetLength(1); j++) distances[i, j] = i == j ? 0 : MAX_DISTANCE;
        }

        for (int j = 0; j < road.GetLength(0); j++)
        {
            int from = road[j, 0] - 1;
            int to = road[j, 1] - 1;
            int distance = road[j, 2];
            if (distance < distances[from, to])
            {
                distances[from, to] = distances[to, from] = distance;
            }
        }

        int start = 0;
        int[] _return = new int[N];
        for (int i = 0; i < _return.Length; i++) _return[i] = start == i ? 0 : distances[start, i];

        bool[] closes = new bool[N];
        closes[start] = true;
        for (int i = 0; i < N - 2; i++)
        {
            int current = TakeMinimum(_return, closes);
            closes[current] = true;
            for (int j = 0; j < N; j++)
            {
                if (!closes[j])
                {
                    if (_return[current] + distances[current, j] < _return[j])
                    {
                        _return[j] = _return[current] + distances[current, j];
                    }
                }
            }
        }

        return _return;
    }



    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
        foreach(var distance in Dijkstra(N, road)) if (distance <= K) answer++;

        return answer;
    }
}