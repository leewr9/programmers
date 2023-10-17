using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 콜라츠_추측
    {
        public int solution(int num)
        {
            int answer = 0;

            long result = num;
            while (result != 1)
            {
                if (result % 2 == 0)
                    result = result / 2;
                else
                    result = (result * 3) + 1;

                answer++;

                if (answer > 500)
                    return -1;
            }

            return answer;
        }
    }
}
