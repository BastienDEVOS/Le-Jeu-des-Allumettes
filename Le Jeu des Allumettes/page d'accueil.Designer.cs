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
            brnrègles = new Button();
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
            // brnrègles
            // 
            brnrègles.BackColor = Color.FromArgb(214, 73, 38);
            brnrègles.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            brnrègles.FlatAppearance.BorderSize = 10;
            brnrègles.FlatStyle = FlatStyle.Flat;
            brnrègles.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            brnrègles.ForeColor = Color.FromArgb(31, 41, 49);
            brnrègles.Location = new Point(510, 936);
            brnrègles.Name = "brnrègles";
            brnrègles.Size = new Size(900, 100);
            brnrègles.TabIndex = 3;
            brnrègles.Text = "RÈGLES";
            brnrègles.UseVisualStyleBackColor = false;
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
            Controls.Add(brnrègles);
            Controls.Add(btnJouer);
            Controls.Add(picLogoCentre);
            Controls.Add(flpHautPage);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Button brnrègles;
        private Button btnParamètres;
    }
}
