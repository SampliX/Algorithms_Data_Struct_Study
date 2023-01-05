using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Struct_Study.Algorithm_classes
{
    public static class SortMethodsClass
    {
        public static void SortSelection(int[] a)
        {
            int N = a.Length;
            int min = 0;
            int imin = 0;
            int i;

            for(i = 0; i < N - 1;i++)
            {
                min = a[i];
                imin = i;

                for(int j = i+1; j < N; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        imin = j;
                    }
                }

                if(i != imin)
                {
                    a[imin] = a[i];
                    a[i] = min;
                }
            }
        }

        public static void SortInsertion(int[] a)
        {
            int tmp = 0;
            int N = a.Length;

            for(int i = 1; i < N; i++)
            {
                int j = i - 1;

                while(j >= 0 && tmp < a[j])
                    a[j + 1] = a[j--];

                a[j + 1] = tmp;
            }
        }
    }
}
