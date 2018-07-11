using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        List<Player> pList = new List<Player>();
        Image image, arrup, arrdown, empty;
        List<Button> bList = new List<Button>();
        public int mode;

        private void frmScore_Load(object sender, EventArgs e)
        {
            string scoreFile = "";
            switch (mode) {
                case 3:
                    scoreFile = "../../scores3x3.txt";
                    lblTitle.Text = "HighScore 3x3";
                    break;
                case 4:
                    scoreFile = "../../scores4x4.txt";
                    lblTitle.Text = "HighScore 4x4";
                    break;
                case 5:
                    scoreFile = "../../scores5x5.txt";
                    lblTitle.Text = "HighScore 5x5";
                    break;
                default:
                    scoreFile = "../../scores3x3.txt";
                    lblTitle.Text = "HighScore 3x3";
                    break;
            }
            btnVolver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.Transparent;
            lblPrev.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lblPrev.FlatAppearance.MouseOverBackColor = Color.Transparent;
            lblNext.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lblNext.FlatAppearance.MouseOverBackColor = Color.Transparent;
            image = resizeImage(Image.FromFile("../../Images/empty.png"), 16, 10);
            arrup = resizeImage(Image.FromFile("../../Images/arrow_up.png"), 16, 10);
            arrdown = resizeImage(Image.FromFile("../../Images/arrow_down.png"), 16, 10);
            empty = resizeImage(Image.FromFile("../../Images/empty.png"), 16, 10);
            for (int i = 0; i < tlpScore.ColumnCount; i++)
            {
                Button b = new Button();
                b.TextImageRelation = TextImageRelation.TextBeforeImage;
                b.TextAlign = ContentAlignment.MiddleRight;
                b.Size = tlpScore.Size;
                b.FlatAppearance.MouseOverBackColor = Color.Transparent;
                b.FlatAppearance.MouseDownBackColor = Color.Transparent;
                b.FlatAppearance.BorderSize = 0;
                b.FlatStyle = FlatStyle.Flat;
                b.Font = new Font("Arial", 16.0F);
                switch (i)
                {
                    case 0:
                        b.Text = "Nombre";
                        b.Click += new EventHandler(btnName_Click);
                        break;
                    case 1:
                        b.Text = "Movimientos";
                        b.Click += new EventHandler(btnMoves_Click);
                        break;
                    case 2:
                        b.Text = "Tiempo";
                        b.Click += new EventHandler(btnTime_Click);
                        break;
                    case 3:
                        b.Text = "Puntos";
                        image = Image.FromFile("../../Images/arrow_up.png");
                        b.Click += new EventHandler(btnPoints_Click);
                        break;
                }
                b.Image = resizeImage(image, 16, 10);
                bList.Add(b);
                tlpScore.Controls.Add(b, i, 0);
            }
            chargeScores(scoreFile, true);
        }

        private void chargeScores(string scoreFile, bool first)
        {
            pList.Clear();
            using (StreamReader sr = File.OpenText(scoreFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Player p = new Player();
                    p.createFromLine(line);
                    pList.Add(p);
                }
            }
            if (pList.Count == 0)
            {
                lblEmpty.Visible = true;
                lblEmpty.Enabled = true;
                lblEmpty.Text = "No hay puntajes de ningún jugador en este modo.";
                int x = this.Width / 2 - lblEmpty.Width / 2;
                int y = this.Height / 2 - lblEmpty.Height / 2;
                lblEmpty.Location = new Point(x, y);
                tlpScore.Visible = false;
                tlpScore.Enabled = false;
            }
            else
            {
                lblEmpty.Visible = false;
                lblEmpty.Enabled = false;
                pList.Sort((b, a) => a.Points.CompareTo(b.Points));
                if (first) { 
                    for (int i = 0; i < tlpScore.ColumnCount; i++)
                    {
                        for (int j = 0; j < pList.Count; j++)
                        {
                            tlpScore.Controls.Remove(tlpScore.GetControlFromPosition(i, j + 1));
                            Label l = new Label();
                            l.Size = tlpScore.Size;
                            l.TextAlign = ContentAlignment.MiddleCenter;
                            l.Font = new Font("Arial", 12.0F);
                            switch (i)
                            {
                                case 0:
                                    l.Text = pList[j].Name;
                                    break;
                                case 1:
                                    l.Text = pList[j].Moves.ToString();
                                    break;
                                case 2:
                                    l.Text = pList[j].Time;
                                    break;
                                case 3:
                                    l.Text = pList[j].Points.ToString();
                                    break;
                            }
                            tlpScore.Controls.Add(l, i, j + 1);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < tlpScore.ColumnCount; i++)
                    {
                        for (int j = 1; j < tlpScore.RowCount; j++)
                        {
                            if(tlpScore.GetControlFromPosition(i, j) != null)
                                tlpScore.GetControlFromPosition(i, j).Text = "";
                        }
                    }
                    refreshScores();
                }
                tlpScore.Visible = true;
                tlpScore.Enabled = true;
            }
        }
        
        private void btnName_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(setArrows(btn) == "up")
            {
                pList.Sort((b, a) => a.Name.CompareTo(b.Name));
            }
            else
            {
                pList.Sort((a, b) => a.Name.CompareTo(b.Name));
            }
            refreshScores();
        }

        private void btnMoves_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (setArrows(btn) == "up")
            {
                pList.Sort((b, a) => a.Moves.CompareTo(b.Moves));
            }
            else
            {
                pList.Sort((a, b) => a.Moves.CompareTo(b.Moves));
            }
            refreshScores();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (setArrows(btn) == "up")
            {
                pList.Sort((b, a) => a.Time.CompareTo(b.Time));
            }
            else
            {
                pList.Sort((a, b) => a.Time.CompareTo(b.Time));
            }
            refreshScores();
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (setArrows(btn) == "up")
            {
                pList.Sort((b, a) => a.Points.CompareTo(b.Points));
            }
            else
            {
                pList.Sort((a, b) => a.Points.CompareTo(b.Points));
            }
            refreshScores();
        }

        private string setArrows(Button btn)
        {
            string s;

            foreach (Button b in bList)
            {
                if (!b.Equals(btn))
                {
                    image = Image.FromFile("../../Images/empty.png");
                    b.Image = resizeImage(image, 16, 10);
                }
            }

            if (compareImages((Bitmap)btn.Image, (Bitmap)arrup) || btn.Image.Equals(empty))
            {
                image = Image.FromFile("../../Images/arrow_down.png");
                s =  "down";
            }
            else
            {
                image = Image.FromFile("../../Images/arrow_up.png");
                s = "up";
            }

            btn.Image = resizeImage(image, 16, 10);

            return s;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.Image = Image.FromFile("../../Images/back-h.png");
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.Image = Image.FromFile("../../Images/back.png");
        }

        private void lblPrev_Click(object sender, EventArgs e)
        {
            string scoreFile = "";
            if (lblTitle.Text == "HighScore 3x3")
            {
                scoreFile = "../../scores5x5.txt";
                lblTitle.Text = "HighScore 5x5";
            }
            else if (lblTitle.Text == "HighScore 4x4")
            {
                scoreFile = "../../scores3x3.txt";
                lblTitle.Text = "HighScore 3x3";
            }
            else
            {
                scoreFile = "../../scores4x4.txt";
                lblTitle.Text = "HighScore 4x4";
            }
            chargeScores(scoreFile, false);
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            string scoreFile = "";
            if (lblTitle.Text == "HighScore 3x3")
            {
                scoreFile = "../../scores4x4.txt";
                lblTitle.Text = "HighScore 4x4";
            }
            else if (lblTitle.Text == "HighScore 4x4")
            {
                scoreFile = "../../scores5x5.txt";
                lblTitle.Text = "HighScore 5x5";
            }
            else
            {
                scoreFile = "../../scores3x3.txt";
                lblTitle.Text = "HighScore 3x3";
            }
            chargeScores(scoreFile, false);
        }

        private void lblPrev_Click_1(object sender, EventArgs e)
        {
            string scoreFile = "";
            if (lblTitle.Text == "HighScore 3x3")
            {
                scoreFile = "../../scores5x5.txt";
                lblTitle.Text = "HighScore 5x5";
            }
            else if (lblTitle.Text == "HighScore 4x4")
            {
                scoreFile = "../../scores3x3.txt";
                lblTitle.Text = "HighScore 3x3";
            }
            else
            {
                scoreFile = "../../scores4x4.txt";
                lblTitle.Text = "HighScore 4x4";
            }
            chargeScores(scoreFile, false);
        }

        private void lblNext_Click_1(object sender, EventArgs e)
        {
            string scoreFile = "";
            if (lblTitle.Text == "HighScore 3x3")
            {
                scoreFile = "../../scores4x4.txt";
                lblTitle.Text = "HighScore 4x4";
            }
            else if (lblTitle.Text == "HighScore 4x4")
            {
                scoreFile = "../../scores5x5.txt";
                lblTitle.Text = "HighScore 5x5";
            }
            else
            {
                scoreFile = "../../scores3x3.txt";
                lblTitle.Text = "HighScore 3x3";
            }
            chargeScores(scoreFile, false);
        }

        private void lblPrev_MouseEnter(object sender, EventArgs e)
        {
            lblPrev.Image = Image.FromFile("../../Images/up-h.png");
        }

        private void lblPrev_MouseLeave(object sender, EventArgs e)
        {
            lblPrev.Image = Image.FromFile("../../Images/up.png");
        }

        private void lblNext_MouseEnter(object sender, EventArgs e)
        {
            lblNext.Image = Image.FromFile("../../Images/down-h.png");
        }

        private void lblNext_MouseLeave(object sender, EventArgs e)
        {
            lblNext.Image = Image.FromFile("../../Images/down.png");
        }

        private void refreshScores()
        {
            for (int i = 0; i < tlpScore.ColumnCount; i++)
            {
                for (int j = 0; j < pList.Count; j++)
                {
                    string text = "";
                    switch (i)
                    {
                        case 0:
                            text = pList[j].Name;
                            break;
                        case 1:
                            text = pList[j].Moves.ToString();
                            break;
                        case 2:
                            text = pList[j].Time;
                            break;
                        case 3:
                            text = pList[j].Points.ToString();
                            break;
                    }
                    if(tlpScore.GetControlFromPosition(i, j + 1) != null)
                    {
                        tlpScore.GetControlFromPosition(i, j + 1).Text = text;
                    }
                }
            }
        }

        public static Image resizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private bool compareImages(Bitmap a, Bitmap b)
        {
            if (a.Size != b.Size)
            {
                return false;
            }
            for(int x = 0; x < a.Width; x++)
            {
                for(int y = 0; y < a.Height; y++)
                {
                    if(a.GetPixel(x, y) != b.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
