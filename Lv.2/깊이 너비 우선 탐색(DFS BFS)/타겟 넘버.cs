using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.깊이_너비_우선_탐색_DFS_BFS_
{
    internal class 타겟_넘버
    {
        public int solution(int[] numbers, int target)
        {
            int answer = 0;

            number(numbers, 0, target, 0, ref answer);

            return answer;
        }

        public void number(int[] numbers, int index, int target, int count, ref int answer)
        {
            count++;

            if (index >= numbers.Length)
                index = 0;

            if (count > numbers.Length)
            {
                if (target == 0)
                    answer++;
                return;
            }

            number(numbers, index + 1, target + numbers[index], count, ref answer);
            number(numbers, index + 1, target - numbers[index], count, ref answer);
        }
    }
}
