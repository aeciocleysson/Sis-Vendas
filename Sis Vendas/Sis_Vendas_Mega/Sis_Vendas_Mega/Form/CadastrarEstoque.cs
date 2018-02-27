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

namespace Sis_Vendas_Mega
{
    public partial class frm_produto : Form
    {
        public frm_produto()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
           
        }

        // Método para cadastrar produto
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
                
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Estoque produto = new Estoque();
            CadastrarProduto(produto);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            if (txt_desc.Text.Trim() == "")
            {
                Close();
            }
            else if (MessageBox.Show("Deseja sair sem cadastrar um produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

      
    }
}
