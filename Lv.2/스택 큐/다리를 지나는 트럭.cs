using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.스택_큐
{
    internal class 다리를_지나는_트럭
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 1;
            int count = 0;
            int index = 0;

            int bridge_weight = 0;

            int[] bridge = new int[truck_weights.Length];
            while (count < truck_weights.Length)
            {
                if (index < bridge.Length && weight >= bridge_weight + truck_weights[index])
                {
                    bridge[index] = bridge_length;
                    bridge_weight += truck_weights[index++];
                }

                for (int i = 0; i < bridge.Length; i++)
                {
                    if (bridge[i] > 0)
                    {
                        bridge[i]--;
                        if (bridge[i] == 0)
                        {
                            bridge[i] = -1;
                            bridge_weight -= truck_weights[i];
                        }
                    }

                    if (bridge[i] == -1)
                    {
                        count++;
                        bridge[i] = -2;
                    }
                }
                answer++;
            }

            return answer;
        }
    }
}

