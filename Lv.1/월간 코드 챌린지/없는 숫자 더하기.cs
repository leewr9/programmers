using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.월간_코드_챌린지
{
    internal class 없는_숫자_더하기
    {
        public int solution(int[] numbers)
        {
            int answer = 0;

            for (int i = 0; i < 10; i++)
                answer += i;

            for (int i = 0; i < numbers.Length; i++) 
                answer -= numbers[i];

            return answer;
        }
    }
}
