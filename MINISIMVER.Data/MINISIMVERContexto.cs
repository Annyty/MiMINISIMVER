using MINISIMVER.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINISIMVER.Data
{
    public class MINISIMVERContexto: DbContext
    {
        public DbSet<EntidadFederativa> Estados { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //para que respete el nombre que le pongo a los DbSet
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

        }

        public MINISIMVERContexto():base(nameOrConnectionString: MINISIMVERContexto.CadenaConexion)
        { 
        
        }
        static MINISIMVERContexto()
        {
            Database.SetInitializer(new InicializadorBaseDatosPropio());
        }

        public static string CadenaConexion {
            get
            {
                if (ConfigurationManager.AppSettings["NombreCadenaConexion"] != null)
                {
                    return ConfigurationManager.AppSettings["NombreCadenaConexion"].ToString();   
                }
                return "DefaultConnection";
            }
                
        }

        

    }
}
