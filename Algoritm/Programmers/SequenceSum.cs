namespace Algoritm.Programmers
{
    public class SequenceSum
    {
        public int[] Solution(int[] sequence, int k, int[] expected)
        {
            int[] answer = new int[2] {-1, 0};

            int start = 0;
            int end = 0;
            int partSum = 0;

            // sequence의 맨 마지막에 도착할때까지 반복
            while(start < sequence.Length)
            {
                // partSum에 sequence 값을 추가한다.
                partSum += sequence[end];

                // 부분합이 k보다 클 경우 Start에 1을 더하고 end, partSum을 초기화 한다.
                if (partSum > k)
                {
                    start++;
                    end = start;
                    partSum = 0;
                    continue;
                }

                // 부분합이 k 값과 같을경우
                if(partSum == k)
                {
                    // answer의 배열 길이 비교
                    int seqLen = end - start;

                    // 1. 배열의 길이가 1일 경우 바로 Return
                    if(seqLen.Equals(0))
                    {
                        answer = new int[2] {start, end};
                        return answer;
                    }

                    if(answer[0] == -1)
                    {
                        answer = new int[2] { start, end };
                    }

                    // 2. 배열의 길이가 더 작을 경우 answer 값 변경
                    if (seqLen < (answer[1] - answer[0]))
                    {
                        answer = new int[2] { start, end };
                    }
                }

                end++;

                // end가 배열끝까지 오면 초기화
                if (end == sequence.Length)
                {
                    start++;
                    end = start;
                    partSum = 0;
                }
            }

            return answer;
        }
    }
}
