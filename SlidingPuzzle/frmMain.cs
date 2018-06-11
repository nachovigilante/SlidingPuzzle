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
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int gap = 120;
            int offset = 40;
            int squareSize = 100;
            int size = 3;
            int button_gap = 170;
            int formSizeX = offset * 2 + gap * size + button_gap;
            int formSizeY = offset * 2 + gap * size + offset/2;
            this.Size = new Size(formSizeX, formSizeY);
            Board b = new Board(size, gap, offset, squareSize);
            b.showPieces(this);
            b.checkPosiblePlays();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
