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

namespace Sis_Vendas_Mega
{
    public partial class frm_manu_cliente : Form
    {
        public frm_manu_cliente()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ListarClientes();
        }

        // Método para limpar os campos
        private void LimparCampos()
        {
            txt_cod.Clear();
            txt_cliente.Clear();
            txt_end.Clear();
            txt_pesquisar.Clear();
            mtb_cel.Clear();
            mtb_tel.Clear();
            txt_cliente.Focus();
        }

        // Método para listar os clientes
        private void ListarClientes()
        {
            ClienteBll bll = new ClienteBll();

            dg_cliente.DataSource = bll.ListarClientes();

            dg_cliente.Columns[0].HeaderText = "Código";
            dg_cliente.Columns[1].HeaderText = "Nome";
            dg_cliente.Columns[2].HeaderText = "Endereço";
            dg_cliente.Columns[3].HeaderText = "Telefone";
            dg_cliente.Columns[4].HeaderText = "Celular";
            dg_cliente.Columns[5].HeaderText = "Tipo de Pessoa";

            dg_cliente.Columns[0].Width = 80;
            dg_cliente.Columns[1].Width = 200;
            dg_cliente.Columns[2].Width = 250;
            dg_cliente.Columns[5].Width = 50;

        }


        // Método para pesquisar usuario
        public void PesquisaClientes()
        {
            string conecta = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";
            MySqlConnection conexao = null;
            MySqlCommand comando = null;

            try
            {
                DataTable dt = new DataTable();

                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("SELECT c.id_cliente, c.nome_cliente, c.endereco, c.telefone, c.celular, p.tipo_pessoa FROM cliente c JOIN pessoa p ON p.id_pessoa = c.tipo_pessoa WHERE nome_cliente LIKE @cliente ORDER BY nome_cliente", conexao);

                comando.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = "%" + txt_pesquisar.Text + "%";

                MySqlDataAdapter Da = new MySqlDataAdapter(comando);
                Da.Fill(dt);
                dg_cliente.DataSource = dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // campo para digitar a pesquisa
        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txt_pesquisar.Text == "")
            {
                ListarClientes();
            }
            else
            {
                PesquisaClientes();
            }
        }

        // Método que seta os dados do grid nos textbox
        private void dg_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_cliente.Rows[e.RowIndex];

                txt_cod.Text = row.Cells["id_cliente"].Value.ToString();
                txt_cliente.Text = row.Cells["nome_cliente"].Value.ToString();
                txt_end.Text = row.Cells["endereco"].Value.ToString();
                mtb_tel.Text = row.Cells["telefone"].Value.ToString();
                mtb_cel.Text = row.Cells["celular"].Value.ToString();

            }
        }

        // Método para editar cliente
        private void EditarCliente(Cliente cliente)
        {
            if (txt_cod.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Você deve selecionar um cliente para ser editado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja realmente editar os dados do cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                ClienteBll bll = new ClienteBll();

                cliente.Id_Cliente = Convert.ToInt16(txt_cod.Text);
                cliente.Nome_Cliente = txt_cliente.Text;
                cliente.Endereco = txt_end.Text;
                cliente.Telefone = mtb_tel.Text;
                cliente.Celular = mtb_cel.Text;

                bll.EditarCliente(cliente);

                MessageBox.Show("Cliente editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarClientes();
            }

           


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            EditarCliente(cliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

       

       

    }
}
