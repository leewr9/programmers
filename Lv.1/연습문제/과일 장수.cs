using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 과일_장수
    {
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;

            int[] apple = new int[k + 1];
            for (int i = 0; i < score.Length; i++)
            {
                apple[score[i]]++;
            }

            int count = score.Length - (score.Length % m);
            int box = m;

            for (int i = apple.Length - 1; i > -1; i--)
            {
                while (apple[i] > 0)
                {
                    count--;
                    box--;

                    apple[i]--;

                    if (box == 0)
                    {
                        answer += i * m;
                        box = m;
                    }
                }

                if (count == 0)
                    break;
            }

            return answer;
        }
    }
}
