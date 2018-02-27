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
    public partial class RelacaoVendas : Form
    {
        Conexao cone = new Conexao();
        public RelacaoVendas()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void RelacaoVendas_Load(object sender, EventArgs e)
        {
            BuscarVenda();
        }

        private void BuscarVenda()
        {
           try
            {
                cone.AbrirConexao();

                    DataTable dt = new DataTable();

                    cone.Cmd = new MySqlCommand("SELECT pedido.id_pedido AS 'Cód.V', pedido.data_pedido AS 'Data', usuario.nome AS 'Vendedor', cliente.nome AS 'Cliente',  itens_pedido.produto AS 'Cód.Prod', estoque.descricao AS 'Produto', itens_pedido.quantidade AS 'Qt', itens_pedido.valor_unitario AS 'VL Uni', itens_pedido.valor_total AS 'VL Parc', pedido.valor_total_pedido AS 'VL Total', s.descrcao AS 'Situação' FROM itens_pedido JOIN estoque ON estoque.id_produto = itens_pedido.produto	JOIN pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN usuario ON  usuario.id_usuario =  pedido.vendedor JOIN cliente ON cliente.id_cliente = pedido.cliente JOIN situacao_pedido s ON s.id_situacao = pedido.situacao ORDER BY pedido.id_pedido", cone.Con);


                    MySqlDataAdapter Da = new MySqlDataAdapter(cone.Cmd);
                    Da.Fill(dt);
                    dg_venda.DataSource = dt;

                    dg_venda.Columns[0].Width = 50;
                    dg_venda.Columns[4].Width = 50;
                    dg_venda.Columns[6].Width = 50;
                    dg_venda.Columns[7].Width = 60;
                    dg_venda.Columns[8].Width = 60;
                    dg_venda.Columns[9].Width = 60;
                    dg_venda.Columns[10].Width = 70;

               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ", "\n" + erro);
            }

        }

        public void PesquisaClientes()
        {
     
            try
            {
                cone.AbrirConexao();

                DataTable dt = new DataTable();

                cone.Cmd = new MySqlCommand("SELECT pedido.id_pedido AS 'Cód.V', pedido.data_pedido AS 'Data', usuario.nome AS 'Vendedor', cliente.nome AS 'Cliente',  itens_pedido.produto AS 'Cód.Prod', estoque.descricao AS 'Produto', itens_pedido.quantidade AS 'Qt', itens_pedido.valor_unitario AS 'VL Uni', itens_pedido.valor_total AS 'VL Parc', pedido.valor_total_pedido AS 'VL Total', s.descrcao AS 'Situação' FROM itens_pedido JOIN estoque ON estoque.id_produto = itens_pedido.produto JOIN pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN usuario ON  usuario.id_usuario =  pedido.vendedor JOIN cliente ON cliente.id_cliente = pedido.cliente JOIN situacao_pedido s ON s.id_situacao = pedido.situacao WHERE cliente.nome LIKE @cliente", cone.Con);

                cone.Cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = "%" + txt_cliente.Text + "%";

                MySqlDataAdapter Da = new MySqlDataAdapter(cone.Cmd);
                Da.Fill(dt);
                dg_venda.DataSource = dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_cliente.Text == "")
            {
                BuscarVenda();
            }
            else
            {
                PesquisaClientes();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}