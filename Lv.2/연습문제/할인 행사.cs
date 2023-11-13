using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 할인_행사
    {
        public int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;
            int start = 0;

            while (start < discount.Length - 9) 
            {
                int[] check = new int[number.Length];
                bool dc = true;

                for(int i = 0; i < number.Length; i++)
                    check[i] = number[i];

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < want.Length; j++)
                    {
                        if (discount[start + i] == want[j])
                        {
                            check[j]--;
                            break;
                        }
                    }
                }

                for (int i = 0; i < check.Length; i++)
                {
                    if (check[i] > 0)
                    {
                        dc = false; 
                        break;
                    }
                }

                if (dc)
                    answer++;

                start++;
            }
            

            return answer;
        }
    }
}
