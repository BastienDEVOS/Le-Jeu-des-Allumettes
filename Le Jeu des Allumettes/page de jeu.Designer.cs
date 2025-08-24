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
            lblTopMargin = new Label();
            lblCombientAllumettes = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnJouer = new Button();
            lblTest = new Label();
            grpPseudoMessageBox = new GroupBox();
            picInfoIcnon = new PictureBox();
            lblNbAllumetteIA = new Label();
            btnOkPseudoMessageBox = new Button();
            picRetour = new PictureBox();
            flpHautPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEngrenage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInterogation).BeginInit();
            flpAffichageAllumettes.SuspendLayout();
            grpPseudoMessageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInfoIcnon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).BeginInit();
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
            lblNbAllumettesRestant.Location = new Point(702, 219);
            lblNbAllumettesRestant.Name = "lblNbAllumettesRestant";
            lblNbAllumettesRestant.Size = new Size(515, 71);
            lblNbAllumettesRestant.TabIndex = 5;
            lblNbAllumettesRestant.Text = "Il reste 1 allumette";
            // 
            // flpAffichageAllumettes
            // 
            flpAffichageAllumettes.BackColor = Color.FromArgb(237, 237, 237);
            flpAffichageAllumettes.Controls.Add(lblTopMargin);
            flpAffichageAllumettes.Location = new Point(40, 330);
            flpAffichageAllumettes.Name = "flpAffichageAllumettes";
            flpAffichageAllumettes.Size = new Size(1840, 400);
            flpAffichageAllumettes.TabIndex = 6;
            // 
            // lblTopMargin
            // 
            lblTopMargin.BackColor = Color.FromArgb(237, 237, 237);
            lblTopMargin.Location = new Point(0, 0);
            lblTopMargin.Margin = new Padding(0);
            lblTopMargin.Name = "lblTopMargin";
            lblTopMargin.Size = new Size(1840, 50);
            lblTopMargin.TabIndex = 0;
            // 
            // lblCombientAllumettes
            // 
            lblCombientAllumettes.AutoSize = true;
            lblCombientAllumettes.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCombientAllumettes.ForeColor = Color.FromArgb(35, 41, 49);
            lblCombientAllumettes.Location = new Point(382, 807);
            lblCombientAllumettes.Name = "lblCombientAllumettes";
            lblCombientAllumettes.Size = new Size(1135, 71);
            lblCombientAllumettes.TabIndex = 7;
            lblCombientAllumettes.Text = "Combien d’allumettes voulez vous enlever";
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
            lblTest.Visible = false;
            // 
            // grpPseudoMessageBox
            // 
            grpPseudoMessageBox.BackColor = Color.White;
            grpPseudoMessageBox.Controls.Add(picInfoIcnon);
            grpPseudoMessageBox.Controls.Add(lblNbAllumetteIA);
            grpPseudoMessageBox.Controls.Add(btnOkPseudoMessageBox);
            grpPseudoMessageBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPseudoMessageBox.Location = new Point(673, 507);
            grpPseudoMessageBox.Name = "grpPseudoMessageBox";
            grpPseudoMessageBox.Size = new Size(600, 300);
            grpPseudoMessageBox.TabIndex = 1;
            grpPseudoMessageBox.TabStop = false;
            grpPseudoMessageBox.Text = "Tour de l'IA";
            grpPseudoMessageBox.Visible = false;
            // 
            // picInfoIcnon
            // 
            picInfoIcnon.Image = (Image)resources.GetObject("picInfoIcnon.Image");
            picInfoIcnon.Location = new Point(30, 101);
            picInfoIcnon.Name = "picInfoIcnon";
            picInfoIcnon.Size = new Size(75, 75);
            picInfoIcnon.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoIcnon.TabIndex = 3;
            picInfoIcnon.TabStop = false;
            picInfoIcnon.Visible = false;
            // 
            // lblNbAllumetteIA
            // 
            lblNbAllumetteIA.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblNbAllumetteIA.Location = new Point(115, 120);
            lblNbAllumetteIA.Name = "lblNbAllumetteIA";
            lblNbAllumetteIA.Size = new Size(475, 40);
            lblNbAllumetteIA.TabIndex = 2;
            lblNbAllumetteIA.Text = "L'IA a choisi de retirer ... allumette(s).";
            lblNbAllumetteIA.Visible = false;
            // 
            // btnOkPseudoMessageBox
            // 
            btnOkPseudoMessageBox.Location = new Point(225, 222);
            btnOkPseudoMessageBox.Name = "btnOkPseudoMessageBox";
            btnOkPseudoMessageBox.Size = new Size(150, 60);
            btnOkPseudoMessageBox.TabIndex = 1;
            btnOkPseudoMessageBox.Text = "OK";
            btnOkPseudoMessageBox.UseVisualStyleBackColor = true;
            btnOkPseudoMessageBox.Visible = false;
            btnOkPseudoMessageBox.Click += btnOkPseudoMessageBox_Click;
            // 
            // picRetour
            // 
            picRetour.Image = (Image)resources.GetObject("picRetour.Image");
            picRetour.Location = new Point(40, 1104);
            picRetour.Name = "picRetour";
            picRetour.Size = new Size(100, 100);
            picRetour.SizeMode = PictureBoxSizeMode.Zoom;
            picRetour.TabIndex = 13;
            picRetour.TabStop = false;
            picRetour.Click += pictRetour_Click;
            // 
            // frmJeu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(1920, 1244);
            Controls.Add(picRetour);
            Controls.Add(lblTest);
            Controls.Add(grpPseudoMessageBox);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "page de jeu";
            Load += frmJeu_Load;
            flpHautPage.ResumeLayout(false);
            flpHautPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEngrenage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInterogation).EndInit();
            flpAffichageAllumettes.ResumeLayout(false);
            grpPseudoMessageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picInfoIcnon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRetour).EndInit();
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
        private Label lblTopMargin;
        private GroupBox grpPseudoMessageBox;
        private Button btnOkPseudoMessageBox;
        private PictureBox picInfoIcnon;
        private Label lblNbAllumetteIA;
        private PictureBox picRetour;
    }
}