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

namespace Sis_Vendas_Mega
{
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ListarUsuarios();
            
        }

        // Método para limpar os campos
        private void LimparCampos()
        {
            txt_nome.Clear();
            txt_login.Clear();
            txt_senha.Clear();
            txt_nome.Focus();
            txt_pesquisar.Clear();
            txt_cod.Clear(); txt_tipo.Clear();
            txt_nome.Focus();
         
        }

       // Método para listar usuários
        public void ListarUsuarios()
        {
            UsuarioBll bll = new UsuarioBll();

            dg_usuario.DataSource = bll.ListarUsuarios();

            dg_usuario.Columns[0].HeaderText = "Cód";
            dg_usuario.Columns[1].HeaderText = "Nome";
            dg_usuario.Columns[2].HeaderText = "Login";
            dg_usuario.Columns[3].HeaderText = "Senha";
            dg_usuario.Columns[4].HeaderText = "Tipo de Usuário";

            dg_usuario.Columns[1].Width = 300;
        }

        // Método para pesquisar usuario
        public void PesquisaUsuario()
        {
            string conecta = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";
            MySqlConnection conexao = null;
            MySqlCommand comando = null;

            try
            {
                DataTable dt = new DataTable();

                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("SELECT u.id_usuario, u.nome_usuario, u.login, u.senha, p.tipo_pessoa FROM usuario u join pessoa p ON p.id_pessoa = u.tipo_pessoa WHERE nome_usuario LIKE @usuario order by nome_usuario", conexao);

                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = "%" + txt_pesquisar.Text + "%";

                MySqlDataAdapter Da = new MySqlDataAdapter(comando);
                Da.Fill(dt);
                dg_usuario.DataSource = dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para excluir usuario
        private void ExcluirUsuario(Usuario usuario)
        {
            if (txt_cod.Text.Trim() == "")
            {
                MessageBox.Show("Você deve selecionar um Usuário para ser excluido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse usuário?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                LimparCampos();
            }
            else
            {
                UsuarioBll bll = new UsuarioBll();

                usuario.Id_Usuario = Convert.ToInt16(txt_cod.Text);

                bll.ExcluirUsuario(usuario);

                MessageBox.Show("Usuário excluir com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarUsuarios();
            }
        }

       // Campo para fazer a pesquisa
        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txt_pesquisar.Text == "")
            {
                ListarUsuarios();
            }
            else
            {
                PesquisaUsuario();
            }
        }
        // Método que seta os os dados do datagrid nos textbox

        private void dg_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_usuario.Rows[e.RowIndex];

                txt_cod.Text = row.Cells["id_usuario"].Value.ToString();
                txt_nome.Text = row.Cells["nome_usuario"].Value.ToString();
                txt_login.Text = row.Cells["login"].Value.ToString();
                txt_senha.Text = row.Cells["senha"].Value.ToString();
                txt_tipo.Text = row.Cells["tipo_pessoa"].Value.ToString();

            }
        }

        // Método para editar 
        private void EditarUsuario(Usuario usuario)
        {
            if (txt_cod.Text == string.Empty)
            {
                MessageBox.Show("Você deve selecionar um Usuário para ser editado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            } else if (MessageBox.Show("Deseja alterar os dados desse usuario?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            
            {

            }
            else
            {
                UsuarioBll bll = new UsuarioBll();

                usuario.Id_Usuario = Convert.ToInt16(txt_cod.Text);
                usuario.Nome_Usuario = txt_nome.Text;
                usuario.Login = txt_login.Text;
                usuario.Senha = txt_senha.Text;
               
                bll.EditarUsuario(usuario);

                MessageBox.Show("Os dados do usuário foram alterados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarUsuarios();
                LimparCampos();
            }
        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
       private void btn_sair_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text.Trim() == "")
            {
                Close();
            }
            else if (MessageBox.Show("Deseja sair sem salvar os dados digitados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Close();
            }
        }

       private void btn_novo_Click(object sender, EventArgs e)
       {
           frm_cad_usuario cad_usuario = new frm_cad_usuario();
           cad_usuario.ShowDialog();
       }

       private void btn_atualizar_Click(object sender, EventArgs e)
       {
           LimparCampos();
           ListarUsuarios();
       }

       private void btn_editar_Click_1(object sender, EventArgs e)
       {
           Usuario usuario = new Usuario();
           EditarUsuario(usuario);
       }

       private void btn_excluir_Click(object sender, EventArgs e)
       {
           Usuario usuario = new Usuario();
           ExcluirUsuario(usuario);
       }

             
    }
}
