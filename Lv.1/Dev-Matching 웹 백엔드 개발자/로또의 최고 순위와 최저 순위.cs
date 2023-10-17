using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.Dev_Matching_웹_백엔드_개발자
{
    internal class 로또의_최고_순위와_최저_순위
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];

            int[] level = { 6, 6, 5, 4, 3, 2, 1 };

            int zero = 0;
            int count = 0;

            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                {
                    zero++;
                    continue;
                }

                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            answer[0] = level[zero + count];
            answer[1] = level[count];

            return answer;
        }
    }
}
