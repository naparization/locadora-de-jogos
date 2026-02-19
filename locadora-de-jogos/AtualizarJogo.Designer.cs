namespace locadora_de_jogos
{
    partial class AtualizarJogo
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
            groupBox1 = new GroupBox();
            rbShooter = new RadioButton();
            rbRPG = new RadioButton();
            rbAcao = new RadioButton();
            txtNomeJogo = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            dtLancamento = new DateTimePicker();
            label4 = new Label();
            txtPreco = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(rbShooter);
            groupBox1.Controls.Add(rbRPG);
            groupBox1.Controls.Add(rbAcao);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 51);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gênero";
            // 
            // rbShooter
            // 
            rbShooter.AutoSize = true;
            rbShooter.Location = new Point(137, 21);
            rbShooter.Name = "rbShooter";
            rbShooter.Size = new Size(66, 19);
            rbShooter.TabIndex = 8;
            rbShooter.Text = "Shooter";
            rbShooter.UseVisualStyleBackColor = true;
            // 
            // rbRPG
            // 
            rbRPG.AutoSize = true;
            rbRPG.Location = new Point(84, 21);
            rbRPG.Name = "rbRPG";
            rbRPG.Size = new Size(47, 19);
            rbRPG.TabIndex = 1;
            rbRPG.Text = "RPG";
            rbRPG.UseVisualStyleBackColor = true;
            // 
            // rbAcao
            // 
            rbAcao.AutoSize = true;
            rbAcao.Location = new Point(26, 21);
            rbAcao.Name = "rbAcao";
            rbAcao.Size = new Size(52, 19);
            rbAcao.TabIndex = 0;
            rbAcao.Text = "Ação";
            rbAcao.UseVisualStyleBackColor = true;
            // 
            // txtNomeJogo
            // 
            txtNomeJogo.Location = new Point(12, 32);
            txtNomeJogo.Name = "txtNomeJogo";
            txtNomeJogo.PlaceholderText = "Nome Do Jogo";
            txtNomeJogo.Size = new Size(245, 23);
            txtNomeJogo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 4;
            label1.Text = "Título";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(137, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 58);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(11, 246);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 58);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dtLancamento
            // 
            dtLancamento.Location = new Point(11, 201);
            dtLancamento.Name = "dtLancamento";
            dtLancamento.Size = new Size(246, 23);
            dtLancamento.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 12;
            label4.Text = "Data Lançamento";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(12, 147);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "100,00";
            txtPreco.Size = new Size(245, 23);
            txtPreco.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 10;
            label3.Text = "Preço";
            // 
            // AtualizarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(269, 392);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            Controls.Add(dtLancamento);
            Controls.Add(txtNomeJogo);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtPreco);
            Controls.Add(label3);
            Name = "AtualizarJogo";
            Text = "Atualizar Jogo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbShooter;
        private RadioButton rbRPG;
        private RadioButton rbAcao;
        private TextBox txtNomeJogo;
        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private DateTimePicker dtLancamento;
        private Label label4;
        private TextBox txtPreco;
        private Label label3;
    }
}