using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MINISIMVERMVC.ViewModels
{
    public class MunicipioModeloCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ClaveOrfis { get; set; }
        public string ClaveInegi { get; set; }
        public int EntidadFederativaId { get; set; }
    }
}