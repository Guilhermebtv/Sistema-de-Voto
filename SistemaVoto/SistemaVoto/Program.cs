using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("| Bem-vindo ao sistema de votos do Brasil |");
            Console.WriteLine("-------------------------------------------");

            int nasc = 0;

            Console.Write("Informe o seu ano de nascimento: ");
            int.TryParse(Console.ReadLine(), out nasc);

            int ano = DateTime.Now.Year;
            int idade = ano - nasc;

            Console.WriteLine($"\nVocê tem {idade} anos.");

            if (idade < 16)
            {
                Console.WriteLine("Você não pode votar.");
            }
            else if ((idade >= 16 && idade < 18) || idade > 65)
            {
                Console.WriteLine("O voto é opcional para você.");
            }
            else if (idade >= 18 && idade <= 65)
            {
                Console.WriteLine("O voto é obrigatório para você.");
            }

            Console.ReadKey();
        }
    }
}
