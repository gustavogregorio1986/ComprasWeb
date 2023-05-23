using ComprasWeb.Dominio.Dominio;
using ComprasWeb.Models;
using ComprasWeb.Servico.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComprasWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioServico usuarioServico;

        public UsuarioController()
        {
            usuarioServico = new UsuarioServico();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Cadastrar(Usuario usuario)
        {
            usuario = new Usuario();
            UsuarioView usuarioView = new UsuarioView();
            usuarioView.IdUser = usuario.IdUser;
            usuarioView.User = usuario.User;
            usuarioView.Senha = usuario.Senha;
            usuarioView.Perfil = usuario.Perfil;
            usuarioView.Email = usuario.Email;
            usuarioServico.Adicionar(usuario);
            return new JsonResult(usuario);
        }
    }
}
