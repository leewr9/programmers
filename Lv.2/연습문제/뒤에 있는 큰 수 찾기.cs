using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 뒤에_있는_큰_수_찾기
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[numbers.Length];

            for (int i = numbers.Length - 1; i > -1; i--)
            {
                for (int j = i - 1; j > -1; j--)
                {
                    if (numbers[i] <= numbers[j])
                        break;

                        answer[j] = numbers[i];
                }
                if (answer[i] == 0)
                    answer[i] = -1;
            }

            return answer;
        }
    }
}
