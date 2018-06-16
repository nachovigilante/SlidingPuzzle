using System;
using System.Collections;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    class Solver
    {
        int[,] boardMatrix;
        Queue piecesQueue;
        Form formReference;
        Board boardReference;

        public void updateMatrix()
        {
            for (int x = 0; x < boardReference.size; x++)
            {
                for (int y = 0; y < boardReference.size; y++)
                {
                    boardMatrix[x, y] = boardReference.pieceArray[y, x].value;
                }
            }
        }

        public void debugMatrix()
        {
            updateMatrix();
            for (int x = 0; x < boardReference.size; x++)
            {
                Console.Write("|");
                for (int y = 0; y < boardReference.size; y++)
                {
                    Console.Write(" " + boardMatrix[x, y] + " |");
                }
                Console.Write("\n");
            }
        }

        public Solver(Form form, Board board)
        {
            formReference = form;
            boardReference = board;
            piecesQueue = new Queue();
            //boardMatrix = new int[boardReference.size, boardReference.size];
            //updateMatrix();
        }
    }
}
