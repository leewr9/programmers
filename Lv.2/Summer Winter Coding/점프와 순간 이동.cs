using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.Summer_Winter_Coding
{
    internal class 점프와_순간_이동
    {
        public int solution(int n)
        {
            int answer = 0;

            while (n > 0)
            {
                if (n % 2 == 0)
                    n = n / 2;
                else
                {
                    n--;
                    answer++;
                }
            }

            return answer;
        }
    }
}
