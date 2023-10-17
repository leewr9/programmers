using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 카드_뭉치
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "Yes";

            int[] index = { cards1.Length, cards2.Length };

            for (int i = 0; i < goal.Length; i++)
            {
                if (index[0] > 0 && goal[i] == cards1[cards1.Length - index[0]])
                {
                    goal[i] = string.Empty;
                    index[0]--;
                }

                if (index[1] > 0 && goal[i] == cards2[cards2.Length - index[1]])
                {
                    goal[i] = string.Empty;
                    index[1]--;
                }

                if (!string.IsNullOrEmpty(goal[i]))
                {
                    answer = "No";
                    break;
                }
            }

            return answer;
        }
    }
}
