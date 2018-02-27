using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibaryConnection;

namespace Sis_Vendas_Mega
{
    public partial class PosicaoEstoque : Form
    {
        Conexao cone = new Conexao();
        public PosicaoEstoque()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ListaProduto();
        }

        private void Posicao()
        {
            
            try
            {
                cone.AbrirConexao();

                cone.Cmd = new MySqlCommand("SELECT pedido.id_pedido AS 'Cód.V', estoque.descricao AS 'Produto', pedido.data_pedido AS 'Data',usuario.nome AS 'Vendedor', cliente.nome AS 'Cliente', itens_pedido.quantidade AS 'Qt', itens_pedido.valor_unitario AS 'VL Uni'FROM itens_pedido JOIN estoque ON estoque.id_produto = itens_pedido.produto JOIN pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN usuario ON  usuario.id_usuario =  pedido.vendedor JOIN cliente ON cliente.id_cliente = pedido.cliente JOIN situacao_pedido s ON s.id_situacao = pedido.situacao WHERE itens_pedido.produto = '" + txt_pesquisar.Text.Trim() + "'", cone.Con);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cone.Cmd;

                da.Fill(dt);

                dg_posicao.DataSource = dt;

                dg_posicao.Columns[0].Width = 40;
                dg_posicao.Columns[1].Width = 200;
                dg_posicao.Columns[3].Width = 140;
                dg_posicao.Columns[4].Width = 150;
                dg_posicao.Columns[5].Width = 40;
                dg_posicao.Columns[6].Width = 50;
                
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Posicao();
        }

        private DataTable ListaProduto()
        {
            
            try
            {
                cone.AbrirConexao();

                cone.Cmd = new MySqlCommand("SELECT id_produto AS Cód, descricao AS Produto FROM estoque ORDER BY descricao", cone.Con);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cone.Cmd;
                da.Fill(dt);

                dg_produto.DataSource = dt;

                dg_produto.Columns[0].Width = 30;
                dg_produto.Columns[1].Width = 210;
               


                return dt;
            }
            catch (Exception erro)
            {
                
                throw erro;
            }

        }

        private void txt_pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Posicao();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dg_posicao_DoubleClick(object sender, EventArgs e)
        {
            TelaPosiVenda telaPosiVenda = new TelaPosiVenda();
            telaPosiVenda.Show();

            telaPosiVenda.txt_cod_venda.Text = dg_posicao.Rows[dg_posicao.CurrentRow.Index].Cells[0].Value.ToString();
            telaPosiVenda.txt_vendedor.Text = dg_posicao.Rows[dg_posicao.CurrentRow.Index].Cells[3].Value.ToString();
            telaPosiVenda.txt_cliente.Text = dg_posicao.Rows[dg_posicao.CurrentRow.Index].Cells[4].Value.ToString();
            telaPosiVenda.txt_data_venda.Text = dg_posicao.Rows[dg_posicao.CurrentRow.Index].Cells[2].Value.ToString();
            telaPosiVenda.txt_descricao.Text = dg_posicao.Rows[dg_posicao.CurrentRow.Index].Cells[1].Value.ToString();
            telaPosiVenda.txt_valor.Text = dg_posicao.Rows[dg_posicao.CurrentRow.Index].Cells[6].Value.ToString();
            telaPosiVenda.txt_quantidade.Text = dg_posicao.Rows[dg_posicao.CurrentRow.Index].Cells[5].Value.ToString();
        }
    }
}
