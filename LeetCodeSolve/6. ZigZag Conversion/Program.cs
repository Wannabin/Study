using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ZigZag_Conversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows ==1)
            {
                return s;
            }
           
            char[] str1 = s.ToCharArray();
            int len = s.Length;
            string[] arr = new string[numRows];

            int row = 0;
            bool down = true;

            for (int i = 0; i < len; ++i)
            {
                arr[row] += (str1[i]);

                if (row == numRows - 1)
                {
                    down = false;
                }
                else if (row == 0)
                {
                    down = true;
                }
                if (down)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            string result = string.Concat(arr);
            return result ;
            

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.Convert("PAYPALISHIRING", 3));
            
        }
    }
}
