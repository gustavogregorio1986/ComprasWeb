using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasWeb.Data.DTO
{
    public class UsuarioDTO
    {
        public int IdUser { get; set; }

        public string User { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }
    }
}
