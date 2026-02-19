using Comun.ViewModels;
using Logica.BLL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Modelo.Modelos;

namespace WebApi1.Controllers
{
    [EnableCors("*")]
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoController : ControllerBase
    {
        [HttpGet]
        public IActionResult LeerTodo(int cantidad = 10, int pagina = 0, string textoBusqueda = null)
        {
            var respuesta = new RespuestaVMR<ListadoPaginadoVMR<MedicoVMR>>();
            try
            {
                respuesta.datos = MedicoBLL.LeerTodo(cantidad, pagina, textoBusqueda);
                respuesta.codigo = System.Net.HttpStatusCode.OK;
                return Ok(respuesta);
            }
            catch (Exception ex)
            {           
                respuesta.codigo = System.Net.HttpStatusCode.InternalServerError;
                respuesta.datos = null;
                respuesta.mensajes.Add(ex.Message);
                respuesta.mensajes.Add(ex.ToString());
                return StatusCode((int)respuesta.codigo, respuesta);
            }
        }

        [HttpGet("{id:long}")]
        public IActionResult LeerUno(long id)
        {
            var respuesta = new RespuestaVMR<MedicoVMR>();
            try
            {
                respuesta.datos = MedicoBLL.LeerUno(id);
                if(respuesta.datos ==null && respuesta.mensajes.Count == 0)
                {
                    respuesta.codigo = System.Net.HttpStatusCode.NotFound;
                    respuesta.mensajes.Add("Elemento no encontrado");
                    return StatusCode((int)respuesta.codigo, respuesta);
                }
                respuesta.codigo = System.Net.HttpStatusCode.OK;
                return Ok(respuesta);
            }
            catch(Exception ex)
            {
                respuesta.codigo = System.Net.HttpStatusCode.InternalServerError;
                respuesta.datos = null;
                respuesta.mensajes.Add(ex.Message);
                respuesta.mensajes.Add(ex.ToString());
                return StatusCode((int)respuesta.codigo, respuesta);
            }

            
        }

        [HttpPost]
        public IActionResult Crear([FromBody] Medico item)
        {
            return StatusCode(501, new { mensaje = "No implementado: Crear" });
        }

        [HttpPut("{id:long}")]
        public IActionResult Actualizar(long id, [FromBody] MedicoVMR item)
        {
            return StatusCode(501, new { mensaje = "No implementado: Actualizar" });
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar([FromBody] List<long> ids)
        {
            return StatusCode(501, new { mensaje = "No implementado: Eliminar" });
        }
    }
}
