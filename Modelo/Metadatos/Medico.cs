using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(MedicoMetaData))]
    public partial class Medico
    {
    }

    public class MedicoMetaData
    {
        [Required]
        [StringLength(10)]
        public string cedula { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo no puede tener más de 50 caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo no puede tener más de 50 caracteres")]
        public string apellidoPaterno { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo no puede tener más de 50 caracteres")]
        public string apellidoMaterno { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string esEspecialista { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string habilitado { get; set; }
    }
}
