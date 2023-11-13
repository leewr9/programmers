using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.탐욕법
{
    internal class 큰_수_만들기
    {
        public string solution(string number, int k)
        {
            string answer = "";

            string[] numbers = new string[number.Length];
            int[] index = new int[numbers.Length];

            for (int i = 0; i < index.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (string.IsNullOrEmpty(numbers[j]))
                        numbers[j] = number[j].ToString();

                    if (max <= int.Parse(numbers[j]))
                    {
                        max = int.Parse(numbers[j]);
                        index[i] = j;
                    }
                }

                numbers[index[i]] = "-1";
            }

            for (int i = 0; i < index.Length; i++)
                numbers[index[i]] = i.ToString();

            Console.WriteLine(number);
            Console.WriteLine(string.Join(",", numbers));
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i].ToString(), out int result) && result < (number.Length / 2))
                {
                    answer += number[i];
                    numbers[i] = "";
                }

                Console.WriteLine(i + " = " + answer);
            }

            Console.WriteLine(answer);

            return answer;
        }
    }
}
