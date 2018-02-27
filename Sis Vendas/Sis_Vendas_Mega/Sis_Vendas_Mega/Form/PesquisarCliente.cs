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
using System.Runtime.InteropServices;
using LibaryConnection;

namespace Sis_Vendas_Mega
{
    public partial class frm_cad_cli : Form
    {
        Conexao cone = new Conexao();
        public frm_cad_cli()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ListarClientes();
            txt_pesquisar.Focus();
        }
             
        private void frm_cad_cli_Load(object sender, EventArgs e)
        {
            FormCloseButtonDisabler.DisableCloseButton(this.Handle.ToInt32());
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
                   
        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (txt_pesquisar.Text.Trim() == "")
            {
                Close();
            }
            else if (MessageBox.Show("Deseja sair sem pesquisar ou incluir um cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        // Método para pesquisar usuario
        public void PesquisaClientes()
        {

            try
            {
                cone.AbrirConexao();

                DataTable dt = new DataTable();

                cone.Cmd = new MySqlCommand("SELECT * FROM cliente JOIN pessoa ON cliente.tipo_pessoa = pessoa.id_pessoa WHERE nome LIKE @cliente ORDER BY nome", cone.Con);

                cone.Cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = "%" + txt_pesquisar.Text + "%";

                MySqlDataAdapter Da = new MySqlDataAdapter(cone.Cmd);
                Da.Fill(dt);
                dg_cliente.DataSource = dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }

           
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            frm_cliente cliente = new frm_cliente();
            DialogResult dialogResult = cliente.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                ListarClientes();
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

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
        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (dg_cliente.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

       

       
    }
}
