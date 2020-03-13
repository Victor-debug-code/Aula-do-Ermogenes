using System;

namespace projeto1
{
    class Program
    {
        static void Main(string[] args)
        {

            String Nome = ("Victor");
            String Sobrenome = ("Morais");
            String nomeCompleto = String.Concat(Nome, " ", Sobrenome);
            Console.WriteLine(Nome + " " + Sobrenome);


            String Sobrenome1 = ("Morais,");
            String Nome1 =("Victor");
            String nomeCompleto1 = String.Concat(Sobrenome1, " ", Nome1);
            Console.WriteLine(Sobrenome1 + " " + Nome1);
        }
    }
}
