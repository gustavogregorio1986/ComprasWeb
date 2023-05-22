using ComprasWeb.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasWeb.Data.Contexto
{
    public class ComprasWebContexto : DbContext
    {
        public ComprasWebContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Loja> lojas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
