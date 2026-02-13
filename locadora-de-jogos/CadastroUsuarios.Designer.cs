namespace locadora_de_jogos
{
    partial class CadastroUsuarios
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
            txtNomeUsuario = new TextBox();
            label1 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbOutro = new RadioButton();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            label2 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtCpf = new TextBox();
            label5 = new Label();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(12, 33);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.PlaceholderText = "Guilherme Hernandez";
            txtNomeUsuario.Size = new Size(245, 23);
            txtNomeUsuario.TabIndex = 2;
            txtNomeUsuario.TextChanged += txtNomeJogo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(rbOutro);
            groupBox1.Controls.Add(rbFeminino);
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 51);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gênero";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbOutro
            // 
            rbOutro.AutoSize = true;
            rbOutro.Location = new Point(173, 22);
            rbOutro.Name = "rbOutro";
            rbOutro.Size = new Size(56, 19);
            rbOutro.TabIndex = 8;
            rbOutro.Text = "Outro";
            rbOutro.UseVisualStyleBackColor = true;
            rbOutro.CheckedChanged += rbShooter_CheckedChanged;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(92, 22);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(75, 19);
            rbFeminino.TabIndex = 1;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            rbFeminino.CheckedChanged += rbRPG_CheckedChanged;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Checked = true;
            rbMasculino.Location = new Point(6, 22);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 7;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "guilhermehernandez@gmail.com";
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 9;
            label4.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 221);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(245, 23);
            txtCpf.TabIndex = 10;
            txtCpf.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 258);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 11;
            label5.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 282);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = " 51 9999-9999";
            txtTelefone.Size = new Size(245, 23);
            txtTelefone.TabIndex = 12;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 322);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 58);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(138, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 58);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(269, 392);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(txtCpf);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtNomeUsuario);
            Name = "CadastroUsuarios";
            Text = "CadastroUsuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNomeUsuario;
        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbOutro;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private Label label2;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtCpf;
        private Label label5;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}