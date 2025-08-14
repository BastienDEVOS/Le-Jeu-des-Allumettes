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

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.Bounds.Width < 1946 || Screen.PrimaryScreen.Bounds.Height < 1315)
            {
                MessageBox.Show("Votre résolution d'écran est trop faile, le jeu ne pourra pas s'afficher correctement. \nSi vous voulez pouvoir jouer aller dans les paramètres puis Système > écran, changer la votre resolution d'écran actuel par 2880x1800 puis relancer le jeu ", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            string fxPath = Path.Combine(Application.StartupPath, "Ressources", "allumage d'allumette.wav");

            using (SoundPlayer fxPlayer = new SoundPlayer(fxPath))
            {
                fxPlayer.PlaySync();
            }

            string musicPath = Path.Combine(Application.StartupPath, "Ressources", "background sound.mp3");
            musicReader = new AudioFileReader(musicPath);
            musicReader.Volume = AudioManager.MusicVolume;

            var loop = new LoopStream(musicReader);
            musicPlayer = new WaveOutEvent();
            musicPlayer.Init(loop);
            musicPlayer.Play();
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

        private void brnRègles_Click(object sender, EventArgs e)
        {
            frmRègles FrmRègles = new frmRègles();
            FrmRègles.Show();
        }

        private void btnParamètres_Click(object sender, EventArgs e)
        {
            frmParamètres FrmParamètres = new frmParamètres();
            FrmParamètres.Show();
        }
    }
}