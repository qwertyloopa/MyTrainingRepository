using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._7._1
{
    class ArrayWorker
    {
        public static T[] InvertArray<T>(T[] array)
        {

            int length = array.Length;
            T[] invertedArray = new T[length];

            for (int i = 0; i < length; i++)
            {
                invertedArray[i] = array[length - 1 - i];
            }

            return invertedArray;
        }
    }
}
