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

        private UsuarioServico usuarioServico;

        public UsuarioController()
        {
            usuarioServico = new UsuarioServico();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Cadastrar(Usuario usuario)
        {
            
            return new JsonResult(usuario);
        }
    }
}
