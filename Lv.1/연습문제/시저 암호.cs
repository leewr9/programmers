using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 시저_암호
    {
        public string solution(string s, int n)
        {
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                int change = s[i] + n;

                if (s[i] >= 'a' && s[i] <= 'z' && change > 'z')
                    change = (change - 'z') + 'a' - 1;
                if (s[i] >= 'A' && s[i] <= 'Z' && change > 'Z')
                    change = (change - 'Z') + 'A' - 1;

                if (s[i] != ' ')
                    answer += (char)change;
                else
                    answer += s[i];
            }

            return answer;
        }
    }
}
