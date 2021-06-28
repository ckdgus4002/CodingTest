using System;
using System.Diagnostics;

public class Solution {
    public int[] solution(int n, int m)
    {
        var gcd = TakeGcd(n, m);
        
        return new[] { gcd, n * m / gcd };
    }

    private int TakeGcd(int n, int m) => n % m == 0 ? m : TakeGcd(m, n % m);   
}