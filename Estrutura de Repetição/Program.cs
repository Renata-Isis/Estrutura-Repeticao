using System;

namespace Estrutura_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "Renata", "Tommy", "Diná", "Ionizis" };


            /* ForEach*/
             foreach(string item in palavras)
            {
                Console.WriteLine(item);
            }

            /*For crescente*/
             for(int contador = 0; contador < palavras.Length; contador++)
            {
                Console.WriteLine(palavras[contador]);
            }

            Console.WriteLine("=============================");

            /*For decrescente*/
            for (int contador2 = palavras.Length -1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(palavras[contador2]);
            }

        }
    }
}
