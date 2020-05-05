using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finger_guessing_game
{
    class judgment
    {
        public string judge(int player_fist, int computer_fist)
        {
            if (player_fist == computer_fist)
            {
                return "棋逢对手";
            }
            else if (player_fist - computer_fist == -2 || player_fist - computer_fist == 1)
            {
                return "恭喜您获胜";
            }
            else
            {
                return "下次加油";
            }
        }
    }
}
