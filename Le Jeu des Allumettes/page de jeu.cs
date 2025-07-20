using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Jeu_des_Allumettes
{
    public partial class frmJeu : Form
    {

        private string pseudoJ1;
        private string pseudoJ2;
        private int adversaire;
        private int niveauIA;
        private int nbAllumettes;
        private int aQuiLeTour;
        int NbAllumettesAEnlever = 0;

        public frmJeu(string pseudoJ1, string pseudoJ2, int adversaire, int niveauIA, int nbAllumettes, int aQuiLeTour)
        {
            InitializeComponent();

            this.pseudoJ1 = pseudoJ1;
            this.pseudoJ2 = pseudoJ2;
            this.adversaire = adversaire;
            this.niveauIA = niveauIA;
            this.nbAllumettes = nbAllumettes;
            this.aQuiLeTour = aQuiLeTour;
        }


        private void CenterLabelInFlow()
        {
            int targetLeftMargin = 810 - lblTitrePage.Width / 2;

            lblTitrePage.Margin = new Padding(targetLeftMargin, lblTitrePage.Margin.Top, lblTitrePage.Margin.Right, lblTitrePage.Margin.Bottom);
        }

        private void frmJeu_Load(object sender, EventArgs e)
        {
            if (nbAllumettes <= 3)
            {
                btn3.Enabled = false;
                btn3.BackColor =  Color.FromArgb(237, 237, 237);
                btn3.ForeColor = Color.FromArgb(217, 217, 217);
                btn3.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 150);

                if (nbAllumettes <= 2)
                {
                    btn2.Enabled = false;
                    btn2.BackColor = Color.FromArgb(237, 237, 237);
                    btn2.ForeColor = Color.FromArgb(217, 217, 217);
                    btn2.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 150);
                }
            }

            lblTest.Text = "Pseudo du joueur 1 : " + pseudoJ1 + "\nPseudo du joueur 2 : " + pseudoJ2 + "\nAdversaire : " + adversaire + "\nNiveau de l'IA : " + niveauIA + "\nQui commence : " + aQuiLeTour + "\nNombre d'allumettes : " + nbAllumettes;

            if (aQuiLeTour % 2 == 0)
            {
                lblTitrePage.Text = "C'EST AU TOUR DE " + pseudoJ1;
            }
            else
            {
                if (adversaire == 1)
                {
                    lblTitrePage.Text = "C'EST AU TOUR DE " + pseudoJ2;
                }
                else
                {
                    lblTitrePage.Text = "C'EST AU TOUR DE L'IA";
                }
            }

            CenterLabelInFlow();

            lblNbAllumettesRestant.Text = "Il reste " + nbAllumettes + " allumettes";

            for (int i = 0; i < nbAllumettes; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = 200;
                pb.Height = 400;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = Image.FromFile("Ressources/allumette.png");
                pb.Margin = new Padding(5);

                flpAffichageAllumettes.Controls.Add(pb);
            }
        }

        private void picEngrenage_Click(object sender, EventArgs e)
        {
            frmParamètres FrmParamètres = new frmParamètres();
            FrmParamètres.Show();
        }

        private void picInterogation_Click(object sender, EventArgs e)
        {
            frmRègles FrmRègles = new frmRègles();
            FrmRègles.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = btnJouer.BackColor = Color.FromArgb(214, 73, 38);
            btn2.BackColor = btn3.BackColor = Color.FromArgb(255, 255, 255);
            btnJouer.Enabled = true;

            NbAllumettesAEnlever = 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = btnJouer.BackColor = Color.FromArgb(214, 73, 38);
            btn1.BackColor = btn3.BackColor = Color.FromArgb(255, 255, 255);
            btnJouer.Enabled = true;

            NbAllumettesAEnlever = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = btnJouer.BackColor = Color.FromArgb(214, 73, 38);
            btn1.BackColor = btn2.BackColor = Color.FromArgb(255, 255, 255);
            btnJouer.Enabled = true;

            NbAllumettesAEnlever = 3;
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            aQuiLeTour++;
            nbAllumettes -= NbAllumettesAEnlever;

            if (nbAllumettes <= 0)
            {
                MessageBox.Show("Le jeu est terminé ! " + (aQuiLeTour % 2 == 0 ? pseudoJ1 : pseudoJ2) + " a gagné !", "Fin du jeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            frmJeu frmJeu = new frmJeu(pseudoJ1, pseudoJ2, adversaire, niveauIA, nbAllumettes, aQuiLeTour);
            frmJeu.Show();

            this.Close();
        }
    }
}