using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComprasWeb.Dominio.Dominio
{
    [Table("tb_Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public Loja Loja { get; set; }

        [ForeignKey("Loja")]
        public int Id_Loja { get; set; }
    }
}
