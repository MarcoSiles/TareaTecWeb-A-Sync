using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    public class Chef
    {
        public static async Task Orden(string text1AS, string text2AS, string text1S, string text2S, string textRes, int timeAS, int timeS, string nombreDelCliente)
        {
             TestChefAsync(text1AS, text2AS, text1S, text2S, textRes, timeAS, timeS, nombreDelCliente);
        }

        public async static Task TestChefAsync(string text1AS, string text2AS, string text1S, string text2S, string textRes, int timeAS, int timeS, string nombreDelCliente)
        {    
            var chef = new ChefAsync();            
            chef.PrepareMediaSyncFunction(text1S, text2S, timeS );                    
            var platoEntregaAsync = chef.PrepareMediaAsyncFunction(text1AS, text2AS, nombreDelCliente, timeAS);
            
            var platoEntrega = await platoEntregaAsync;   
            
            Console.WriteLine("\tLa Pizza "+textRes+platoEntrega+" : Lista");
        }
        public class ChefAsync
        {
            /* //prueba numero 1
            public async Task<string> Recibir(string nombre)
            {
                string respuesta = "La pizza de la familia " + nombre;
                await Task.Run(() =>
                {
                    Console.WriteLine("Comida Pedida");
                    Thread.Sleep(10000);
                    Console.WriteLine("Preparando Comida");
                });
                
                return respuesta;
            }*/
            public void PrepareMediaSyncFunction(string txt1, string txt2, int clockRate)
            {

                
                Console.WriteLine("\t" + txt1);
                Thread.Sleep(clockRate);

                
                Console.WriteLine("\t" + txt2);
            }
            public async Task<string> PrepareMediaAsyncFunction(string txt1, string txt2, string nombre, int clockRate)
            {
                string respuesta = " de la familia " + nombre;
                await Task.Run(() =>
                {

                    
                    Console.WriteLine("\t"+txt1);    
                    Thread.Sleep(clockRate);

                    
                    Console.WriteLine("\t" + txt2);
                });

                return respuesta;
            }
        }
    }
}
