using AbovePremiere.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbovePremiere.DAOs
{
    class UsuariosDAO
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static void iniciar() 
        {
            listaUsuarios.Add(new Usuario("admin", "admin"));
            listaUsuarios.Add(new Usuario("usuario", "password"));

        }
        public static bool existeUsuario(string usuario, string password) 
        {

            var comprobarUsuario = listaUsuarios.Find(usuarioObj => usuarioObj.usuario == usuario && usuarioObj.password == password);

            if (comprobarUsuario == null) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
