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
            tmrAnimate = new Timer();
            tmrAnimate.Tick += tmrAnimate_Tick;
            tmrAnimate.Interval = b.animationSpeed;
        }

        public void animate(Point zeroLocation)
        {
            //animatePieceX = pieceX;
            //animatePieceY = pieceY;
            //animatePieceLocation = b.pieceArray[pieceX, pieceY].pb.Location;
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

        public void pb_Click(object sender, EventArgs e)
        {
            if (b.playing && tmrAnimate.Enabled == false)
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
                                    b.moveToZero(x, y + i, true);
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
                                    b.moveToZero(x, y + i, true);
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
                                    b.moveToZero(x + i, y, true);
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
                                    b.moveToZero(x + i, y, true);
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
