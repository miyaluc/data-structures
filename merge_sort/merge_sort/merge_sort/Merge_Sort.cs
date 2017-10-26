using System;
using System.Collections.Generic;
using System.Text;

namespace merge_sort
{
    class Merge_Sort
    {
        public void DivideDrop(int[] w)
        {
            int v = w.Length / 2;
            int[] newArray1 = new int[v];
            int[] newArray2 = new int[w.Length];

            for(int i=0; i<v; i++)
            {
                newArray1[i] = w[i];
            }
            for(int i=v; i<w.Length; i++)
            {
                newArray2[i] = w[i];
            }
        }
        public void Merge(int[] x, int[] y)
        {
            int[x.Length + y.Length] z;
            int zIndex = 0;
            int i = 0;
            int k = 0;

            for(i; i < x.Length; i++)
            {
                for(k; k<y.Length; k++)
                {
                    if (y[k] < x[i])
                    {
                        z[zIndex] = y[k];
                    }
                    else
                    {
                        z[zIndex] = x[i];
                        zIndex++;
                    }
                }
            }
        }
    }
}
