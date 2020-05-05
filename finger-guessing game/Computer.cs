using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finger_guessing_game
{
    class Computer
    {
        //1.用来存储结果的属性
        public string FistName
        {
            get;
            set;
        }

        //2.计算机的出拳的方法
        public int ShowFist()
        {
            int result = -1;
            Random random = new Random();
            result = random.Next(1, 4);
            switch (result)
            {
                case 1:
                    this.FistName = "剪刀";
                    break;
                case 2:
                    this.FistName = "石头";
                    break;
                case 3:
                    this.FistName = "布";
                    break;
            }
            return result;
        }
    }
}
