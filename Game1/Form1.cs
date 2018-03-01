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
        int[,] _map = new int [50,50];

        Image _groundBlock = Resource1.Ground1;
        Image _sandBlock = Resource1.Ground2;

        const int blockWidth = 80, blockHeight = 80;
        int viewX = 0;
        int viewY = 0;
        int currentPlacedBlock = 0;
        
        public Form1()
        {
            InitializeComponent();
            //DoubleBuffered = true;
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            GenerateWorld();
        }

        private void GenerateWorld()
        {
            Random r = new Random();
            int direction = 1;
            int y = 40;

            for (int x = 0; x < _map.GetLength(0); x++)
            {
                y += direction;
                direction = r.Next(-1, 2);
                for (int _y = y; _y < _map.GetLength(1); _y++)
                {
                    _map[x, _y] = 1;
                }

            }
        }

        private int Clamp (int value, int max, int min)
        {
            if (value > max)
            {
                return max;
            }
            else if (value > min)
            {
                return min;
            }
            return value;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mainLoopTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = PointToClient(Cursor.Position);
            MoveCamera(cursor);
            

           

            Invalidate();
            Refresh();
        }



        private void MoveCamera(Point cursor)
        {
            cursor = PointToClient(Cursor.Position);

            float borderWidth = 50;
            float minSpeed = -10;
            float maxSpeed = 10;
            float speed = 0;
            float deep = 0; //0...50           

            if (cursor.X > 750)
            {
                deep = 50 - (800 - cursor.X);
                
            }
            else if (cursor.X < 50)
            {
                deep = -50 + cursor.X;
            }
            else if (cursor.Y > 550)
            {
                deep = 50 - (600 - cursor.Y);
                
            }
            else if (cursor.Y < 50)
            {
                deep = -50 + cursor.Y;
            }
            deep = Clamp((int)deep, -50, 50);
            speed = 10 * (deep / borderWidth);
            viewX += (int)speed;
            viewY -= (int)speed;
            viewX = Clamp(viewX, 0, _map.GetLength(0) * blockWidth - 800);
            viewX = Clamp(viewY, 0, _map.GetLength(1) * blockWidth - 600);
            log.Text = cursor.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.D)
            {
                viewX += 5;
            }
            else if (e.KeyCode==Keys.A)
            {
                viewX -= 5;
            }
            else if (e.KeyCode==Keys.W)
            {
                viewY += 5;
            }
            else if (e.KeyCode==Keys.S)
            {
                viewY -= 5;
            }

        }

      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    int blockType = _map[x, y];
                    Rectangle rectangle = new Rectangle((x * blockWidth) - viewX, (y * blockHeight) - viewY, blockWidth, blockHeight);
                    DrawBlock(rectangle, blockType, g);
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Point cursor = PointToClient(Cursor.Position);

            if (cursor.X < 0 || cursor.Y < 0 || cursor.X > 800 || cursor.Y > 600)
            {
                return;
            }

            int mousePositionX, mousePositionY;

            mousePositionX = (cursor.X + viewX) / blockWidth;
            mousePositionY = (cursor.Y + viewY) / blockHeight;

            _map[mousePositionX, mousePositionY] = currentPlacedBlock;
        }

        private void CurrentPlacedBlock(object sender, EventArgs e)
        {            
            Button button = (Button)sender;
            string groundButton = button.Tag.ToString();
            if (groundButton == "ground")
            {
                currentPlacedBlock = 1;
            }
            else if (groundButton == "sand")
            {
                currentPlacedBlock = 2;
            }
            else if (groundButton == "empty")
            {
                currentPlacedBlock = 0;
            }
            
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateWorld();
        }

        private void DrawBlock(Rectangle rectangle, int blockType, Graphics g)
        {
            Image currentImage = null;

            if (blockType == 1)
            {
                currentImage = _groundBlock;
            }
            else if (blockType == 2)
            {
                currentImage = _sandBlock;
            }

            if (currentImage==null)
            {
                return;
            }

            g.DrawImage(currentImage, rectangle);
        }

        private void SaveWorld()
        {

        }

        private void LoadWorld()
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveWorld();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadWorld();
        }

        
    }
}
