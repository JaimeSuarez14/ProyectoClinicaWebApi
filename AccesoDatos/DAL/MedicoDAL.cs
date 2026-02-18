using Comun.ViewModels;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DAL
{
    public class MedicoDAL
    {
        public static ListadoPaginadoVMR<MedicoVMR> LeerTodos(int cantidad, int pagina, string textoBusqueda)
        {
            ListadoPaginadoVMR<MedicoVMR> resultado = new ListadoPaginadoVMR<MedicoVMR>();
            using (var db = db_clinicaEntities.Create())
            {
                var query = db.Medico.Where(x => !x.borrado).Select(x => new MedicoVMR
                {
                    id = x.id,
                    cedula = x.cedula,
                    nombre = x.nombre + " " + x.apellidoPaterno + (x.apellidoMaterno != null ? " " + x.apellidoMaterno : ""),
                    esEspecialista = x.esEspecialista,
                });

                if(!string.IsNullOrEmpty(textoBusqueda))
                {
                    query = query.Where(x => x.nombre.Contains(textoBusqueda) || x.cedula.Contains(textoBusqueda));
                }

                resultado.cantidad = query.Count();
            }
            return resultado;
        }
        public static MedicoVMR LeerUno( long id)
        {
            MedicoVMR item = null;
            using (var db = db_clinicaEntities.Create())
            {

            }
            return item;
        }
        public static long Crear(Medico item)
        {
            long id = 0;
            using (var db = db_clinicaEntities.Create())
            {

            }
            return id;

        }
        public static void Actualizar(MedicoVMR item)
        {
            using (var db = db_clinicaEntities.Create())
            {

            }
        }
        public static void Eliminar(List<long> ids)
        {
            using (var db = db_clinicaEntities.Create())
            {

            }
        }
    }
}
