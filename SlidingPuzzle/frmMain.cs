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
        Board b;
        public Bitmap[,] bmpArray;
        public bool animationsActive = true;
        public frmMain(bool animationsActive, int animationSpeed)
        {
            this.animationsActive = animationsActive;
            this.animationSpeed = animationSpeed;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            squareSize = bmpArray[0,0].Height;
            int formSizeX = offset * 2 + squareSize * size + buttonGap;
            int formSizeY = offset * 2 + squareSize * size + offset;
            b = new Board(size, squareSize, offset, squareSize, bmpArray, animationsActive, animationSpeed);
            Size = new Size(formSizeX, formSizeY);
            b.showPieces(this);
            b.checkPosiblePlays();
            grpControls.Location = new Point(formSizeX - (buttonGap + 20), (formSizeY - grpControls.Size.Height) / 2 - 22);
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (btnBegin.Text == "Empezar")
            {
                btnBegin.Text = "Rendirse";
                b.pieceArray[b.zeroX, b.zeroY].pb.Visible = false;
                b.shuffle();
                b.playing = true;
            }
            else
            {
                btnBegin.Text = "Empezar";
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
            if (!b.playing)
                btnBegin.Text = "Empezar";
        }

    }
}
