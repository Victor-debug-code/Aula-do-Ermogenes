using System;

namespace projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite uma frase:");
            String frase = Console.ReadLine();
            String flase = frase.Replace("r","l")
                                .Replace("R","L");
            Console.WriteLine(flase);                        
        }
    }
}
