using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Struct_Study.Algorithm_classes
{
    public static class SearchMethodsClass
    {
        public static int SearchSimpleUnSort(int[] a, int x)
        {
            int L = a.Length;
            int i = 0;

            while (i < L && a[i] != x)
                i++;

            if(i < L)
                return i;
            else
                return -1;
        }

        public static int SearchBarrierUnSort(int[] a, int x)
        {
            int L = a.Length;
            Array.Resize<int>(ref a, ++L);
            a[L - 1] = x;
            int i = 0;

            while (a[i] != x)
                i++;

            if (i < L - 1)
                return i;
            else
                return -1;
        }

        public static int SearchSimpleMyUnSort(int[] a, int x)
        {
            int result = -1;
            int i = 0;

            while (i < a.Length && a[i] != x)
                i++;

            if (i < a.Length)
                result = i;

            return result;
        }

        public static int SearchBinary(int[] a, int x)
        {
            int m;
            int left = 0;
            int right = a.Length - 1;

            do
            {
                m = (left + right) / 2;
                if (x > a[m])
                    left = m + 1;
                else
                    right = m - 1;
            } 
            while ((a[m] != x) && (left <= right));

            if (a[m] == x)
                return m;
            else
                return -1;
        }
    }
}
