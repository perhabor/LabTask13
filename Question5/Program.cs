using System;

namespace Question5
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
              Numbers squareArray = () =>
            {
                int[] numbers = { 6, 10, 20 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    double num = Math.Pow(numbers[i], 2);
                    Console.Write(+num + " ");
                }
            };
            squareArray();
        }
    }
}
// private static int[] squareArray(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         result[i] = (int)Math.Pow(array[i], 2);
//     }
//     return result;
// }