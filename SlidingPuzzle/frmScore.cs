using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        List<Player> pList = new List<Player>();

        private void frmScore_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tlpScore.ColumnCount; i++)
            {
                Label l = new Label();
                l.Size = tlpScore.Size;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Font = new Font("Arial", 16.0F);
                switch (i)
                {
                    case 0:
                        l.Text = "Nombre";
                        l.Click += new EventHandler(lblName_Click);
                        break;
                    case 1:
                        l.Text = "Movimientos";
                        l.Click += new EventHandler(lblMoves_Click);
                        break;
                    case 2:
                        l.Text = "Tiempo";
                        l.Click += new EventHandler(lblTime_Click);
                        break;
                    case 3:
                        l.Text = "Puntos";
                        l.Click += new EventHandler(lblPoints_Click);
                        break;
                }
                this.Controls.Add(l);
                tlpScore.Controls.Add(l, i, 0);
            }
            using (StreamReader sr = File.OpenText("../../scores.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Player p = new Player();
                    p.createFromLine(line);
                    pList.Add(p);
                }
            }
            pList.Sort((b, a) => a.Points.CompareTo(b.Points));
            displayScores();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            pList.Sort((a, b) => a.Name.CompareTo(b.Name));
            displayScores();
        }

        private void lblMoves_Click(object sender, EventArgs e)
        {
            pList.Sort((a, b) => a.Moves.CompareTo(b.Moves));
            displayScores();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            pList.Sort((a, b) => a.Time.CompareTo(b.Time));
            displayScores();
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {
            pList.Sort((b, a) => a.Points.CompareTo(b.Points));
            displayScores();
        }

        private void displayScores()
        {
            for (int i = 0; i < tlpScore.ColumnCount; i++)
            {
                for (int j = 0; j < pList.Count; j++)
                {
                    tlpScore.Controls.Remove(tlpScore.GetControlFromPosition(i, j +1));
                    Label l = new Label();
                    l.Size = tlpScore.Size;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    l.Font = new Font("Arial", 12.0F);
                    switch (i)
                    {
                        case 0:
                            l.Text = pList[j].Name;
                            break;
                        case 1:
                            l.Text = pList[j].Moves.ToString();
                            break;
                        case 2:
                            l.Text = pList[j].Time;
                            break;
                        case 3:
                            l.Text = pList[j].Points.ToString();
                            break;
                    }
                    tlpScore.Controls.Add(l, i, j + 1);
                }
            }
        }
    }
}
