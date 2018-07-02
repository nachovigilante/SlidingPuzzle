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
        private void frmScore_Load(object sender, EventArgs e)
        {
            List<Player> pList = new List<Player>();
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
            for (int i = 0; i < tlpScore.ColumnCount; i++)
            {
                for (int j = 1; j < tlpScore.RowCount; j++)
                {
                    Label l = new Label();
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    l.Font = new Font("Arial", 16.0F);
                    l.Text = "JAJA";
                    tlpScore.Controls.Add(l, i, j);
                }
            }
        }
    }
}
