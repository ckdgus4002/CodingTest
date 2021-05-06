using System;
using System.Numerics;

namespace LCH
{
    public class A_Number
    {
        public A_Number()
        {
            for (int i = 2_147_483_647; 0 <= i; i--)
            {
                double digit = Math.Log10(i) + 1;
                BigInteger aPow = BigInteger.Pow(i, 2);

                if (i == aPow % (BigInteger)Math.Pow(10, digit))
                {
                    Console.Write(i);
                    break;
                }
            }
        }
    }
}