namespace Aula10_Ex01
{
    partial class Creditos
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
            lblNome = new Label();
            lblNome1 = new Label();
            lblNome2 = new Label();
            lblNome3 = new Label();
            lblNome4 = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 25F);
            lblNome.Location = new Point(239, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(284, 39);
            lblNome.TabIndex = 0;
            lblNome.Text = "Feito pelos alunos";
            // 
            // lblNome1
            // 
            lblNome1.AutoSize = true;
            lblNome1.Font = new Font("Arial", 25F);
            lblNome1.Location = new Point(263, 112);
            lblNome1.Name = "lblNome1";
            lblNome1.Size = new Size(234, 39);
            lblNome1.TabIndex = 1;
            lblNome1.Text = "Heitor Lacourt ";
            lblNome1.Click += lblNome1_Click;
            // 
            // lblNome2
            // 
            lblNome2.AutoSize = true;
            lblNome2.Font = new Font("Arial", 25F);
            lblNome2.Location = new Point(263, 168);
            lblNome2.Name = "lblNome2";
            lblNome2.Size = new Size(281, 39);
            lblNome2.TabIndex = 2;
            lblNome2.Text = "Mateus Srocinski ";
            // 
            // lblNome3
            // 
            lblNome3.AutoSize = true;
            lblNome3.Font = new Font("Arial", 25F);
            lblNome3.Location = new Point(263, 231);
            lblNome3.Name = "lblNome3";
            lblNome3.Size = new Size(251, 39);
            lblNome3.TabIndex = 3;
            lblNome3.Text = "Eduardo Hauer ";
            // 
            // lblNome4
            // 
            lblNome4.AutoSize = true;
            lblNome4.Font = new Font("Arial", 25F);
            lblNome4.Location = new Point(263, 301);
            lblNome4.Name = "lblNome4";
            lblNome4.Size = new Size(260, 39);
            lblNome4.TabIndex = 4;
            lblNome4.Text = "Gustavo Correa ";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(331, 353);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(135, 64);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(lblNome4);
            Controls.Add(lblNome3);
            Controls.Add(lblNome2);
            Controls.Add(lblNome1);
            Controls.Add(lblNome);
            Name = "Creditos";
            Text = "Creditos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblNome1;
        private Label lblNome2;
        private Label lblNome3;
        private Label lblNome4;
        private Button btnVoltar;
    }
}