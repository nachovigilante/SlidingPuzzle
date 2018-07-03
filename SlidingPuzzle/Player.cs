using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingPuzzle
{
    class Player
    {
        public string Name {get; set;}
        public int Moves { get; set; }
        public string Time { get; set; }
        public int Points { get; set; }

        public Player() { }
        public Player(string name, string time, int moves, int points)
        {
            this.Name = name;
            this.Moves = moves;
            this.Time = time;
            this.Points = points;
        }

        public void writeToTxt(bool edit)
        {
            string toWrite = this.Name + "; " + this.Moves + "; " + this.Time + "; " + this.Points + Environment.NewLine;
            if (edit)
            {
                List<string> linesList = File.ReadAllLines("../../scores.txt").ToList();
                linesList.RemoveAt(9);
                File.WriteAllLines("../../scores.txt", linesList.ToArray());
            }
            File.AppendAllText("../../scores.txt", toWrite);
        }

        public void createFromLine(string line)
        {
            string[] players = new string[4];
            int index = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != ';')
                {
                    players[index] += line[i];
                }
                else
                {
                    i++;
                    index++;
                }
            }
            this.Name = players[0];
            this.Moves = int.Parse(players[1]);
            this.Time= players[2];
            this.Points = int.Parse(players[3]);
        }
    }
}
