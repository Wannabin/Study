using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }
        // i l I L 
        static void Main(string[] args)
        {

            int result = Program.Add(1, 2, d: 2);

            Console.WriteLine(result);

            
        }
    }
}
