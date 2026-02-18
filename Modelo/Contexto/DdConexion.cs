using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    public partial class DdConexion: DbContext
    {
        private DbConexion( string stringConexion)
            : base(stringConexion)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CommandTimeout = 900;
        }

        public static DdConexion Create()
        {
            return new DdConexion("name=db_clinicaEntities");
        }
    }
}
