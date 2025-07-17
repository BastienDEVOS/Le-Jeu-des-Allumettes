namespace Le_Jeu_des_Allumettes
{
    partial class frmParametrage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrage));
            flpHautPage = new FlowLayoutPanel();
            picLogoHaut = new PictureBox();
            lblTitrePage = new Label();
            txtPseudoJ1 = new TextBox();
            btn2Joueur = new Button();
            btnIA = new Button();
            btnNaïf = new Button();
            btnConfirmé = new Button();
            btnExpert = new Button();
            btnStartAutre = new Button();
            btnStartJ1 = new Button();
            btnJouer = new Button();
            nupNbAllumettes = new NumericUpDown();
            lblPseudoJ1 = new Label();
            lblAdversaire = new Label();
            lblNbAllumettes = new Label();
            lblPseudoJ2 = new Label();
            lblNiveauIA = new Label();
            lblQuiCommence = new Label();
            pnlContourPseudoJ1 = new Panel();
            pnlContourPseudoJ2 = new Panel();
            txtPseudoJ2 = new TextBox();
            pnlContoutNUP = new Panel();
            pnlBarreCentral = new Panel();
            flpHautPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupNbAllumettes).BeginInit();
            pnlContourPseudoJ1.SuspendLayout();
            pnlContourPseudoJ2.SuspendLayout();
            pnlContoutNUP.SuspendLayout();
            SuspendLayout();
            // 
            // flpHautPage
            // 
            flpHautPage.BackColor = Color.FromArgb(253, 175, 65);
            flpHautPage.Controls.Add(picLogoHaut);
            flpHautPage.Controls.Add(lblTitrePage);
            flpHautPage.Location = new Point(0, 0);
            flpHautPage.Name = "flpHautPage";
            flpHautPage.Size = new Size(1920, 150);
            flpHautPage.TabIndex = 1;
            // 
            // picLogoHaut
            // 
            picLogoHaut.Image = (Image)resources.GetObject("picLogoHaut.Image");
            picLogoHaut.Location = new Point(0, 0);
            picLogoHaut.Margin = new Padding(0);
            picLogoHaut.Name = "picLogoHaut";
            picLogoHaut.Size = new Size(150, 150);
            picLogoHaut.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoHaut.TabIndex = 0;
            picLogoHaut.TabStop = false;
            // 
            // lblTitrePage
            // 
            lblTitrePage.AutoSize = true;
            lblTitrePage.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            lblTitrePage.ForeColor = Color.FromArgb(35, 41, 49);
            lblTitrePage.Location = new Point(472, 22);
            lblTitrePage.Margin = new Padding(322, 22, 3, 0);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new Size(975, 106);
            lblTitrePage.TabIndex = 1;
            lblTitrePage.Text = "PARAMÈTRAGE PARTIE";
            // 
            // txtPseudoJ1
            // 
            txtPseudoJ1.BackColor = Color.White;
            txtPseudoJ1.BorderStyle = BorderStyle.None;
            txtPseudoJ1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            txtPseudoJ1.ForeColor = Color.FromArgb(35, 41, 49);
            txtPseudoJ1.Location = new Point(4, 4);
            txtPseudoJ1.Margin = new Padding(0);
            txtPseudoJ1.MaximumSize = new Size(790, 90);
            txtPseudoJ1.MinimumSize = new Size(790, 90);
            txtPseudoJ1.Name = "txtPseudoJ1";
            txtPseudoJ1.PlaceholderText = "Joueur 1";
            txtPseudoJ1.Size = new Size(790, 90);
            txtPseudoJ1.TabIndex = 2;
            // 
            // btn2Joueur
            // 
            btn2Joueur.BackColor = Color.FromArgb(214, 73, 38);
            btn2Joueur.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btn2Joueur.FlatAppearance.BorderSize = 10;
            btn2Joueur.FlatStyle = FlatStyle.Flat;
            btn2Joueur.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn2Joueur.ForeColor = Color.FromArgb(35, 41, 49);
            btn2Joueur.Location = new Point(80, 620);
            btn2Joueur.Name = "btn2Joueur";
            btn2Joueur.Size = new Size(375, 100);
            btn2Joueur.TabIndex = 4;
            btn2Joueur.Text = "Joueur 2";
            btn2Joueur.UseVisualStyleBackColor = false;
            // 
            // btnIA
            // 
            btnIA.BackColor = Color.FromArgb(214, 73, 38);
            btnIA.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnIA.FlatAppearance.BorderSize = 10;
            btnIA.FlatStyle = FlatStyle.Flat;
            btnIA.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnIA.ForeColor = Color.FromArgb(35, 41, 49);
            btnIA.Location = new Point(505, 620);
            btnIA.Name = "btnIA";
            btnIA.Size = new Size(375, 100);
            btnIA.TabIndex = 5;
            btnIA.Text = "IA";
            btnIA.UseVisualStyleBackColor = false;
            // 
            // btnNaïf
            // 
            btnNaïf.BackColor = Color.FromArgb(214, 73, 38);
            btnNaïf.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnNaïf.FlatAppearance.BorderSize = 10;
            btnNaïf.FlatStyle = FlatStyle.Flat;
            btnNaïf.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnNaïf.ForeColor = Color.FromArgb(35, 41, 49);
            btnNaïf.Location = new Point(1040, 620);
            btnNaïf.Name = "btnNaïf";
            btnNaïf.Size = new Size(250, 100);
            btnNaïf.TabIndex = 6;
            btnNaïf.Text = "Naïf";
            btnNaïf.UseVisualStyleBackColor = false;
            // 
            // btnConfirmé
            // 
            btnConfirmé.BackColor = Color.FromArgb(214, 73, 38);
            btnConfirmé.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnConfirmé.FlatAppearance.BorderSize = 10;
            btnConfirmé.FlatStyle = FlatStyle.Flat;
            btnConfirmé.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnConfirmé.ForeColor = Color.FromArgb(35, 41, 49);
            btnConfirmé.Location = new Point(1315, 620);
            btnConfirmé.Name = "btnConfirmé";
            btnConfirmé.Size = new Size(250, 100);
            btnConfirmé.TabIndex = 7;
            btnConfirmé.Text = "Confirmé";
            btnConfirmé.UseVisualStyleBackColor = false;
            // 
            // btnExpert
            // 
            btnExpert.BackColor = Color.FromArgb(214, 73, 38);
            btnExpert.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnExpert.FlatAppearance.BorderSize = 10;
            btnExpert.FlatStyle = FlatStyle.Flat;
            btnExpert.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnExpert.ForeColor = Color.FromArgb(35, 41, 49);
            btnExpert.Location = new Point(1590, 620);
            btnExpert.Name = "btnExpert";
            btnExpert.Size = new Size(250, 100);
            btnExpert.TabIndex = 8;
            btnExpert.Text = "Expert";
            btnExpert.UseVisualStyleBackColor = false;
            // 
            // btnStartAutre
            // 
            btnStartAutre.BackColor = Color.FromArgb(214, 73, 38);
            btnStartAutre.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnStartAutre.FlatAppearance.BorderSize = 10;
            btnStartAutre.FlatStyle = FlatStyle.Flat;
            btnStartAutre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnStartAutre.ForeColor = Color.FromArgb(35, 41, 49);
            btnStartAutre.Location = new Point(1465, 870);
            btnStartAutre.Name = "btnStartAutre";
            btnStartAutre.Size = new Size(375, 100);
            btnStartAutre.TabIndex = 9;
            btnStartAutre.Text = "Joueur 2";
            btnStartAutre.UseVisualStyleBackColor = false;
            // 
            // btnStartJ1
            // 
            btnStartJ1.BackColor = Color.FromArgb(214, 73, 38);
            btnStartJ1.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnStartJ1.FlatAppearance.BorderSize = 10;
            btnStartJ1.FlatStyle = FlatStyle.Flat;
            btnStartJ1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnStartJ1.ForeColor = Color.FromArgb(35, 41, 49);
            btnStartJ1.Location = new Point(1040, 870);
            btnStartJ1.Name = "btnStartJ1";
            btnStartJ1.Size = new Size(375, 100);
            btnStartJ1.TabIndex = 10;
            btnStartJ1.Text = "Joueur 1";
            btnStartJ1.UseVisualStyleBackColor = false;
            // 
            // btnJouer
            // 
            btnJouer.BackColor = Color.FromArgb(214, 73, 38);
            btnJouer.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnJouer.FlatAppearance.BorderSize = 10;
            btnJouer.FlatStyle = FlatStyle.Flat;
            btnJouer.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            btnJouer.ForeColor = Color.FromArgb(35, 41, 49);
            btnJouer.Location = new Point(510, 1100);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(900, 100);
            btnJouer.TabIndex = 11;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
            // 
            // nupNbAllumettes
            // 
            nupNbAllumettes.Font = new Font("Segoe UI Black", 25.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nupNbAllumettes.ForeColor = Color.FromArgb(35, 41, 49);
            nupNbAllumettes.Location = new Point(4, 4);
            nupNbAllumettes.Name = "nupNbAllumettes";
            nupNbAllumettes.Size = new Size(800, 98);
            nupNbAllumettes.TabIndex = 12;
            nupNbAllumettes.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblPseudoJ1
            // 
            lblPseudoJ1.AutoSize = true;
            lblPseudoJ1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblPseudoJ1.ForeColor = Color.FromArgb(35, 41, 49);
            lblPseudoJ1.Location = new Point(80, 325);
            lblPseudoJ1.Name = "lblPseudoJ1";
            lblPseudoJ1.Size = new Size(326, 45);
            lblPseudoJ1.TabIndex = 13;
            lblPseudoJ1.Text = "Pseudo du Joueur 1";
            // 
            // lblAdversaire
            // 
            lblAdversaire.AutoSize = true;
            lblAdversaire.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblAdversaire.ForeColor = Color.FromArgb(35, 41, 49);
            lblAdversaire.Location = new Point(80, 575);
            lblAdversaire.Name = "lblAdversaire";
            lblAdversaire.Size = new Size(446, 45);
            lblAdversaire.TabIndex = 14;
            lblAdversaire.Text = "Qui voulez vous affronter ?";
            // 
            // lblNbAllumettes
            // 
            lblNbAllumettes.AutoSize = true;
            lblNbAllumettes.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblNbAllumettes.ForeColor = Color.FromArgb(35, 41, 49);
            lblNbAllumettes.Location = new Point(80, 825);
            lblNbAllumettes.Name = "lblNbAllumettes";
            lblNbAllumettes.Size = new Size(355, 45);
            lblNbAllumettes.TabIndex = 15;
            lblNbAllumettes.Text = "Nombre d’allumettes";
            // 
            // lblPseudoJ2
            // 
            lblPseudoJ2.AutoSize = true;
            lblPseudoJ2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblPseudoJ2.ForeColor = Color.FromArgb(35, 41, 49);
            lblPseudoJ2.Location = new Point(1040, 325);
            lblPseudoJ2.Name = "lblPseudoJ2";
            lblPseudoJ2.Size = new Size(330, 45);
            lblPseudoJ2.TabIndex = 18;
            lblPseudoJ2.Text = "Pseudo du Joueur 2";
            // 
            // lblNiveauIA
            // 
            lblNiveauIA.AutoSize = true;
            lblNiveauIA.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblNiveauIA.ForeColor = Color.FromArgb(35, 41, 49);
            lblNiveauIA.Location = new Point(1040, 575);
            lblNiveauIA.Name = "lblNiveauIA";
            lblNiveauIA.Size = new Size(447, 45);
            lblNiveauIA.TabIndex = 17;
            lblNiveauIA.Text = "Niveau de difficulté de l'IA";
            // 
            // lblQuiCommence
            // 
            lblQuiCommence.AutoSize = true;
            lblQuiCommence.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblQuiCommence.ForeColor = Color.FromArgb(35, 41, 49);
            lblQuiCommence.Location = new Point(1040, 825);
            lblQuiCommence.Name = "lblQuiCommence";
            lblQuiCommence.Size = new Size(274, 45);
            lblQuiCommence.TabIndex = 16;
            lblQuiCommence.Text = "Qui commence ?";
            // 
            // pnlContourPseudoJ1
            // 
            pnlContourPseudoJ1.BackColor = Color.FromArgb(106, 45, 20);
            pnlContourPseudoJ1.BorderStyle = BorderStyle.FixedSingle;
            pnlContourPseudoJ1.Controls.Add(txtPseudoJ1);
            pnlContourPseudoJ1.Location = new Point(80, 370);
            pnlContourPseudoJ1.Name = "pnlContourPseudoJ1";
            pnlContourPseudoJ1.Size = new Size(800, 100);
            pnlContourPseudoJ1.TabIndex = 19;
            // 
            // pnlContourPseudoJ2
            // 
            pnlContourPseudoJ2.BackColor = Color.FromArgb(106, 45, 20);
            pnlContourPseudoJ2.BorderStyle = BorderStyle.FixedSingle;
            pnlContourPseudoJ2.Controls.Add(txtPseudoJ2);
            pnlContourPseudoJ2.Location = new Point(1040, 370);
            pnlContourPseudoJ2.Name = "pnlContourPseudoJ2";
            pnlContourPseudoJ2.Size = new Size(800, 100);
            pnlContourPseudoJ2.TabIndex = 20;
            // 
            // txtPseudoJ2
            // 
            txtPseudoJ2.BackColor = Color.White;
            txtPseudoJ2.BorderStyle = BorderStyle.None;
            txtPseudoJ2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            txtPseudoJ2.ForeColor = Color.FromArgb(35, 41, 49);
            txtPseudoJ2.Location = new Point(4, 4);
            txtPseudoJ2.Margin = new Padding(0);
            txtPseudoJ2.MaximumSize = new Size(790, 90);
            txtPseudoJ2.MinimumSize = new Size(790, 90);
            txtPseudoJ2.Name = "txtPseudoJ2";
            txtPseudoJ2.PlaceholderText = "Joueur 2";
            txtPseudoJ2.Size = new Size(790, 90);
            txtPseudoJ2.TabIndex = 2;
            // 
            // pnlContoutNUP
            // 
            pnlContoutNUP.BackColor = Color.FromArgb(106, 45, 20);
            pnlContoutNUP.BorderStyle = BorderStyle.FixedSingle;
            pnlContoutNUP.Controls.Add(nupNbAllumettes);
            pnlContoutNUP.Location = new Point(80, 870);
            pnlContoutNUP.Name = "pnlContoutNUP";
            pnlContoutNUP.Size = new Size(810, 110);
            pnlContoutNUP.TabIndex = 21;
            // 
            // pnlBarreCentral
            // 
            pnlBarreCentral.BackColor = Color.FromArgb(106, 45, 20);
            pnlBarreCentral.Location = new Point(960, 250);
            pnlBarreCentral.Name = "pnlBarreCentral";
            pnlBarreCentral.Size = new Size(10, 800);
            pnlBarreCentral.TabIndex = 22;
            // 
            // frmParametrage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1244);
            Controls.Add(pnlBarreCentral);
            Controls.Add(pnlContoutNUP);
            Controls.Add(pnlContourPseudoJ2);
            Controls.Add(pnlContourPseudoJ1);
            Controls.Add(lblPseudoJ2);
            Controls.Add(lblNiveauIA);
            Controls.Add(lblQuiCommence);
            Controls.Add(lblNbAllumettes);
            Controls.Add(lblAdversaire);
            Controls.Add(lblPseudoJ1);
            Controls.Add(btnJouer);
            Controls.Add(btnStartJ1);
            Controls.Add(btnStartAutre);
            Controls.Add(btnExpert);
            Controls.Add(btnConfirmé);
            Controls.Add(btnNaïf);
            Controls.Add(btnIA);
            Controls.Add(btn2Joueur);
            Controls.Add(flpHautPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1946, 1315);
            MinimizeBox = false;
            MinimumSize = new Size(1946, 1315);
            Name = "frmParametrage";
            Text = "page de parametrage";
            flpHautPage.ResumeLayout(false);
            flpHautPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupNbAllumettes).EndInit();
            pnlContourPseudoJ1.ResumeLayout(false);
            pnlContourPseudoJ1.PerformLayout();
            pnlContourPseudoJ2.ResumeLayout(false);
            pnlContourPseudoJ2.PerformLayout();
            pnlContoutNUP.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpHautPage;
        private PictureBox picLogoHaut;
        private Label lblTitrePage;
        private Button btn2Joueur;
        private Button btnIA;
        private Button btnNaïf;
        private Button btnConfirmé;
        private Button btnExpert;
        private Button btnStartAutre;
        private Button btnStartJ1;
        private Button btnJouer;
        private NumericUpDown nupNbAllumettes;
        private Label lblPseudoJ1;
        private Label lblAdversaire;
        private Label lblNbAllumettes;
        private Label lblPseudoJ2;
        private Label lblNiveauIA;
        private Label lblQuiCommence;
        public TextBox txtPseudoJ1;
        private Panel pnlContourPseudoJ1;
        private Panel pnlContourPseudoJ2;
        public TextBox txtPseudoJ2;
        private Panel pnlContoutNUP;
        private Panel pnlBarreCentral;
    }
}