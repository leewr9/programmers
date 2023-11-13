using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 롤케이크_자르기
    {
        public int solution(int[] topping)
        {
            int answer = 0;

            int[][] count = new int[2][];
            count[0] = new int[10001];
            count[1] = new int[10001];

            for (int i = 0; i < topping.Length; i++)
            {
                if (count[0][topping[i]] == 0)
                    count[0][0]++;
                count[0][topping[i]]++;
            }

            for (int i = topping.Length - 1; i > -1; i--)
            {
                if (count[1][topping[i]] == 0)
                    count[1][0]++;
                count[1][topping[i]]++;

                if (count[0][topping[i]] > 0)
                    count[0][topping[i]]--;

                if (count[0][topping[i]] == 0)
                    count[0][0]--;

                if (count[1][0] == count[0][0])
                    answer++;
            }

            return answer;
        }
    }
}
