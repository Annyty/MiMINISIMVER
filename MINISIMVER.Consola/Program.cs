using MINISIMVER.Data;
using MINISIMVER.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINISIMVER.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MINISIMVERContexto contexto = new MINISIMVERContexto();
                contexto.Estados.Add(new EntidadFederativa()
                {
                    Nombre = "VERACRUZ",
                    Clave = "30"

                });
                contexto.SaveChanges();
                Console.WriteLine("Nuevo estado agregado");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex.Message);
                
            }
            Console.ReadKey();
            
        }
    }
}
