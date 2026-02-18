using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Metadatos
{
    [MetadataType(typeof(IngresoMetaData))]
    public partial class Ingreso
    {
    }

    public partial class IngresoMetaData
    {
        [Required(ErrorMessage = "La fecha es requerida.")]
        public System.DateTime fecha { get; set; }
        [Required(ErrorMessage = "El número de sala es requerido.")]
        public int numeroSala { get; set; }
        [Required(ErrorMessage = "El número de cama es requerido.")]
        public int numeroCama { get; set; }
        [Required(ErrorMessage = "El diagnóstico es requerido.")]
        public string diagnostico { get; set; }
        [Required(ErrorMessage = "El médico es requerido.")]
        public long medicoId { get; set; }
        [Required(ErrorMessage = "El paciente es requerido.")]
        public long pacienteId { get; set; }
    }
}
