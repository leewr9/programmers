using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class _2016년
    {
        public string solution(int a, int b)
        {
            string answer = "FRI";

            int[] month = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] day = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };

            int count = b;
            for (int i = 0; i < a - 1; i++)
                count += month[i];

            int index = count % day.Length;
            if (index > 0)
                answer = day[index - 1];

            return answer;
        }
    }
}
