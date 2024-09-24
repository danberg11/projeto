namespace projeto.view
{
    partial class pesquisar
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
            tbx_pesquisar = new Label();
            btn_excluir = new Button();
            btn_alterar = new Button();
            label2 = new Label();
            tbx_idade = new Label();
            tbx_posicao = new Label();
            textBox1 = new TextBox();
            tbx_pesquisarid = new Label();
            btn_pesquisar = new Button();
            tbx_nome = new TextBox();
            tbx_idade1 = new TextBox();
            tbx_posicao1 = new TextBox();
            SuspendLayout();
            // 
            // tbx_pesquisar
            // 
            tbx_pesquisar.AutoSize = true;
            tbx_pesquisar.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbx_pesquisar.Location = new Point(284, 9);
            tbx_pesquisar.Name = "tbx_pesquisar";
            tbx_pesquisar.Size = new Size(239, 40);
            tbx_pesquisar.TabIndex = 0;
            tbx_pesquisar.Text = "Manipular Dados";
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(136, 372);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(142, 54);
            btn_excluir.TabIndex = 1;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(471, 372);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(123, 54);
            btn_alterar.TabIndex = 2;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 177);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // tbx_idade
            // 
            tbx_idade.AutoSize = true;
            tbx_idade.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbx_idade.Location = new Point(22, 235);
            tbx_idade.Name = "tbx_idade";
            tbx_idade.Size = new Size(71, 30);
            tbx_idade.TabIndex = 5;
            tbx_idade.Text = "Idade:";
            // 
            // tbx_posicao
            // 
            tbx_posicao.AutoSize = true;
            tbx_posicao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbx_posicao.Location = new Point(22, 302);
            tbx_posicao.Name = "tbx_posicao";
            tbx_posicao.Size = new Size(91, 30);
            tbx_posicao.TabIndex = 6;
            tbx_posicao.Text = "Posição:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 7;
            // 
            // tbx_pesquisarid
            // 
            tbx_pesquisarid.AutoSize = true;
            tbx_pesquisarid.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbx_pesquisarid.Location = new Point(22, 95);
            tbx_pesquisarid.Name = "tbx_pesquisarid";
            tbx_pesquisarid.Size = new Size(172, 30);
            tbx_pesquisarid.TabIndex = 9;
            tbx_pesquisarid.Text = "Pesquisar por id:";
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(396, 98);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(87, 32);
            btn_pesquisar.TabIndex = 10;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // tbx_nome
            // 
            tbx_nome.Location = new Point(106, 184);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(100, 23);
            tbx_nome.TabIndex = 11;
            // 
            // tbx_idade1
            // 
            tbx_idade1.Location = new Point(106, 242);
            tbx_idade1.Name = "tbx_idade1";
            tbx_idade1.Size = new Size(100, 23);
            tbx_idade1.TabIndex = 12;
            // 
            // tbx_posicao1
            // 
            tbx_posicao1.Location = new Point(106, 309);
            tbx_posicao1.Name = "tbx_posicao1";
            tbx_posicao1.Size = new Size(100, 23);
            tbx_posicao1.TabIndex = 13;
            // 
            // pesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tbx_posicao1);
            Controls.Add(tbx_idade1);
            Controls.Add(tbx_nome);
            Controls.Add(btn_pesquisar);
            Controls.Add(tbx_pesquisarid);
            Controls.Add(textBox1);
            Controls.Add(tbx_posicao);
            Controls.Add(tbx_idade);
            Controls.Add(label2);
            Controls.Add(btn_alterar);
            Controls.Add(btn_excluir);
            Controls.Add(tbx_pesquisar);
            Name = "pesquisar";
            Text = "pesquisar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tbx_pesquisar;
        private Button btn_excluir;
        private Button btn_alterar;
        private Label label2;
        private Label tbx_idade;
        private Label tbx_posicao;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label tbx_pesquisarid;
        private Button btn_pesquisar;
        private TextBox tbx_nome;
        private TextBox tbx_idade1;
        private TextBox tbx_posicao1;
    }
}