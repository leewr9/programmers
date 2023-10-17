using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.완전탐색
{
    internal class 카펫
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];

            int carpet = brown + yellow;
            for (int i = 3; i < carpet; i++)
            {
                if (carpet % i == 0)
                {
                    int y = (i + ((carpet / i) - 2)) * 2;

                    if (carpet - y == yellow)
                    {
                        answer[0] = (carpet / i);
                        answer[1] = i;
                        break;
                    }
                }
            }

            return answer;
        }
    }
}
