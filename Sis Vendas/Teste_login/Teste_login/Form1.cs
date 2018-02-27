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

namespace Teste_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Logado = false;
        public bool verificarLogin()
        {
            
            string stringConexao = "SERVER=localhost; DATABASE=vendas_mega; UID=root; PWD=3103";

            MySqlConnection conexao = new MySqlConnection();

            conexao.ConnectionString = stringConexao;

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM usuario WHERE login = '" + txt_usuario.Text + "' AND senha = '" + txt_senha.Text + "';", conexao);

                conexao.Open();

                MySqlDataReader dados = comando.ExecuteReader();

                return dados.HasRows;

            }catch(Exception erro){
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
            
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text.Trim() == string.Empty || txt_senha.Text.Trim() == string.Empty){

                MessageBox.Show("Os campos Login e Senha devem ser preenchidos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else{

                 bool resultado = verificarLogin();

            Logado = resultado;

            if (resultado)
            {
                this.Hide();
                Form2 from = new Form2();
                from.Show();
            }
            else
            {
                MessageBox.Show("Não foi possivel logar, login ou senha inválidos");
            }

            }

           
        }

               
    }
}
