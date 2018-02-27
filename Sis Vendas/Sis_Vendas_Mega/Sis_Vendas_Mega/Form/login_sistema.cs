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
using Sis_Vendas_Mega.Model;
using LibaryConnection;

namespace Sis_Vendas_Mega
{

    public partial class login__sistema : Form
    {
        // váriavel que recebe o usuário conectado
        public static string usuarioConectado = "";
        public static int idUsuario;

        public string cargo;
        public int id;

        private bool Logado = false;

        Conexao conexao = new Conexao();
        public login__sistema()
        {
            InitializeComponent();
        }

        public bool verificarLogin()
        {                 
            try
            {
                conexao.AbrirConexao();
                conexao.Cmd = new MySqlCommand("SELECT * FROM usuario WHERE login = '" + txtUsuario.Text + "' AND senha = '" + txtSenha.Text + "'", conexao.Con);


                MySqlDataReader dados = conexao.Cmd.ExecuteReader();
                Usuario user = new Usuario();
               
                if (dados.Read())
                {
                    cargo = dados.GetString("tipo_pessoa");
                    id = dados.GetInt16("id_usuario");
                    idUsuario = id;
                    string usuarioLogado = user.Login;
                    
                    //Variaveil usuarioConectado foi criada no inicio da tela e recebe campo usuariotextBox.Text

                    usuarioConectado = txtUsuario.Text;
                }
                                 
           
               return dados.HasRows;

               
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.FecharConexao();
            }

        }

        private void logar()
        {
            if (txtUsuario.Text.Trim() == string.Empty || txtSenha.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Os campos Login e Senha devem ser preenchidos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else
            {

                bool resultado = verificarLogin();

                Logado = resultado;

                if (resultado)
                {
                    this.Hide();
                    Principal principal = new Principal();
                    principal.Show();

                }
                else
                {
                    MessageBox.Show("Não foi possivel logar, login ou senha inválidos");
                }

            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            logar();          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                logar();
            }
        }

        private void login__sistema_Load(object sender, EventArgs e)
        {
          
        }


     }
  }

