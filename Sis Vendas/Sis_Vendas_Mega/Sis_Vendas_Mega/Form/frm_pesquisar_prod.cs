using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sis_Vendas_Mega.Bll;
using MySql.Data.MySqlClient;

namespace Sis_Vendas_Mega
{
    public partial class frm_pesquisar_prod : Form
    {
        public frm_pesquisar_prod()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ListarProdutos();
        }

        // Método para listar os produtos no grid
        private void ListarProdutos()
        {
            EstoqueBll bll = new EstoqueBll();

            dg_produto.DataSource = bll.ListarProdutos();

            dg_produto.Columns[0].HeaderText = "Código";
            dg_produto.Columns[1].HeaderText = "Descrição do Produto";
            dg_produto.Columns[2].HeaderText = "Qt Estoque";
            dg_produto.Columns[5].HeaderText = "Qt Mínima em Estoque";
            //dg_produto.Columns[6].HeaderText = "Qt Máxima em Estoque";
            dg_produto.Columns[3].HeaderText = "Valor";
            dg_produto.Columns[4].HeaderText = "Dt de cadastro";

            dg_produto.Columns[0].Width = 70;
            dg_produto.Columns[1].Width = 200;

        }

        // Método para pesquisar produto
        public void PesquisaProduto()
        {
            string conecta = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";
            MySqlConnection conexao = null;
            MySqlCommand comando = null;

            try
            {
                DataTable dt = new DataTable();

                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("SELECT * FROM estoque WHERE descricao_produto LIKE @descricao ORDER BY descricao_produto", conexao);

                comando.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = "%" + txt_pesquisar.Text + "%";

                MySqlDataAdapter Da = new MySqlDataAdapter(comando);
                Da.Fill(dt);
                dg_produto.DataSource = dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Campo para digitar a pesquisa
        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txt_pesquisar.Text == "")
            {
                ListarProdutos();
            }
            else
            {
                PesquisaProduto();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Selecionar()
        {
            if (dg_produto.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

    }


}
