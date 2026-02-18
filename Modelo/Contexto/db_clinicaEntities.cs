using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    public partial class db_clinicaEntities: DbContext
    {
        private db_clinicaEntities( string stringConexion)
            : base(stringConexion)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CommandTimeout = 900;
        }

        public static db_clinicaEntities Create()
        {
            return new db_clinicaEntities("name=db_clinicaEntities");
        }
    }
}
