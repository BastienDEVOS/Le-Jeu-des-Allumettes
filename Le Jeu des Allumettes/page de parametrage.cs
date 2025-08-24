using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Jeu_des_Allumettes
{
    public partial class frmParametrage : Form
    {
        public frmParametrage()
        {
            InitializeComponent();
        }

        private bool retourClique = false;
        string pseudoJ1 = "Joueur 1";
        string pseudoJ2 = "Joueur 2";
        int Adversaire = 1;
        int NiveauIA = 1;
        int NbAllumettes = 0;
        int AQuiLetour = 0;

        private void txtPseudoJ1_TextChanged(object sender, EventArgs e)
        {
            btnStartJ1.Text = txtPseudoJ1.Text;
            pseudoJ1 = txtPseudoJ1.Text;
        }

        private void txtPseudoJ1_Leave(object sender, EventArgs e)
        {
            if (btnStartJ1.Text == "")
            {
                btnStartJ1.Text = "Joueur 1";
                pseudoJ1 = "Joueur 1";
            }
        }

        private void txtPseudoJ2_TextChanged(object sender, EventArgs e)
        {
            btnStartAutre.Text = txtPseudoJ2.Text;
            btn2Joueur.Text = txtPseudoJ2.Text;
            pseudoJ2 = txtPseudoJ2.Text;
        }

        private void txtPseudoJ2_Leave(object sender, EventArgs e)
        {
            if (btnStartAutre.Text == "")
            {
                btnStartAutre.Text = "Joueur 2";
                btn2Joueur.Text = "Joueur 2";
                pseudoJ2 = "Joueur 2";
            }
        }

        private void btnIA_Click(object sender, EventArgs e)
        {
            btnIA.BackColor = Color.FromArgb(214, 73, 38);
            btn2Joueur.BackColor = Color.FromArgb(255, 255, 255);

            btnNaïf.Enabled = btnConfirmé.Enabled = btnExpert.Enabled = true;
            btnNaïf.BackColor = Color.FromArgb(214, 73, 38);
            btnConfirmé.BackColor = btnExpert.BackColor = Color.FromArgb(237, 237, 237);
            btnNaïf.ForeColor = btnConfirmé.ForeColor = btnExpert.ForeColor = lblNiveauIA.ForeColor = Color.FromArgb(31, 41, 49);
            btnNaïf.FlatAppearance.BorderColor = btnConfirmé.FlatAppearance.BorderColor = btnExpert.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);

            lblPseudoJ2.ForeColor = Color.FromArgb(217, 217, 217);
            txtPseudoJ2.BackColor = Color.FromArgb(237, 237, 237);
            pnlContourPseudoJ2.BackColor = Color.FromArgb(150, 150, 150);
            txtPseudoJ2.Enabled = false;

            btnStartAutre.Text = "IA";

            Adversaire = 2;
            pseudoJ2 = "IA";
        }

        private void btn2Joueur_Click(object sender, EventArgs e)
        {
            btn2Joueur.BackColor = Color.FromArgb(214, 73, 38);
            btnIA.BackColor = Color.FromArgb(255, 255, 255);

            btnNaïf.Enabled = btnConfirmé.Enabled = btnExpert.Enabled = false;
            btnNaïf.BackColor = btnConfirmé.BackColor = btnExpert.BackColor = Color.FromArgb(237, 237, 237);
            btnNaïf.ForeColor = btnConfirmé.ForeColor = btnExpert.ForeColor = lblNiveauIA.ForeColor = Color.FromArgb(217, 217, 217);
            btnNaïf.FlatAppearance.BorderColor = btnConfirmé.FlatAppearance.BorderColor = btnExpert.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 150);

            lblPseudoJ2.ForeColor = Color.FromArgb(35, 41, 49);
            txtPseudoJ2.BackColor = Color.White;
            pnlContourPseudoJ2.BackColor = Color.FromArgb(106, 45, 20);
            txtPseudoJ2.Enabled = true;

            if (txtPseudoJ2.Text == "")
            {
                btnStartAutre.Text = "Joueur 2";
                pseudoJ2 = "Joueur 2";
            }
            else
            {
                btnStartAutre.Text = txtPseudoJ2.Text;
                pseudoJ2 = txtPseudoJ2.Text;
            }

            Adversaire = 1;
        }

        private void btnNaïf_Click(object sender, EventArgs e)
        {
            btnNaïf.BackColor = Color.FromArgb(214, 73, 38);
            btnConfirmé.BackColor = btnExpert.BackColor = Color.FromArgb(237, 237, 237);

            NiveauIA = 1;
        }

        private void btnConfirmé_Click(object sender, EventArgs e)
        {
            btnConfirmé.BackColor = Color.FromArgb(214, 73, 38);
            btnNaïf.BackColor = btnExpert.BackColor = Color.FromArgb(237, 237, 237);

            NiveauIA = 2;
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            btnExpert.BackColor = Color.FromArgb(214, 73, 38);
            btnNaïf.BackColor = btnConfirmé.BackColor = Color.FromArgb(237, 237, 237);

            NiveauIA = 3;
        }

        private void btnStartJ1_Click(object sender, EventArgs e)
        {
            btnStartJ1.BackColor = Color.FromArgb(214, 73, 38);
            btnStartAutre.BackColor = Color.FromArgb(237, 237, 237);

            AQuiLetour = 0;
        }

        private void btnStartAutre_Click(object sender, EventArgs e)
        {
            btnStartAutre.BackColor = Color.FromArgb(214, 73, 38);
            btnStartJ1.BackColor = Color.FromArgb(237, 237, 237);

            AQuiLetour = 1;
        }

        private void nupNbAllumettes_ValueChanged(object sender, EventArgs e)
        {
            if (nupNbAllumettes.Value < 10)
            {
                MessageBox.Show("Le nombre d'allumettes ne doit pas être inférieur à 10.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nupNbAllumettes.Value = 10;
            }
            else if (nupNbAllumettes.Value > 30)
            {
                MessageBox.Show("Le nombre d'allumettes ne doit pas être supérieur à 30.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nupNbAllumettes.Value = 30;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            retourClique = true;
            this.Close();
        }

        private void frmParametres_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!retourClique && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            if (txtPseudoJ1.Text != "")
            {
                pseudoJ1 = txtPseudoJ1.Text;
            }

            if (txtPseudoJ2.Text != "" && Adversaire == 1)
            {
                pseudoJ2 = txtPseudoJ2.Text;
            }

            NbAllumettes = (int)nupNbAllumettes.Value;

            frmJeu FrmJeu = new frmJeu(pseudoJ1, pseudoJ2, Adversaire, NiveauIA, NbAllumettes, AQuiLetour);
            FrmJeu.Show();
        }
    }
}
