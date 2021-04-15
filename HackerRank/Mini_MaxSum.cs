using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace LCH.CodingTest.HackerRank
{
    public class Mini_MaxSum
    {
        public static void miniMaxSum(int[] arr)
        {
            List<decimal> list = new List<decimal>();
            for (int i = 0; i < arr.Length; i++) list.Add(arr[i]);
            list.Sort();

            decimal min = 0;
            for (int i = 0; i < list.Count - 1; i++) min += list[i];

            decimal max = 0;
            for (int i = 1; i < list.Count; i++) max += list[i];

            Console.Write($"{min} {max}");
        }
    }
}
