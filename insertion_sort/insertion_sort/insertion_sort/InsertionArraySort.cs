﻿using System;
using System.Collections.Generic;
using System.Text;

namespace insertion_sort
{
    class InsertionArraySort
    {
        public int[] arr;

        public InsertionArraySort(int[] newArray)
        {
            arr = newArray;    
        }
        public int[] InsertionSort()
        {
            int[] thisArray = arr;

            for (int i = 0; i < thisArray.Length - 1; i++)
            {
                for (int k = i + 1; k > 0; k--)
                {
                    if (thisArray[k] < thisArray[k - 1])
                    {
                        int temp = thisArray[k - 1];
                        thisArray[k - 1] = thisArray[k];
                        thisArray[k] = temp;
                    }
                }
            }
            return thisArray;
        }
    }
}