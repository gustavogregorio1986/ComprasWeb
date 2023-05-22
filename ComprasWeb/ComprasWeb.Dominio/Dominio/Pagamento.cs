using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComprasWeb.Dominio.Dominio
{
    [Table("tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public Produto Produto { get; set; }

        [ForeignKey("Produto")]
        public int Id_Produto { get; set; }
    }
}
