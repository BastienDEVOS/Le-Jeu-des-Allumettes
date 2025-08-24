namespace Le_Jeu_des_Allumettes
{
    partial class frmAPropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPropos));
            flpHautPage = new FlowLayoutPanel();
            picLogoHaut = new PictureBox();
            lblTitrePage = new Label();
            btnRetour = new Button();
            lblAPropos = new Label();
            btnTroll = new Button();
            flpHautPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).BeginInit();
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
            flpHautPage.TabIndex = 7;
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
            lblTitrePage.Size = new Size(137, 32);
            lblTitrePage.TabIndex = 1;
            lblTitrePage.Text = "A PROPOS";
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(214, 73, 38);
            btnRetour.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnRetour.FlatAppearance.BorderSize = 3;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI Black", 7.5F, FontStyle.Bold);
            btnRetour.ForeColor = Color.FromArgb(31, 41, 49);
            btnRetour.Location = new Point(125, 1018);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(350, 56);
            btnRetour.TabIndex = 8;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // lblAPropos
            // 
            lblAPropos.Font = new Font("Segoe UI Black", 6.3F, FontStyle.Bold);
            lblAPropos.Location = new Point(25, 93);
            lblAPropos.Name = "lblAPropos";
            lblAPropos.Size = new Size(550, 904);
            lblAPropos.TabIndex = 9;
            lblAPropos.Text = resources.GetString("lblAPropos.Text");
            // 
            // btnTroll
            // 
            btnTroll.FlatAppearance.BorderSize = 0;
            btnTroll.FlatStyle = FlatStyle.Flat;
            btnTroll.Font = new Font("Segoe UI", 4F);
            btnTroll.ForeColor = Color.FromArgb(237, 237, 237);
            btnTroll.Location = new Point(490, 1000);
            btnTroll.Name = "btnTroll";
            btnTroll.Size = new Size(85, 56);
            btnTroll.TabIndex = 10;
            btnTroll.Text = "Click pour une recompence";
            btnTroll.UseVisualStyleBackColor = true;
            btnTroll.Click += btnTroll_Click;
            btnTroll.MouseEnter += btnTroll_MouseEnter;
            btnTroll.MouseLeave += btnTroll_MouseLeave;
            // 
            // frmAPropos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(600, 1104);
            Controls.Add(btnTroll);
            Controls.Add(lblAPropos);
            Controls.Add(btnRetour);
            Controls.Add(flpHautPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(626, 1175);
            MinimizeBox = false;
            MinimumSize = new Size(626, 1175);
            Name = "frmAPropos";
            Text = "page a propos";
            Deactivate += frmAPropos_Deactivate;
            Load += frmAPropos_Load;
            flpHautPage.ResumeLayout(false);
            flpHautPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoHaut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpHautPage;
        private PictureBox picLogoHaut;
        private Label lblTitrePage;
        private Button btnRetour;
        private Label lblAPropos;
        private Button btnTroll;
    }
}