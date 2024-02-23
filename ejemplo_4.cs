namespace LeerTeclado
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("suma de dos numeros");
            Console.Write("ingresa número 1: ");
            string dato = Console.ReadLine();
            int n1 = int.Parse(dato);

            Console.Write("Ingresa número 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es: {0}", suma);
        }
    }
}