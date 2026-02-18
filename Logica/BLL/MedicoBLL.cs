using AccesoDatos.DAL;
using Comun.ViewModels;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BLL
{
    /* Descripcion: Esta clase define la capa de lógica de negocio (BLL) para la entidad Medico 
     * en una aplicación de gestión clínica. La clase proporciona métodos para realizar operaciones 
     * CRUD (Crear, Leer, Actualizar, Eliminar), que a su vez llaman a los métodos correspondientes 
     * en la capa de acceso a datos (DAL).Ademas aca tambien se pueden agregar validaciones o reglas 
     * de negocio antes de llamar a la capa de acceso a datos.
     * **/
    public class MedicoBLL
    {
        public static ListadoPaginadoVMR<MedicoVMR> LeerTodo(int cantidad, int pagina, string textoBusqueda)
        {
            return MedicoDAL.LeerTodos(cantidad, pagina, textoBusqueda);
        }

        public static MedicoVMR LeerUno(long id)
        {
            return MedicoDAL.LeerUno(id);
        }

        public static long Crear(Medico item)
        {
            return MedicoDAL.Crear(item);

        }

        public static void Actualizar(MedicoVMR item)
        {
            MedicoDAL.Actualizar(item);
        }

        public static void Eliminar(List<long> ids)
        {
            MedicoDAL.Eliminar(ids);
        }

    }
}
