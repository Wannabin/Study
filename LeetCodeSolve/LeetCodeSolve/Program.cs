using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolve
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            int lenght = s.Length;
            int start = 0;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int j = 0; j < lenght; j++)
            {
                if (map.ContainsKey(s[j]))
                {
                    if (map[s[j]] >= start)
                    {
                        start = map[s[j]];
                    }
                }

                result = Math.Max(result, j - start + 1);
                map[s[j]] = j + 1;
            }

            return result;
        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            Solution sol = new Solution();

            sol.LengthOfLongestSubstring("au");
        }
    }
}
