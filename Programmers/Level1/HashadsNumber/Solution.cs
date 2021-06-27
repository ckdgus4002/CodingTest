using System;
using System.Linq;

public class Solution {
    public bool solution(int x) => (x % x.ToString().Sum(c => c - '0')) == 0;
}