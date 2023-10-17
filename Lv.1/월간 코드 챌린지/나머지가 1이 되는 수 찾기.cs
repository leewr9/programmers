using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.월간_코드_챌린지
{
    internal class 나머지가_1이_되는_수_찾기
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }
            }

            return answer;
        }
    }
}
