using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sis_Vendas_Mega.Dao;
using Sis_Vendas_Mega.Model;
using System.Data;

namespace Sis_Vendas_Mega.Bll
{
    class UsuarioBll
    {
        UsuarioDao usuarioDao = null;
        // Método para cadastrar usuários
        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuarioDao = new UsuarioDao();

                usuarioDao.Cadastrar(usuario);
            }
            catch (Exception erro)
            {
                throw erro;
            }         
        }

        // Método para listar usuários

        public DataTable ListarUsuarios()
        {
            try
            {
                DataTable Dt = new DataTable();

                usuarioDao = new UsuarioDao();
                Dt = usuarioDao.ListarUsuarios();

                return Dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para excluir usuário

        public void ExcluirUsuario(Usuario usuario)
        {
            try
            {
                usuarioDao = new UsuarioDao();
                usuarioDao.ExcluirUsuario(usuario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para atualizar usuario
        public void EditarUsuario(Usuario usuario)
        {
            try
            {
                usuarioDao = new UsuarioDao();
                usuarioDao.EditarUsuario(usuario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

     }
}
