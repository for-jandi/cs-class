using System;
using System.Collections.Generic;

namespace CSClass
{
   
    public class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public Fibonacci()
        {
        }

        internal int Get(int v)
        {
            Console.WriteLine(v);
            if (v < 0) return 0;
            if (v == 1) return 1;
            if (memo.ContainsKey(v))
            {
                return (int)memo[v];
            }
            else
            {
                long value = Get(v - 2) + Get(v - 1);
                memo[v] = value;
                return (int)value;
            }
        }
    }
}