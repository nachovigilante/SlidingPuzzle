using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    class Piece
    {
        public int value { get; internal set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool moveable = false;
        public PictureBox pb { get; set; }
        public Board br;

        public void showPiece(Form form)
        {
            form.Controls.Add(this.pb);
        }

        public Piece(int v, int x, int y, Board b, int gap, int offset, int squareSize)
        {
            value = v;
            this.x = x;
            this.y = y;
            br = b;
            pb = new PictureBox();
            pb.Click += pb_Click;
            pb.Name = "pb_" + v;
            pb.Size = new Size(squareSize, squareSize);
            loadRightImage(pb, v);
            pb.BackColor = Color.White;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Location = new Point(this.x * gap + offset, this.y * gap + offset);
            pb.Anchor = AnchorStyles.Left;
            if (v == 0)
                pb.Visible = false;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            if (moveable && br.playing)
                br.moveToZero(x, y, true);
        }

        private void loadRightImage(PictureBox pb, int v)
        {
            switch (v)
            {
                case 1:
                    pb.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    pb.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    pb.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    pb.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    pb.BackgroundImage = Properties.Resources._5;
                    break;
                case 6:
                    pb.BackgroundImage = Properties.Resources._6;
                    break;
                case 7:
                    pb.BackgroundImage = Properties.Resources._7;
                    break;
                case 8:
                    pb.BackgroundImage = Properties.Resources._8;
                    break;
            }

        }
    }
}
