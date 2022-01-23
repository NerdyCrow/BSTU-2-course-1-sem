using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
   public partial class Array
    {
        public override bool Equals(object obj)
        {
            if (obj==null)
            {
                return false;
            }
            Array arr = obj as Array;
            if (arr==null)
            {
                return false;
            }
            return arr.size == this.size;
        }
       /* public override int ToString()
        {
            for (int i = 0; i < IntArr.Length; i++)
            {
                Console.Write($"Arr[{i + 1}] = {IntArr[i]} \n");
            }
            Console.WriteLine();
           
        }*/
    }
}
