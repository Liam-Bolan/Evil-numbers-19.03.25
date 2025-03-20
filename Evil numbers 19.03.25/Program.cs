using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evil_numbers_19._03._25
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int num = 1;
            List<int> decnums = new List<int>();
            List<int> evilnums = new List<int>();
            
            for (int i = 0; i < 1000; i++)
            {
                decnums.Add(num);
                num += 1;
            }
            foreach(int number in decnums)
            {
                int onecount = 0;
                string binarynum = Convert.ToString(number, 2);
                foreach(char bits in binarynum)
                {
                    if (bits == '1')
                    {
                        onecount += 1;
                    }
                }
                if (onecount % 2 == 0)
                {
                    evilnums.Add(number);
                } 
            }
            foreach(int number in evilnums)
            {
                Console.Write(number + ",");
            }
            Console.ReadLine();

        }
    }
}
