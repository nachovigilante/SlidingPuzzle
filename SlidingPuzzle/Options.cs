using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingPuzzle
{
    class Options
    {
        public bool keyMoves { get; internal set; }
        public bool multiMoves { get; set; }
        public bool animationsActive { get; set; }
        public int animationSpeed { get; set; }
        public int size { get; set; }

        public Options(int s, bool aA, int aS, bool km, bool mm)
        {
            size = s;
            animationsActive = aA;
            animationSpeed = aS;
            keyMoves = km;
            multiMoves = mm;
        }
    }
}
