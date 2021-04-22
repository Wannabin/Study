using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (s == null || "".Equals(s))
            {
                return s;
            }

            int len = s.Length;

            string ans = "";
            int max = 0;

            bool[][] dp = new bool[][] { };

            for (int j = 0; j < len; j++)
            {
                for (int i = 0; i <= j; i++)
                {
                    Boolean judge = s[i] == s[j];

                    dp[i][j] = j - i > 2 ? dp[i + 1][j - 1] && judge : judge; 

                    if (dp[i][j] && j - i + 1 > max)
                    {
                        max = j - i + 1;
                        ans = s.Substring(i, j + 1);
                    }
                }
            }

            return ans;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            Console.WriteLine(sol.LongestPalindrome("babad"));
            
        }
    }
}
