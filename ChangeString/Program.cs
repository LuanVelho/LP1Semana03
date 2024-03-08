using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza uma frase: ");
            string frase = Console.ReadLine();
            Console.Write("Introduza um caractere para ser substituido: ");
            string letra = Console.ReadLine();
            char caractere = char.Parse(letra);

            string stringFinal = "";
            foreach (char f in frase)
            {
                if (f == caractere)
                {
                    stringFinal += "X";
                }
                else
                {
                    stringFinal += f;
                }
            }
            Console.WriteLine(stringFinal);

        }
    }
}