using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 연속된_부분_수열의_합
    {
        public int[] solution(int[] sequence, int k)
        {
            int[] answer = new int[2];

            int[] index = new int[sequence.Length];

            int idx = 0;
            int cidx = 0;
            int sum = 0;

            for (int i = 0; i < index.Length; i++)
                index[i] = -1;

            while (idx < sequence.Length)
            {
                sum += sequence[idx++];

                if (sum >= k)
                {
                    while (sum > k)
                        sum -= sequence[cidx++];

                    if (sum == k)
                        index[cidx] = idx - 1;
                }
            }

            int min = sequence.Length;
            for (int i = 0; i < index.Length; i++)
            {
                int size = index[i] - i;
                if (index[i] > -1 && size < min)
                {
                    min = size;
                    answer[0] = i;
                    answer[1] = index[i];
                }
            }

            return answer;
        }
    }
}
