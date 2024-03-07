using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma string:");
            string frase = Console.ReadLine();
            Console.WriteLine("Escreva uma letra para substituir");
            string letra = Console.ReadLine();
            foreach (f in frase)
                if (f == letra)
                    Console.Write("X");
                else (Console.WriteLine(f));

        }
    }
}
