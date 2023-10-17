using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 최댓값과_최솟값
    {
        public string solution(string s)
        {
            string[] value = s.Split(' ');

            int min = int.Parse(value[0]);
            int max = int.Parse(value[0]);

            for (int i = 0; i < value.Length; i++)
            {
                if (int.Parse(value[i]) < min)
                    min = int.Parse(value[i]);

                if (int.Parse(value[i]) > max)
                    max = int.Parse(value[i]);
            }

            string answer = string.Format("{0} {1}", min, max);

            return answer;
        }
    }
}
