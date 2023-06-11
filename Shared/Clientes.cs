using System.ComponentModel.DataAnnotations;

namespace PizzaPlace_.Shared
{
    public class Clientes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proporcione un nombre")]
        public string Nombre { get; set; } = default!;

        [Required(ErrorMessage = "Proporcione una calle con número de casa")]
        public string Calle { get; set; } = default!;

        [Required(ErrorMessage = "Proporcione una ciudad")]
        public string Ciudad { get; set; } = default!;
    }
}