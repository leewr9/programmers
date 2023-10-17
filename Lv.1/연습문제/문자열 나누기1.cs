using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 문자열_나누기1
    {
        public int solution(string s)
        {
            int answer = 0;

            int[] counts = new int[2];

            char start = s[0];
            int length = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (start == s[i])
                    counts[0]++;
                else
                    counts[1]++;

                if (counts[0] == counts[1])
                {
                    counts = new int[2];
                    if(i + 1 < s.Length)
                        start = s[i + 1];

                    answer++;
                    length = i + 1;
                }
            }

            if (length != s.Length)
                answer++;

            return answer;
        }
    }
}
