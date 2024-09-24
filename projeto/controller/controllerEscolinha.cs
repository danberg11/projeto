using projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.controller
{
    internal class controllerEscolinha
    {
        public void Enviarbanco()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_CadastrarJogador", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", escolinha.Nome);
                cmd.Parameters.AddWithValue("@idade", escolinha.Idade);
                cmd.Parameters.AddWithValue("@posicao", escolinha.Posicao);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sejam bem-vindos ao nosso time! Juntos, vamos alcançar grandes conquistas e fazer a diferença!");
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirBanco()
            {
                SqlConnection cn = new SqlConnection(conexao.Conectar());
                SqlCommand cmd = new SqlCommand("P_Excluir", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@Id", escolinha.Id);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados do Jogador Excluidos com Sucesso!");
                }
                catch (Exception)
                {
                    throw;
                }
            }

        public void Pesquisar()
            {
                SqlConnection cn = new SqlConnection(conexao.Conectar());
                SqlCommand cmd = new SqlCommand("P_Pesquisar", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try

                {

                    cmd.Parameters.AddWithValue("@id", escolinha.Id);

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    var dr = cmd.ExecuteReader();

                    if (dr.Read())

                    {

                        escolinha.Nome = dr["nome"].ToString();

                        escolinha.Idade = (int) dr["idade"];

                        escolinha.Posicao = dr["posicao"].ToString();

                        escolinha.Id = (int)dr["id"];



                    }

                    else

                    {

                        escolinha.Nome = "";

                        escolinha.Idade = 0;

                        escolinha.Posicao = "";

                        escolinha.Id = 0;

                        MessageBox.Show("Código não localizado.");

                    }

                }

                catch (Exception)

                {

                    throw;

                }

            }

        public void PesquisaCodigo()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_Pesquisar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Id", escolinha.Id);
                cn.Open();
                cmd.ExecuteNonQuery();

                var bb = cmd.ExecuteReader();
                if (bb.Read())
                {
                    escolinha.Id = Convert.ToInt32(bb["Id"]);
                    escolinha.Nome = (string)bb["nome"];
                    escolinha.Idade = Convert.ToInt32(bb["idade"]);
                    escolinha.Posicao = (string)bb["posicao"];
                }
                else
                {
                    escolinha.Id = 0;
                    escolinha.Nome = "";
                    escolinha.Idade = 0;
                    escolinha.Posicao = "";
                }

                }
            catch (Exception)
            {
                throw;
            }
            }

        public static BindingSource visualizarAtleta()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            {
                cmd.Parameters.AddWithValue("@nome", escolinha.Nome);
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                BindingSource dados = new BindingSource();
                dados.DataSource = table;

                return dados;

            }
        }

        public void alterar()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_Alterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@id", escolinha.Id);
                cmd.Parameters.AddWithValue("@nome", escolinha.Nome);
                cmd.Parameters.AddWithValue("@idade", escolinha.Idade);
                cmd.Parameters.AddWithValue("@posicao", escolinha.Posicao);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com Sucesso!");
            }
            catch (Exception) {
                throw;
              
            
                }
            }

        }

    }
   