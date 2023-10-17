using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.카카오_채용연계형_인턴십
{
    internal class 숫자_문자열과_영단어
    {
        public int solution(string s)
        {
            s = s.Replace("zero", "0");
            s = s.Replace("one", "1");
            s = s.Replace("two", "2");
            s = s.Replace("three", "3");
            s = s.Replace("four", "4");
            s = s.Replace("five", "5");
            s = s.Replace("six", "6");
            s = s.Replace("seven", "7");
            s = s.Replace("eight", "8");
            s = s.Replace("nine", "9");

            return int.Parse(s);
        }
    }
}
