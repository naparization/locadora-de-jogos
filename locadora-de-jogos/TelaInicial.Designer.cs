namespace locadora_de_jogos
{
    partial class TelaInicial
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
            dgvDados = new DataGridView();
            pictureBox1 = new PictureBox();
            btnJogos = new Button();
            btnUsuarios = new Button();
            btnNovoAlugar = new Button();
            btnEditar = new Button();
            btnExcluirDevolver = new Button();
            btnRegistros = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 65);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(494, 373);
            dgvDados.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Super_Jogos;
            pictureBox1.Location = new Point(121, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 87);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnJogos
            // 
            btnJogos.Location = new Point(512, 65);
            btnJogos.Name = "btnJogos";
            btnJogos.Size = new Size(120, 57);
            btnJogos.TabIndex = 2;
            btnJogos.Text = "Jogos";
            btnJogos.UseVisualStyleBackColor = true;
            btnJogos.Click += button1_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(512, 128);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(120, 57);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += button2_Click;
            // 
            // btnNovoAlugar
            // 
            btnNovoAlugar.BackColor = Color.FromArgb(192, 255, 192);
            btnNovoAlugar.Location = new Point(512, 254);
            btnNovoAlugar.Name = "btnNovoAlugar";
            btnNovoAlugar.Size = new Size(120, 58);
            btnNovoAlugar.TabIndex = 4;
            btnNovoAlugar.Text = "Novo / Alugar";
            btnNovoAlugar.UseVisualStyleBackColor = false;
            btnNovoAlugar.Click += btnNovoAlugar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 192);
            btnEditar.Location = new Point(512, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 58);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluirDevolver
            // 
            btnExcluirDevolver.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluirDevolver.Location = new Point(512, 380);
            btnExcluirDevolver.Name = "btnExcluirDevolver";
            btnExcluirDevolver.Size = new Size(120, 58);
            btnExcluirDevolver.TabIndex = 6;
            btnExcluirDevolver.Text = "Excluir / Devolver";
            btnExcluirDevolver.UseVisualStyleBackColor = false;
            btnExcluirDevolver.Click += btnExcluirDevolver_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.Location = new Point(512, 191);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(120, 57);
            btnRegistros.TabIndex = 7;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistro_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(644, 450);
            Controls.Add(btnRegistros);
            Controls.Add(btnExcluirDevolver);
            Controls.Add(btnEditar);
            Controls.Add(btnNovoAlugar);
            Controls.Add(btnUsuarios);
            Controls.Add(btnJogos);
            Controls.Add(pictureBox1);
            Controls.Add(dgvDados);
            Name = "TelaInicial";
            Text = "Super Jogos";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDados;
        private PictureBox pictureBox1;
        private Button btnJogos;
        private Button btnUsuarios;
        private Button btnNovoAlugar;
        private Button btnEditar;
        private Button btnExcluirDevolver;
        private Button btnRegistros;
    }
}