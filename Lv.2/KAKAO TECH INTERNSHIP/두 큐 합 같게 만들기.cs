using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.KAKAO_TECH_INTERNSHIP
{
    internal class 두_큐_합_같게_만들기
    {
        public int solution(int[] queue1, int[] queue2)
        {
            int answer = 0;

            long q1 = 0;
            long q2 = 0;
            for (int i = 0; i < queue1.Length; i++)
                q1 += queue1[i];
            for (int i = 0; i < queue2.Length; i++)
                q2 += queue2[i];

            long sum = q1 + q2;

            int i1 = 0;
            int i2 = 0;

            while (q1 != (sum / 2) && q1 != 0 && q2 != 0 && i1 < queue1.Length * 2 && i2 < queue2.Length * 2)
            {
                if (q1 < sum / 2)
                {
                    for (int i = i1++; i < queue2.Length; i++)
                    {
                        q1 += queue2[i];
                        q2 -= queue2[i];

                        answer++;
                        break;
                    }

                    if (i1 > queue2.Length - 1)
                    {
                        for (int i = i1 - queue1.Length; i < queue1.Length; i++)
                        {
                            q1 += queue1[i];
                            q2 -= queue1[i];

                            answer++;
                            break;
                        }
                    }
                }

                if (q2 < sum / 2)
                {
                    for (int i = i2++; i < queue1.Length; i++)
                    {
                        if (queue1[i] != 0)
                        {
                            q2 += queue1[i];
                            q1 -= queue1[i];

                            answer++;
                            break;
                        }
                    }

                    if (i2 > queue1.Length - 1)
                    {
                        for (int i = i2 - queue2.Length; i < queue2.Length; i++)
                        {
                            q2 += queue2[i];
                            q1 -= queue2[i];

                            answer++;
                            break;
                        }
                    }
                }
            }

            if (q1 == 0 || q2 == 0 || i1 + 1 > queue1.Length * 2 || i2 + 1 > queue2.Length * 2)
                return -1;

            return answer;
        }
    }
}
