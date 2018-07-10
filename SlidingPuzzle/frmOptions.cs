using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class frmOptions : Form
    {
        public frmOptions(frmMenu menuForm)
        {
            this.menuForm = menuForm;
            InitializeComponent();
        }
        frmMenu menuForm;
        int prevSize = 3;
        Options optObj = new Options(3, true, 30, true, true);
        //int size = 3;
        Bitmap[,] bmpArray = null;
        Bitmap imageToUse;
        PictureBox[,] pbArray;
        private bool imageLoaded = false;
        //public int animationsActive = true;
        //public int animationSpeed = 30;
        //public bool keyMoves = true;
        //public bool multiMoves = true;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void chkAnimations_CheckedChanged(object sender, EventArgs e)
        {
            optObj.animationsActive = chkAnimations.Checked;
        }

        public void updateFromTxt()
        {
            optObj.readFromTxt();
            chkKeys.Checked = optObj.keyMoves;
            checkBox1.Checked = optObj.multiMoves;
            chkAnimations.Checked = optObj.animationsActive;
            colorSlider2.Value = (optObj.animationSpeed - 55) / (-5);
        }

        public void loadImage()
        {
            loadPreview();
            Bitmap resizedImage = new Bitmap(imageToUse, new Size(300, 300));
            bmpArray = new Bitmap[optObj.size, optObj.size];
            int tileSize = (int)Math.Floor((float)resizedImage.Width / optObj.size);
            for (int x = 0; x < optObj.size; x++)
            {
                for (int y = 0; y < optObj.size; y++)
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
                    loadImage();
                }
            }
        }

        private void loadPreview()
        {
            Bitmap resizedImage = new Bitmap(imageToUse, new Size(200, 200));
            if (imageLoaded)
                cleanPbArray();
            pbArray = new PictureBox[optObj.size, optObj.size];
            prevSize = optObj.size;
            int tileSize = (int)Math.Floor((float)resizedImage.Width / optObj.size);
            for (int x = 0; x < optObj.size; x++)
            {
                for (int y = 0; y < optObj.size; y++)
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
                    pbArray[x, y].Location = new Point(grpTab.Location.X + tileSize * x + 5 * x + (grpTab.Width - tileSize * optObj.size)/2, grpTab.Location.Y + 250 + 5 * y + tileSize * y);
                    pbArray[x, y].Anchor = AnchorStyles.Left;
                    pbArray[x, y].Visible = true;
                    pbArray[x, y].BringToFront();
                    pbArray[x, y].Image = tile;
                }
            }
            imageLoaded = true;
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            optObj.size = 3 + cboSize.SelectedIndex;
            if (imageLoaded)
            {
                loadImage();
            }
        }

        private void loadDefault()
        {
            imageToUse = new Bitmap(Properties.Resources.night);
            loadImage();
        }

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            loadDefault();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            btnVolver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoadDefault.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLoadDefault.FlatAppearance.MouseOverBackColor = Color.Transparent;
            updateFromTxt();
            loadDefault();
            cboSize.SelectedIndex = 0;
            cusCboSize.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            optObj.writeToTxt();
            menuForm.bmpArray = bmpArray;
            menuForm.size = optObj.size;
            menuForm.animationsActive = optObj.animationsActive;
            menuForm.animationSpeed = optObj.animationSpeed;
            menuForm.keyMoves = optObj.keyMoves;
            menuForm.multiMoves = optObj.multiMoves;
            menuForm.Show();
            Hide();
        }

        private void trkAnimations_Scroll(object sender, EventArgs e)
        {
            optObj.animationSpeed = 55 - 5 * trkAnimations.Value;
        }

        private void chkKeys_CheckedChanged(object sender, EventArgs e)
        {
            optObj.keyMoves = chkKeys.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            optObj.multiMoves = checkBox1.Checked;
        }

        private void frmOptions_Scroll(object sender, ScrollEventArgs e)
        {
            /*Point newLocation = new Point(btnVolver.Location.X, 10);
            btnVolver.Location = newLocation;*/
            //Console.WriteLine("LocationY: " + btnVolver.Location.Y);            
        }

        private void lblPreview_Click(object sender, EventArgs e)
        {

        }

        private void grpTab_Enter(object sender, EventArgs e)
        {

        }

        private void lblFile_Click(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void lblDefault_Click(object sender, EventArgs e)
        {

        }

        private void lblVel_Click(object sender, EventArgs e)
        {

        }

        private void grpAnimations_Enter(object sender, EventArgs e)
        {

        }

        private void lblAnimations_Click(object sender, EventArgs e)
        {

        }

        private void lblKeys_Click(object sender, EventArgs e)
        {

        }

        private void grpControls_Enter(object sender, EventArgs e)
        {

        }

        private void lblMulti_Click(object sender, EventArgs e)
        {

        }

        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            optObj.animationSpeed = 55 - 5 * colorSlider2.Value;
        }

        private void grpControls_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.FromArgb(255, 233, 165));
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(Color.FromArgb(255, 136, 16));
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                //g.FillPath(borderBrush, RoundedRect(rect, 10));

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                

                // Drawing Border
                //Left
                //g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                //g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                //g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
