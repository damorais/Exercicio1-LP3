using System;

namespace Exercicio1_LP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {
                "Dino da Silva Sauro",
                "Fran da Silva Sauro",
                "Charlene da Silva Sauro",
                "Bob da Silva Sauro",
                "Baby da Silva Sauro"
            };

            foreach (var nome in nomes)
                Console.WriteLine(nome);

            Console.ReadKey();

            
        }
    }
}
