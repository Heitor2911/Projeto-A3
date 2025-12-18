namespace Aula10_Ex01
{
    partial class Cadastro
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
            lblNovoManga = new Label();
            lblNome = new Label();
            lblEdicao = new Label();
            lblPreco = new Label();
            txtNome = new TextBox();
            txtEdicao = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNovoManga
            // 
            lblNovoManga.AutoSize = true;
            lblNovoManga.Font = new Font("Arial", 20F);
            lblNovoManga.Location = new Point(12, 9);
            lblNovoManga.Name = "lblNovoManga";
            lblNovoManga.Size = new Size(167, 32);
            lblNovoManga.TabIndex = 0;
            lblNovoManga.Text = "Novo Manga";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 53);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblEdicao
            // 
            lblEdicao.AutoSize = true;
            lblEdicao.Location = new Point(12, 91);
            lblEdicao.Name = "lblEdicao";
            lblEdicao.Size = new Size(42, 15);
            lblEdicao.TabIndex = 2;
            lblEdicao.Text = "Edição";
            lblEdicao.Click += lblNovo2_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 131);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(133, 23);
            txtNome.TabIndex = 5;
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(60, 83);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(133, 23);
            txtEdicao.TabIndex = 6;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(60, 123);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(133, 23);
            txtPreco.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(120, 173);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(84, 43);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 43);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtEdicao);
            Controls.Add(txtNome);
            Controls.Add(lblPreco);
            Controls.Add(lblEdicao);
            Controls.Add(lblNome);
            Controls.Add(lblNovoManga);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoManga;
        private Label lblNome;
        private Label lblEdicao;
        private Label lblPreco;
        private TextBox txtNome;
        private TextBox txtEdicao;
        private TextBox txtPreco;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}