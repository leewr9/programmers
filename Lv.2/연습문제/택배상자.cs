using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 택배상자
    {
        public int solution(int[] order)
        {
            int answer = 0;

            int index = 0;
            int main = 1;
            int sub = 0;

            int[] subs = new int[order.Length];

            while (sub < order.Length && index < order.Length)
            {
                bool add = false;
                if (order[index] == main)
                {
                    index++;
                    answer++;
                }
                else if(sub > 0 && order[index] == subs[sub - 1])
                {
                    add = true;
                    index++;
                    answer++;

                    sub--;
                    subs[sub] = 0;
                }
                else 
                    subs[sub++] = main;

                if (!add)
                {
                    if (main < order.Length && main > 0)
                        main++;
                    else
                        main = 0;
                }
            }

            return answer;
        }
    }
}
