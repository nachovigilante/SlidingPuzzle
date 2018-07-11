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
    public partial class frmMain : Form
    {
        //static int gap = 100;
        static int offset = 40;
        static int yOffset = 200;
        public int squareSize = 100;
        public int size;
        static int buttonGap = 200;
        public int animationSpeed = 30;
        public bool keyMoves = true;
        public bool multiMoves = true;
        Board b;
        public Bitmap[,] bmpArray;
        public bool animationsActive = true;
        public frmMenu formMenu;
        
        public frmMain(bool animationsActive, int animationSpeed, bool keyMoves, bool multiMoves, frmMenu formMenu)
        {
            this.animationsActive = animationsActive;
            this.animationSpeed = animationSpeed;
            this.keyMoves = keyMoves;
            this.multiMoves = multiMoves;
            this.formMenu = formMenu;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            squareSize = bmpArray[0,0].Height;
            int formSizeX = offset * 2 + squareSize * size + buttonGap;
            int formSizeY = yOffset + offset + squareSize * size;
            b = new Board(size, squareSize, offset, yOffset, squareSize, bmpArray, animationsActive, animationSpeed, multiMoves);
            Size = new Size(formSizeX - 40, formSizeY - 40);
            int p = pictureBox1.Location.Y;
            pictureBox1.Location = new Point(((formSizeX - pictureBox1.Width) / 2) - 22, p);
            b.showPieces(this);
            b.checkPosiblePlays();
            grpControls.Location = new Point(formSizeX - (buttonGap + 20), (formSizeY - grpControls.Size.Height) / 2 + yOffset/2 - 57);
            btnBegin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBegin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVolver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (!b.playing)
            {
                b.pieceArray[b.zeroX, b.zeroY].pb.Visible = false;
                b.shuffle();
                b.playing = true;
                btnBegin.Image = new Bitmap("../../Images/rendirse-debil.png");
            }
            else
            {
                btnBegin.Image = new Bitmap("../../Images/empezar-debil.png");
                b.playing = false;
            }
            b.time = 0;
            b.moves = 0;

            b.tmrTick.Enabled = !b.tmrTick.Enabled;
        }

        private void tmrTickExtern_Tick(object sender, EventArgs e)
        {
            lblTime.Text = b.getPlayTime();
            lblMoves.Text = b.getMoves();
            /*if (b.playing)
                btnBegin.Image = new Bitmap("../../Images/rendirse-debil.png");*/
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            useKey(e.KeyCode);
        }

        private void frmMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void grpControls_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void btnBegin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void useKey(Keys keyCode)
        {
            if (keyMoves)
            {
                if (keyCode == Keys.Up)
                {
                    if (b.pieceExists(b.zeroX, b.zeroY + 1))
                    {
                        b.pieceArray[b.zeroX, b.zeroY + 1].pb_Click(b.pieceArray[b.zeroX, b.zeroY + 1].pb, null);
                    }
                }
                else if (keyCode == Keys.Down)
                {
                    if (b.pieceExists(b.zeroX, b.zeroY - 1))
                    {
                        b.pieceArray[b.zeroX, b.zeroY - 1].pb_Click(b.pieceArray[b.zeroX, b.zeroY - 1].pb, null);
                    }
                }
                else if (keyCode == Keys.Right)
                {
                    if (b.pieceExists(b.zeroX - 1, b.zeroY))
                    {
                        b.pieceArray[b.zeroX - 1, b.zeroY].pb_Click(b.pieceArray[b.zeroX - 1, b.zeroY].pb, null);
                    }
                }
                else if (keyCode == Keys.Left)
                {
                    if (b.pieceExists(b.zeroX + 1, b.zeroY))
                    {
                        b.pieceArray[b.zeroX + 1, b.zeroY].pb_Click(b.pieceArray[b.zeroX + 1, b.zeroY].pb, null);
                    }
                }
            }
        }

        private void btnBegin_KeyDown(object sender, KeyEventArgs e)
        {
            useKey(e.KeyCode);
        }

        private void btnSolve_KeyDown(object sender, KeyEventArgs e)
        {
            useKey(e.KeyCode);
        }

        private void btnSolve_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            Hide();
        }

        private void grpControls_Enter(object sender, EventArgs e)
        {

        }

        private void btnBegin_MouseEnter(object sender, EventArgs e)
        {
            if (!b.playing)
                btnBegin.Image = Image.FromFile("../../Images/empezar-debil-h.png");
            else
                btnBegin.Image = Image.FromFile("../../Images/rendirse-debil-h.png");
        }

        private void btnBegin_MouseLeave(object sender, EventArgs e)
        {
            if(!b.playing)
                btnBegin.Image = Image.FromFile("../../Images/empezar-debil.png");
            else
                btnBegin.Image = Image.FromFile("../../Images/rendirse-debil.png");
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.Image = Image.FromFile("../../Images/menu-h.png");
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.Image = Image.FromFile("../../Images/menu.png");
        }

        private void grpControls_Paint(object sender, PaintEventArgs e)
        {
             Brush b = new SolidBrush(Color.FromArgb(64, 64, 64));
            SizeF strSize = e.Graphics.MeasureString(grpControls.Text, grpControls.Font);
            Rectangle rect = new Rectangle(grpControls.ClientRectangle.X,
                                               grpControls.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               grpControls.ClientRectangle.Width - 1,
                                               grpControls.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            e.Graphics.Clear(this.BackColor);

            e.Graphics.FillRectangle(b, rect);
            //e.Graphics.DrawRectangle(new Pen(Color.Gray), rect);
            //int paddingLeft = 10;
            //int yOffset = 15;

            // Draw text
            //g.DrawString(box.Text, box.Font, textBrush, paddingLeft, 0);
            // Draw line
            //g.DrawLine(borderPen, new Point(rect.X, rect.Y + yOffset), new Point(rect.X + rect.Width, rect.Y + yOffset));
        }
    }
}
