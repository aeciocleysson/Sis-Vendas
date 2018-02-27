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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        // Método para limpar os campos
        private void LimparCampo()
        {
            txt_cliente.Clear();
            txt_end.Clear();
            mtb_cel.Clear();
            mtb_tel.Clear();
            txt_cliente.Focus();
        }

        // Método para cadastrar cliente
        private void CadastrarCliente(Cliente cliente)
        {
            if (txt_cliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo Nome é obrigatório", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cliente.Focus();
            }
            else
            {

                ClienteBll bll = new ClienteBll();

                cliente.Nome_Cliente = txt_cliente.Text;
                cliente.Endereco = txt_end.Text;
                cliente.Telefone = mtb_tel.Text;
                cliente.Celular = mtb_cel.Text;

                cliente.Tipo_Pessoa = "4";

                bll.Cadastrar(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampo();
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            CadastrarCliente(cliente);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (txt_cliente.Text.Trim() == "" || txt_end.Text.Trim() == "")
            {
                Close();
            }
            else if (MessageBox.Show("Deseja sair sem salvar os dados digitados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }
    }
}
