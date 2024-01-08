using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._7._1
{
    internal class ArrayWorker
    {
        public static int[] InvertArray(int[] array)
        {
            int length = array.Length;
            int[] invertedArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                invertedArray[i] = array[length - 1 - i];
            }

            return invertedArray;
        }
    }
}
