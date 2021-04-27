using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Reverse_Integer
{
    class Solution
    {
        public int Reverse(int x)
        {
            long res = 0;
            while (x != 0)
            {
                res = res * 10 + x % 10;
                x = x / 10;
            }
            if (res < int.MinValue || res> int.MaxValue)
            {
                return 0;
            }
            else
            {
                return (int)res;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            sol.Reverse(1534236469);
        }
    }
}
