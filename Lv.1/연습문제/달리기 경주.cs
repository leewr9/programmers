using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 달리기_경주
    {
        public string[] solution(string[] players, string[] callings)
        {
            string[] answer = new string[players.Length];

            Dictionary<string, int> playerIndex = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++)
            {
                answer[i] = players[i];
                playerIndex.Add(players[i], i);
            }

            for (int i = 0; i < callings.Length; i++)
            {
                int index = playerIndex[callings[i]];

                if (index > 0)
                {
                    playerIndex[callings[i]]--;

                    string player = answer[index - 1];
                    answer[index - 1] = answer[index];
                    answer[index] = player;

                    playerIndex[player]++;
                }
            }

            return answer;
        }
    }
}
