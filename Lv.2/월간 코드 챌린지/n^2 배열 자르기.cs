using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.월간_코드_챌린지
{
    internal class n_2_배열_자르기
    {
        public long[] solution(long n, long left, long right)
        {
            long[] answer = new long[right - left + 1];

            long count = (left / n) * n;
            long index = 0;

            for (long i = left / n; i < n; i++)
            {
                long num = i + 1;
                for (long j = 0; j < n; j++)
                {
                    if (index > answer.Length - 1)
                        break;

                    if (index < answer.Length && count > left - 1)
                    {
                        if (num < j + 1)
                            answer[index++] = j + 1;
                        else
                            answer[index++] = num;
                    }

                    count++;
                }

                if (index > answer.Length - 1)
                    break;
            }
            return answer;
        }
    }
}
