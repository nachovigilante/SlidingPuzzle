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
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void chkAnimations_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Abrir una imagen";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap userImage = new Bitmap(dlg.FileName);
                    Bitmap resizedImage = new Bitmap(userImage, new Size(200, 200));
                    int size = 3;
                    PictureBox[,] pbArray = new PictureBox[size, size];
                    int tileSize = (int)Math.Floor((float)resizedImage.Width / size);
                    for (int x = 0; x < size; x++)
                    {
                        for (int y = 0; y < size; y++)
                        {
                            Rectangle cloneRect = new Rectangle(tileSize * x, tileSize * y, tileSize, tileSize);
                            System.Drawing.Imaging.PixelFormat format = resizedImage.PixelFormat;
                            Bitmap tile = resizedImage.Clone(cloneRect, format);

                            pbArray[x, y] = new PictureBox();
                            Controls.Add(pbArray[x, y]);
                            pbArray[x, y].Name = "pbArray_" + x + "_" + y;
                            pbArray[x, y].Size = new Size(tileSize, tileSize);
                            pbArray[x, y].BackColor = Color.White;
                            pbArray[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                            pbArray[x, y].Location = new Point(lblFile.Location.X + tileSize * x + 5 * x, lblFile.Location.Y + 5 * y + tileSize * y + 50);
                            pbArray[x, y].Anchor = AnchorStyles.Left;
                            pbArray[x, y].Visible = true;
                            pbArray[x, y].Image = tile;
                        }
                    }

                }
            }
        }
    }
}
