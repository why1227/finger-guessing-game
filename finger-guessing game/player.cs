using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finger_guessing_game
{
    public class player
    {
        //1.用来存储结果的属性
        public string FistName
        {
            get;
            set;
        }

        //2.出拳的方法
        //1表示剪刀
        //2表示石头
        //3表示布
        public int ShowFist(string fist)
        {
            int result = -1;
            this.FistName = fist;
            switch (fist)
            {
                case "剪刀":
                    result = 1;
                    break;
                case "石头":
                    result = 2;
                    break;
                case "布":
                    result = 3;
                    break;
            }
            return result;
        }
}
}
