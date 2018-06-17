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
                int lim = b.size - 1;
                if (moveable)
                    b.moveToZero(x, y, animationsActive);
                else if(b.zeroX - x == 0)
                {
                    if (b.zeroY < y)
                    {
                        for (int i = -lim; i < lim; i++)
                        {
                            //Console.Write("Analyzing piece " + x + ", " + (y + i) + ": ");
                            if (b.pieceExists(x, y + i))
                            {
                                //Console.Write("Piece " + x + ", " + (y + i) + " exists... ");
                                if (b.pieceArray[x, y + i].moveable)
                                {
                                    //Console.Write("Moving piece " + x + ", " + (y + i));
                                    b.moveToZero(x, y + i, false);
                                }
                            }
                           //Console.Write("\n");
                        }
                    }
                    else
                    {
                        for (int i = lim; i > -lim; i--)
                        {
                            //Console.Write("Analyzing piece " + x + ", " + (y + i) + ": ");
                            if (b.pieceExists(x, y + i))
                            {
                                //Console.Write("Piece " + x + ", " + (y + i) + " exists... ");
                                if (b.pieceArray[x, y + i].moveable)
                                {
                                    //Console.Write("Moving piece " + x + ", " + (y + i));
                                    b.moveToZero(x, y + i, false);
                                }
                            }
                            //Console.Write("\n");
                        }
                    }
                }else if(b.zeroY - y == 0)
                {
                    if (b.zeroX < x)
                    {
                        for (int i = -lim; i < lim; i++)
                        {
                            //Console.Write("Analyzing piece " + (x + i) + ", " + y + ": ");
                            if (b.pieceExists(x + i, y))
                            {
                                //Console.Write("Piece " + (x + i) + ", " + y + " exists... ");
                                if (b.pieceArray[x + i, y].moveable)
                                {
                                    //Console.Write("Moving piece " + (x + i) + ", " + y);
                                    b.moveToZero(x + i, y, false);
                                }
                            }
                            //Console.Write("\n");
                        }
                    }
                    else
                    {
                        for (int i = lim; i > -lim; i--)
                        {
                            //Console.Write("Analyzing piece " + (x + i) + ", " + y + ": ");
                            if (b.pieceExists(x + i, y))
                            {
                                //Console.Write("Piece " + (x + i) + ", " + y + " exists... ");
                                if (b.pieceArray[x + i, y].moveable)
                                {
                                    //Console.Write("Moving piece " + (x + i) + ", " + y);
                                    b.moveToZero(x + i, y, false);
                                }
                            }
                            //Console.Write("\n");
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
