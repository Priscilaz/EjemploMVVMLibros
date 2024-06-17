using PriscilaZunigaLibrosMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriscilaZunigaLibrosMVVM.Services
{
    public class LibroService : ILibroService
    {
        public List<PZLibro> ObtenerLibro() 
        {
            return new List<PZLibro>
            {
                new PZLibro { Titulo = "La Odisea", Autor = "Homero" },
                new PZLibro { Titulo = "L1", Autor = "A1" },
                new PZLibro { Titulo = "L2", Autor = "A2" },
                new PZLibro { Titulo = "L3 ", Autor = "A3" },
                new PZLibro { Titulo = "L4", Autor = "A4" }


             };

        }
    }
}
