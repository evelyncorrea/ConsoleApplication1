using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bubble = { 5, 2, 3, 1, 4, 9999, 89, 100 };
            int b = bubble[0];
            
            for (int i = 0; i < bubble.Length; i++)
            {
                for (int j = i + 1; j < bubble.Length; j++)
                {
                    if (bubble[i] > bubble[j])
                    {
                        b = bubble[i];
                        bubble[i] = bubble[j];
                        bubble[j] = b;
                    }
                }
                Console.WriteLine(bubble[i]);
                Console.ReadLine();
            }
        }
    }
}
