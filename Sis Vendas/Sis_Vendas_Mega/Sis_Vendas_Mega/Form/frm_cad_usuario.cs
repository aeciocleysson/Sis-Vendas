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

namespace Sis_Vendas_Mega
{
    public partial class frm_cad_usuario : Form
    {
        public frm_cad_usuario()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
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

        private void LimparCampos()
        {
            txt_nome.Clear();
            txt_login.Clear();
            txt_senha.Clear();
            cb_tipo.SelectedIndex = -1;
            txt_nome.Focus();
        }

        private void CadastrarUsuario(Usuario usuario)
        {
            if (txt_nome.Text.Trim() == string.Empty || txt_login.Text.Trim() == string.Empty ||
                txt_senha.Text.Trim() == string.Empty || cb_tipo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Os campos: Nome, Login, Tipo e Senha devem ser peenchidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
            }
            else
            {

                UsuarioBll bll = new UsuarioBll();

                if (cb_tipo.Text.Trim() == "Administrador")

                    usuario.tipo_usuario = "1";
                else if (cb_tipo.Text.Trim() == "Gerente")
                    usuario.tipo_usuario = "2";
                else if (cb_tipo.Text.Trim() == "Vendedor")
                    usuario.tipo_usuario = "3";

                usuario.Nome_Usuario = txt_nome.Text;
                usuario.Login = txt_login.Text;
                usuario.Senha = txt_senha.Text;

                bll.Cadastrar(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();

                frm_usuario frmusuario = new frm_usuario();
                frmusuario.ListarUsuarios();
              

            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            CadastrarUsuario(usuario);
        }
    }
}
