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
    public partial class frmTroll : Form
    {
        public frmTroll()
        {
            InitializeComponent();
        }

        int clickAttempts = 0;
        bool canClickToClose = false;
        Random rand = new Random();

        private void frmTroll_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void btnTroll_MouseMove(object sender, MouseEventArgs e)
        {
            if (canClickToClose) return;

            clickAttempts++;

            if (clickAttempts >= 10)
            {
                lblGG.Location = new Point(btnTroll.Left, btnTroll.Bottom + 10);
                lblGG.Visible = true;
                canClickToClose = true;
                return;
            }

            int maxX = this.ClientSize.Width - btnTroll.Width;
            int maxY = this.ClientSize.Height - btnTroll.Height;

            int newX = rand.Next(maxX);
            int newY = rand.Next(maxY);

            btnTroll.Location = new Point(newX, newY);
        }

        private void btnTroll_Click(object sender, EventArgs e)
        {
            if (canClickToClose)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Non non non, bien essayé… mais t'es coincé ici avec moi tant que t'auras pas réussi à appuyer sur le bouton 😈", "Nice try", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTroll_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClickToClose)
            {
                e.Cancel = true;
                MessageBox.Show("Non non non, bien essayé… mais t'es coincé ici avec moi tant que t'auras pas réussi à appuyer sur le bouton 😈", "Nice try", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTroll_Deactivate(object sender, EventArgs e)
        {
            if (!canClickToClose)
            {
                MessageBox.Show("Non non non, bien essayé… mais t'es coincé ici avec moi tant que t'auras pas réussi à appuyer sur le bouton 😈", "Nice try", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
