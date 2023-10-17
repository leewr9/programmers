using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.KAKAO_TECH_INTERNSHIP
{
    internal class 성격_유형_검사하기
    {
        public string solution(string[] survey, int[] choices)
        {
            string answer = "";

            char[] types = { 'R', 'T', 'C', 'F', 'J', 'M', 'A', 'N' };
            int[] scores = new int[types.Length];

            for (int i = 0; i < survey.Length; i++)
            {
                int index = 0;
                if (choices[i] > 4)
                    index = 1;

                for (int n= 0; n < types.Length; n++)
                {
                    if (survey[i][index] == types[n])
                    {
                        index = n;
                        break;
                    }
                }

                scores[index] += Math.Abs(4 - choices[i]);
            }

            for (int i = 0; i < types.Length; i++)
            {
                int index = i;
                if (scores[i] < scores[i + 1])
                    index = i + 1;

                answer += types[index];
                i++;
            }

            return answer;
        }
    }
}
