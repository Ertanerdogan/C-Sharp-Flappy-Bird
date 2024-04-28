using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yercekim = 3;
        int hiz = 10;
        int skor = 0;
        int sayac = 0;
        bool oyunbitti = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(oyunbitti == false)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (sayac == 0)
                    {
                        label1.Text = "SKOR : " + skor;
                        timer1.Start();
                    }
                    bird.Top -= 40;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "SKOR : " + skor;
            bird.Top += yercekim;
            boru_alt.Left -= hiz;
            boru_ust.Left -= hiz;
            if(boru_alt.Left <= -150)
            {
                alt();
                buyukluk_alt();
                skor += 5;
            }
            if (boru_ust.Left <= -150)
            {
                ust();
                buyukluk_ust();
                skor += 5;
            }
            if(bird.Bounds.IntersectsWith(zemin.Bounds) || bird.Bounds.IntersectsWith(boru_alt.Bounds)
                || bird.Bounds.IntersectsWith(boru_ust.Bounds) || bird.Location.Y <= 0) 
            {
                timer1.Stop();
                oyunbitti = true;
                MessageBox.Show("Oyun Bitti !\nSkorunuz :" + skor);
            }
        }

       private void alt()
        {
            Random rand =new Random();
            int a = rand.Next(800, 1400);
            boru_alt.Left = a;
        }

        private void ust()
        {
            Random rand = new Random();
            int a = rand.Next(800, 1400);
            boru_ust.Left = a;
        }

        private void buyukluk_alt()
        {
            Random rand = new Random();
            int buyuk = rand.Next(100, 200);
            int x = boru_alt.Size.Width;
            int x1 = boru_alt.Location.X;
            boru_alt.Size = new Size(x, buyuk);
            if(buyuk >=180)
            {
                boru_alt.Location = new Point(x1, 270 - (buyuk - 180) - 34);
            }
            else
            {
                boru_alt.Location = new Point(x1, 270 + (180 - buyuk) - 34);
            }
        }

        private void buyukluk_ust()
        {
            Random rand = new Random();
            int buyuk = rand.Next(100, 200);
            int x = boru_ust.Size.Width;
            int x1 = boru_ust.Location.X;
            boru_ust.Size = new Size(x, buyuk);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Başlamak için lütfen SPACE ' e basınız";
            timer1.Stop();
        }

    }
}
