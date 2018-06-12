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
        int time = 0;
        static int gap = 120;
        static int offset = 40;
        static int squareSize = 100;
        static int size = 3;
        static int buttonGap = 200;
        int formSizeX = offset * 2 + gap * size + buttonGap;
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
            grpControls.Location = new Point(formSizeX - (buttonGap + 20), (formSizeY - grpControls.Size.Height)/2 - 22);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            time++;
            int hours = (time / 60) / 60;
            int minutes = time / 60;
            int seconds = (time - minutes * 60);
            lblTime.Text = (hours < 10 & hours > 0 ? "0" : "") + (hours > 0 ? hours.ToString() + ":" : "") + minutes.ToString() + ":" + (seconds < 10 ? "0" + seconds.ToString() : seconds.ToString());
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            time = 0;
            tmrTick.Enabled = !tmrTick.Enabled;
        }
    }
}
