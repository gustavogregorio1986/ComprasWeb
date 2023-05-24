using ComprasWeb.Data.DTO;
using ComprasWeb.Data.Repositorio.Interface;
using ComprasWeb.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasWeb.Data.Repositorio
{
    public class UsuarioRepositorio : GenericRepositorio<UsuarioDTO>, IUsuarioRepositorio
    {
    }
}
