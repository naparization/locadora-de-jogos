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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            btnSalvar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 0;
            label1.Text = "Deseja alugar o jogo \"Nome do Jogo\"?";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 23);
            dateTimePicker1.TabIndex = 1;
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
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "AlugarJogo";
            Text = "Alugar Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button btnSalvar;
        private Button button1;
    }
}