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
    public partial class frmDialog : Form
    {
        public frmDialog()
        {
            InitializeComponent();
        }
        public string time;
        public string moves;
        public string points;
        public int mode;
        public bool higher;
        public int edit;
        public string scoreFile;

        private void frmDialog_Load(object sender, EventArgs e)
        {
            btnVolver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            txtName.MaxLength = 8;
            // Me fijo si todavía no se lleno el top ten.
            switch (mode)
            {
                case 3:
                    scoreFile = "../../scores3x3.txt";
                    break;
                case 4:
                    scoreFile = "../../scores4x4.txt";
                    break;
                case 5:
                    scoreFile = "../../scores5x5.txt";
                    break;
                default:
                    scoreFile = "../../scores3x3.txt";
                    break;
            }
            int i = File.ReadAllLines(scoreFile).Count();
            if (i < 10) { 
                // Si todavía hay lugares en el highscore, puede agregarse.
                lblWin.Text = "¡Ganaste en " + time + " minutos y " + moves + " movimientos!. Podrás guardar tu partida si asi lo deseas con tu nombre aquí abajo.";
            }
            else
            {
                // Veo si el puntaje obtenido supera a alguno del highscore.
                higher = false;
                List<Player> pList = new List<Player>();
                using (StreamReader sr = File.OpenText(scoreFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Player p = new Player();
                        p.createFromLine(line);
                        pList.Add(p);
                    }
                }
                int lowest = pList.Min(a => a.Points);
                if(int.Parse(points) > lowest)
                {
                    lblWin.Text = "¡Ganaste en " + time + " minutos y en " + moves + " movimientos! ¡Lo hiciste tan bien, que entraste al top ten! Podrás guardar tu partida si asi lo deseas con tu nombre aquí abajo.";
                    edit = pList.FindIndex(a => a.Points == lowest);
                    higher = true;
                }
                else
                {
                    this.Height = 195;
                    lblWin.Text = "¡Ganaste en " + time + " minutos y en " + moves + " movimientos! Pero no pudiste entrar al top ten. ¡Seguí intentandolo!";
                    btnOk.Enabled = false;
                    txtName.Enabled = false;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "") {
                Player winner = new Player(txtName.Text.Trim(), time, int.Parse(moves), int.Parse(points));
                winner.ScoreFile = scoreFile;
                if (higher)
                {
                    winner.Edit = edit;
                    winner.writeToTxt(true);
                }
                else
                {
                    winner.writeToTxt(false);
                }
                frmScore form = new frmScore();
                form.mode = this.mode;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No ingresó un nombre de jugador", "Jugador");
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.Image = Image.FromFile("../../Images/guardar-h.png");
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.Image = Image.FromFile("../../Images/guardar.png");
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.Image = Image.FromFile("../../Images/back-h.png");
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.Image = Image.FromFile("../../Images/back.png");
        }
    }

}