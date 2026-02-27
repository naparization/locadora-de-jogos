namespace locadora_de_jogos
{
    partial class AlugarJogo
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
            txtNomeJogo = new Label();
            dtRetirarada = new DateTimePicker();
            label2 = new Label();
            btnSalvar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNomeJogo
            // 
            txtNomeJogo.AutoSize = true;
            txtNomeJogo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeJogo.ForeColor = Color.White;
            txtNomeJogo.Location = new Point(68, 5);
            txtNomeJogo.Name = "txtNomeJogo";
            txtNomeJogo.Size = new Size(270, 20);
            txtNomeJogo.TabIndex = 0;
            txtNomeJogo.Text = "Deseja alugar o jogo \"Nome do Jogo\"?";
            // 
            // dtRetirarada
            // 
            dtRetirarada.Location = new Point(20, 71);
            dtRetirarada.Name = "dtRetirarada";
            dtRetirarada.Size = new Size(246, 23);
            dtRetirarada.TabIndex = 1;
            dtRetirarada.ValueChanged += dtRetirarada_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 49);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Data retirada";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(20, 107);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 58);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Alugar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(146, 107);
            button1.Name = "button1";
            button1.Size = new Size(120, 58);
            button1.TabIndex = 16;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // AlugarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(294, 192);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(dtRetirarada);
            Controls.Add(txtNomeJogo);
            Name = "AlugarJogo";
            Text = "Alugar Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNomeJogo;
        private DateTimePicker dtRetirarada;
        private Label label2;
        private Button btnSalvar;
        private Button button1;
    }
}