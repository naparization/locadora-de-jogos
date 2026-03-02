namespace locadora_de_jogos
{
    partial class AtualizarRegistro
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
            dtDataRegistro = new DateTimePicker();
            label5 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // dtDataRegistro
            // 
            dtDataRegistro.Location = new Point(33, 69);
            dtDataRegistro.Name = "dtDataRegistro";
            dtDataRegistro.Size = new Size(200, 23);
            dtDataRegistro.TabIndex = 31;
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
            label5.TabIndex = 28;
            label5.Text = "Aluguel manual";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(138, 122);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 58);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(12, 122);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 58);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 92);
            label3.Name = "label3";
            label3.Size = new Size(163, 17);
            label3.TabIndex = 32;
            label3.Text = "(Editar data de devolução)";
            // 
            // AtualizarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(269, 208);
            Controls.Add(label3);
            Controls.Add(dtDataRegistro);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "AtualizarRegistro";
            Text = "AtualizarRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtDataRegistro;
        private Label label5;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label3;
    }
}