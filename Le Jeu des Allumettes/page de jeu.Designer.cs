namespace Le_Jeu_des_Allumettes
{
    partial class frmJeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJeu));
            flpHautPage = new FlowLayoutPanel();
            picLogoHaut = new PictureBox();
            lblTitrePage = new Label();
            picEngrenage = new PictureBox();
            picInterogation = new PictureBox();
            lblNbAllumettesRestant = new Label();
            flpAffichageAllumettes = new FlowLayoutPanel();
            lblCombientAllumettes = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnJouer = new Button();
            lblTest = new Label();
            flpHautPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEngrenage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInterogation).BeginInit();
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
            flpHautPage.TabIndex = 2;
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
            lblTitrePage.Location = new Point(520, 22);
            lblTitrePage.Margin = new Padding(370, 22, 3, 0);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new Size(880, 106);
            lblTitrePage.TabIndex = 1;
            lblTitrePage.Text = "C'EST AU TOUR DE ...";
            // 
            // picEngrenage
            // 
            picEngrenage.Image = (Image)resources.GetObject("picEngrenage.Image");
            picEngrenage.Location = new Point(40, 190);
            picEngrenage.Name = "picEngrenage";
            picEngrenage.Size = new Size(100, 100);
            picEngrenage.SizeMode = PictureBoxSizeMode.Zoom;
            picEngrenage.TabIndex = 3;
            picEngrenage.TabStop = false;
            picEngrenage.Click += picEngrenage_Click;
            // 
            // picInterogation
            // 
            picInterogation.Image = (Image)resources.GetObject("picInterogation.Image");
            picInterogation.Location = new Point(1780, 190);
            picInterogation.Name = "picInterogation";
            picInterogation.Size = new Size(100, 100);
            picInterogation.SizeMode = PictureBoxSizeMode.Zoom;
            picInterogation.TabIndex = 4;
            picInterogation.TabStop = false;
            picInterogation.Click += picInterogation_Click;
            // 
            // lblNbAllumettesRestant
            // 
            lblNbAllumettesRestant.AutoSize = true;
            lblNbAllumettesRestant.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNbAllumettesRestant.ForeColor = Color.FromArgb(35, 41, 49);
            lblNbAllumettesRestant.Location = new Point(677, 219);
            lblNbAllumettesRestant.Name = "lblNbAllumettesRestant";
            lblNbAllumettesRestant.Size = new Size(566, 71);
            lblNbAllumettesRestant.TabIndex = 5;
            lblNbAllumettesRestant.Text = "Il reste ... allumettes";
            // 
            // flpAffichageAllumettes
            // 
            flpAffichageAllumettes.Location = new Point(40, 330);
            flpAffichageAllumettes.Name = "flpAffichageAllumettes";
            flpAffichageAllumettes.Size = new Size(1840, 400);
            flpAffichageAllumettes.TabIndex = 6;
            // 
            // lblCombientAllumettes
            // 
            lblCombientAllumettes.AutoSize = true;
            lblCombientAllumettes.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCombientAllumettes.ForeColor = Color.FromArgb(35, 41, 49);
            lblCombientAllumettes.Location = new Point(382, 807);
            lblCombientAllumettes.Name = "lblCombientAllumettes";
            lblCombientAllumettes.Size = new Size(1157, 71);
            lblCombientAllumettes.TabIndex = 7;
            lblCombientAllumettes.Text = "Combient d’allumettes voulez vous enlever";
            // 
            // btn1
            // 
            btn1.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btn1.FlatAppearance.BorderSize = 10;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.FromArgb(35, 41, 49);
            btn1.Location = new Point(45, 927);
            btn1.Name = "btn1";
            btn1.Size = new Size(580, 100);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btn2.FlatAppearance.BorderSize = 10;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.FromArgb(35, 41, 49);
            btn2.Location = new Point(670, 927);
            btn2.Name = "btn2";
            btn2.Size = new Size(580, 100);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btn3.FlatAppearance.BorderSize = 10;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.FromArgb(35, 41, 49);
            btn3.Location = new Point(1295, 927);
            btn3.Name = "btn3";
            btn3.Size = new Size(580, 100);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnJouer
            // 
            btnJouer.BackColor = Color.FromArgb(237, 237, 237);
            btnJouer.Enabled = false;
            btnJouer.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnJouer.FlatAppearance.BorderSize = 10;
            btnJouer.FlatStyle = FlatStyle.Flat;
            btnJouer.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            btnJouer.ForeColor = Color.FromArgb(35, 41, 49);
            btnJouer.Location = new Point(610, 1077);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(700, 100);
            btnJouer.TabIndex = 12;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(173, 190);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(145, 32);
            lblTest.TabIndex = 0;
            lblTest.Text = "label de test";
            // 
            // frmJeu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(1920, 1244);
            Controls.Add(lblTest);
            Controls.Add(btnJouer);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblCombientAllumettes);
            Controls.Add(flpAffichageAllumettes);
            Controls.Add(lblNbAllumettesRestant);
            Controls.Add(picInterogation);
            Controls.Add(picEngrenage);
            Controls.Add(flpHautPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1946, 1315);
            MinimizeBox = false;
            MinimumSize = new Size(1946, 1315);
            Name = "frmJeu";
            Text = "page de jeu";
            Load += frmJeu_Load;
            flpHautPage.ResumeLayout(false);
            flpHautPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEngrenage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInterogation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpHautPage;
        private PictureBox picLogoHaut;
        private Label lblTitrePage;
        private PictureBox picEngrenage;
        private PictureBox picInterogation;
        private Label lblNbAllumettesRestant;
        private FlowLayoutPanel flpAffichageAllumettes;
        private Label lblCombientAllumettes;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnJouer;
        private Label lblTest;
    }
}