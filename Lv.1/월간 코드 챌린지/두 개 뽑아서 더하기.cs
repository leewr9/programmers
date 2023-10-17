using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.월간_코드_챌린지
{
    internal class 두_개_뽑아서_더하기
    {
        public int[] solution(int[] numbers)
        {
            int[] result = new int[200];
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    result[numbers[i] + numbers[j]]++;
                    if (result[numbers[i] + numbers[j]] == 1)
                        count++;
                }
            }

            int[] answer = new int[count];
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > 0)
                    answer[answer.Length - count--] = i;
            }

            return answer;
        }
    }
}
