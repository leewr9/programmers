using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 달리기_경주
    {
        public string[] solution(string[] players, string[] callings)
        {
            string[] answer = new string[] { };

            Dictionary<string, int> playerIndex = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++)
            {
                playerIndex.Add(players[i], i);
            }

            for (int i = 0; i < callings.Length; i++)
            {
                int index = playerIndex[callings[i]];

                if (index > 0)
                {
                    playerIndex[callings[i]]--;

                    string player = players[index - 1];
                    players[index - 1] = players[index];
                    players[index] = player;

                    playerIndex[player]++;
                }
            }

            return answer;
        }
    }
}
