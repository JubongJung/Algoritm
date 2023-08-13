using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm.Programmers
{
    public class SmallestNumber
    {
        public int solution(int[] A, int[] B)
        {
            int answer = 0;

            A = OrderByAscending(A);
            B = OrderByDescending(B);

            for(int i = 0; i < A.Length; i++)
            {
                answer += A[i] * B[i];
            }

            return answer;
        }

        public int[] OrderByAscending(int[] ints)
        {
            for(int i = 0; i < ints.Length - 1; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] > ints[j])       
                    {
                        int temp = ints[i]; 
                        ints[i] = ints[j]; 
                        ints[j] = temp;
                    }
                }
            }

            return ints;
        }

        public int[] OrderByDescending(int[] ints)
        {
            for (int i = 0; i < ints.Length - 1; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)  
                {
                    if (ints[i] < ints[j])       
                    {
                        int temp = ints[i]; 
                        ints[i] = ints[j]; 
                        ints[j] = temp;
                    }
                }
            }

            return ints;
        }
    }
}
