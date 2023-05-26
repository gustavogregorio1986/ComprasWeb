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

        [MaxLengthAttribute(80)]
        public string User { get; set; }

        [MaxLengthAttribute(100)]
        public string Senha { get; set; }

        [MaxLengthAttribute(60)]
        public string Email { get; set; }

        [MaxLengthAttribute(20)]
        public string Perfil { get; set; }
    }
}
