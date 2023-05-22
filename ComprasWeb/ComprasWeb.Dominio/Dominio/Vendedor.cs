using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComprasWeb.Dominio.Dominio
{
    [Table("tb_Vendedor")]
    public class Vendedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idvendedor { get; set; }

        public string NomeVendedor { get; set; }

        public string EmailVendedor { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("Usuario")]
        public int Id_Usuario { get; set; }
    }
}
