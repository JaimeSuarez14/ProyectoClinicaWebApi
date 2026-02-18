using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(PacienteMatadata))]
    public partial class Paciente
    {
    }

    public class PacienteMatadata
    {
        [Required(ErrorMessage = "La cédula es requerida.")]
        [StringLength(10, ErrorMessage = "La cédula no puede tener más de 10 caracteres.")]
        public string cedula { get; set; }
        [Required(ErrorMessage = "La nombre es requerida.")]
        [StringLength(50, ErrorMessage = "La nombre no puede tener más de 50 caracteres.")]
        public string nombre { get; set; }
        [Required(ErrorMessage ="El apellidoPaterno es requerido")]
        [StringLength(50, ErrorMessage = "El apellidoPaterno no puede tener más de 50 caracteres.")]
        public string apellidoPaterno { get; set; }
        [Required(ErrorMessage = "El apellidoMaterno es requerido.")]
        [StringLength(50, ErrorMessage = "El apellidoMaterno no puede tener más de 50 caracteres.")]
        public string apellidoMaterno { get; set; }
        [Required(ErrorMessage = "La direccion es requerida.")]
        [StringLength(100, ErrorMessage = "La direccion no puede tener más de 500 caracteres.")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El celular es requerido.")]
        [StringLength(10, ErrorMessage = "El celular no puede tener más de 15 caracteres.")]
        public string celular { get; set; }
        [Required(ErrorMessage = "El correo electrónico es requerido.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string correoElectronico { get; set; }

    }
}
