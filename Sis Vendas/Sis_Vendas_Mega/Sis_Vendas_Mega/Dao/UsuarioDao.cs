using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sis_Vendas_Mega.Model;
using MySql.Data.MySqlClient;
using System.Data;
using LibaryConnection;

namespace Sis_Vendas_Mega.Dao
{
    class UsuarioDao : Conexao
    {        
        // Método para cadastrar usuarios
        public void Cadastrar(Usuario usuario)
        {
            try
            {
                AbrirConexao();
                
                Cmd = new MySqlCommand("INSERT INTO usuario (id_usuario, nome, login, senha, tipo_pessoa) VALUES (@id, @nome, @login, @senha, @tipo_pessoa)", Con);

                Cmd.Parameters.AddWithValue("@id", usuario.Id_Usuario);
                Cmd.Parameters.AddWithValue("@nome", usuario.Nome_Usuario);
                Cmd.Parameters.AddWithValue("@login", usuario.Login);
                Cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                Cmd.Parameters.AddWithValue("@tipo_pessoa", usuario.tipo_usuario);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }

        }

        // Método para listar usuarios

        public DataTable ListarUsuarios()
        {
            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("select u.id_usuario, u.nome, u.login, u.senha, p.tipo_pessoa from usuario u join  pessoa p on p.id_pessoa = u.tipo_pessoa order by nome", Con);

                MySqlDataAdapter Da = new MySqlDataAdapter();

                Da.SelectCommand = Cmd;

                DataTable Dt = new DataTable();

                Da.Fill(Dt);
                
                return Dt;
            }
            catch(Exception erro){
                throw erro;

            }
            finally
            {
                FecharConexao();
            }
        }

        // Método para excluir usuário
        public void ExcluirUsuario(Usuario usuario)
        {
            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("DELETE FROM usuario WHERE id_usuario = @id", Con);

                Cmd.Parameters.AddWithValue("@id", usuario.Id_Usuario);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método para atualiza os dados do usuário
        public void EditarUsuario(Usuario usuario)
        {
            try
            {
                AbrirConexao();

                Cmd = new MySqlCommand("UPDATE usuario SET nome = @nome_usuario, login = @login, senha = @senha WHERE id_usuario = @id", Con);

                Cmd.Parameters.AddWithValue("@id", usuario.Id_Usuario);
                Cmd.Parameters.AddWithValue("@nome_usuario", usuario.Nome_Usuario);
                Cmd.Parameters.AddWithValue("@login", usuario.Login);
                Cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                //comando.Parameters.AddWithValue("@tipo_pessoa", usuario.tipo_usuario);
                
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

                
            
        }

     }

