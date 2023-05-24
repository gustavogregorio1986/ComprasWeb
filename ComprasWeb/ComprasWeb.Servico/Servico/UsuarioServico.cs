using ComprasWeb.Data.DTO;
using ComprasWeb.Data.Repositorio;
using ComprasWeb.Dominio.Dominio;
using ComprasWeb.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasWeb.Servico.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly UsuarioRepositorio usuarioReposiutorio;

        public UsuarioServico()
        {
            usuarioReposiutorio = new UsuarioRepositorio();
        }

        public void Adicionar(UsuarioDTO usuarioDTO)
        {
            usuarioReposiutorio.Adicionar(usuarioDTO);
        }
    }
}
