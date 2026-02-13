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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 94);
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
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 5;
            label2.Text = "Id do Usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(12, 55);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.PlaceholderText = "ex: 1";
            txtIdUsuario.Size = new Size(245, 23);
            txtIdUsuario.TabIndex = 6;
            // 
            // txtIdJogo
            // 
            txtIdJogo.Location = new Point(12, 118);
            txtIdJogo.Name = "txtIdJogo";
            txtIdJogo.PlaceholderText = "ex: 1";
            txtIdJogo.Size = new Size(245, 23);
            txtIdJogo.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 208);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 58);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(138, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 58);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(269, 392);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtIdJogo);
            Controls.Add(txtIdUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroRegistros";
            Text = "CadastroRegistros";
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
    }
}