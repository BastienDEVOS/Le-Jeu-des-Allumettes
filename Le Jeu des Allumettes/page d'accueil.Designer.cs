namespace Le_Jeu_des_Allumettes
{
    partial class frmAcceuil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceuil));
            flpHautPage = new FlowLayoutPanel();
            picLogoHaut = new PictureBox();
            lblTitrePage = new Label();
            picLogoCentre = new PictureBox();
            btnJouer = new Button();
            brnRègles = new Button();
            btnParamètres = new Button();
            flpHautPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogoCentre).BeginInit();
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
            flpHautPage.TabIndex = 0;
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
            lblTitrePage.Location = new Point(453, 22);
            lblTitrePage.Margin = new Padding(303, 22, 3, 0);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new Size(1013, 106);
            lblTitrePage.TabIndex = 1;
            lblTitrePage.Text = "LE JEU DES ALLUMETTES";
            // 
            // picLogoCentre
            // 
            picLogoCentre.Image = (Image)resources.GetObject("picLogoCentre.Image");
            picLogoCentre.Location = new Point(659, 156);
            picLogoCentre.Name = "picLogoCentre";
            picLogoCentre.Size = new Size(602, 602);
            picLogoCentre.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoCentre.TabIndex = 1;
            picLogoCentre.TabStop = false;
            // 
            // btnJouer
            // 
            btnJouer.BackColor = Color.FromArgb(214, 73, 38);
            btnJouer.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnJouer.FlatAppearance.BorderSize = 10;
            btnJouer.FlatStyle = FlatStyle.Flat;
            btnJouer.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            btnJouer.ForeColor = Color.FromArgb(31, 41, 49);
            btnJouer.Location = new Point(510, 771);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(900, 100);
            btnJouer.TabIndex = 2;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            // 
            // brnRègles
            // 
            brnRègles.BackColor = Color.FromArgb(214, 73, 38);
            brnRègles.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            brnRègles.FlatAppearance.BorderSize = 10;
            brnRègles.FlatStyle = FlatStyle.Flat;
            brnRègles.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            brnRègles.ForeColor = Color.FromArgb(31, 41, 49);
            brnRègles.Location = new Point(510, 936);
            brnRègles.Name = "brnRègles";
            brnRègles.Size = new Size(900, 100);
            brnRègles.TabIndex = 3;
            brnRègles.Text = "RÈGLES";
            brnRègles.UseVisualStyleBackColor = false;
            brnRègles.Click += brnRègles_Click;
            // 
            // btnParamètres
            // 
            btnParamètres.BackColor = Color.FromArgb(214, 73, 38);
            btnParamètres.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnParamètres.FlatAppearance.BorderSize = 10;
            btnParamètres.FlatStyle = FlatStyle.Flat;
            btnParamètres.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            btnParamètres.ForeColor = Color.FromArgb(31, 41, 49);
            btnParamètres.Location = new Point(510, 1101);
            btnParamètres.Name = "btnParamètres";
            btnParamètres.Size = new Size(900, 100);
            btnParamètres.TabIndex = 4;
            btnParamètres.Text = "PARAMÈTRES";
            btnParamètres.UseVisualStyleBackColor = false;
            // 
            // frmAcceuil
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(1920, 1244);
            Controls.Add(btnParamètres);
            Controls.Add(brnRègles);
            Controls.Add(btnJouer);
            Controls.Add(picLogoCentre);
            Controls.Add(flpHautPage);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1946, 1315);
            MinimizeBox = false;
            MinimumSize = new Size(1946, 1315);
            Name = "frmAcceuil";
            Text = "page d'accueil";
            Load += frmAcceuil_Load;
            flpHautPage.ResumeLayout(false);
            flpHautPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogoCentre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpHautPage;
        private PictureBox picLogoHaut;
        private Label lblTitrePage;
        private PictureBox picLogoCentre;
        private Button btnJouer;
        private Button brnRègles;
        private Button btnParamètres;
    }
}
