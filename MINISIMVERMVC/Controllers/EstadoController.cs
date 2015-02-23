using MINISIMVER.Data;
using MINISIMVER.Modelos;
using MINISIMVERMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MINISIMVERMVC.Controllers
{
    public class EstadoController : ApiController
    {
        MINISIMVERContexto contexto = new MINISIMVERContexto();
        public IEnumerable<EstadoModeloCliente> GetEstados()
        {
            return contexto.Estados.Select(u => new EstadoModeloCliente
            {
                Id = u.Id,
                Nombre = u.Nombre,
                Clave = u.Clave

            }).ToList();

        }

        //public EstadoModeloCliente GetEstados(int id)
        //{ 
        
        //}

        public void PostEstado(EstadoModeloCliente Estado)
        {
            EntidadFederativa estadobd = new EntidadFederativa();
            estadobd.Id = Estado.Id;
            estadobd.Clave = Estado.Clave;
            estadobd.Nombre = Estado.Nombre;
            contexto.Estados.Add(estadobd);
            contexto.SaveChanges();
        }
    }
}
