using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игор
{
    public partial class Form1 : Form
    {

        private стуб stub1;
        private стуб stub2;
        private стуб stub3;
        private стуб stub4;
        private стуб stub5;
        private стуб stub6;

        Random r = new Random();

        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int force = 20;

        int n = 1;

        int kreni = 0;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            stub1 = new стуб(0, 0, panel1.Width, panel1.Height, Color.Gainsboro, Color.Gainsboro);
            stub2 = new стуб(0, 0, panel2.Width, panel2.Height, Color.Gainsboro, Color.Gainsboro);
            stub3 = new стуб(0, 0, panel3.Width, panel3.Height, Color.Gainsboro, Color.Gainsboro);
            stub4 = new стуб(0, 0, panel4.Width, panel4.Height, Color.Gainsboro, Color.Gainsboro);
            stub5 = new стуб(0, 0, panel5.Width, panel5.Height, Color.Gainsboro, Color.Gainsboro);
            stub6 = new стуб(0, 0, panel6.Width, panel6.Height, Color.Gainsboro, Color.Gainsboro);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left = panel1.Left - 5*n;
            if (panel1.Left <= -panel1.Width)
            {
                panel1.Left = ClientRectangle.Width;
                panel1.Top = r.Next(200, 420);
            }

            panel2.Left = panel2.Left - 5*n;
            if (panel2.Left <= -panel2.Width)
            {
                panel2.Left = ClientRectangle.Width;
                panel2.Top = r.Next(200, 420);
            }

            panel3.Left = panel3.Left - 5*n;
            if (panel3.Left <= -panel3.Width)
            {
                panel3.Left = ClientRectangle.Width;
                panel3.Top = r.Next(200, 420);
            }

            panel4.Left = panel4.Left - 5*n;
            if (panel4.Left <= -panel4.Width)
            {
                panel4.Left = ClientRectangle.Width;
                panel4.Top = r.Next(200, 420);
            }

            panel5.Left = panel5.Left - 5*n;
            if (panel5.Left <= -panel5.Width)
            {
                panel5.Left = ClientRectangle.Width;
                panel5.Top = r.Next(200, 420);
            }

            panel6.Left = panel6.Left - 5*n;
            if (panel6.Left <= -panel6.Width)
            {
                panel6.Left = ClientRectangle.Width;
                panel6.Top = r.Next(200, 420);
            }

            дипси.Left = дипси.Left - 30*n;
            if (дипси.Left <= -дипси.Width)
            {
                дипси.Left = ClientRectangle.Width;
                дипси.Top = r.Next(200, 420);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            stub1.NacrtajSe(e.Graphics);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            stub2.NacrtajSe(e.Graphics);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            stub3.NacrtajSe(e.Graphics);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            stub4.NacrtajSe(e.Graphics);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            stub5.NacrtajSe(e.Graphics);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            stub6.NacrtajSe(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
                kreni++;
            }

            if(e.KeyCode == Keys.Down)
            {
                игор.Height = 35;
                игор.Width = 75;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }

            if(e.KeyCode == Keys.Down)
            {
                игор.Height = 70;
                игор.Width = 50;
            }
        }

        private void Sudaranje()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Panel && x.Tag.ToString() == "stub")
                {
                    if (игор.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        if (игор.Bottom > x.Top)
                        {
                            force = 8;
                            игор.Top = x.Top - игор.Height;
                        }
                    }
                }
            }

            if(игор.Left < 0 || игор.Bottom > ClientRectangle.Height || игор.Bounds.IntersectsWith(дипси.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("ИЗГУБИЛИ СТЕ!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            игор.Top += jumpSpeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (goleft)
            {
                игор.Left -= 5;
            }

            if (goright)
            {
                игор.Left += 5;
            }

            if (jumping)
            {
                jumpSpeed = -32;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if(kreni == 1)
            {
                timer1.Enabled = true;
                timer3.Enabled = true;
            }
            Sudaranje();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            n++;
            label2.Text = n.ToString() + "x"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
