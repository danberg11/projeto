﻿namespace projeto.view
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label2 = new Label();
            btn_salvar = new Button();
            label5 = new Label();
            cbx_posicao = new ComboBox();
            cbx_idade = new ComboBox();
            tbx_nome = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 47);
            label1.TabIndex = 0;
            label1.Text = "Base de Futebol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 89);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 2;
            label3.Text = "Qual sua Idade?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 140);
            label4.Name = "label4";
            label4.Size = new Size(77, 18);
            label4.TabIndex = 3;
            label4.Text = "Posição:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_salvar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbx_posicao);
            groupBox1.Controls.Add(cbx_idade);
            groupBox1.Controls.Add(tbx_nome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(204, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 320);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inscreva-se";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(447, 19);
            label6.Name = "label6";
            label6.Size = new Size(226, 120);
            label6.TabIndex = 11;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 55);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 10;
            label2.Text = "Nome:";
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.DarkSlateGray;
            btn_salvar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_salvar.ForeColor = SystemColors.ButtonHighlight;
            btn_salvar.Location = new Point(189, 242);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(250, 58);
            btn_salvar.TabIndex = 8;
            btn_salvar.Text = "Inscreva-se";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 188);
            label5.Name = "label5";
            label5.Size = new Size(683, 51);
            label5.TabIndex = 7;
            label5.Text = resources.GetString("label5.Text");
            // 
            // cbx_posicao
            // 
            cbx_posicao.BackColor = SystemColors.MenuBar;
            cbx_posicao.FormattingEnabled = true;
            cbx_posicao.Items.AddRange(new object[] { "Goleiro", "Lateral direito", "Lateral esquerdo", "Zagueiro", "Volante", "Meio-campista", "Meio-campista ofensivo ( meia-atacante )", "Ponta-Esquerda", "Ponta-Direita", "Centroavante" });
            cbx_posicao.Location = new Point(89, 140);
            cbx_posicao.Name = "cbx_posicao";
            cbx_posicao.Size = new Size(121, 23);
            cbx_posicao.TabIndex = 6;
            // 
            // cbx_idade
            // 
            cbx_idade.BackColor = SystemColors.MenuBar;
            cbx_idade.FormattingEnabled = true;
            cbx_idade.Items.AddRange(new object[] { "9 ", "11", "13", "15", "17", "20" });
            cbx_idade.Location = new Point(150, 84);
            cbx_idade.Name = "cbx_idade";
            cbx_idade.Size = new Size(113, 23);
            cbx_idade.TabIndex = 5;
            // 
            // tbx_nome
            // 
            tbx_nome.BackColor = SystemColors.MenuBar;
            tbx_nome.Location = new Point(71, 55);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(239, 23);
            tbx_nome.TabIndex = 4;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(958, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "home";
            Text = "home";
            Load += home_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox cbx_posicao;
        private ComboBox cbx_idade;
        private TextBox tbx_nome;
        private Label label5;
        private Button btn_salvar;
        private Label label2;
        private Label label6;
    }
}