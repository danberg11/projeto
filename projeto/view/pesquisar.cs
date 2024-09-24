using projeto.controller;
using projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto.view
{
    public partial class pesquisar : Form
    {
        public pesquisar()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            escolinha.Id = Convert.ToInt32(textBox1.Text);
            controllerEscolinha controllerEscolinha = new controllerEscolinha();
            controllerEscolinha.PesquisaCodigo();

            tbx_nome.Text = escolinha.Nome;
            tbx_idade1.Text = escolinha.Idade.ToString();
            tbx_posicao1.Text = escolinha.Posicao;
            textBox1.Text = escolinha.Id.ToString();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (btn_pesquisar.Text == "")
            {
                MessageBox.Show("Digite o id do Atleta.");
            }
            else
            {
                var id = MessageBox.Show("Deseja excluir os dados do Atleta" + btn_pesquisar.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (id == DialogResult.Yes)
                {
                    escolinha.Id = Convert.ToInt32(textBox1.Text);
                    controllerEscolinha controllerEscolinha = new controllerEscolinha();
                    controllerEscolinha.ExcluirBanco();
                }
                else
                {
                    tbx_nome.Text = "";
                    tbx_idade1.ToString();
                    tbx_posicao1.ToString();
                }

            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite o Codigo do Atleta.");
            }
            else
            {
                {
                    var alterar = MessageBox.Show("Deseja fazer alteração nesses dados" + btn_pesquisar.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (alterar == DialogResult.Yes)
                    {
                        escolinha.Nome = tbx_nome.Text;
                        escolinha.Idade = Convert.ToInt32(tbx_idade1.Text);
                        escolinha.Posicao = tbx_posicao1.Text;
                        escolinha.Id = Convert.ToInt32(textBox1.Text);

                        controllerEscolinha controllerEscolinha = new controllerEscolinha();
                        controllerEscolinha.alterar();

                    }

                    else
                    {
                        tbx_nome.Text = "";
                        tbx_idade1.Text = "";
                        tbx_posicao1.Text = "";
                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

