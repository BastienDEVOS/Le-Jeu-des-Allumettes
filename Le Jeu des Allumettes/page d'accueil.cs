using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Le_Jeu_des_Allumettes
{
    public partial class frmAccueil : Form
    {
        public static WaveOutEvent musicPlayer;
        public static AudioFileReader musicReader;

        public frmAccueil()
        {
            InitializeComponent();
        }

        private async void frmAccueil_Load(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.Bounds.Width < 1946 || Screen.PrimaryScreen.Bounds.Height < 1315)
            {
                MessageBox.Show("Votre r�solution d'�cran est trop faile, le jeu ne pourra pas s'afficher correctement. \nSi vous voulez pouvoir jouer aller dans les param�tres puis Syst�me > �cran, changer la votre resolution d'�cran actuel par 2880x1800 puis relancer le jeu ", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            // Effet d�allumage
            SoundManager.PlayEffect("Ressources/allumage d'allumette.wav");

            // Attendre avant de lancer la musique
            await Task.Delay(3000);

            // Musique de fond en boucle
            SoundManager.PlayMusic("Ressources/background sound.mp3");
        }

        private void frmAccueil_FormClosed(object sender, FormClosedEventArgs e)
        {
            musicPlayer?.Stop();
            musicPlayer?.Dispose();
            musicReader?.Dispose();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            frmParametrage FrmParametrage = new frmParametrage();
            FrmParametrage.Show();

            this.Hide();

            FrmParametrage.FormClosed += (s, args) => this.Show();
            FrmParametrage.Show();
        }

        private void brnR�gles_Click(object sender, EventArgs e)
        {
            frmR�gles FrmR�gles = new frmR�gles();
            FrmR�gles.Show();
        }

        private void btnParam�tres_Click(object sender, EventArgs e)
        {
            frmParam�tres FrmParam�tres = new frmParam�tres();
            FrmParam�tres.Show();
        }
    }
}