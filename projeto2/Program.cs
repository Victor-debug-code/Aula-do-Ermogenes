using System;

namespace projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string textoDigitado = Console.ReadLine();
            Console.Write("Olá, ");
            Console.Write(textoDigitado);
            Console.WriteLine("!");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
