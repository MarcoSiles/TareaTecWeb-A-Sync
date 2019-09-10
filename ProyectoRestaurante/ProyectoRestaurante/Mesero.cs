using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    public static class Mesero
    {
        public static void LimpiaMesa()
        {
           // Console.Clear();
            var limpiar = new Limpiar();
            limpiar.PutChickenInTheOven();
        }
        public static void MostrarMenu()
        {
            int cont = 1;
            var devs = Solemio.Platos();
            var groupname = devs.GroupBy(n => n.Nombre);
            Console.WriteLine("                                                    MENU");
            foreach (var nom in devs)
            {
                Console.WriteLine(cont+".-"+nom.GetPlatillos());
                cont++;
            }
        }
        public class Limpiar
        {
            public void PutChickenInTheOven()
            {
                Console.WriteLine("\tMesero esta limpiando las mesa");
                Thread.Sleep(2000);
                Console.WriteLine("\tLas mesas estan limpiada");
            }
        }
    }
}
