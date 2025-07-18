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
            // Lecture du son d'allumette (WAV)
            string fxPath = Path.Combine(Application.StartupPath, "Ressources", "allumage d'allumette.wav");

            using (SoundPlayer fxPlayer = new SoundPlayer(fxPath))
            {
                fxPlayer.PlaySync(); // Joue le son et bloque jusqu’à la fin
            }

            // Lecture de la musique d’ambiance (MP3, en boucle)
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