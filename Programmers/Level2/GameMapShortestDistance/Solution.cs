using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public int solution(int[,] maps)
    {
        return AStar.Find(new Node()
        {
            x = 0,
            y = 0,
        }, new Node()
        {
            x = maps.GetLength(0) - 1,
            y = maps.GetLength(1) - 1,
        }, maps);
    }

    public class AStar
    {
        public static int Find(Node start, Node arrive, int[,] maps)
        {
            List<Node> open = new List<Node>() { start };
            List<Node> close = new List<Node>();

            while (true)
            {
                Node current = FindMinimumNode(open);
                open.Remove(current);
                close.Add(current);

                if (current == arrive)
                {
                    int _return = 1;
                    while (true)
                    {
                        _return++;
                        current = current.parent;

                        if (current.parent == null) break;
                    }

                    return _return;
                }
                else
                {
                    foreach (Node neighbor in current.Neighbors)
                    {
                        if (current.CanMove(neighbor, maps)
                            && !neighbor.Contains(close)
                            )
                        {
                            int move = current.g + 1;
                            if (move < neighbor.g || !open.Contains(neighbor))
                            {
                                neighbor.g = move;
                                neighbor.h = neighbor.Distance(arrive);
                                neighbor.parent = current;
                                open.Add(neighbor);
                            }
                        }
                    }

                    // 막혀있을 경우.
                    if (open.Count == 0)
                    {
                        return -1;
                    }
                }
            }
        }

        private static Node FindMinimumNode(List<Node> open)
        {
            int min = open.Min(a => a.F);
            List<Node> minFs = open.FindAll(a => a.F == min);

            Node _return = new Node() { h = int.MaxValue };
            for (int i = 0; i < minFs.Count; i++) _return = minFs[i].h < _return.h ? minFs[i] : _return;

            return _return;
        }
    }

    internal class Node
    {
        public int x;
        public int y;
        public int h;
        public int g;
        public Node parent;


        public int F => g + h;

        public Node[] Neighbors => _Neighbors == null ? _Neighbors = new Node[] { Right, Down, Left, Up } : _Neighbors;
        private Node[] _Neighbors;

        public Node Right => new Node { x = x + 1, y = y };
        public Node Down => new Node { x = x, y = y + 1 };
        public Node Left => new Node { x = x - 1, y = y };
        public Node Up => new Node { x = x, y = y - 1 };



        public int Distance(Node a) => Math.Abs(x - a.x) + Math.Abs(y - a.y);

        public bool CanMove(Node destination, int[,] maps)
        {
            return 0 <= destination.x && destination.x < maps.GetLength(1)
                && 0 <= destination.y && destination.y < maps.GetLength(0)
                && maps[destination.y, destination.x] == 1;
        }

        public bool Contains(List<Node> list)
        {
            for (int i = 0; i < list.Count; i++) if (this == list[i]) return true;

            return false;
        }

        public override bool Equals(object obj) => base.Equals(obj);

        public override int GetHashCode() => base.GetHashCode();

        public static bool operator ==(Node a, Node b)
        {
            bool aIsNull = ReferenceEquals(a, null);
            bool bIsNull = ReferenceEquals(b, null);
            if (aIsNull && bIsNull) return true;
            else if (aIsNull || bIsNull) return false;
            else return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Node a, Node b)
        {
            bool aIsNull = ReferenceEquals(a, null);
            bool bIsNull = ReferenceEquals(b, null);
            if (!aIsNull && bIsNull) return true;
            else if (aIsNull && bIsNull) return false;
            else return a.x != b.x || a.y != b.y;
        }
    }
}