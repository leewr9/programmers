using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 기사단원의_무기
    {
        public int solution(int number, int limit, int power)
        {
            int answer = 0;
            int[] weapon = new int[number];

            for (int i = 0; i < number; i++)
            {
                int max = 0;
                for (int j = 1; j < (i + 2); j++)
                {
                    if (j == max)
                    {
                        weapon[i] = weapon[i] * 2;
                        break;
                    }
                    else
                    {
                        int result = (i + 1) % j;
                        if (result == 0)
                        {
                            max = (i + 1) / j;
                            weapon[i]++;
                        }
                    }
                }

                if (weapon[i] > limit)
                    weapon[i] = power;

                answer += weapon[i];
            }

            return answer;
        }
    }
}
