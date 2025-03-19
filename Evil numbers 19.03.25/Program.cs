using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evil_numbers_19._03._25
{
    internal class Program
    {
        int[] binary = new int[] { 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
        static void Main(string[] args)
        {
            int num = 1;
            List<string> decnums = new List<string>();
            List<string> evilnums = new List<string>();

            for (int i = 0; i < 1000; i++)
            {
                decnums.Add(num.ToString());
                num += 1;
            }
            
            
        }
    }
}
