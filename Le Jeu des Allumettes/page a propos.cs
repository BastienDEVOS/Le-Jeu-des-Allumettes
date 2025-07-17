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
    public partial class frmAPropos : Form
    {
        public frmAPropos()
        {
            InitializeComponent();
        }

        private void frmAPropos_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroll_MouseEnter(object sender, EventArgs e)
        {
            btnTroll.BackColor = Color.White;
            btnTroll.ForeColor = Color.Black;
            btnTroll.FlatAppearance.BorderSize = 2;
        }

        private void btnTroll_MouseLeave(object sender, EventArgs e)
        {
            btnTroll.BackColor = this.BackColor;
            btnTroll.ForeColor = this.BackColor;
            btnTroll.FlatAppearance.BorderSize = 0;
        }

        private void btnTroll_Click(object sender, EventArgs e)
        {
            frmTroll FrmTroll = new frmTroll();
            FrmTroll.Show();

            this.Hide();
        }

        private void frmAPropos_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
