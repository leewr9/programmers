using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 멀리_뛰기
    {
        public long solution(int n)
        {
            long answer = 1;
            long start = 1;

            while (n-- > 1)
            {
                long before = answer;
                answer += (start % 1234567);
                start = (before % 1234567);
            }

            return answer % 1234567;
        }
    }
}
