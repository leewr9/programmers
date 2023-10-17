using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 가운데_글자_가져오기
    {
        public string solution(string s)
        {
            string answer = "";

            if (s.Length % 2 == 0)
                answer = s.Substring(s.Length / 2 - 1, 2);
            else
                answer = s.Substring(s.Length / 2, 1);

            return answer;
        }
    }
}
