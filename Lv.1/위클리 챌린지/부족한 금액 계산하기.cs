using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.위클리_챌린지
{
    internal class 부족한_금액_계산하기
    {
        public long solution(int price, int money, int count)
        {
            long answer = 0;
            for (int i = 1; i < count + 1; i++)
                answer += price * i;

            answer = answer - money;
            if (answer < 0) 
                answer = 0;

            return answer;
        }
    }
}
