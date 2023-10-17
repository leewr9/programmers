using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.월간_코드_챌린지
{
    internal class 이진_변환_반복하기
    {
        public int[] solution(string s)
        {
            int[] answer = { 0 , 0 };

            while (s.Length > 1)
            {
                int remove = s.Length - s.Replace("0", "").Length;
                int count = s.Length - remove;

                answer[0]++;
                answer[1] += remove;

                s = "";
                while (count > 0)
                {
                    s = s + (count % 2);
                    count = count / 2;
                }
            }

            return answer;
        }
    }
}
