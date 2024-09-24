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
using System.Xml;

namespace projeto.view
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            escolinha.Nome = tbx_nome.Text;
            escolinha.Idade = Convert.ToInt32(cbx_idade.Text);
            escolinha.Posicao = cbx_posicao.Text;

            controllerEscolinha controllerEscolinha = new controllerEscolinha();
            controllerEscolinha.Enviarbanco();


        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            escolinha.Nome = tbx_nome.Text;
            escolinha.Idade = Convert.ToInt32(cbx_idade.Text);
            escolinha.Posicao = cbx_posicao.Text;

            controllerEscolinha controllerEscolinha = new controllerEscolinha();
            controllerEscolinha.Enviarbanco();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
           escolinha.Id = Convert.ToInt32(tbx_nome.Text);
           controllerEscolinha controllerescolinha = new controllerEscolinha();
           controllerescolinha.Pesquisar();

            cbx_idade.Text = Convert.ToString(escolinha.Idade);
            cbx_posicao.Text = escolinha.Posicao;

        }
    }
}
