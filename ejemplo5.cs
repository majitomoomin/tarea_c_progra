using System;

namespace Sentencias
{
    class SentenciaIf
    {
        public static void Main(string[]args)
        {
            int numeroentero = int.Parse(Console.ReadLine());

            if (numeroentero == 7)
                Console.WriteLine("Numero es 7 ");
            else if (numeroentero < 0)
                Console.WriteLine("EL numro es negativo ");
            else
                Console.WriteLine("El numero no es ninguno de los casos programados");
            {
                
            }
        }
    }
}