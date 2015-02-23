using MINISIMVER.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MINISIMVER.Data
{
    public class InicializadorBaseDatosPropio:CreateDatabaseIfNotExists<MINISIMVERContexto>
    {
        protected override void Seed(MINISIMVERContexto contexto)
        {
            AgregarEstados(contexto);

            base.Seed(contexto);
        }

        private void AgregarEstados(MINISIMVERContexto contexto)
        {
            List<EntidadFederativa> estados = new List<EntidadFederativa>()
            {
                new EntidadFederativa(){
                    Nombre="AGUASCALIENTES",
                    Clave="01",
                },
                new EntidadFederativa(){
                    Nombre="BAJA CALIFORNIA",
                    Clave="02",
                },
                new EntidadFederativa(){
                    Nombre="BAJA CALIFORNIA SUR",
                    Clave="03",
                }

            };
            foreach (var estado in estados) 
            {
                contexto.Estados.Add(estado);
            }
            contexto.SaveChanges();
        }
    }
}
