using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    public class Platillos
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int PrecioP { get; set; }
        public int PrecioG { get; set; }

        public string GetPlatillos()
        {
            return $"{Nombre}: {Descripcion}  Grande:{PrecioG}  Pequeno:{PrecioP}";
        }
    }
}
