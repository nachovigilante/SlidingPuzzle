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

        int prevSize = 3;
        int size = 3;
        Bitmap[,] bmpArray = null;
        Bitmap imageToUse;
        PictureBox[,] pbArray;
        private bool imageLoaded;

        private void chkAnimations_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void loadImage()
        {
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

        private void cleanPbArray()
        {
            for (int x = 0; x < prevSize; x++)
            {
                for (int y = 0; y < prevSize; y++)
                {
                    pbArray[x, y].Visible = false;
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Abrir una imagen";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imageToUse = new Bitmap(dlg.FileName);
                    Bitmap resizedImage = new Bitmap(imageToUse, new Size(200, 200));
                    if(imageLoaded)
                        cleanPbArray();
                    pbArray = new PictureBox[size, size];
                    prevSize = size;
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
                            pbArray[x, y].BringToFront();
                            pbArray[x, y].Image = tile;
                        }
                    }
                    imageLoaded = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = 3 + cboSize.SelectedIndex;
        }

    }
}
