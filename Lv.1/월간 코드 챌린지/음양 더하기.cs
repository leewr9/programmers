using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.월간_코드_챌린지
{
    internal class 음양_더하기
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for(int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i])
                    answer += absolutes[i];
                else
                    answer -= absolutes[i];
            }

            return answer;
        }
    }
}
