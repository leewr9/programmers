using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class x만큼_간격이_있는_n개의_숫자
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];

            long num = x;
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = num;
                num += x;
            }

            return answer;
        }
    }
}
