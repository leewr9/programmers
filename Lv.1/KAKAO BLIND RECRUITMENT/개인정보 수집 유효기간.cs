using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.KAKAO_BLIND_RECRUITMENT
{
    internal class 개인정보_수집_유효기간
    {
        public int[] solution(string today, string[] terms, string[] privacies)
        {
            int[] record = new int[privacies.Length];
            int[] check = new int[26];

            DateTime date = DateTime.Parse(today);

            int month = 28;
            int year = month * 12;
            int day = (date.Year * year) + (date.Month * month) + date.Day;

            for (int i = 0; i < terms.Length; i++)
                check[terms[i][0] - 65] = int.Parse(terms[i].Split(' ')[1]) * month;

            int count = 0;
            for (int i = 0; i < privacies.Length; i++)
            {
                string[] privacie = privacies[i].Split(' ');
                string[] days = privacie[0].Split('.');

                int parseDay = (int.Parse(days[0]) * year) + (int.Parse(days[1]) * month) + int.Parse(days[2]) + check[privacie[1][0] - 65];

                if (parseDay <= day)
                {
                    record[i] = i + 1;
                    count++;
                }
            }

            int[] answer = new int[count];
            int index = 0;
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] > 0)
                    answer[index++] = record[i];
            }

            return answer;
        }
    }
}
