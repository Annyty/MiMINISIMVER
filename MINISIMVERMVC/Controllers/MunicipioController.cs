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
    public class MunicipioController : ApiController
    {
        //public IEnumerable<string> GetLista()
        //{
        //    List<string> lista = new List<string>();
        //    lista.Add("Coatepec");
        //    lista.Add("Xico");
        //    lista.Add("Xalapa");

        //    return lista;
        //}

        //public void PostMunicipio(Municipio municipio)
        //{
        //    MINISIMVERContexto contexto = new MINISIMVERContexto();
        //    contexto.Municipios.Add(municipio);
        //}

        MINISIMVERContexto contexto = new MINISIMVERContexto();
        public IEnumerable<MunicipioModeloCliente> GetMunicipios()
        {
            return contexto.Municipios.Select(u => new MunicipioModeloCliente
                {
                    Id=u.Id,
                    Nombre= u.Nombre,
                    ClaveInegi = u.ClaveINEGI,
                    ClaveOrfis = u.ClaveORFIS,
                    EntidadFederativaId = u.EntidadFederativaId

                }).ToList();
            
        }

        public MunicipioModeloCliente GetMunicipio(int id)
        {
            var municipio = contexto.Municipios
                .Where(u => u.Id ==id)
                .Select(u => new MunicipioModeloCliente
            {
                Id = u.Id,
                Nombre = u.Nombre,
                ClaveInegi = u.ClaveINEGI,
                ClaveOrfis = u.ClaveORFIS,
                EntidadFederativaId = u.EntidadFederativaId

            }).FirstOrDefault();
            return municipio;

        }

        public void PostMunicipio(Municipio municipio)
        {
            contexto.Municipios.Add(municipio);
            contexto.SaveChanges();
        }

    }
}
