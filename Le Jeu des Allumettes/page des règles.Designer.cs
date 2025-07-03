namespace Le_Jeu_des_Allumettes
{
    partial class frmRègles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRègles));
            btnRetour = new Button();
            lblRèglesJeu = new Label();
            flpHautPage = new FlowLayoutPanel();
            picLogoHaut = new PictureBox();
            lblTitrePage = new Label();
            flpHautPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).BeginInit();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(214, 73, 38);
            btnRetour.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnRetour.FlatAppearance.BorderSize = 3;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI Black", 7.5F, FontStyle.Bold);
            btnRetour.ForeColor = Color.FromArgb(31, 41, 49);
            btnRetour.Location = new Point(125, 886);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(350, 56);
            btnRetour.TabIndex = 3;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // lblRèglesJeu
            // 
            lblRèglesJeu.Font = new Font("Segoe UI Black", 5.5F, FontStyle.Bold);
            lblRèglesJeu.Location = new Point(25, 101);
            lblRèglesJeu.Name = "lblRèglesJeu";
            lblRèglesJeu.Size = new Size(550, 750);
            lblRèglesJeu.TabIndex = 4;
            lblRèglesJeu.Text = resources.GetString("lblRèglesJeu.Text");
            // 
            // flpHautPage
            // 
            flpHautPage.BackColor = Color.FromArgb(253, 175, 65);
            flpHautPage.Controls.Add(picLogoHaut);
            flpHautPage.Controls.Add(lblTitrePage);
            flpHautPage.Location = new Point(0, 0);
            flpHautPage.Name = "flpHautPage";
            flpHautPage.Size = new Size(600, 75);
            flpHautPage.TabIndex = 5;
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
            lblTitrePage.Location = new Point(250, 22);
            lblTitrePage.Margin = new Padding(175, 22, 3, 0);
            lblTitrePage.Name = "lblTitrePage";
            lblTitrePage.Size = new Size(100, 32);
            lblTitrePage.TabIndex = 1;
            lblTitrePage.Text = "RÈGLES";
            // 
            // frmRègles
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 1004);
            Controls.Add(flpHautPage);
            Controls.Add(lblRèglesJeu);
            Controls.Add(btnRetour);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(626, 1075);
            MinimizeBox = false;
            MinimumSize = new Size(626, 1075);
            Name = "frmRègles";
            Text = "page des règles";
            flpHautPage.ResumeLayout(false);
            flpHautPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
        private Label lblRèglesJeu;
        private FlowLayoutPanel flpHautPage;
        private PictureBox picLogoHaut;
        private Label lblTitrePage;
    }
}