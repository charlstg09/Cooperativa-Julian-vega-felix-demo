using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperativa_Julian_vega_felix.modelado
{
    internal class mariscosDa
    {

        public List<Marisco> ObtenerMariscos()
        {
            using (var dbContext = new PruebaContext()) // Reemplaza PruebaContext con tu propio contexto de base de datos
            {
                // Obtener la lista de mariscos desde la base de datos
                var mariscos = dbContext.Mariscos.ToList(); // Reemplaza Mariscos con el nombre de tu tabla de mariscos en la base de datos

                return mariscos;
            }
        }
    }
}
