using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    public class Program
    {
        static void Main(string[] args)
        {

            Solemio prog = new Solemio();
            while (true)
            {
                prog.AccederAlMenu();
            }
        }
    }
}
