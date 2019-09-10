using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class Solemio
    {
        public void AccederAlMenu()
        {
            Menu();
        }
        public async Task Menu()
        {
            int a;
            int timeAS = 0, timeS = 0;
            string text1AS = " ", text2AS = " ", textRes = " ", text1S = " ", text2S = " ";
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("     OPCIONES:");
                Console.WriteLine("1: Mostrar Menu y tomar la Orden");                
                Console.WriteLine("2: Limpiar Mesas");
                var opc = Convert.ToInt32(Console.ReadLine());
                a = opc;
                switch (opc)
                {
                    case 1:
                        //Console.Clear();
                        Mesero.MostrarMenu();
                        
                        Console.Write("Introduzca el Apellido en el cual estra su orden:");
                        string nombreDelCliente = Console.ReadLine();
                        
                        Console.Write("Introduzca el number del platillo que desea:");
                        int tipoDePlato = int.Parse(Console.ReadLine());
                        textRes = SacarNombrePorPrimaryKey(tipoDePlato);

                        text1AS = "Se pone la Pizza " + textRes + " al horno";
                        text2AS = "Se saca la Pizza " + textRes + " del horno";

                        text1S = "Se preparan los " + SacarDescripcionPorPrimaryKey(tipoDePlato);
                        text2S = "La masa esta totalmente preparada y los ingredientes estan listos";

                        

                        switch (tipoDePlato)
                        {
                            case 1:
                                timeAS = 20000;
                                timeS = 1000;
                                break;
                            case 2:
                                timeAS = 20000;
                                timeS = 2000;
                                break;
                            case 3:
                                timeAS = 20000;
                                timeS = 3000;
                                break;
                            case 4:
                                timeAS = 20000;
                                timeS = 1200;
                                break;
                            case 5:
                                timeAS = 20000;
                                timeS = 3000;
                                break;
                            case 6:
                                timeAS = 20000;
                                timeS = 5000;
                                break;

                        }
                        
                        Chef.Orden(text1AS, text2AS, text1S, text2S, textRes, timeAS, timeS, nombreDelCliente);
                        
                        //Console.ReadKey();
                        break;
                    case 2:
                        Mesero.LimpiaMesa();
                        break;
                }
            }
            while (a != 4);
        }
      
        private string SacarDescripcionPorPrimaryKey(int numero)
        {
            var devs = Platos();
            string resultado=devs[numero-1].Descripcion;
            return resultado;
        }
        private string SacarNombrePorPrimaryKey(int numero)
        {
            var devs = Platos();
            string resultado = devs[numero - 1].Nombre;
            return resultado;
        }
        public static List<Platillos> Platos()
        {
            var comida = new List<Platillos>();
            comida.Add(new Platillos() { Nombre = "Sole mio", Descripcion = "Salsa de tomate, queso mozzarella, jamon, champinones, aceitunas verdes y huevo", PrecioG = 85, PrecioP = 65 });
            comida.Add(new Platillos() { Nombre = "Rustica", Descripcion = "Salsa de tomate, queso mozzarella, champinones y berenjenas", PrecioG = 75, PrecioP = 60 });
            comida.Add(new Platillos() { Nombre = "Rio mare", Descripcion = "Salsa de tomate, queso mozzarella, atun y cebolla", PrecioG = 80, PrecioP = 75 });
            comida.Add(new Platillos() { Nombre = "Ortolana", Descripcion = "Salsa de tomate, queso mozzarella, pimenton, cebolla y aceitunas negras", PrecioG = 70, PrecioP = 55 });
            comida.Add(new Platillos() { Nombre = "Funghi porcini", Descripcion = "Salsa de tomate, queso mozzarella y hongos porcini", PrecioG = 90, PrecioP = 70 });
            comida.Add(new Platillos() { Nombre = "Diavola", Descripcion = "Salsa de tomate, queso mozzarella, salame y aji", PrecioG = 70, PrecioP = 55 });
            return comida;
        }
    }
}
