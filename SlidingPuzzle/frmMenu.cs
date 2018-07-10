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
        public bool multiMoves = true;
        frmOptions formOptions;
        frmScore frmScore;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain(animationsActive, animationSpeed, keyMoves, multiMoves, this);
            form.bmpArray = bmpArray;
            form.size = size;
            form.animationsActive = animationsActive;
            form.Show();
            Hide();
            if(frmScore != null)
                frmScore.Hide();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            frmScore = new frmScore();
            frmScore.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            if(formOptions == null)
                formOptions = new frmOptions(this);
            formOptions.Show();
            Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOptions.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOptions.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnScore.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnScore.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOut.FlatAppearance.MouseOverBackColor = Color.Transparent;
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("../../Images/jugar-h.png");
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Image = Image.FromFile("../../Images/jugar.png");
        }

        private void btnOptions_MouseEnter(object sender, EventArgs e)
        {
            btnOptions.Image = Image.FromFile("../../Images/opciones-h.png");
        }

        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            btnOptions.Image = Image.FromFile("../../Images/opciones.png");
        }

        private void btnScore_MouseEnter(object sender, EventArgs e)
        {
            btnScore.Image = Image.FromFile("../../Images/highscores-h.png");
        }

        private void btnScore_MouseLeave(object sender, EventArgs e)
        {
            btnScore.Image = Image.FromFile("../../Images/highscores.png");
        }

        private void btnOut_MouseEnter(object sender, EventArgs e)
        {
            btnOut.Image = Image.FromFile("../../Images/out-big-h.png");
        }

        private void btnOut_MouseLeave(object sender, EventArgs e)
        {
            btnOut.Image = Image.FromFile("../../Images/out-big.png");
        }
    }
}
