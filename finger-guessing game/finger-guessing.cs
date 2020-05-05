using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finger_guessing_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void start_game(string item)
        {
            player p1 = new player();
            int player_fist = p1.ShowFist(item);
            label_player.Text = p1.FistName;

            Computer c1 = new Computer();
            int computer_fist = c1.ShowFist();
            label_computer.Text = c1.FistName;

            judgment judgment = new judgment();
            label_result.Text = judgment.judge(player_fist, computer_fist);
        }

        //剪刀
        private void button_jiandao_Click(object sender, EventArgs e)
        {
            start_game("剪刀");
        }
        //石头
        private void button_shitou_Click(object sender, EventArgs e)
        {
            start_game("石头");
        }
        //布
        private void button_bu_Click(object sender, EventArgs e)
        {
            start_game("布");
        }

        //无论点击哪个都用这个（三个点击都用这个）
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            start_game(btn.Text);
        }
    }
}
