using ComprasWeb.Data.DTO;
using ComprasWeb.Dominio.Dominio;
using ComprasWeb.Servico.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComprasWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private UsuarioServico usuarioServico;

        public UsuarioController()
        {
            usuarioServico = new UsuarioServico();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CadastrarUsuario(Usuario usuario)
        {
            usuario = new Usuario();
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            usuario.IdUser = usuarioDTO.IdUser;
            usuario.User = usuarioDTO.User;
            usuario.Senha = usuarioDTO.Senha;
            usuario.Email = usuarioDTO.Email;
            usuario.Perfil = usuarioDTO.Perfil;
            return new JsonResult(usuario);
        }
    }
}
