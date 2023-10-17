using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 명예의_전당
    {
        public int[] solution(int k, int[] score)
        {
            int[] answer = new int[score.Length];
            int[] owner = new int[k];

            for (int i = 0; i < owner.Length; i++)
            {
                owner[i] = -1;
            }
            
            for (int i = 0; i < score.Length; i++)
            {
                for (int j = 0; j < owner.Length; j++)
                {
                    if (owner[j] > score[i])
                        continue;

                    int down = owner[j];
                    owner[j] = score[i];

                    int next = j + 1;
                    while (next < owner.Length)
                    {
                        if (owner[next] > down)
                        {
                            next++;
                            continue;
                        }

                        int keep = owner[next];
                        owner[next++] = down;
                        down = keep;
                    }
                    break;
                }

                for (int j = owner.Length - 1; j > -1; j--)
                {
                    if (owner[j] != -1)
                    {
                        answer[i] = owner[j];
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
