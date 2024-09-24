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
    public partial class pesquisarid : Form
    {
        public pesquisarid()
        {
            InitializeComponent();
        }

        private void pesquisarid_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            escolinha.Nome = tbx_nome.Text;
            dataGridView1.DataSource = controllerEscolinha.visualizarAtleta();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;



            dataGridView1.Columns[4].HeaderCell.Value = "id";
            dataGridView1.Columns[5].HeaderCell.Value = "nome";
            dataGridView1.Columns[6].HeaderCell.Value = "idade";
            dataGridView1.Columns[7].HeaderCell.Value = "Posição";
        }
    }
}
