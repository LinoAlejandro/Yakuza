using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class UsuariosUtilerias
    {

        private static YakuzaDBEntities db = new YakuzaDBEntities();

        public static Boolean isNickNameUnique(String nickName)
        {
            
            List<Usuario> usuarios = db.Usuario.Where(u => u.nickNameUsuario == nickName).ToList();

            return usuarios.Count == 0;
        }

        public static void createUsuario(Usuario usuario)
        {
            db.Usuario.Add(usuario);
            db.SaveChanges();

            Usuario newUsuario = db.Usuario.Where(u => u.nickNameUsuario == usuario.nickNameUsuario).First();

            Consumidor consumidor = new Consumidor();
            consumidor.IdUsuario = newUsuario.IdUsuario;

            db.Consumidor.Add(consumidor);
            db.SaveChanges();
        }
    }
}