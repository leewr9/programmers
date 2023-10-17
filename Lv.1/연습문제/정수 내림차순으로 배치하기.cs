using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 정수_내림차순으로_배치하기
    {
        public long solution(long n)
        {
            string s = n.ToString();

            char[] chars = s.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                for(int j = 0; j < chars.Length; j++)
                {
                    if ((chars[i] - 48) > (chars[j] - 48))
                    {
                        char next = chars[i];
                        chars[i] = chars[j];
                        chars[j] = next;
                    }
                }
            }

            long answer = long.Parse(string.Join("", chars));

            return answer;
        }
    }
}
