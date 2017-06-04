using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class UsuariosUtilerias
    {
        public static Boolean isNickNameUnique(String nickName)
        {
            YakuzaEntities db = new YakuzaEntities();
            List<Usuario> usuarios = db.Usuario.Where(u => u.nickNameUsuario == nickName).ToList();

            return usuarios.Count == 0;
        }
    }
}