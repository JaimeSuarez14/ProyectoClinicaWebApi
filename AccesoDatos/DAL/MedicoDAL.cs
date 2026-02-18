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
                resultado.elementos = query
                    .OrderBy(x => x.id)  // Ordenar por id para garantizar la consistencia de la paginación
                    .Skip(pagina * cantidad) // Saltar los elementos de las páginas anteriores
                    .Take(cantidad) // Tomar solo la cantidad de elementos para la página actual
                    .ToList(); // Ejecutar la consulta y obtener los resultados
            }
            return resultado;
        }
        public static MedicoVMR LeerUno( long id)
        {
            MedicoVMR item = null;
            using (var db = db_clinicaEntities.Create())
            {
                item = db.Medico.Where(x => !x.borrado && x.id == id).Select(x => new MedicoVMR
                {
                    id = x.id,
                    cedula = x.cedula,
                    nombre = x.nombre,
                    apellidoPaterno = x.apellidoPaterno,
                    apellidoMaterno = x.apellidoMaterno,
                    esEspecialista = x.esEspecialista,
                    habilitado = x.habilitado
                }).FirstOrDefault();

            }
            return item;
        }
        public static long Crear(Medico item)
        {
            long id = 0;
            using (var db = db_clinicaEntities.Create())
            {
                item.borrado= false;
                db.Medico.Add(item);
                db.SaveChanges();
            }
            return id;

        }
        public static void Actualizar(MedicoVMR item)
        {
            using (var db = db_clinicaEntities.Create())
            {
                var itemActualizar = db.Medico.Where(x => !x.borrado && x.id == item.id).FirstOrDefault();
                if (itemActualizar != null)
                {
                    itemActualizar.cedula = item.cedula;
                    itemActualizar.nombre = item.nombre;
                    itemActualizar.apellidoPaterno = item.apellidoPaterno;
                    itemActualizar.apellidoMaterno = item.apellidoMaterno;
                    itemActualizar.esEspecialista = item.esEspecialista;
                    itemActualizar.habilitado = item.habilitado;
                    db.Entry(itemActualizar).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

            }
        }
        public static void Eliminar(List<long> ids)
        {
            using (var db = db_clinicaEntities.Create())
            {
                var items = db.Medico.Where(x => !x.borrado && ids.Contains(x.id)).ToList();
                foreach (var item in items)
                {
                    item.borrado = true;
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
        }
    }
}
