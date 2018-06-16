using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            form.bmpArray = bmpArray;
            form.size = size;
            form.Show();
            this.Hide();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            frmScore form = new frmScore();
            form.Show();
            this.Hide();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions form = new frmOptions(this);
            form.Show();
            this.Hide();
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
