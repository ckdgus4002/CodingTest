using System;
using System.Collections.Generic;

public class Solution
{
    private struct Vector2
    {
        private static readonly Vector2 minSize = new Vector2() { x = -5, y = -5 };
        private static readonly Vector2 maxSize = new Vector2() { x = 5, y = 5 };

        public int x, y;

        public bool TryGo(char d)
        {
            if (d == 'R' && x < maxSize.x) { x++; return true; }
            else if (d == 'D' && minSize.y < y) { y--; return true; }
            else if (d == 'L' && minSize.x < x) { x--; return true; }
            else if (d == 'U' && y < maxSize.y) { y++; return true; }
            else return false;
        }

        public static bool operator == (Vector2 a, Vector2 b) => a.x == b.x && a.y == b.y;
        public static bool operator != (Vector2 a, Vector2 b) => a.x != b.x || a.y != b.y;
    }



    public int solution(string dirs)
    {
        List<Vector2[]> open = new List<Vector2[]>();
        Vector2 current = new Vector2();
        foreach(char d in dirs)
        {
            Vector2 prev = current;
            if (current.TryGo(d))
            {
                Vector2[] path = new Vector2[] { prev, current };
                Vector2[] find = open.Find(o => (o[0] == path[0] && o[1] == path[1])
                                             || (o[0] == path[1] && o[1] == path[0])
                                             );
                if (find == null)
                {
                    open.Add(path);
                }
            }
        }

        return open.Count;
    }
}