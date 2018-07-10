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
        public bool higher;
        public int edit;

        private void frmDialog_Load(object sender, EventArgs e)
        {
            txtName.MaxLength = 8;
            // Me fijo si todavía no se lleno el top ten.
            int i = File.ReadAllLines("../../scores.txt").Count();
            if (i < 10) { 
                // Si todavía hay lugares en el highscore, puede agregarse.
                lblWin.Text = "¡Ganaste en " + time + " minutos y " + moves + " movimientos!. Podés guardar tu partida así aparecera en el highscore.";
            }
            else
            {
                // Veo si el puntaje obtenido supera a alguno del highscore.
                higher = false;
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
                int lowest = pList.Min(a => a.Points);
                if(int.Parse(points) > lowest)
                {
                    lblWin.Text = "¡Ganaste en " + time + " minutos y en " + moves + " movimientos!. ¡Lo hiciste tan bien, que entraste al top ten!. Podrás guardar tu partida si asi lo deseas.";
                    edit = pList.FindIndex(a => a.Points == lowest);
                    higher = true;
                }
                else
                {
                    lblWin.Text = "¡Ganaste en " + time + " minutos y en " + moves + " movimientos!. Pero no pudiste entrar al top ten. ¡Seguí intentandolo!.";
                    btnOk.Visible = false;
                    txtName.Visible = false;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "") {
                Player winner = new Player(txtName.Text.Trim(), time, int.Parse(moves), int.Parse(points));
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
    }

}