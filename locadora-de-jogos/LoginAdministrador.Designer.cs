
namespace locadora_de_jogos
{
    partial class LoginAdministrador
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
            txtUsuario = new TextBox();
            label1 = new Label();
            txtSenha = new TextBox();
            label2 = new Label();
            lblLoginAdmin = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(32, 35);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 17);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(32, 87);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // lblLoginAdmin
            // 
            lblLoginAdmin.Location = new Point(45, 122);
            lblLoginAdmin.Name = "lblLoginAdmin";
            lblLoginAdmin.Size = new Size(75, 23);
            lblLoginAdmin.TabIndex = 4;
            lblLoginAdmin.Text = "Login";
            lblLoginAdmin.UseVisualStyleBackColor = true;
            lblLoginAdmin.Click += button1_Click;
            // 
            // LoginAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(164, 169);
            Controls.Add(lblLoginAdmin);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Name = "LoginAdministrador";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtSenha;
        private Label label2;
        private Button lblLoginAdmin;
    }
}