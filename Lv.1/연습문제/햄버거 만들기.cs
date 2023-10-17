using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lv._1
{
    internal class 햄버거_만들기
    {
        public int solution(int[] ingredient)
        {
            int answer = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < ingredient.Length; i++)
            {
                sb.Append(ingredient[i]);

                if (sb.Length > 3)
                {
                    if (sb[sb.Length - 4] == '1' && sb[sb.Length - 3] == '2' && sb[sb.Length - 2] == '3' && sb[sb.Length - 1] == '1')
                    {
                        answer++;
                        sb.Remove(sb.Length - 4, 4);
                    }
                }
            }

            return answer;
        }
    }
}
