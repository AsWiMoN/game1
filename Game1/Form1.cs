using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        int[] _map = { 1, 1, 1, 2, 2, 1, 1, 1};

        Image _groundBlock = Resource1.Ground1;
        Image _sandBlock = Resource1.Ground2;

        const int blockWidth = 80, blockHeight = 80;
        int viewX = 0;
        public Form1()
        {
            InitializeComponent();
            //DoubleBuffered = true;
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            _map = new int[25];
            Random random = new Random();
            for (int i = 0; i < _map.Length; i++)
            {
                _map[i] = random.Next(1, 3);
            }
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mainLoopTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.D)
            {
                viewX += 1;
            }
            else if (e.KeyCode==Keys.A)
            {
                viewX -= 1;
            }
        }

      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; ;

            for (int i = 0; i < _map.Length; i++)
            {
                Image currentImage = null;

                if (_map[i] == 1)
                {
                    currentImage = _groundBlock;
                }
                else if (_map[i] == 2)
                {
                    currentImage = _sandBlock;
                }

                g.DrawImage(currentImage, new Rectangle((i * blockWidth) - viewX, 520, blockWidth, blockHeight));
            }
        }
    }
}
