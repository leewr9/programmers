using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 자릿수_더하기
    {
        public int solution(int n)
        {
            int answer = 0;
            string s = n.ToString();

            for (int i = 0; i < s.Length; i++)
                answer += s[i] - 48;

            return answer;
        }
    }
}
