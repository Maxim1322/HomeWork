using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        int Score;
        bool click;
        public Form1()
        {
            InitializeComponent();
            Score = 0;
            click = false;
        }
        

        private void csgo2_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                csgo2.Left = csgo2.Left + e.X - csgo2.Width / 2; ;
                csgo2.Top = csgo2.Top + e.Y - csgo2.Height / 2; ;
                bool x1 = csgo2.Left > BigBox2.Left;
                bool x2 = csgo2.Top > BigBox2.Top;
                bool x3 = csgo2.Left < BigBox2.Left + BigBox2.Width - csgo2.Width;
                bool x4 = csgo2.Top < BigBox2.Top + BigBox2.Height - csgo2.Height;
                if (x1 && x2 && x3 && x4)
                {
                    csgo2.Left = BigBox2.Left + BigBox2.Width / 2 - csgo2.Width / 2;
                    csgo2.Top = BigBox2.Top + BigBox2.Height / 2 - csgo2.Height / 2;
                    csgo2.Enabled = false;
                    Score++;
                    label4.Text = "Score=" + Score;
                }
            }
        }
        private void csgo2_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
        }

        private void csgo2_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void civi_vi_3_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                civi_vi_3.Left = civi_vi_3.Left + e.X - civi_vi_3.Width / 2; ;
                civi_vi_3.Top = civi_vi_3.Top + e.Y - civi_vi_3.Height / 2; ;
                bool x1 = civi_vi_3.Left > BigBox3.Left;
                bool x2 = civi_vi_3.Top > BigBox3.Top;
                bool x3 = civi_vi_3.Left < BigBox3.Left + BigBox3.Width - civi_vi_3.Width;
                bool x4 = civi_vi_3.Top < BigBox3.Top + BigBox3.Height - civi_vi_3.Height;
                if (x1 && x2 && x3 && x4)
                {
                    civi_vi_3.Left = BigBox3.Left + BigBox3.Width / 2 - civi_vi_3.Width / 2;
                    civi_vi_3.Top = BigBox3.Top + BigBox3.Height / 2 - civi_vi_3.Height / 2;
                    civi_vi_3.Enabled = false;
                    Score++;
                    label4.Text = "Score=" + Score;
                }
            }

        }

        private void civi_vi_3_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
        }

        private void civi_vi_3_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void fifa_20_1_MouseMove(object sender, MouseEventArgs e)
        {
            fifa_20_1.Left = fifa_20_1.Left + e.X - fifa_20_1.Width / 2; ;
            fifa_20_1.Top = fifa_20_1.Top + e.Y - fifa_20_1.Height / 2; ;
            bool x1 = fifa_20_1.Left > BigBox1.Left;
            bool x2 = fifa_20_1.Top > BigBox1.Top;
            bool x3 = fifa_20_1.Left < BigBox1.Left + BigBox1.Width - fifa_20_1.Width;
            bool x4 = fifa_20_1.Top < BigBox1.Top + BigBox1.Height - fifa_20_1.Height;
            if (x1 && x2 && x3 && x4)
            {
                fifa_20_1.Left = BigBox1.Left + BigBox1.Width / 2 - fifa_20_1.Width / 2;
                fifa_20_1.Top = BigBox1.Top + BigBox1.Height / 2 - fifa_20_1.Height / 2;
                fifa_20_1.Enabled = false;
                Score++;
                label4.Text = "Score=" + Score;
            }
        
        }

        private void fifa_20_1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
        }

        private void fifa_20_1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }
    }
}
