using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComprasWeb.Dominio.Dominio
{
    [Table("tb_Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string Sexo { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("Usuario")]
        public int Id_Usuario { get; set; }
    }
}
