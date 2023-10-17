using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 하샤드_수
    {
        public bool solution(int x)
        {
            bool answer = true;

            string s = x.ToString();
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
                sum += s[i] - 48;

            answer = x % sum == 0;

            return answer;
        }
    }
}
