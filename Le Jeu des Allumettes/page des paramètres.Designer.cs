namespace Le_Jeu_des_Allumettes
{
    partial class frmParamètres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParamètres));
            flpHautPage = new FlowLayoutPanel();
            picLogoHaut = new PictureBox();
            lblTitrePage = new Label();
            trbEffectsSonore = new TrackBar();
            picMuteEffectsSonore = new PictureBox();
            picSondEffectSonore = new PictureBox();
            picSondMusic = new PictureBox();
            picMuteMusic = new PictureBox();
            trbMusic = new TrackBar();
            lblEffectsSonore = new Label();
            lblMusic = new Label();
            btnNousContacter = new Button();
            btnAPropos = new Button();
            lblNosRéseaux = new Label();
            btnInsta = new Button();
            btnSnap = new Button();
            btnX = new Button();
            btnRetour = new Button();
            btnConfirmer = new Button();
            flpHautPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbEffectsSonore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMuteEffectsSonore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSondEffectSonore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSondMusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMuteMusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbMusic).BeginInit();
            SuspendLayout();
            // 
            // flpHautPage
            // 
            flpHautPage.BackColor = Color.FromArgb(253, 175, 65);
            flpHautPage.Controls.Add(picLogoHaut);
            flpHautPage.Controls.Add(lblTitrePage);
            flpHautPage.Location = new Point(0, 0);
            flpHautPage.Name = "flpHautPage";
            flpHautPage.Size = new Size(600, 75);
            flpHautPage.TabIndex = 6;
            // 
            // picLogoHaut
            // 
            picLogoHaut.Image = (Image)resources.GetObject("picLogoHaut.Image");
            picLogoHaut.Location = new Point(0, 0);
            picLogoHaut.Margin = new Padding(0);
            picLogoHaut.Name = "picLogoHaut";
            picLogoHaut.Size = new Size(75, 75);
            picLogoHaut.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoHaut.TabIndex = 0;
            picLogoHaut.TabStop = false;
            // 
            // lblTitrePage
            // 
            lblTitrePage.AutoSize = true;
            lblTitrePage.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblTitrePage.ForeColor = Color.FromArgb(35, 41, 49);
            lblTitrePage.Location = new Point(211, 22);
            lblTitrePage.Margin = new Padding(136, 22, 3, 0);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new Size(177, 32);
            lblTitrePage.TabIndex = 1;
            lblTitrePage.Text = "PARAMÈTRES";
            // 
            // trbEffectsSonore
            // 
            trbEffectsSonore.BackColor = SystemColors.Control;
            trbEffectsSonore.Location = new Point(100, 152);
            trbEffectsSonore.Maximum = 8;
            trbEffectsSonore.Name = "trbEffectsSonore";
            trbEffectsSonore.Size = new Size(400, 90);
            trbEffectsSonore.TabIndex = 7;
            trbEffectsSonore.Value = 4;
            // 
            // picMuteEffectsSonore
            // 
            picMuteEffectsSonore.Image = (Image)resources.GetObject("picMuteEffectsSonore.Image");
            picMuteEffectsSonore.Location = new Point(52, 152);
            picMuteEffectsSonore.Name = "picMuteEffectsSonore";
            picMuteEffectsSonore.Size = new Size(42, 42);
            picMuteEffectsSonore.SizeMode = PictureBoxSizeMode.Zoom;
            picMuteEffectsSonore.TabIndex = 8;
            picMuteEffectsSonore.TabStop = false;
            // 
            // picSondEffectSonore
            // 
            picSondEffectSonore.Image = (Image)resources.GetObject("picSondEffectSonore.Image");
            picSondEffectSonore.Location = new Point(510, 152);
            picSondEffectSonore.Name = "picSondEffectSonore";
            picSondEffectSonore.Size = new Size(42, 42);
            picSondEffectSonore.SizeMode = PictureBoxSizeMode.Zoom;
            picSondEffectSonore.TabIndex = 9;
            picSondEffectSonore.TabStop = false;
            // 
            // picSondMusic
            // 
            picSondMusic.Image = (Image)resources.GetObject("picSondMusic.Image");
            picSondMusic.Location = new Point(510, 268);
            picSondMusic.Name = "picSondMusic";
            picSondMusic.Size = new Size(42, 42);
            picSondMusic.SizeMode = PictureBoxSizeMode.Zoom;
            picSondMusic.TabIndex = 12;
            picSondMusic.TabStop = false;
            // 
            // picMuteMusic
            // 
            picMuteMusic.Image = (Image)resources.GetObject("picMuteMusic.Image");
            picMuteMusic.Location = new Point(52, 268);
            picMuteMusic.Name = "picMuteMusic";
            picMuteMusic.Size = new Size(42, 42);
            picMuteMusic.SizeMode = PictureBoxSizeMode.Zoom;
            picMuteMusic.TabIndex = 11;
            picMuteMusic.TabStop = false;
            // 
            // trbMusic
            // 
            trbMusic.Location = new Point(100, 268);
            trbMusic.Maximum = 8;
            trbMusic.Name = "trbMusic";
            trbMusic.Size = new Size(400, 90);
            trbMusic.TabIndex = 10;
            trbMusic.Value = 4;
            // 
            // lblEffectsSonore
            // 
            lblEffectsSonore.AutoSize = true;
            lblEffectsSonore.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEffectsSonore.ForeColor = Color.FromArgb(35, 41, 49);
            lblEffectsSonore.Location = new Point(204, 106);
            lblEffectsSonore.Name = "lblEffectsSonore";
            lblEffectsSonore.Size = new Size(193, 32);
            lblEffectsSonore.TabIndex = 13;
            lblEffectsSonore.Text = "Effects sonores";
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMusic.ForeColor = Color.FromArgb(35, 41, 49);
            lblMusic.Location = new Point(258, 233);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(84, 32);
            lblMusic.TabIndex = 14;
            lblMusic.Text = "Music";
            // 
            // btnNousContacter
            // 
            btnNousContacter.BackColor = Color.FromArgb(214, 73, 38);
            btnNousContacter.BackgroundImageLayout = ImageLayout.Zoom;
            btnNousContacter.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnNousContacter.FlatAppearance.BorderSize = 3;
            btnNousContacter.FlatStyle = FlatStyle.Flat;
            btnNousContacter.Font = new Font("Segoe UI Black", 7.5F, FontStyle.Bold);
            btnNousContacter.ForeColor = Color.FromArgb(35, 41, 49);
            btnNousContacter.Image = (Image)resources.GetObject("btnNousContacter.Image");
            btnNousContacter.Location = new Point(52, 393);
            btnNousContacter.Name = "btnNousContacter";
            btnNousContacter.Padding = new Padding(5, 0, 0, 0);
            btnNousContacter.Size = new Size(500, 56);
            btnNousContacter.TabIndex = 15;
            btnNousContacter.Text = "Nous contacter";
            btnNousContacter.TextAlign = ContentAlignment.MiddleRight;
            btnNousContacter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNousContacter.UseVisualStyleBackColor = false;
            btnNousContacter.Click += btnNousContacter_Click;
            // 
            // btnAPropos
            // 
            btnAPropos.BackColor = Color.FromArgb(214, 73, 38);
            btnAPropos.BackgroundImageLayout = ImageLayout.Zoom;
            btnAPropos.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnAPropos.FlatAppearance.BorderSize = 3;
            btnAPropos.FlatStyle = FlatStyle.Flat;
            btnAPropos.Font = new Font("Segoe UI Black", 7.5F, FontStyle.Bold);
            btnAPropos.ForeColor = Color.FromArgb(35, 41, 49);
            btnAPropos.Image = (Image)resources.GetObject("btnAPropos.Image");
            btnAPropos.Location = new Point(52, 524);
            btnAPropos.Name = "btnAPropos";
            btnAPropos.Size = new Size(500, 56);
            btnAPropos.TabIndex = 16;
            btnAPropos.Text = "A propos";
            btnAPropos.TextAlign = ContentAlignment.MiddleRight;
            btnAPropos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAPropos.UseVisualStyleBackColor = false;
            btnAPropos.Click += btnAPropos_Click;
            // 
            // lblNosRéseaux
            // 
            lblNosRéseaux.AutoSize = true;
            lblNosRéseaux.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNosRéseaux.ForeColor = Color.FromArgb(35, 41, 49);
            lblNosRéseaux.Location = new Point(221, 634);
            lblNosRéseaux.Name = "lblNosRéseaux";
            lblNosRéseaux.Size = new Size(158, 32);
            lblNosRéseaux.TabIndex = 17;
            lblNosRéseaux.Text = "Nos réseaux";
            // 
            // btnInsta
            // 
            btnInsta.BackgroundImage = (Image)resources.GetObject("btnInsta.BackgroundImage");
            btnInsta.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsta.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnInsta.FlatAppearance.BorderSize = 5;
            btnInsta.FlatStyle = FlatStyle.Flat;
            btnInsta.Location = new Point(52, 716);
            btnInsta.Name = "btnInsta";
            btnInsta.Size = new Size(100, 100);
            btnInsta.TabIndex = 18;
            btnInsta.UseVisualStyleBackColor = true;
            btnInsta.Click += btnInsta_Click;
            // 
            // btnSnap
            // 
            btnSnap.BackgroundImage = (Image)resources.GetObject("btnSnap.BackgroundImage");
            btnSnap.BackgroundImageLayout = ImageLayout.Zoom;
            btnSnap.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnSnap.FlatAppearance.BorderSize = 5;
            btnSnap.FlatStyle = FlatStyle.Flat;
            btnSnap.Location = new Point(250, 716);
            btnSnap.Name = "btnSnap";
            btnSnap.Size = new Size(100, 100);
            btnSnap.TabIndex = 19;
            btnSnap.UseVisualStyleBackColor = true;
            btnSnap.Click += btnSnap_Click;
            // 
            // btnX
            // 
            btnX.BackgroundImage = (Image)resources.GetObject("btnX.BackgroundImage");
            btnX.BackgroundImageLayout = ImageLayout.Zoom;
            btnX.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnX.FlatAppearance.BorderSize = 5;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Location = new Point(452, 716);
            btnX.Name = "btnX";
            btnX.Size = new Size(100, 100);
            btnX.TabIndex = 20;
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(214, 73, 38);
            btnRetour.BackgroundImageLayout = ImageLayout.Zoom;
            btnRetour.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnRetour.FlatAppearance.BorderSize = 3;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI Black", 7.5F, FontStyle.Bold);
            btnRetour.ForeColor = Color.FromArgb(35, 41, 49);
            btnRetour.Location = new Point(52, 908);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(225, 56);
            btnRetour.TabIndex = 21;
            btnRetour.Text = "Retour";
            btnRetour.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnConfirmer
            // 
            btnConfirmer.BackColor = Color.FromArgb(214, 73, 38);
            btnConfirmer.BackgroundImageLayout = ImageLayout.Zoom;
            btnConfirmer.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnConfirmer.FlatAppearance.BorderSize = 3;
            btnConfirmer.FlatStyle = FlatStyle.Flat;
            btnConfirmer.Font = new Font("Segoe UI Black", 7.5F, FontStyle.Bold);
            btnConfirmer.ForeColor = Color.FromArgb(35, 41, 49);
            btnConfirmer.Location = new Point(327, 908);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(225, 56);
            btnConfirmer.TabIndex = 22;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirmer.UseVisualStyleBackColor = false;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // frmParamètres
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(600, 1004);
            Controls.Add(btnConfirmer);
            Controls.Add(btnRetour);
            Controls.Add(btnX);
            Controls.Add(btnSnap);
            Controls.Add(btnInsta);
            Controls.Add(lblNosRéseaux);
            Controls.Add(btnAPropos);
            Controls.Add(btnNousContacter);
            Controls.Add(lblMusic);
            Controls.Add(lblEffectsSonore);
            Controls.Add(picSondMusic);
            Controls.Add(picMuteMusic);
            Controls.Add(trbMusic);
            Controls.Add(picSondEffectSonore);
            Controls.Add(picMuteEffectsSonore);
            Controls.Add(trbEffectsSonore);
            Controls.Add(flpHautPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(626, 1075);
            MinimizeBox = false;
            MinimumSize = new Size(626, 1075);
            Name = "frmParamètres";
            Text = "page des paramètres";
            Load += frmParamètres_Load;
            flpHautPage.ResumeLayout(false);
            flpHautPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbEffectsSonore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMuteEffectsSonore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSondEffectSonore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSondMusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMuteMusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbMusic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpHautPage;
        private PictureBox picLogoHaut;
        private Label lblTitrePage;
        private TrackBar trbEffectsSonore;
        private PictureBox picMuteEffectsSonore;
        private PictureBox picSondEffectSonore;
        private PictureBox picSondMusic;
        private PictureBox picMuteMusic;
        private TrackBar trbMusic;
        private Label lblEffectsSonore;
        private Label lblMusic;
        private Button btnNousContacter;
        private Button btnAPropos;
        private Label lblNosRéseaux;
        private Button btnInsta;
        private Button btnSnap;
        private Button btnX;
        private Button btnRetour;
        private Button btnConfirmer;
    }
}