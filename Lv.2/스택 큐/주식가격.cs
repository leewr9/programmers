using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.스택_큐
{
    internal class 주식가격
    {
        public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    answer[i]++;
                    if (prices[i] > prices[j])
                        break;
                }
            }
            return answer;
        }
    }
}
