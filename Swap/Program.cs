
using System;

namespace Swap
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers SwapValues = () => {
            int num = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    num[i] = "codebits";
                    Console.WriteLine(num);
                }
            }
            // return num;
            

            };
            SwapValues();
        }
    }
}
