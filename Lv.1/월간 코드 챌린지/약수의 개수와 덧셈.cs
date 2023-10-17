using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.월간_코드_챌린지
{
    internal class 약수의_개수와_덧셈
    {
        public int solution(int left, int right)
        {
            int answer = 0;

            for(int i = left; i < right + 1; i++)
            {
                int count = 0;
                for (int j = 1; j < i + 1; j++)
                {
                    if (i % j == 0)
                        count++;
                }

                if (count % 2 == 0)
                    answer += i;
                else
                    answer -= i;
            }

            return answer;
        }
    }
}
