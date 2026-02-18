using Comun.ViewModels;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DAL
{
    public class MedicoDAL
    {
        public static ListadoPaginadoVMR<MedicoVMR> LeerTodos(int cantidad, int pagina, string textoBusqueda)
        {
            ListadoPaginadoVMR<MedicoVMR> resultado = new ListadoPaginadoVMR<MedicoVMR>();
            return resultado;
        }
        public static MedicoVMR LeerUno( long id)
        {
            MedicoVMR item = null;
            return item;
        }
        public static long Crear(Medico item)
        {
            long id = 0;
            return id;

        }
        public static void Actualizar(MedicoVMR item)
        {

        }
        public static void Eliminar(List<long> ids)
        {

        }
    }
}
