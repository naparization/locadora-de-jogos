namespace locadora_de_jogos
{
    partial class AtualizarUsuario
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
            label6 = new Label();
            txtDDD = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtTelefone = new TextBox();
            label5 = new Label();
            txtCpf = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rbOutro = new RadioButton();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            label1 = new Label();
            txtNomeUsuario = new TextBox();
            txtErro = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(5, 237);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 30;
            label6.Text = "DDD";
            // 
            // txtDDD
            // 
            txtDDD.Location = new Point(10, 261);
            txtDDD.Name = "txtDDD";
            txtDDD.PlaceholderText = "+ 00";
            txtDDD.Size = new Size(39, 23);
            txtDDD.TabIndex = 29;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(137, 296);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 58);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(11, 296);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 58);
            btnSalvar.TabIndex = 27;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(58, 261);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "0 0000-0000";
            txtTelefone.Size = new Size(199, 23);
            txtTelefone.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 237);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 25;
            label5.Text = "Telefone";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 200);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(245, 23);
            txtCpf.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 23;
            label4.Text = "CPF";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "nome@dominio.com";
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 21;
            label2.Text = "Email";
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
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gênero";
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
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(6, 22);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 0;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 19;
            label1.Text = "Nome";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(12, 33);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.PlaceholderText = "Fulano De Tal";
            txtNomeUsuario.Size = new Size(245, 23);
            txtNomeUsuario.TabIndex = 18;
            // 
            // txtErro
            // 
            txtErro.AutoSize = true;
            txtErro.ForeColor = Color.Red;
            txtErro.Location = new Point(5, 355);
            txtErro.Name = "txtErro";
            txtErro.Size = new Size(0, 15);
            txtErro.TabIndex = 31;
            // 
            // AtualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(269, 465);
            Controls.Add(txtErro);
            Controls.Add(label6);
            Controls.Add(txtDDD);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(txtCpf);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtNomeUsuario);
            Name = "AtualizarUsuario";
            Text = "Atualizar Usuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtDDD;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtCpf;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rbOutro;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private Label label1;
        private TextBox txtNomeUsuario;
        private Label txtErro;
    }
}