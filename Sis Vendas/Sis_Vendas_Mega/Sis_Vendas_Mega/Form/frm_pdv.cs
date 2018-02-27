﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryConnection;
using Sis_Vendas_Mega.Model;
using Sis_Vendas_Mega.Bll;
using MySql.Data.MySqlClient;
using Sis_Vendas_Mega.Dao;

namespace Sis_Vendas_Mega
{
    public partial class frm_pdv : Form
    {
        frm_cad_cli cliente = new frm_cad_cli();

        float totalVenda;

        
        //---------------------------------------------------------------------------------------------------------
        // esse é o método construto do form
        public frm_pdv()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            txt_vendedor.Text = login__sistema.usuarioConectado;
            txt_id_usuario.Text = login__sistema.idUsuario.ToString();
            GerarCodigo();
            
        }

        //---------------------------------------------------------------------------------------------------------
        // esse método faz o select na tabela Pedido, e pega o id da última venda e mostra na tela qual sera o id da proxima venda  
        public void GerarCodigo()
        {

            MySqlConnection conexao = null;
            MySqlCommand comando = null;
            string conecta = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";

           
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("SELECT max(id_pedido) FROM pedido", conexao);

                conexao.Open();

                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    txt_cod_venda.Text = "1";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    txt_cod_venda.Text = ra.ToString();
                }


            }

            catch (Exception erro)
            {
                throw erro;
            }
        }

        //---------------------------------------------------------------------------------------------------------
        // Método para limpar campos
        private void LimparCamposIncluir()
        {
            txt_cod_prod.Clear();
            txt_descricao.Clear();
            txt_preco.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();
        }
        //---------------------------------------------------------------------------------------------------------

        
        string validarCampoCaixa = "";
        public DateTime data;

        // Load do form
        //---------------------------------------------------------------------------------------------------------
        
        private void frm_pdv_Load(object sender, EventArgs e)
        {
            data = DateTime.Now;
            lbl_data.Text = data.ToShortDateString();
            dg_venda.ColumnCount = 5;
        }
        //---------------------------------------------------------------------------------------------------------


        // Método para buscar cliente pelo botão cliente
        //---------------------------------------------------------------------------------------------------------
        private void Buscarcliente()
        {
            validarCampoCaixa = txt_cod_cli.Text.Trim();

            if (validarCampoCaixa == string.Empty)
            {

                MessageBox.Show("Campo Código Cliente é obrigatório.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_cod_cli.Focus();
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_cod_cli.Text.Trim()) == false)
                    {
                        string cmd = string.Format("SELECT nome_cliente FROM cliente WHERE id_cliente = '{0}'", txt_cod_cli.Text.Trim());

                        DataSet Ds = Utilitario.Executar(cmd);

                        txt_nome_cli.Text = Ds.Tables[0].Rows[0]["nome_cliente"].ToString().Trim();
                        txt_cod_prod.Focus();
                       
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro inesperado, entre em contato com o suporte" + erro.Message);
                    throw erro;
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------


        // Método para selecionar um cliente pelo botão selecionar, assim que o grid cliente abrir
        //---------------------------------------------------------------------------------------------------------
        private void SelecionarCliente()
        {
            frm_cad_cli frmCliente = new frm_cad_cli();
            frmCliente.ShowDialog();

            if (frmCliente.DialogResult == DialogResult.OK)
            {
                txt_cod_cli.Text = frmCliente.dg_cliente.Rows[frmCliente.dg_cliente.CurrentRow.Index].Cells[0].Value.ToString();
                txt_nome_cli.Text = frmCliente.dg_cliente.Rows[frmCliente.dg_cliente.CurrentRow.Index].Cells[1].Value.ToString();

                txt_cod_prod.Focus();
            }
        }
        //---------------------------------------------------------------------------------------------------------


        // Método para selecionar produto pelo botão produto
        //---------------------------------------------------------------------------------------------------------
        
        private void SelecionarProduto()
        {
            frm_pesquisar_prod frmProduto = new frm_pesquisar_prod();
            frmProduto.ShowDialog();

            if (txt_cod_cli.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione um cliente para iniciar uma venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (frmProduto.DialogResult == DialogResult.OK)
            {

                txt_cod_prod.Text = frmProduto.dg_produto.Rows[frmProduto.dg_produto.CurrentRow.Index].Cells[0].Value.ToString();
                txt_descricao.Text = frmProduto.dg_produto.Rows[frmProduto.dg_produto.CurrentRow.Index].Cells[1].Value.ToString();
                txt_preco.Text = frmProduto.dg_produto.Rows[frmProduto.dg_produto.CurrentRow.Index].Cells[3].Value.ToString();

                txt_quantidade.Focus();


            }
        }
        //---------------------------------------------------------------------------------------------------------


        // Método para adicionar os itens no datagrid pelo botão incluir
        //---------------------------------------------------------------------------------------------------------
        public static int cont_linha = 0;
               
        private void IncluirProduto()
        {
            Boolean existe = false;
            int numero_linha = 0;

            if (cont_linha == 0)
            {
                dg_venda.Rows.Add(txt_cod_prod.Text, txt_descricao.Text, txt_preco.Text, txt_quantidade.Text);
                double valor = Convert.ToDouble(dg_venda.Rows[cont_linha].Cells[2].Value) * Convert.ToDouble(dg_venda.Rows[cont_linha].Cells[3].Value);
                dg_venda.Rows[cont_linha].Cells[4].Value = valor;

                cont_linha++;
            }
            else
            {
                foreach (DataGridViewRow linha in dg_venda.Rows)
                {
                    //if (linha.Cells[0].Value.ToString() == txt_cod_prod.Text)
                    //{
                    //    existe = true;
                    //    numero_linha = linha.Index;
                    //}
                }
                if (existe == true)
                {
                    dg_venda.Rows[numero_linha].Cells[3].Value = (Convert.ToDouble(txt_quantidade.Text) + Convert.ToDouble(dg_venda.Rows[numero_linha].Cells[3].Value.ToString()));
                    double valor = Convert.ToDouble(dg_venda.Rows[numero_linha].Cells[2].Value) * Convert.ToDouble(dg_venda.Rows[numero_linha].Cells[3].Value);
                    dg_venda.Rows[numero_linha].Cells[4].Value = valor;
                }
                else
                {
                    dg_venda.Rows.Add(txt_cod_prod.Text, txt_descricao.Text, txt_preco.Text, txt_quantidade.Text);
                    double valor = Convert.ToDouble(dg_venda.Rows[cont_linha].Cells[2].Value) * Convert.ToDouble(dg_venda.Rows[cont_linha].Cells[3].Value);
                    dg_venda.Rows[cont_linha].Cells[4].Value = valor;

                    cont_linha++;

                }
            }
        }
        //---------------------------------------------------------------------------------------------------------


        // Método para totalizar a venda assim que informar a quantidade de produto selecionado
        //---------------------------------------------------------------------------------------------------------
      
        private void TotalVenda()
        {
            totalVenda += float.Parse(txt_valor.Text);
            txt_total_venda.Text = totalVenda.ToString();
        }

        // Botão para incluir os itens no datadrid
        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txt_cod_cli.Text.Trim() == string.Empty || txt_cod_prod.Text.Trim() == string.Empty || 
                txt_quantidade.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione um cliente para iniciar a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IncluirProduto();
                TotalVenda();
                LimparCamposIncluir();
            }

        }

        // Método que cria o pedido assim que clicar no botão estoque 
        private void Pedido(Pedido pedido)
        {
            MySqlConnection conexao = null;
            MySqlCommand comando = null;
            string conecta = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";
            pedido.Situacao_Pedido = Convert.ToInt16(1);
            pedido.Forma_Pag = Convert.ToInt16(1);
           


            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("INSERT INTO pedido (id_pedido, cliente,  vendedor, situacao) VALUES (@id, @cliente, @vendedor, @situacao)", conexao);

               
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@id", pedido.Id_Pedido);
                    comando.Parameters.AddWithValue("@cliente", Convert.ToInt16(txt_cod_cli.Text));
                    comando.Parameters.AddWithValue("@vendedor", Convert.ToInt16(txt_id_usuario.Text));
                    comando.Parameters.AddWithValue("@situacao", pedido.Situacao_Pedido);
                    
                   

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    conexao.Close();
               
            }catch(Exception erro)
            {
                throw erro;
            }
            
        }

        public void AtualizarPedido()
        {
            try
            {
                MySqlConnection conexao = null;
                MySqlCommand comando = null;
                string conecta = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";

                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("UPDATE pedido set valor_total_pedido = @valorTotal WHERE id_pedido = @id_pedido", conexao);

                comando.Parameters.AddWithValue("@valorTotal", txt_total_venda.Text);
                comando.Parameters.AddWithValue("@id_pedido", txt_cod_venda.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }catch(Exception erro)
            {
                throw erro;

            }
           

        }

        // Método para gerar os itens do pedido
        private void ItensPendido(ItensPedido itens)
        {
            Pedido pedido = new Model.Pedido();

            MySqlConnection conexao = null;
            MySqlCommand comando = null;
            string conecta = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";

            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("INSERT INTO itens_pedido (id, id_pedido, produto, quantidade, valor_unitario,  valor_total, desconto) VALUES (@id, @id_pedido, @produto, @quantidade, @valor, @valor_total,  @desconto)", conexao);

                for (int i = 0; i < dg_venda.Rows.Count - 1; i++)
                {

                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@id", itens.Id);
                    comando.Parameters.AddWithValue("@id_pedido", txt_cod_venda.Text);
                    comando.Parameters.AddWithValue("@produto", dg_venda.Rows[i].Cells[0].Value);
                    comando.Parameters.AddWithValue("@quantidade", dg_venda.Rows[i].Cells[0].Value);
                    comando.Parameters.AddWithValue("@valor", Convert.ToDouble(dg_venda.Rows[i].Cells[2].Value).ToString());
                    comando.Parameters.AddWithValue("@valor_total", Convert.ToDouble(dg_venda.Rows[i].Cells[4].Value).ToString());
                    comando.Parameters.AddWithValue("@desconto", itens.Desconto);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    AtualizarPedido();
                    conexao.Close();

                    MessageBox.Show("Venda realizada com sucesso");


                    
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        

        /*======================================================================================================================*/

        // Botão para sair do sistema
        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }



        // Botão para selecionar um cliente
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            
            SelecionarCliente();
        }

        // Botão para selecionar produto
        private void btn_produto_Click(object sender, EventArgs e)
        {
            
           
            SelecionarProduto();
        }

        private void txt_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_valor.Focus();
            }
        }

        private void txt_cod_prod_DoubleClick(object sender, EventArgs e)
        {
            SelecionarProduto();
        }

      
        private void btn_incluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IncluirProduto();
            }
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_quantidade_Validating(object sender, CancelEventArgs e)
        {
            if (txt_quantidade.Text != string.Empty)
            {
                txt_valor.Text = (float.Parse(txt_preco.Text) * float.Parse(txt_quantidade.Text)).ToString();
                btn_incluir.Focus();
            }
            else
            {
                MessageBox.Show("Digite a quantidade de produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantidade.Focus();
            }
        }

        private void btn_efet_venda_Click(object sender, EventArgs e)
        {
            ItensPedido itens = new ItensPedido();
            ItensPendido(itens);
        }

        private void txt_cod_venda_TextChanged(object sender, EventArgs e)
        {
            GerarCodigo();
        }

        private void btn_abrir_venda_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            Pedido(pedido);
            btn_produto.Enabled = true;
            btn_abrir_venda.Enabled = false;
        }
    }
}
