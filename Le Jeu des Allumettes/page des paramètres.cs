using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Le_Jeu_des_Allumettes
{
    public partial class frmParamètres : Form
    {
        public frmParamètres()
        {
            InitializeComponent();
        }

        private void frmParamètres_Load(object sender, EventArgs e)
        {
            trbMusic.Minimum = 0;
            trbMusic.Maximum = 8;
            trbEffectsSonore.Minimum = 0;
            trbEffectsSonore.Maximum = 8;

            // Réaffecter la position des TrackBar à partir des valeurs du SoundManager
            trbMusic.Value = (int)(SoundManager.MusicVolume * 8);
            trbEffectsSonore.Value = (int)(SoundManager.EffectsVolume * 8);
        }
        private void trbMusic_Scroll(object sender, EventArgs e)
        {
            SoundManager.MusicVolume = trbMusic.Value / 8f; // 0 → 1
        }

        private void trbEffectsSonore_Scroll(object sender, EventArgs e)
        {
            SoundManager.EffectsVolume = trbEffectsSonore.Value / 8f; // 0 → 1
        }


        private void btnNousContacter_Click(object sender, EventArgs e)
        {
            string email = "bastiendevos.perso@gmail.com";

            string mailto = $"mailto:{email}";

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = mailto,
                UseShellExecute = true
            });
        }

        private void btnAPropos_Click(object sender, EventArgs e)
        {
            frmAPropos FrmAPropos = new frmAPropos();
            FrmAPropos.Show();

            this.Hide();
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/bastien_dvs_159/",
                UseShellExecute = true
            });
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.snapchat.com/add/baba_dvs/",
                UseShellExecute = true
            });
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://x.com/juste17947",
                UseShellExecute = true
            });
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParamètres_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}