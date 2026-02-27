namespace locadora_de_jogos
{
    partial class CalculoAluguel
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
            label2 = new Label();
            txtFatura = new Label();
            button1 = new Button();
            rbCredito = new RadioButton();
            rbBoleto = new RadioButton();
            rbPix = new RadioButton();
            groupBox1 = new GroupBox();
            txtMulta = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeJogo
            // 
            txtNomeJogo.AutoSize = true;
            txtNomeJogo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeJogo.ForeColor = Color.White;
            txtNomeJogo.Location = new Point(1, 9);
            txtNomeJogo.Name = "txtNomeJogo";
            txtNomeJogo.Size = new Size(152, 21);
            txtNomeJogo.TabIndex = 0;
            txtNomeJogo.Text = "Jogo: Nome do Jogo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Valor: ";
            // 
            // txtFatura
            // 
            txtFatura.AutoSize = true;
            txtFatura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFatura.ForeColor = Color.White;
            txtFatura.Location = new Point(48, 35);
            txtFatura.Name = "txtFatura";
            txtFatura.Size = new Size(46, 21);
            txtFatura.TabIndex = 2;
            txtFatura.Text = "1000";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(38, 72);
            button1.Name = "button1";
            button1.Size = new Size(128, 63);
            button1.TabIndex = 3;
            button1.Text = "Pagar e Devolver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Checked = true;
            rbCredito.ForeColor = Color.White;
            rbCredito.Location = new Point(33, 28);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(64, 19);
            rbCredito.TabIndex = 4;
            rbCredito.TabStop = true;
            rbCredito.Text = "Crédito";
            rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbBoleto
            // 
            rbBoleto.AutoSize = true;
            rbBoleto.ForeColor = Color.White;
            rbBoleto.Location = new Point(103, 28);
            rbBoleto.Name = "rbBoleto";
            rbBoleto.Size = new Size(59, 19);
            rbBoleto.TabIndex = 5;
            rbBoleto.Text = "Boleto";
            rbBoleto.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.ForeColor = Color.White;
            rbPix.Location = new Point(74, 53);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(42, 19);
            rbPix.TabIndex = 6;
            rbPix.Text = "PIX";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBoleto);
            groupBox1.Controls.Add(rbPix);
            groupBox1.Controls.Add(rbCredito);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(7, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 93);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de pagamento";
            // 
            // txtMulta
            // 
            txtMulta.AutoSize = true;
            txtMulta.ForeColor = Color.Red;
            txtMulta.Location = new Point(4, 54);
            txtMulta.Name = "txtMulta";
            txtMulta.Size = new Size(0, 15);
            txtMulta.TabIndex = 8;
            // 
            // CalculoAluguel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(219, 240);
            Controls.Add(txtMulta);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(txtFatura);
            Controls.Add(label2);
            Controls.Add(txtNomeJogo);
            Name = "CalculoAluguel";
            Text = "CalculoAluguel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNomeJogo;
        private Label label2;
        private Label txtFatura;
        private Button button1;
        private RadioButton rbCredito;
        private RadioButton rbBoleto;
        private RadioButton rbPix;
        private GroupBox groupBox1;
        private Label txtMulta;
    }
}