using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.KAKAO_BLIND_RECRUITMENT
{
    internal class 주차_요금_계산
    {
        public int[] solution(int[] fees, string[] records)
        {
            int[] cars = new int[10000];

            bool[] @in = new bool[10000];
            bool[] @out = new bool[10000];

            for (int i = 0; i < records.Length; i++)
            {
                string[] record = records[i].Split(' ');

                int hour = int.Parse(record[0].Split(':')[0]) * 60;
                int minute = int.Parse(record[0].Split(':')[1]);
                int car = int.Parse(record[1]);

                if (record[2] == "IN")
                {
                    @in[car] = true;
                    @out[car] = false;

                    if (cars[car] > 0)
                        cars[car] = (hour + minute) - cars[car];
                    else
                        cars[car] += (hour + minute);
                }
                else
                {
                    @out[car] = true;
                    cars[car] = (hour + minute) - cars[car];
                }
            }

            for (int i = 0; i < @in.Length; i++)
                if (@in[i] && !@out[i])
                    cars[i] = ((23 * 60) + 59) - cars[i];

            int count = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (@in[i])
                {
                    count++;

                    cars[i] = cars[i] - fees[0];
                    if (cars[i] > 0)
                    {
                        int m = cars[i] % fees[2];
                        cars[i] = cars[i] / fees[2];
                        if (m > 0)
                            cars[i]++;

                        cars[i] = fees[1] + (cars[i] * fees[3]);
                    }
                    else
                        cars[i] = fees[1];
                }
            }

            int[] answer = new int[count];
            int index = 0;

            for (int i = 0; i < cars.Length; i++)
                if (@in[i])
                    answer[index++] = cars[i];

            return answer;
        }
    }
}
