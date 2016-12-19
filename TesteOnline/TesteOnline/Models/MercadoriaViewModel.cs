using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace Ecommerce.Web.Models
{
    public class MercadoriaViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string NomeMercadoria { get; set; }
        [RegularExpression("([0-9]+)")]
        public int Quantidade { get; set; }
        [RegularExpression(@"^-?(0|[1-9]\d{0,3})([,\.]\d{1,2})?$"),]
        public decimal Preco { get; set; }
        [Display ( Name="Qual o tipo de negocio?")]
        public string TipoNegocio { get; set; }
    }
}