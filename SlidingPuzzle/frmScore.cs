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

        private void frmScore_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tlpScore.ColumnCount; i++)
            {
                Button b = new Button();
                Image image = Image.FromFile("arrow_up.png");
                image = resizeImage(image, 16,10);
                b.BackColor = Color.Blue;
                b.Image = image;
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.TextImageRelation = TextImageRelation.TextBeforeImage;
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
                        b.Click += new EventHandler(lblName_Click);
                        break;
                    case 1:
                        b.Text = "Movimientos";
                        b.Click += new EventHandler(lblMoves_Click);
                        break;
                    case 2:
                        b.Text = "Tiempo";
                        b.Click += new EventHandler(lblTime_Click);
                        break;
                    case 3:
                        b.Text = "Puntos";
                        b.Click += new EventHandler(lblPoints_Click);
                        break;
                }
                this.Controls.Add(b);
                tlpScore.Controls.Add(b, i, 0);
            }
            using (StreamReader sr = File.OpenText("../../scores.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Player p = new Player();
                    p.createFromLine(line);
                    pList.Add(p);
                }
            }
            pList.Sort((b, a) => a.Points.CompareTo(b.Points));
            displayScores();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            pList.Sort((a, b) => a.Name.CompareTo(b.Name));
            displayScores();
        }

        private void lblMoves_Click(object sender, EventArgs e)
        {
            pList.Sort((a, b) => a.Moves.CompareTo(b.Moves));
            displayScores();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            pList.Sort((a, b) => a.Time.CompareTo(b.Time));
            displayScores();
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {
            pList.Sort((b, a) => a.Points.CompareTo(b.Points));
            displayScores();
        }

        private void displayScores()
        {
            for (int i = 0; i < tlpScore.ColumnCount; i++)
            {
                for (int j = 0; j < pList.Count; j++)
                {
                    tlpScore.Controls.Remove(tlpScore.GetControlFromPosition(i, j +1));
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
    }
}
