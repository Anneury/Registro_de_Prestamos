using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_de_Prestamos.Model
{
    public class Prestamos
    {
        [Key]
        [Required(ErrorMessage = "No debe de estar Vacío este campo")]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío este campo")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío este campo")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío este campo")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío este campo")]
        public float Monto { get; set; }

        public float Balance { get; set; }
    }
}
