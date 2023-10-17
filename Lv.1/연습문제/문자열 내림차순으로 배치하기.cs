using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 문자열_내림차순으로_배치하기
    {
        public string solution(string s)
        {
            char[] chars = s.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                for(int j = 0; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        char next = chars[i];
                        chars[i] = chars[j];
                        chars[j] = next;
                    }
                }
            }

            string answer = string.Join("", chars);
            return answer;
        }
    }
}
