using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 다음_큰_숫자
    {
        public int solution(int n)
        {
            int answer = 0;

            string convert = Convert.ToString(n, 2);
            int check = convert.Length - (convert.Replace("1", "").Length);

            for (int i = n + 1; n < 1000001; i++)
            {
                convert = Convert.ToString(i, 2);
                if (check == convert.Length - (convert.Replace("1", "").Length))
                {
                    answer = i;
                    break;
                }
            }

            return answer;
        }
    }
}
