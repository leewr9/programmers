using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.스택_큐
{
    internal class 기능개발
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            int[] finish = new int[progresses.Length];
            int day = 0;

            while (true)
            {
                for (int i = 0; i < progresses.Length; i++)
                {
                    if (progresses[i] > -1)
                        progresses[i] += speeds[i];
                }

                int count = 0;
                for (int i = 0; i < progresses.Length; i++)
                {
                    if (progresses[i] >= 100)
                    {
                        progresses[i] = -1;
                        count++;
                    }
                    else if(progresses[i] != -1)
                        break;
                }

                if (count > 0)
                    finish[day++] = count;

                count = -1;
                for (int i = 0; i < progresses.Length; i++)
                {
                    if (progresses[i] > -1)
                    {
                        count = 0;
                        break;
                    }
                }

                if (count == -1)
                    break;
            }

            int[] answer = new int[day];

            for (int i = 0; i < answer.Length; i++)
                answer[i] = finish[i];

            return answer;
        }
    }
}
