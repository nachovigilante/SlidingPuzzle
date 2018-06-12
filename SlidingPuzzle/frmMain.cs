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
        static int gap = 120;
        static int offset = 40;
        static int squareSize = 100;
        static int size = 3;
        static int button_gap = 200;
        int formSizeX = offset * 2 + gap * size + button_gap;
        int formSizeY = offset * 2 + gap * size + offset / 2;
        Board b = new Board(size, gap, offset, squareSize);
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(formSizeX, formSizeY);
            b.showPieces(this);
            b.checkPosiblePlays();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
