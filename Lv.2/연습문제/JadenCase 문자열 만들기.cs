using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class JadenCase_문자열_만들기
    {
        public string solution(string s)
        {
            string answer = "";

            bool empty = true;
            s = s.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                if (empty)
                    answer += (char)(s[i] - 32);
                else
                    answer += s[i];

                empty = s[i] == ' ';
            }

            return answer;
        }
    }
}
