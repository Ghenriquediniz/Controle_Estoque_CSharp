using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Controle_G_
{
    public partial class Frm_main : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string strSQL;

        public Frm_main()
        {
            InitializeComponent();

        }

        private void LimparCampos()
        {
            txt_descricao.Text = "";
            txt_codigo.Text = "";
            txt_qtd.Text = "";
            txt_valor.Text = "";
            txt_qtdAlterar.Text = "";
            txt_vlrAlterar.Text = "";
            txt_codigoAlterar.Text = "";
            txt_descricaoAlterar.Text = "";
        }

        private void AtualizarTabela()
        {
            try
            {
                conexao = new SqlConnection("Server=Guilherme\\SQLG ;Database=Estoque ;User Id=sa ;Password= 3273;");
                strSQL = "SELECT * FROM \"TABELAESTOQUE\"";
                comando = new SqlCommand(strSQL, conexao);
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();

                // Limpa a tabela antes de atualizar
                dt_grid.Rows.Clear();

                while (dr.Read())
                {
                    // Obtém os valores das colunas do resultado da consulta
                    string codigo = dr["CODIGO"].ToString();
                    string descricao = dr["DESCRICAO"].ToString();
                    string quantidade = dr["QUANTIDADE"].ToString();
                    string valor = dr["VALOR"].ToString();

                    // Adiciona os valores na tabela
                    dt_grid.Rows.Add(codigo, descricao, quantidade, valor);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            // Colunas para atualização do Grid
            dt_grid.Columns.Add("Codigo", "Código");
            dt_grid.Columns.Add("Descricao", "Descrição");
            dt_grid.Columns.Add("Quantidade", "Quantidade");
            dt_grid.Columns.Add("Valor", "Valor");

            AtualizarTabela();
        }

        //Botão Novo
        private void btn_novo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_descricao.Text) || string.IsNullOrWhiteSpace(txt_qtd.Text) || string.IsNullOrWhiteSpace(txt_valor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            try
            {
                conexao = new SqlConnection("Server=Guilherme\\SQLG ;Database=Estoque ;User Id=sa ;Password= 3273;");

                /*Verifica se o código já está cadastrado*/
                strSQL = "SELECT COUNT(*) FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txt_codigo.Text);

                conexao.Open();
                int count = (int)comando.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("O código fornecido já está cadastrado.");
                    return;
                }

                /* Insere o novo registro*/
                strSQL = "INSERT INTO \"TABELAESTOQUE\" (CODIGO, DESCRICAO, QUANTIDADE, VALOR) VALUES (@CODIGO, @DESCRICAO, @QUANTIDADE, @VALOR)";
                comando.CommandText = strSQL;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@CODIGO", txt_codigo.Text);
                comando.Parameters.AddWithValue("@DESCRICAO", txt_descricao.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txt_qtd.Text);
                comando.Parameters.AddWithValue("@VALOR", txt_valor.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Item Novo Adicionado!");
                LimparCampos();
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao = null;
                comando = null;
                comando.Dispose();
            }
        }

        //Botão Exibir
        private void btn_exibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=Guilherme\\SQLG ;Database=Estoque ;User Id=sa ;Password= 3273;");
                strSQL = "SELECT * FROM \"TABELAESTOQUE\"";
                comando = new SqlCommand(strSQL, conexao);
                conexao.Open();

                SqlDataReader dr = comando.ExecuteReader();

                // Limpar as linhas existentes no DataGridView
                dt_grid.Rows.Clear();

                while (dr.Read())
                {
                    string codigo = dr["CODIGO"].ToString();
                    string descricao = dr["DESCRICAO"].ToString();
                    string quantidade = dr["QUANTIDADE"].ToString();
                    string valor = dr["VALOR"].ToString();

                    dt_grid.Rows.Add(codigo, descricao, quantidade, valor);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }
        }

        //Botão Excluir
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text))
            {
                MessageBox.Show("O campo Código é obrigatório.");
                return;
            }
            try
            {
                conexao = new SqlConnection("Server=Guilherme\\SQLG ;Database=Estoque ;User Id=sa ;Password= 3273;");
                strSQL = "SELECT COUNT(*) FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txt_codigo.Text);
                conexao.Open();

                    int count = (int)comando.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("O código fornecido não existe.");
                            return;
                        }

                //Executar da Exclução
                strSQL = "DELETE FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando.CommandText = strSQL;
                comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluído com sucesso.");
                AtualizarTabela();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comando.Dispose();
            }

        }

        private void dt_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text))
            {
                MessageBox.Show("O campo Código é obrigatório.");
                return;
            }
            try
            {
                
                conexao = new SqlConnection("Server=Guilherme\\SQLG;Database=Estoque;User Id=sa;Password=3273;");

                /*Validação*/
                strSQL = "SELECT COUNT(*) FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txt_codigo.Text);

                conexao.Open();

                int count = (int)comando.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("O código fornecido não existe.");
                        return;
                    }

                /*Consulta*/
                strSQL = "SELECT * FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@CODIGO", txt_codigo.Text);
                conexao.Open();

                SqlDataReader dr = comando.ExecuteReader();

                
                dt_grid.Rows.Clear();

                    while (dr.Read())
                    {
                        // Obtém os valores das colunas do resultado da consulta
                        string codigo = dr["CODIGO"].ToString();
                        string descricao = dr["DESCRICAO"].ToString();
                        string quantidade = dr["QUANTIDADE"].ToString();
                        string valor = dr["VALOR"].ToString();

                        // Adiciona os valores como nova linha no DataGridView
                        dt_grid.Rows.Add(codigo, descricao, quantidade, valor);
                    }

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Close();
                comando.Dispose();
            }

        }


        //Alterar
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigoAlterar.Text))
            {
                MessageBox.Show("O campo Código é obrigatório.");
                return;
            }
            try
            {
                conexao = new SqlConnection("Server=Guilherme\\SQLG ;Database=Estoque ;User Id=sa ;Password= 3273;");
                strSQL = "SELECT COUNT(*) FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txt_codigoAlterar.Text);

                conexao.Open();

                int count = (int)comando.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("O código fornecido não existe.");
                    return;
                }

                strSQL = "SELECT * FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@CODIGO", txt_codigoAlterar.Text);

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    txt_descricaoAlterar.Text = dr["DESCRICAO"].ToString();
                    txt_qtdAlterar.Text = dr["QUANTIDADE"].ToString();
                    txt_vlrAlterar.Text = dr["VALOR"].ToString();
                }
                else
                {
                    MessageBox.Show("O código fornecido não existe.");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }
        }

        private void txt_codigoAlterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descricaoAlterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qtdAlterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_vlrAlterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_alterarok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigoAlterar.Text))
            {
                MessageBox.Show("O campo Código é obrigatório.");
                return;
            }

            try
            {
                conexao = new SqlConnection("Server=Guilherme\\SQLG ;Database=Estoque ;User Id=sa ;Password= 3273;");
                strSQL = "SELECT COUNT(*) FROM \"TABELAESTOQUE\" WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txt_codigoAlterar.Text);

                conexao.Open();

                int count = (int)comando.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("O código fornecido não existe.");
                    return;
                }

                strSQL = "UPDATE \"TABELAESTOQUE\" SET DESCRICAO = @DESCRICAO, QUANTIDADE = @QUANTIDADE, VALOR = @VALOR WHERE CODIGO = @CODIGO";
                comando.CommandText = strSQL;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@DESCRICAO", txt_descricaoAlterar.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txt_qtdAlterar.Text);
                comando.Parameters.AddWithValue("@VALOR", txt_vlrAlterar.Text);
                comando.Parameters.AddWithValue("@CODIGO", txt_codigoAlterar.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Registro alterado com sucesso.");
                LimparCampos();
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tool_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
