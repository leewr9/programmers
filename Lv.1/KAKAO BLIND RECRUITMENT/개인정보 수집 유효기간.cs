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
            Dictionary<string, int> termDays = new Dictionary<string, int>();
            List<int> answer = new List<int>();

            DateTime date = DateTime.Parse(today);

            int month = 28;
            int year = month * 12;
            int day = (date.Year * year) + (date.Month * month) + date.Day;

            for (int i = 0; i < terms.Length; i++)
            {
                string[] days = terms[i].Split(' ');
                termDays.Add(days[0], int.Parse(days[1]) * month);
            }

            for (int i = 0; i < privacies.Length; i++)
            {
                string[] privacie = privacies[i].Split(' ');
                string[] days = privacie[0].Split('.');

                int parseDay = (int.Parse(days[0]) * year) + (int.Parse(days[1]) * month) + int.Parse(days[2]) + termDays[privacie[1]];

                if (parseDay <= day)
                    answer.Add(i + 1);
            }

            return answer.ToArray();
        }
    }
}
