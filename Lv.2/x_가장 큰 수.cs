using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.정렬
{
    internal class 가장_큰_수
    {
        public string solution(int[] numbers)
        {
            string answer = "";

            string[] num = new string[numbers.Length];

            Array.Sort(numbers);

            Console.WriteLine(string.Join(",", numbers));
            for (int i = 0; i < numbers.Length; i++)
            {
                string s = numbers[i].ToString();

                num[i] = s.PadRight(6, s[0]);   
            }

            Console.WriteLine(string.Join(",", num));
            Array.Sort(num);

            Console.WriteLine(string.Join(",", num));

            for (int i = num.Length - 1; i > -1; i--)
                answer += num[i];

            // 999 9966 9911 9973 9989 9999
        
            Console.WriteLine(answer);
            // 1 3 8 87 88 9 90 93
            // 993908888731
            //899 89 9
            //99 9
            return answer;
        }
    }
}
