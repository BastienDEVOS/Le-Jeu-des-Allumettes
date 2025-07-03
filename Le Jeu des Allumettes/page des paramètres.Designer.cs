namespace Le_Jeu_des_Allumettes
{
    partial class page_des_paramètres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page_des_paramètres));
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
            trbEffectsSonore.Location = new Point(100, 190);
            trbEffectsSonore.Name = "trbEffectsSonore";
            trbEffectsSonore.Size = new Size(400, 90);
            trbEffectsSonore.TabIndex = 7;
            // 
            // picMuteEffectsSonore
            // 
            picMuteEffectsSonore.Image = (Image)resources.GetObject("picMuteEffectsSonore.Image");
            picMuteEffectsSonore.Location = new Point(52, 190);
            picMuteEffectsSonore.Name = "picMuteEffectsSonore";
            picMuteEffectsSonore.Size = new Size(42, 42);
            picMuteEffectsSonore.SizeMode = PictureBoxSizeMode.Zoom;
            picMuteEffectsSonore.TabIndex = 8;
            picMuteEffectsSonore.TabStop = false;
            // 
            // picSondEffectSonore
            // 
            picSondEffectSonore.Image = (Image)resources.GetObject("picSondEffectSonore.Image");
            picSondEffectSonore.Location = new Point(506, 190);
            picSondEffectSonore.Name = "picSondEffectSonore";
            picSondEffectSonore.Size = new Size(42, 42);
            picSondEffectSonore.SizeMode = PictureBoxSizeMode.Zoom;
            picSondEffectSonore.TabIndex = 9;
            picSondEffectSonore.TabStop = false;
            // 
            // picSondMusic
            // 
            picSondMusic.Image = (Image)resources.GetObject("picSondMusic.Image");
            picSondMusic.Location = new Point(506, 457);
            picSondMusic.Name = "picSondMusic";
            picSondMusic.Size = new Size(42, 42);
            picSondMusic.SizeMode = PictureBoxSizeMode.Zoom;
            picSondMusic.TabIndex = 12;
            picSondMusic.TabStop = false;
            // 
            // picMuteMusic
            // 
            picMuteMusic.Image = (Image)resources.GetObject("picMuteMusic.Image");
            picMuteMusic.Location = new Point(52, 457);
            picMuteMusic.Name = "picMuteMusic";
            picMuteMusic.Size = new Size(42, 42);
            picMuteMusic.SizeMode = PictureBoxSizeMode.Zoom;
            picMuteMusic.TabIndex = 11;
            picMuteMusic.TabStop = false;
            // 
            // trbMusic
            // 
            trbMusic.Location = new Point(100, 457);
            trbMusic.Name = "trbMusic";
            trbMusic.Size = new Size(400, 90);
            trbMusic.TabIndex = 10;
            // 
            // lblEffectsSonore
            // 
            lblEffectsSonore.AutoSize = true;
            lblEffectsSonore.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEffectsSonore.Location = new Point(204, 144);
            lblEffectsSonore.Name = "lblEffectsSonore";
            lblEffectsSonore.Size = new Size(193, 32);
            lblEffectsSonore.TabIndex = 13;
            lblEffectsSonore.Text = "Effects sonores";
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMusic.Location = new Point(258, 422);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(84, 32);
            lblMusic.TabIndex = 14;
            lblMusic.Text = "Music";
            // 
            // page_des_paramètres
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 1004);
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
            Name = "page_des_paramètres";
            Text = "page_des_paramètres";
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
    }
}