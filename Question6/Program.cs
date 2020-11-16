
using System;
using System.Collections.Generic;

namespace Question6
{

    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
            Numbers AverageArray = () => { 
             List<int> oddArray = new List<int>();
            int num = 0;
            if(num.length == 0)
            {
             oddArray.Add(num);
            }
             for (int i = 0; i < numbers.length; i++){
               num += numbers[i];
            }
            return num / num.length;
            };
            AverageArray();

        
       }
    }
}
// function average (numbers) {
//   let num = 0;
// if(num.length === 0){
// return num;
        
//     }
//   for (let i = 0; i < numbers.length; i++){
//       num += numbers[i];
//   }
//   return num / num.length;
//   console.log(num)
// }

