using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace SimpleGame
{
    public partial class Form1 : Form
    {
        Image Player;
        Image Mario;
        Image Tube;        
        int MarioPosition;
        int GubkaBobPosition = 200;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Player = Resource1.Player;
            Mario = Resource1.Mario;
            Tube = Resource1.MarioTube;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Red, 10);
            //g.DrawLine(pen, 0, 0, 150, 150);
            //g.DrawImage(Player, 100, 100);
            Graphics g = e.Graphics;            
            //g.DrawImage(Player, new Rectangle(0, 0, 100, 100));
            g.DrawImage(Mario, new Rectangle(13, MarioPosition, 100, 100));
            g.DrawImage(Tube, new Rectangle(10, 150, 120, 120));
            g.DrawImage(Player, new Rectangle(GubkaBobPosition, 0, 120, 120));
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MarioPosition += 1;
            Invalidate();
            Refresh();
            if (MarioPosition > 150)
            {
                timerMario.Stop();
            }
            if (MarioPosition > 50)
            {
                PlaySoundTube();
            }
        }

        private void timerBob_Tick(object sender, EventArgs e)
        {
            if (GubkaBobPosition > 0)
            {
                GubkaBobPosition -= 1;
                Invalidate();
                Refresh();
                
            }
            else  timerBob.Enabled = false;
        }

        private void PlaySoundTube()
        {
            SoundPlayer soundTube = new SoundPlayer(Resource1.TubeSound);
            soundTube.Play();           
            //soundTube.Stop();
        }

        
    }
}
