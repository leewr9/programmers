using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 두_정수_사이의_합
    {
        public long solution(int a, int b)
        {
            long answer = 0;

            long start = a;
            long end = b;

            if (a > b)
            {
                start = b;
                end = a;
            }

            for (long i = start; i < end + 1; i++)
                answer += i;

            return answer;
        }
    }
}
