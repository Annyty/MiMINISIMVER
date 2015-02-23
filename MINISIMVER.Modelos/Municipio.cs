using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINISIMVER.Modelos
{
    public class Municipio
    {
        public int Id { get; set; }
        public string ClaveORFIS { get; set; }
        public string ClaveINEGI { get; set; }
        public string Nombre { get; set; }

        public int EntidadFederativaId { get; set; }
        public virtual EntidadFederativa EntidadFederativa { get;set;}
         
            
    }
}
