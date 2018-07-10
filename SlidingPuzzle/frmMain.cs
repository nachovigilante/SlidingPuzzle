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
            int formSizeY = offset * 2 + squareSize * size + offset;
            b = new Board(size, squareSize, offset, squareSize, bmpArray, animationsActive, animationSpeed, multiMoves);
            Size = new Size(formSizeX, formSizeY);
            b.showPieces(this);
            b.checkPosiblePlays();
            grpControls.Location = new Point(formSizeX - (buttonGap + 20), (formSizeY - grpControls.Size.Height) / 2 - 22);
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
    }
}
