using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 둘만의_암호
    {
        public string solution(string s, string skip, int index)
        {
            string answer = "";
            for (int i = 0; i < s.Length; i++)
            {
                int id = s[i];
                for (int j = 0; j < index; j++)
                {
                    id++;
                    if (id > 122)
                        id = 97;
                    if (skip.Contains((char)(id)))
                        j--;
                }
                answer += (char)id;
            }
            Console.WriteLine(answer);
            return answer;
        }
    }
}
