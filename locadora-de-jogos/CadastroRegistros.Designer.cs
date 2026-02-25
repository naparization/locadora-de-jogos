namespace locadora_de_jogos
{
    partial class CadastroRegistros
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
            label1 = new Label();
            label2 = new Label();
            txtIdUsuario = new TextBox();
            txtIdJogo = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtNomeCliente = new Label();
            txtNomeJogo = new Label();
            dtDataRegistro = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 4;
            label1.Text = "Id do Jogo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 5;
            label2.Text = "Id do Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(12, 95);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.PlaceholderText = "ex: 1";
            txtIdUsuario.Size = new Size(246, 23);
            txtIdUsuario.TabIndex = 6;
            txtIdUsuario.TextChanged += txtIdUsuario_TextChanged;
            // 
            // txtIdJogo
            // 
            txtIdJogo.Location = new Point(12, 165);
            txtIdJogo.Name = "txtIdJogo";
            txtIdJogo.PlaceholderText = "ex: 1";
            txtIdJogo.Size = new Size(246, 23);
            txtIdJogo.TabIndex = 7;
            txtIdJogo.TextChanged += txtIdUsuario_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(12, 219);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 58);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Registrar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(138, 219);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 58);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(34, 23);
            label5.Name = "label5";
            label5.Size = new Size(195, 32);
            label5.TabIndex = 18;
            label5.Text = "Aluguel manual";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.AutoSize = true;
            txtNomeCliente.ForeColor = Color.White;
            txtNomeCliente.Location = new Point(11, 121);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(122, 15);
            txtNomeCliente.TabIndex = 19;
            txtNomeCliente.Text = "Usuário: Não definido";
            // 
            // txtNomeJogo
            // 
            txtNomeJogo.AutoSize = true;
            txtNomeJogo.ForeColor = Color.White;
            txtNomeJogo.Location = new Point(13, 191);
            txtNomeJogo.Name = "txtNomeJogo";
            txtNomeJogo.Size = new Size(107, 15);
            txtNomeJogo.TabIndex = 20;
            txtNomeJogo.Text = "Jogo: Não definido";
            // 
            // dtDataRegistro
            // 
            dtDataRegistro.Location = new Point(33, 282);
            dtDataRegistro.Name = "dtDataRegistro";
            dtDataRegistro.Size = new Size(200, 23);
            dtDataRegistro.TabIndex = 21;
            // 
            // CadastroRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(269, 392);
            Controls.Add(dtDataRegistro);
            Controls.Add(txtNomeJogo);
            Controls.Add(txtNomeCliente);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtIdJogo);
            Controls.Add(txtIdUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroRegistros";
            Text = "Cadastro Registros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdUsuario;
        private TextBox txtIdJogo;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label5;
        private Label txtNomeCliente;
        private Label txtNomeJogo;
        private DateTimePicker dtDataRegistro;
    }
}