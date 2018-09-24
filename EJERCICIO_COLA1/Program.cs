using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EJERCICIO_COLA1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            ///Crea un programa que pida al usuario 5 numeros reales de doble presicion, los guarde
            ///en una cola y luego los muestre en pantalla

            int valores = 0, val = 0;
            Queue miCola = new Queue();  // genera la cola de nombre miCola y la inicia como cola
            for (byte i = 0; i < 5; i++) // arma el bucle para recorrer la cola
            {

                System.Console.WriteLine("Ingrese valor: ");
                val = System.Convert.ToInt32(System.Console.ReadLine());
                miCola.Enqueue(val);    // ingresa hola

            }

            System.Console.WriteLine("LOS VALORES INGRESADOS SON: ");
            for (byte i = 0; i < 5; i++) // arma el bucle para recorrer la cola
            {
                valores = (int)miCola.Dequeue(); // desencola la cola con Dequeue
                Console.WriteLine(valores);         // imprime por pantalla

            }
            Console.ReadKey();

        }
    }






}
