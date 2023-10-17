using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 푸드_파이트_대회
    {
        public string solution(int[] food)
        {
            string answer = "";
            string[] count = new string[food.Length];

            for(int i = 1; i < food.Length; i++)
            {
                for (int j = 0; j < (food[i] / 2); j++)
                {
                    count[i] += i.ToString();
                }
            }

            for (int i = 1; i < count.Length; i++)
            {
                if (!string.IsNullOrEmpty(count[i]))
                    answer += count[i];
            }

            answer += "0";

            for (int i = count.Length - 1; i > -1; i--)
            {
                if (!string.IsNullOrEmpty(count[i]))
                    answer += count[i];
            }
            Console.WriteLine(answer);
            return answer;
        }
    }
}
