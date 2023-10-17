using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.월간_코드_챌린지
{
    internal class _3진법_뒤집기
    {
        public int solution(int n)
        {
            int answer = 0;

            string three = string.Empty;
            while (n > 0)
            {
                three = n % 3 + three;
                n = n / 3;
            }

            int start = 1;
            for (int i = 0; i < three.Length; i++)
            {
                answer += (three[i] - 48) * start;
                start *= 3;
            }

            return answer;
        }
    }
}
