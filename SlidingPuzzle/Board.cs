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
        //public Queue<int> moveablePieces = new Queue<int>(); 

        public void showPieces(Form form){
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
            for(int i = -1; i < 2; i += 2)
            {
                if (pieceExists(zeroX + i, zeroY))
                    pieceArray[zeroX + i, zeroY].moveable = true;
                    //moveablePieces.Enqueue(pieceArray[zeroX + i, zeroY].value);
                if (pieceExists(zeroX, zeroY + i))
                    pieceArray[zeroX, zeroY + i].moveable = true;
                    //moveablePieces.Enqueue(pieceArray[zeroX, zeroY + i].value);
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
            int winIterator = 1;
            bool win = true;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (pieceArray[j, i].value != winIterator && winIterator < 9)
                        win = false;
                    winIterator++;
                }
            }
            if (win)
            {
                MessageBox.Show("Ganaste campeon");
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
            checkIfWin();
        }

        public Board(int s, int gap, int offset, int squareSize)
        {
            size = s;
            int valueI = 0;
            pieceArray = new Piece[s, s];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    pieceArray[j, i] = new Piece(valueI, j, i, this, gap, offset, squareSize);
                    valueI++;
                }
            }
        }

    }
}
