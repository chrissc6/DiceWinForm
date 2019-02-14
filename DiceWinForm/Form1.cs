using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        Random rng2 = new Random();
        int roll = 0;
        int wins = 0;
        int loses = 0;
        int game = 0;
        int point = 0;
        int croll = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            roll = 0;

            if (point != 0)
            {
                croll++;
                label4RollNbr.Text = croll.ToString();
                Roll2();
            }
            else
            {
                croll++;
                label4RollNbr.Text = croll.ToString();
                Roll1();
            }
            
            

        }


        private void Roll1()
        {
            game++;
            label2Game.Text = game.ToString();

            roll = rng.Next(1, 7) + rng2.Next(1, 7);
            label8Roll.Text = roll.ToString();

            if(roll == 7 || roll == 11)
            {
                Win();
            }
            else if(roll == 2 || roll == 3 || roll == 12)
            {
                Lose();
            }
            else
            {
                point = roll;
                label10Point.Text = point.ToString();
            }
        }

        private void Roll2()
        {
            roll = rng.Next(1, 7) + rng2.Next(1, 7);
            label8Roll.Text = roll.ToString();

            if(roll == 7)
            {
                Lose();
            }
            else if(roll == point)
            {
                Win();
            }
            else
            {
                return;
            }
        }

        private void Win()
        {
            wins++;
            label4Wins.Text = wins.ToString();
            point = 0;
            croll = 0;
            label10Point.Text = "";
            label4RollNbr.Text = "";
        }

        private void Lose()
        {
            loses++;
            label6Loses.Text = loses.ToString();
            point = 0;
            croll = 0;
            label10Point.Text = "";
            label4RollNbr.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roll = 0;
            wins = 0;
            loses = 0;
            game = 0;
            point = 0;
            croll = 0;
            label2Game.Text = "";
            label4Wins.Text = "";
            label6Loses.Text = "";
            label8Roll.Text = "";
            label10Point.Text = "";
            label4RollNbr.Text = "";
        }
    }
}
