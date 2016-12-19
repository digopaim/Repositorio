using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.core.Entities
{
    public class Mercadoria
    {
        [Key]
        public int Id { get; set; }
        public string NomeMercadoria { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string TipoNegocio { get; set; }
    }
}
