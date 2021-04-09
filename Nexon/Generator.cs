using System;
using System.Collections.Generic;

namespace LCH.CodingTest.Nexon
{
    public class Generator
    {
        private readonly List<int> generatedNumbers = new List<int>();



        public Generator()
        {
            for (int i = 0; i< 5000; i++) generatedNumbers.Add(Generate(i));

            int result = 0;
            for (int i = 0; i< 5000; i++) if (!generatedNumbers.Contains(i)) result += i;

            Console.Write(result);
        }



        private int Generate(int generator)
        {
            int _return = generator;
            int digit = (int)Math.Log10(generator) + 1;

            while (true)
            {
                if (1 < digit)
                {
                    _return += generator / (int)Math.Pow(10, --digit);
                }
                else
                {
                    _return += generator % 10;
                    break;
                }
            }

            return _return;
        }
    }
}