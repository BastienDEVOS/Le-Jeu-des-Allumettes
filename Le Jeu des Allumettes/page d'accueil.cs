using System.Media;

namespace Le_Jeu_des_Allumettes
{
    public partial class frmAcceuil : Form
    {
        public frmAcceuil()
        {
            InitializeComponent();
        }

        private void frmAcceuil_Load(object sender, EventArgs e)
        {
            //SoundPlayer player = new SoundPlayer("Ressources\\allumage d'allumette.wav\\");
            //player.Play();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {

        }

        private void brnRègles_Click(object sender, EventArgs e)
        {
            frmRègles FrmRègles = new frmRègles();
            FrmRègles.Show();
        }
    }
}
