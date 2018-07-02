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

        private void frmDialog_Load(object sender, EventArgs e)
        {
            txtName.MaxLength = 8;
            if (new FileInfo("scores.txt").Length > 0) { 
                lblWin.Text = "¡Ganaste en " + time + " segundos y en " + moves + " movimientos. Podés guardar tu partida así aparecera en el highscore.";
                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "") {
                Player winner = new Player(txtName.Text, time, moves, points);
                winner.writeToTxt(false);
            }
            else
            {
                MessageBox.Show("No ingresó un nombre de usuario");
            }
        }
    }

}