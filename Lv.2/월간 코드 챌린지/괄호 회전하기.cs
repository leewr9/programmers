using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.월간_코드_챌린지
{
    internal class 괄호_회전하기
    {
        public int solution(string s)
        {
            int answer = 0;

            int count = s.Length;
            int start = 0;
            while (count-- > 0)
            {
                string find = s.Substring(start, s.Length - start) + s.Substring(0, start);
                int length = find.Length;
                int change = 0;

                while (change != length) 
                {
                    length = find.Length;
                    find = find.Replace("[]", "");
                    find = find.Replace("{}", "");
                    find = find.Replace("()", "");
                    change = find.Length;
                }

                if (find.Length == 0)
                    answer++;

                start++;
            }

            return answer;
        }
    }
}
