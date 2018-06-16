using System;
using System.Drawing;
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
        public Board b;
        bool animationsActive = true;

        public void showPiece(Form form)
        {
            form.Controls.Add(this.pb);
        }

        public Piece(int v, int x, int y, Board b, int gap, int offset, int squareSize, bool animationsActive)
        {
            value = v;
            this.x = x;
            this.y = y;
            this.b = b;
            pb = new PictureBox();
            pb.Click += pb_Click;
            pb.Name = "pb_" + v;
            pb.Size = new Size(squareSize, squareSize);
            pb.BackColor = Color.White;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Location = new Point(this.x * gap + offset, this.y * gap + offset);
            pb.Anchor = AnchorStyles.Left;
            loadRightImage(pb, v);
            this.animationsActive = animationsActive;
        }

        public void pb_Click(object sender, EventArgs e)
        {
            if (b.playing && b.tmrAnimate.Enabled == false)
            {
                int min;
                if (moveable)
                    b.moveToZero(x, y, animationsActive);
                else if(b.zeroX - x == 0)
                {
                    if (b.zeroY > y)
                        min = -(b.size - 1);
                    else
                        min = b.size - 1;
                    for(int i = -(b.size-1); i < b.size-1; i++)
                    {
                        if(b.pieceExists(x, y + i))
                        {
                            if(b.pieceArray[x, y + i].moveable)
                                b.moveToZero(x, y + i, false);
                        }
                    }
                }else if(b.zeroY - y == 0)
                {
                    if (b.zeroX > x)
                        min = -(b.size - 1);
                    else
                        min = b.size - 1;
                    for (int i = -(b.size-1); i < b.size-1; i++)
                    {
                        if (b.pieceExists(x + i, y))
                        {
                            if (b.pieceArray[x + i, y].moveable)
                                b.moveToZero(x + i, y, false);
                        }
                    }
                }
            }
        }

        private void loadRightImage(PictureBox pb, int v)
        {
            pb.Image = b.bmpArray[x, y];
        }
    }
}
