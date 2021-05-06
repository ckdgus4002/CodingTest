using System;
using System.Collections.Generic;

namespace LCH
{
    /// <source>
    /// https://nypc.github.io/2020/2020_online_1.html
    /// </source>
    public class MaximumIntervalTotal
    {
        public MaximumIntervalTotal()
         {
            Console.Write(Calculate("3\n-1 -2 -3"));
        }



        private long Calculate(string str)
        {
            // Take length.
            string[] splitStringByLF = str.Split('\n');
            int length = ToInt(splitStringByLF[0]);

            // Calculate maximum interval total.
            List<long> values = new List<long>();
            if (!string.IsNullOrWhiteSpace(splitStringByLF[1]))
            {
                // Take list(or array).
                List<int> list = new List<int>();
                foreach (string s in splitStringByLF[1].Split(' ')) list.Add(ToInt(s));

                for (int i = 0; i < length; i++)
                {
                    for (int j = i; j < length; j++)
                    {
                        long value = 0;

                        for (int k = i; k <= j; k++)
                        {
                            value += list[k];
                        }

                        values.Add(value);
                    }
                }

                values.Sort();
            }

            return values[0 < values.Count ? values.Count - 1 : 0];
        }



        private int ToInt(string s)
        {
            return int.TryParse(s, out int result) ? result : 0;
        }
    }
}