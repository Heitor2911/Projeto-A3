namespace Aula10_Ex01
{
    partial class Colecao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblColecao = new Label();
            listview = new ListView();
            columnHeader1 = new ColumnHeader();
            btnCadastro = new Button();
            Credito = new Button();
            SuspendLayout();
            // 
            // lblColecao
            // 
            lblColecao.AutoSize = true;
            lblColecao.Font = new Font("Arial", 20F);
            lblColecao.Location = new Point(239, 46);
            lblColecao.Name = "lblColecao";
            lblColecao.Size = new Size(287, 32);
            lblColecao.TabIndex = 0;
            lblColecao.Text = "Minha Coleção Manga";
            // 
            // listview
            // 
            listview.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listview.Location = new Point(239, 81);
            listview.Name = "listview";
            listview.Size = new Size(326, 297);
            listview.TabIndex = 1;
            listview.UseCompatibleStateImageBehavior = false;
            listview.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 300;
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Arial", 12F);
            btnCadastro.Location = new Point(607, 81);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(154, 64);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // Credito
            // 
            Credito.Location = new Point(607, 196);
            Credito.Name = "Credito";
            Credito.Size = new Size(154, 66);
            Credito.TabIndex = 3;
            Credito.Text = "Crédito";
            Credito.UseVisualStyleBackColor = true;
            Credito.Click += button1_Click;
            // 
            // Colecao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Credito);
            Controls.Add(btnCadastro);
            Controls.Add(listview);
            Controls.Add(lblColecao);
            Name = "Colecao";
            Text = "Colecao";
            Load += Colecao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColecao;
        private ListView listview;
        private ColumnHeader columnHeader1;
        private Button btnCadastro;
        private Button Credito;
    }
}
