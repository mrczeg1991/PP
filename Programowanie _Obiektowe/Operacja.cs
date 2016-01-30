using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Programowanie__Obiektowe
{
    class Operacja
    {
        private int listOfValuesSize = 0;
        long[] listOfValues;
        public Operacja(int listOfValuesSize)
        {
            this.listOfValuesSize = listOfValuesSize;
        }
        public int ListOfValuesSize
        {
            get
            {
                return listOfValuesSize;
            }
        }
        public long findLargestValue()
        {
            long maxValue = listOfValues[0];
            for (int i = 1; i < listOfValuesSize - 1; i++)
            {
                if (maxValue < listOfValues[i])
                {
                    maxValue = listOfValues[i];
                }
            }
            return maxValue;
        }
        public long[] initlistOfValues()
        {
            listOfValues = new long[listOfValuesSize];
            Random rand = new Random();
            for (int i = 0; i < listOfValuesSize - 1; i++)
            {
                listOfValues[i] = rand.Next();
            }
            return listOfValues;
        }
        public void QuickSort(long[] array,int left,int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    // swap
                    var tmp = array[i];
                    array[i++] = array[j];  // ++ and -- inside array braces for shorter code
                    array[j--] = tmp;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
        
    }
}
