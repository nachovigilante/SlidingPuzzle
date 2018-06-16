using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public Bitmap[,] bmpArray;
        public int size = 3;
        public Bitmap imageToUse = new Bitmap(Properties.Resources.night);
        public bool animationsActive = true;
        public int animationSpeed = 30;
        public bool keyMoves = true;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain(animationsActive, animationSpeed, keyMoves);
            form.bmpArray = bmpArray;
            form.size = size;
            form.animationsActive = animationsActive;
            form.Show();
            Hide();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            frmScore form = new frmScore();
            form.Show();
            Hide();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions form = new frmOptions(this);
            form.Show();
            Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            bmpArray = new Bitmap[size, size];
            Bitmap resizedImage = new Bitmap(imageToUse, new Size(300, 300));
            bmpArray = new Bitmap[size, size];
            int tileSize = (int)Math.Floor((float)resizedImage.Width / size);
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Rectangle cloneRect = new Rectangle(tileSize * x, tileSize * y, tileSize, tileSize);
                    System.Drawing.Imaging.PixelFormat format = resizedImage.PixelFormat;
                    Bitmap tile = resizedImage.Clone(cloneRect, format);
                    bmpArray[x, y] = tile;
                }
            }
        }
    }
}
