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
        string time;
        static int gap = 120;
        static int offset = 40;
        static int squareSize = 100;
        static int size = 3;
        static int buttonGap = 200;
        int formSizeX = offset * 2 + gap * size + buttonGap;
        int formSizeY = offset * 2 + gap * size + offset / 2;
        Board b;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Board(size, gap, offset, squareSize);
            this.Size = new Size(formSizeX, formSizeY);
            b.showPieces(this);
            b.checkPosiblePlays();
            grpControls.Location = new Point(formSizeX - (buttonGap + 20), (formSizeY - grpControls.Size.Height) / 2 - 22);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (btnBegin.Text == "Empezar")
            {
                btnBegin.Text = "Rendirse";
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

        private void button1_Click(object sender, EventArgs e)
        {
            b.movePiece();
        }
    }
}
