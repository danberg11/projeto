namespace projeto.view
{
    partial class pesquisarid
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            idade = new DataGridViewTextBoxColumn();
            posicao = new DataGridViewTextBoxColumn();
            btn_pesquisar = new Button();
            tbx_nome = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 26);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Alterar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, idade, posicao });
            dataGridView1.Location = new Point(173, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 74);
            dataGridView1.TabIndex = 15;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // idade
            // 
            idade.HeaderText = "Idade";
            idade.Name = "idade";
            // 
            // posicao
            // 
            posicao.HeaderText = "Posicao";
            posicao.Name = "posicao";
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(440, 97);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(75, 23);
            btn_pesquisar.TabIndex = 17;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // tbx_nome
            // 
            tbx_nome.Location = new Point(285, 99);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(124, 23);
            tbx_nome.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 97);
            label2.Name = "label2";
            label2.Size = new Size(224, 25);
            label2.TabIndex = 19;
            label2.Text = "Digite o nome do Atleta:";
            // 
            // pesquisarid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(tbx_nome);
            Controls.Add(btn_pesquisar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "pesquisarid";
            Text = "pesquisarid";
            Load += pesquisarid_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn idade;
        private DataGridViewTextBoxColumn posicao;
        private Button btn_pesquisar;
        private TextBox tbx_nome;
        private Label label2;
    }
}