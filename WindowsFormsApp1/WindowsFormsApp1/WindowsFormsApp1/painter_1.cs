using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class painter_1 : Form
    {
        public painter_1()
        {
            InitializeComponent();
        }




        int opacity = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox1.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox1.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void Era_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();

            Search Search = new Search();
            Search.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox2.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox2.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox3.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox3.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox4.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox4.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox5.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox5.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox6.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox6.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox7.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox7.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox8.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox8.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox9.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox9.Image = img;
                opacity++;

            }
            else
                timer1.Stop();
        }



        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            timer9.Start();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            timer8.Start();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            timer7.Start();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox1.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox1.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }
    

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox2.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox2.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }

    

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox3.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox3.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox4.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox4.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }

        private void timer5_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox5.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox5.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }

        private void timer6_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox6.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox6.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }

        private void timer7_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox7.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox7.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }

        private void timer8_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox8.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox8.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }

        private void timer9_Tick_1(object sender, EventArgs e)
        {
            if (opacity < 255)
            {
                Image img = pictureBox9.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                pictureBox9.Image = img;
                opacity += 5;

            }

            else
                opacity = 0;
        }
    }

}
