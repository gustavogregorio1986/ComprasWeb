using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComprasWeb.Dominio.Dominio
{
    [Table("tb_Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }

        public string User { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Perfil { get; set; }
    }
}
