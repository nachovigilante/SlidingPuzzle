﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    class Board
    {
        int size { get; set; }
        public Piece[,] pieceArray;
        public int zeroX = 0;
        public int zeroY = 0;
        public Timer tmrTick;
        public int time;
        public bool playing;
        public int moves = 0;
        public static Random r = new Random();

        public void shuffle()
        {
            for (int i = 0; i < 200 * size; i++)
            {
                int pieceX = r.Next(0, size);
                int pieceY = r.Next(0, size);
                if (pieceArray[pieceX, pieceY].moveable)
                    moveToZero(pieceX, pieceY);
            }
        }

        public void showPieces(Form form)
        {
            foreach (Piece p in pieceArray)
            {
                p.showPiece(form);
            }
        }

        public void findZero()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (pieceArray[j, i].value == 0)
                    {
                        zeroX = j;
                        zeroY = i;
                        break;
                    }
                }
            }
        }

        public bool pieceExists(int x, int y)
        {
            if (x > -1 && y > -1 && x < size && y < size)
                return true;
            return false;
        }

        private void findMoveablePieces()
        {
            for (int i = -1; i < 2; i += 2)
            {
                if (pieceExists(zeroX + i, zeroY))
                    pieceArray[zeroX + i, zeroY].moveable = true;
                if (pieceExists(zeroX, zeroY + i))
                    pieceArray[zeroX, zeroY + i].moveable = true;
            }
        }

        public void resetMoveables()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    pieceArray[j, i].moveable = false;
                }
            }
        }

        public void checkPosiblePlays()
        {
            findZero();
            resetMoveables();
            findMoveablePieces();
        }

        private void checkIfWin()
        {
            if (playing)
            {
                int winIterator = 1;
                bool win = true;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (pieceArray[j, i].value != winIterator && winIterator < size * size)
                            win = false;
                        winIterator++;
                    }
                }
                if (win)
                {
                    playing = false;
                    tmrTick.Enabled = false;
                    MessageBox.Show("Ganaste campeon!", "Muy bien");
                }
            }
        }

        public void moveToZero(int pieceX, int pieceY)
        {
            Point aux = new Point();
            aux = pieceArray[pieceX, pieceY].pb.Location;
            pieceArray[pieceX, pieceY].pb.Location = pieceArray[zeroX, zeroY].pb.Location;
            pieceArray[zeroX, zeroY].pb.Location = aux;

            Piece auxPiece = pieceArray[pieceX, pieceY];
            pieceArray[pieceX, pieceY] = pieceArray[zeroX, zeroY];
            pieceArray[zeroX, zeroY] = auxPiece;

            pieceArray[pieceX, pieceY].x = pieceX;
            pieceArray[pieceX, pieceY].y = pieceY;
            pieceArray[zeroX, zeroY].x = zeroX;
            pieceArray[zeroX, zeroY].y = zeroY;

            checkPosiblePlays();
            moves++;
            checkIfWin();
        }

        public void tmrTick_Tick(object sender, EventArgs e)
        {
            if (playing)
                time++;
        }

        public string getPlayTime()
        {
            int hours = (time / 60) / 60;
            int minutes = time / 60;
            int seconds = (time - minutes * 60);
            return (hours < 10 & hours > 0 ? "0" : "") + (hours > 0 ? hours.ToString() + ":" : "") + minutes.ToString() + ":" + (seconds < 10 ? "0" + seconds.ToString() : seconds.ToString());
        }

        public string getMoves()
        {
            return moves.ToString();
        }

        public Board(int s, int gap, int offset, int squareSize)
        {
            size = s;
            int valueI = 1;
            pieceArray = new Piece[s, s];
            tmrTick = new Timer();
            tmrTick.Tick += tmrTick_Tick;
            tmrTick.Interval = 1000;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (valueI == size * size)
                        pieceArray[j, i] = new Piece(0, j, i, this, gap, offset, squareSize);
                    else
                        pieceArray[j, i] = new Piece(valueI, j, i, this, gap, offset, squareSize);
                    valueI++;
                }
            }
        }

    }
}
