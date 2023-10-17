using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 문자열_다루기_기본
    {
        public bool solution(string s)
        {
            bool answer = int.TryParse(s, out _);
            
            return answer && s.Length == 4 || answer && s.Length == 6;
        }
    }
}
