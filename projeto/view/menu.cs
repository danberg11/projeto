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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void inscreverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home telaHome = new home();
            telaHome.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisar telaHome = new pesquisar();
            telaHome.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarid telaHome = new pesquisarid();
            telaHome.Show();
        }
    }
}
