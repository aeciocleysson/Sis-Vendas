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
using Sis_Vendas_Mega.Model;
using MySql.Data.MySqlClient;
using LibaryConnection;

namespace Sis_Vendas_Mega
{
    public partial class Caixa : Form
    {
        Conexao cone = new Conexao();
        public Caixa()
        {
            InitializeComponent();
            
        }

      
        // Método para buscar a venda
        private void BuscarVenda()
        {
                                  
            try
            {
                cone.AbrirConexao();

                if (txt_cod_venda.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Digite o código da venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cod_venda.Clear();
                    txt_cod_venda.Focus();

               }else{

                  
                DataTable dt = new DataTable();
                                    
                cone.Cmd= new MySqlCommand("SELECT pedido.id_pedido AS 'Cód.V', "+
                    "+ pedido.data_pedido AS 'Data', "+
                    "+ usuario.nome AS 'Vendedor', "+
                    "+ cliente.nome AS 'Cliente', "+
                    "+ itens_pedido.produto AS 'Cód.Prod', "+
                    "+ estoque.descricao AS 'Produto', "+
                    "+ itens_pedido.quantidade AS 'Qt', "+
                    "+ itens_pedido.valor_unitario AS 'VL Uni', "+
                    "+ itens_pedido.valor_total AS 'VL Parc', "+
                    "+ pedido.valor_total_pedido AS 'VL Total', s.descrcao AS 'Situação' FROM itens_pedido JOIN estoque ON estoque.id_produto = itens_pedido.produto JOIN pedido ON pedido.id_pedido = itens_pedido.id_pedido JOIN usuario ON  usuario.id_usuario =  pedido.vendedor JOIN cliente ON cliente.id_cliente = pedido.cliente JOIN situacao_pedido s ON s.id_situacao = pedido.situacao WHERE pedido.id_pedido LIKE '" + txt_cod_venda.Text + "'", cone.Con);

                              
                MySqlDataAdapter Da = new MySqlDataAdapter(cone.Cmd);
                Da.Fill(dt);
                dg_frente_caixa.DataSource = dt;



                // Seta os campos nos text box
                txt_cliente.Text = dg_frente_caixa.Rows[0].Cells[3].Value.ToString();
                txt_vendedor.Text = dg_frente_caixa.Rows[0].Cells[2].Value.ToString();
                txt_valor_total.Text = dg_frente_caixa.Rows[0].Cells[9].Value.ToString();
                txt_situacao.Text = dg_frente_caixa.Rows[0].Cells[10].Value.ToString();
                dt_venda.Text = dg_frente_caixa.Rows[0].Cells[1].Value.ToString();
                        
               
                 // seta o tamanho das colunas
                dg_frente_caixa.Columns[4].Width = 70;
                dg_frente_caixa.Columns[5].Width = 400;
                dg_frente_caixa.Columns[6].Width = 70;
                dg_frente_caixa.Columns[7].Width = 70;

                // colunas que não seram visiveis
                dg_frente_caixa.Columns[0].Visible = false;
                dg_frente_caixa.Columns[1].Visible = false;
                dg_frente_caixa.Columns[2].Visible = false;
                dg_frente_caixa.Columns[3].Visible = false;
                dg_frente_caixa.Columns[9].Visible = false;
                dg_frente_caixa.Columns[10].Visible = false;
                txt_valor_recebido.Focus();

                }

                
            }
            catch (Exception erro)
            {
                throw erro;
                //MessageBox.Show("Pedido Inexistente \n\n", "Alerta" + erro);
            }
        }

        /*==================================================================================================================================*/
      // metodo que faz os calculos
            private void Calcular()
        {
            Decimal total = Convert.ToDecimal(txt_valor_total.Text);
            Decimal valorRecebido = Convert.ToDecimal(txt_valor_recebido.Text);
            Decimal desconto = Convert.ToDecimal(txt_desconto.Text);
            Decimal troco;


            troco = valorRecebido - total - desconto;
            txt_troco.Text = troco.ToString();
        }

            // Método para finalizar a venda
            // esse método faz um select pelo codigo da venda e muda o status da venda para RECEBIDO apos a confirmação de recebimento
        private void FinalizarVenda(Pedido pedido)
        {

            VendaBll bll = new VendaBll();
           
            pedido.Id_Pedido = Convert.ToInt32(txt_cod_venda.Text);
            pedido.Total_Venda = Convert.ToDecimal(txt_valor_total.Text);

            bll.FinalizarVendas(pedido);

            MessageBox.Show("Venda realizada com sucesso. \n Retire a mercadoria com o seu Vendedor.", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        /*==================================================================================================================================*/



        public void Limpar()
        {
            txt_cod_venda.Clear();
            txt_cliente.Clear();
            dg_frente_caixa.Rows.Clear();
        }
        private void txt_cod_venda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarVenda();
            }
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_valor_recebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_desconto.Focus();
            }

        }
       
        private void txt_item_desconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calcular();
              btn_finalizar.Focus();
            }
        }

        
        private void txt_desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_item_desconto.Focus();
            }
        }

       private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            FinalizarVenda(pedido);
                     
        }

        private void btn_finalizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pedido pedido = new Pedido();
            FinalizarVenda(pedido);     
        }

        private void txt_troco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pedido pedido = new Pedido();
            FinalizarVenda(pedido);
        }

        private void dg_frente_caixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
