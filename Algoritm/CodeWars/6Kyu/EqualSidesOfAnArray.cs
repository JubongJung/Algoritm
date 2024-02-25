using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.CodeWars._6Kyu
{
    public class EqualSidesOfAnArray
    {
        public static int FindEvenIndex(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = 0;
                for(int j = 0; j < i; j++)
                {
                    left += arr[j];
                }

                for(int j = i+1; j < arr.Length; j++)
                {
                    right += arr[j];
                }

                if(left.Equals(right))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
