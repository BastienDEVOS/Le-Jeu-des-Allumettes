using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace Le_Jeu_des_Allumettes
{
    public partial class frmAcceuil : Form
    {
        private IWavePlayer musicPlayer;
        private AudioFileReader musicReader;

        public frmAcceuil()
        {
            InitializeComponent();
            this.Load += frmAcceuil_Load;
            this.FormClosed += frmAcceuil_FormClosed;
        }

        private async void frmAcceuil_Load(object sender, EventArgs e)
        {
            string matchPath = Path.Combine(Application.StartupPath, "Ressources", "allumage d'allumette.wav");
            using (var matchPlayer = new WaveOutEvent())
            using (var matchReader = new AudioFileReader(matchPath))
            {
                matchPlayer.Init(matchReader);
                matchPlayer.Play();
                while (matchPlayer.PlaybackState == PlaybackState.Playing)
                    await Task.Delay(100);
            }

            string musicPath = Path.Combine(Application.StartupPath, "Ressources", "background sound.mp3");
            musicReader = new AudioFileReader(musicPath);
            musicReader.Volume = 0.1f;

            var loopStream = new LoopStream(musicReader);
            musicPlayer = new WaveOutEvent();
            musicPlayer.Init(loopStream);
            musicPlayer.Play();
        }

        private void frmAcceuil_FormClosed(object sender, FormClosedEventArgs e)
        {
            musicPlayer?.Stop();
            musicPlayer?.Dispose();
            musicReader?.Dispose();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {

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
