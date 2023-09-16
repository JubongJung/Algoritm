using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System;

namespace Algoritm.Programmers
{
    /// <summary>
    /// https://school.programmers.co.kr/learn/courses/30/lessons/131701
    /// </summary>
    public class 연속부분수열합의개수
    {
        public int[] array = null;

        public int solution(int[] elements)
        {
            int answer = 0;
            array = elements;
            
            Dictionary<int,int> map = new Dictionary<int,int>();

            // 몇개씩 합할지
            for(int sumCount = 2; sumCount < array.Length; sumCount++)
            {
                for (int index = 0; index < array.Length; index++)
                {
                    int sum = 0;

                    // 현재 Index부터 sumCount 갯수까지의 합
                    for (int i = index; i < index + sumCount; i++)
                    {
                        sum += Get(i);
                    }

                    if (!map.ContainsKey(sum))
                    {
                        map.Add(sum, index);
                    };
                }
            }

            int arraySum = 0;

            foreach(int row in array)
            {
                if (!map.ContainsKey(row))
                {
                    map.Add(row, row);
                }
                arraySum += row;
            }
            map.Add(arraySum, arraySum);
            
            return answer;
        }

        public int Get(int index)
        {
            if(array.Length <= index)
            {
                return Get(index - array.Length);
            }
            else if(index < 0)
            {
                return Get(index + array.Length);
            }
            return array[index];
        }
    }
}
