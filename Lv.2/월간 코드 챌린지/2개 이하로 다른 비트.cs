using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.월간_코드_챌린지
{
    internal class _2개_이하로_다른_비트
    {
        public long[] solution(long[] numbers)
        {
            long[] answer = new long[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                char[] number = Convert.ToString(numbers[i], 2).ToCharArray();
                for (int j = number.Length - 1; j > -1; j--)
                {
                    if (number[j] == '0')
                    {
                        number[j] = '1';
                        if (j < number.Length - 1)
                            number[j + 1] = '0';
                        break;
                    }

                    if (j == 0)
                        number[0] = '0';
                }

                string convert = string.Join("", number);
                if (number[0] == '0')
                    convert = "1" + convert;

                answer[i] = Convert.ToInt64(convert, 2);
            }

            return answer;
        }
    }
}
