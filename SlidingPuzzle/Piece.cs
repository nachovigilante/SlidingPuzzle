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
        Point zeroLocation;
        Timer tmrAnimate;
        int animateIterator = 0;

        public void showPiece(Form form)
        {
            form.Controls.Add(this.pb);
        }

        public Piece(int v, int x, int y, Board b, int gap, int offset, int yOffset, int squareSize, bool animationsActive)
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
            pb.Location = new Point(this.x * gap + offset, this.y * gap + yOffset - 37);
            pb.Anchor = AnchorStyles.Left;
            loadRightImage(pb, v);
            this.animationsActive = animationsActive;
            tmrAnimate = new Timer();
            tmrAnimate.Tick += tmrAnimate_Tick;
            tmrAnimate.Interval = b.animationSpeed;
        }

        public void animate(Point zeroLocation)
        {
            this.zeroLocation = zeroLocation;
            tmrAnimate.Enabled = true;
        }

        public void tmrAnimate_Tick(object sender, EventArgs e)
        {
            if (animateIterator < ((b.animationSpeed * 7) / 40))
            {
                pb.Location = b.Lerp(pb.Location, zeroLocation, (float)0.5);
                animateIterator++;
            }
            else
            {
                animateIterator = 0;
                pb.Location = zeroLocation;
                tmrAnimate.Enabled = false;
            }
        }

        public void asd(int x, int y, int dx, int dy)
        {
            do
            {
                x += dx;
                y += dy;
                if (b.pieceArray[x, y].moveable)
                    b.moveToZero(x, y, true);
            } while (b.pieceExists(x, y));
        }

        public void pb_Click(object sender, EventArgs e)
        {
            if (b.playing && tmrAnimate.Enabled == false)
            {
                if (moveable)
                    b.moveToZero(x, y, animationsActive);
                else if(b.zeroX - x == 0 && b.multiMoves)
                {
                    int lim = (b.zeroY - y);
                    if (b.zeroY > y)
                    {
                        for (int i = lim; i > -1; i--)
                        {
                            if (b.pieceExists(x, y + i))
                            {
                                if (b.pieceArray[x, y + i].moveable)
                                {
                                    b.moveToZero(x, y + i, true);
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = lim; i < 1; i++)
                        {
                            if (b.pieceExists(x, y + i))
                            {
                                if (b.pieceArray[x, y + i].moveable)
                                {
                                    b.moveToZero(x, y + i, true);
                                }
                            }
                        }
                    }
                }else if(b.zeroY - y == 0 && b.multiMoves)
                {
                    int lim = (b.zeroX - x);
                    if (b.zeroX > x)
                    {
                        for (int i = lim; i > -1; i--)
                        {
                            if (b.pieceExists(x + i, y))
                            {
                                if (b.pieceArray[x + i, y].moveable)
                                {
                                    b.moveToZero(x + i, y, true);
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = lim; i < 1; i++)
                        {
                            if (b.pieceExists(x + i, y))
                            {
                                if (b.pieceArray[x + i, y].moveable)
                                {
                                    b.moveToZero(x + i, y, true);
                                }
                            }
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
