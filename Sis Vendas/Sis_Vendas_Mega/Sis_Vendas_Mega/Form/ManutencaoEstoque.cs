using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sis_Vendas_Mega.Model;
using Sis_Vendas_Mega.Bll;
using MySql.Data.MySqlClient;
using LibaryConnection;

namespace Sis_Vendas_Mega
{
    public partial class frm_cad_produto : Form
    {
        Conexao cone = new Conexao();
        public frm_cad_produto()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ListarProdutos();
        }

        // Método para limpar os campos
        private void LimparCampos()
        {
            txt_desc.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();
            txt_desc.Focus();
            txt_mini.Clear();
            txt_maxi.Clear();
            txt_cod.Clear();
        }

        // Método para cadastrar produtos
        private void CadastrarProduto(Estoque produto)
        {
            if (txt_desc.Text.Trim() == string.Empty || txt_valor.Text.Trim() == string.Empty
                || txt_quantidade.Text.Trim() == string.Empty || txt_mini.Text.Trim() == string.Empty || txt_maxi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Os campos: Nome, Quantidade, Valor, Estoque Mínimo, Estoque Máximo e Data de Cadastro devem ser preenchidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_desc.Focus();
            }
            else
            {

                EstoqueBll bll = new EstoqueBll();

                produto.Descricao_Produto = txt_desc.Text;
                produto.Quantidade = Convert.ToInt16(txt_quantidade.Text);
                produto.Valor_Produto = Convert.ToDecimal(txt_valor.Text);
                produto.Data_Cad = Convert.ToDateTime(data_cad.Text);
                produto.Quant_Mini = Convert.ToInt16(txt_mini.Text);
                produto.Quant_Maxi = Convert.ToInt16(txt_maxi.Text);

                bll.Cadastrar(produto);

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarProdutos();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Estoque produto = new Estoque();
            CadastrarProduto(produto);
        }

        // Método para listar os produtos do estoque
        private void ListarProdutos()
        {
            EstoqueBll bll = new EstoqueBll();

            dg_produto.DataSource = bll.ListarProdutos();

            dg_produto.Columns[0].HeaderText = "Código";
            dg_produto.Columns[1].HeaderText = "Descrição do Produto";
            dg_produto.Columns[2].HeaderText = "Qt Estoque";
            dg_produto.Columns[5].HeaderText = "Qt Mínima em Estoque";
            dg_produto.Columns[4].HeaderText = "Qt Máxima em Estoque";
            dg_produto.Columns[5].HeaderText = "Valor";
            
            dg_produto.Columns[0].Width = 70;
            dg_produto.Columns[1].Width = 200;

        }

        private void dg_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_produto.Rows[e.RowIndex];

                txt_cod.Text = row.Cells["id_produto"].Value.ToString();
                txt_desc.Text = row.Cells["descricao"].Value.ToString();
                txt_quantidade.Text = row.Cells["quantidade"].Value.ToString();
                txt_valor.Text = row.Cells["valor_unitario"].Value.ToString();
                txt_mini.Text = row.Cells["quant_min"].Value.ToString();
                txt_maxi.Text = row.Cells["quant_max"].Value.ToString();
                data_cad.Text = row.Cells["data_cad"].Value.ToString();
            }
        }

        private void EditarProduto(Estoque produto)
        {
            if (txt_cod.Text == string.Empty)
            {
                MessageBox.Show("Você deve selecionar um produto para ser editado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja realmente alterar os dados desse produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                LimparCampos();
            }
            else
            {

                EstoqueBll bll = new EstoqueBll();

                produto.Id_Produto = Convert.ToInt16(txt_cod.Text);
                produto.Descricao_Produto = txt_desc.Text;
                produto.Quantidade = Convert.ToInt16(txt_quantidade.Text);
                produto.Valor_Produto = Convert.ToDecimal(txt_valor.Text);
                produto.Data_Cad = Convert.ToDateTime(data_cad.Text);
                produto.Quant_Mini = Convert.ToInt16(txt_mini.Text);
                produto.Quant_Maxi = Convert.ToInt16(txt_maxi.Text);

                bll.EditarProduto(produto);

                MessageBox.Show("Produto editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                ListarProdutos();
            }
                    
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Estoque produto = new Estoque();
            EditarProduto(produto);
        }

        // Método para excluir produtos do estoque
        private void ExcluirProduto(Estoque produto)
        {
            if (txt_cod.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve selecionar um produto para ser excluido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(MessageBox.Show("Dejesa realmente excluir esse produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                EstoqueBll bll = new EstoqueBll();

                produto.Id_Produto = Convert.ToInt16(txt_cod.Text);

                bll.ExcluirProduto(produto);

                MessageBox.Show("Produto excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarProdutos();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Estoque produto = new Estoque();
            ExcluirProduto(produto);
        }

        public void PesquisaProduto()
        {
          
            try
            {
                cone.AbrirConexao();

                DataTable dt = new DataTable();

                cone.Cmd = new MySqlCommand("SELECT * FROM estoque WHERE descricao_produto LIKE @descricao ORDER BY descricao_produto", cone.Con);

                cone.Cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = "%" + txt_pesquisar.Text + "%";

                MySqlDataAdapter Da = new MySqlDataAdapter(cone.Cmd);
                Da.Fill(dt);
                dg_produto.DataSource = dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                cone.FecharConexao();
            }
        }

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

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ListarProdutos();
            LimparCampos();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            if (txt_pesquisar.Text.Trim() == "" && txt_desc.Text.Trim() == "")
            {
                Close();
            }
            else if (MessageBox.Show("Deseja sair sem alterar os dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            frm_produto frmProduto = new frm_produto();
            frmProduto.Show();
        }

        
    }
}
