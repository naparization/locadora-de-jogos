namespace locadora_de_jogos
{
    partial class TelaLogin
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
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            lblLogin = new Button();
            lblLoginAdmin = new Button();
            rbIsAdmin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Super_Jogos;
            pictureBox1.Location = new Point(136, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 113);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.Black;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 255, 128);
            lblLogin.Location = new Point(247, 203);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(184, 49);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            lblLogin.UseVisualStyleBackColor = false;
            lblLogin.Click += lblLogin_Click;
            // 
            // lblLoginAdmin
            // 
            lblLoginAdmin.BackColor = Color.Black;
            lblLoginAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLoginAdmin.ForeColor = Color.FromArgb(255, 255, 128);
            lblLoginAdmin.Location = new Point(247, 257);
            lblLoginAdmin.Name = "lblLoginAdmin";
            lblLoginAdmin.Size = new Size(184, 51);
            lblLoginAdmin.TabIndex = 2;
            lblLoginAdmin.Text = "Fechar";
            lblLoginAdmin.UseVisualStyleBackColor = false;
            lblLoginAdmin.Click += lblLoginAdmin_Click;
            // 
            // rbIsAdmin
            // 
            rbIsAdmin.AutoSize = true;
            rbIsAdmin.ForeColor = Color.White;
            rbIsAdmin.Location = new Point(297, 314);
            rbIsAdmin.Name = "rbIsAdmin";
            rbIsAdmin.Size = new Size(85, 19);
            rbIsAdmin.TabIndex = 3;
            rbIsAdmin.Text = "Sou Admin";
            rbIsAdmin.UseVisualStyleBackColor = true;
            rbIsAdmin.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(644, 450);
            Controls.Add(rbIsAdmin);
            Controls.Add(lblLoginAdmin);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "TelaLogin";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button lblLogin;
        private Button lblLoginAdmin;
        private CheckBox rbIsAdmin;
    }
}
