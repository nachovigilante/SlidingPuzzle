using System;
using System.Collections.Generic;
using System.IO;
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

        public void readFromTxt()
        {
            List<string> linesList = File.ReadAllLines("../../options.txt").ToList();
            keyMoves = linesList[0] != "False";
            multiMoves = linesList[1] != "False";
            animationsActive = linesList[2] != "False";
            animationSpeed = Int32.Parse(linesList[3]);
            size = Int32.Parse(linesList[4]);
        }

        public void writeToTxt()
        {
            List<string> linesList = new List<string>();
            linesList.Add(keyMoves.ToString());
            linesList.Add(multiMoves.ToString());
            linesList.Add(animationsActive.ToString());
            linesList.Add(animationSpeed.ToString());
            linesList.Add(size.ToString());
            File.WriteAllText("../../options.txt", "");
            File.WriteAllLines("../../options.txt", linesList);
        }
    }
}
