namespace Le_Jeu_des_Allumettes
{
    partial class frmTroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroll));
            picTroll = new PictureBox();
            btnTroll = new Button();
            lblGG = new Label();
            ((System.ComponentModel.ISupportInitialize)picTroll).BeginInit();
            SuspendLayout();
            // 
            // picTroll
            // 
            picTroll.Image = (Image)resources.GetObject("picTroll.Image");
            picTroll.Location = new Point(62, 4);
            picTroll.Name = "picTroll";
            picTroll.Size = new Size(694, 571);
            picTroll.SizeMode = PictureBoxSizeMode.Zoom;
            picTroll.TabIndex = 1;
            picTroll.TabStop = false;
            // 
            // btnTroll
            // 
            btnTroll.BackColor = Color.FromArgb(214, 73, 38);
            btnTroll.FlatAppearance.BorderColor = Color.FromArgb(106, 45, 20);
            btnTroll.FlatAppearance.BorderSize = 3;
            btnTroll.FlatStyle = FlatStyle.Flat;
            btnTroll.Font = new Font("Segoe UI Black", 7.5F, FontStyle.Bold);
            btnTroll.ForeColor = Color.FromArgb(31, 41, 49);
            btnTroll.Location = new Point(234, 614);
            btnTroll.Name = "btnTroll";
            btnTroll.Size = new Size(350, 56);
            btnTroll.TabIndex = 9;
            btnTroll.Text = "Fermer";
            btnTroll.UseVisualStyleBackColor = false;
            btnTroll.Click += btnTroll_Click;
            btnTroll.MouseMove += btnTroll_MouseMove;
            // 
            // lblGG
            // 
            lblGG.AutoSize = true;
            lblGG.Location = new Point(292, 673);
            lblGG.Name = "lblGG";
            lblGG.Size = new Size(234, 32);
            lblGG.TabIndex = 10;
            lblGG.Text = "Ok vas-y t'as gagné..";
            lblGG.Visible = false;
            // 
            // frmTroll
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(819, 707);
            Controls.Add(lblGG);
            Controls.Add(btnTroll);
            Controls.Add(picTroll);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(845, 778);
            MinimizeBox = false;
            MinimumSize = new Size(845, 778);
            Name = "frmTroll";
            Text = "page Troll";
            Deactivate += frmTroll_Deactivate;
            FormClosing += FormTroll_FormClosing;
            Load += frmTroll_Load;
            ((System.ComponentModel.ISupportInitialize)picTroll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picTroll;
        private Button btnTroll;
        private Label lblGG;
    }
}