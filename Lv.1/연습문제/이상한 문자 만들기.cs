using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 이상한_문자_만들기
    {
        public string solution(string s)
        {
            string answer = "";

            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    answer += s[i];
                    count = 0;
                }
                else if (count++ % 2 == 0)
                    answer += s[i].ToString().ToUpper();
                else
                    answer += s[i].ToString().ToLower();
            }

            return answer;
        }
    }
}
