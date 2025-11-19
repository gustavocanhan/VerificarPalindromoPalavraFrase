using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPalindromoPalavraFrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Verificar Palíndromo de Palavra ou Frase ===");
            Console.Write("Digite uma palavra ou frase: ");

            string input = Console.ReadLine();

            string inputSemEspacos = input.Replace(" ", "").ToLower();

            RemoverAcentos removerAcentos = new RemoverAcentos();
            string inputSemAcentos = removerAcentos.RemoverAcentosFrase(inputSemEspacos);

            InverterTexto inverterTexto = new InverterTexto();
            string inputInvertido = inverterTexto.Inverter(inputSemAcentos);

            Palindromo palindromo = new Palindromo();

            Console.WriteLine("\n=== Resultado ===");
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Limpo: " + inputSemAcentos);
            Console.WriteLine("Invertido: " + inputInvertido);

            if (palindromo.VerificarPalindromo(inputSemAcentos, inputInvertido))
            {
                Console.WriteLine("Resultado: É palíndromo");
            }
            else
            {
                Console.WriteLine("Resultado: Não é palíndromo");
            }

        }
    }
}
