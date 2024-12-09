using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    class Program
    {

        static string LimparTexto(string texto)
        {
            // String para armazenar o texto limpo
            string textoLimpo = "";

            // Percorrer cada caractere e adicionar ao texto limpo se for uma letra ou número
            foreach (char c in texto)
            {
                // Verifica se o caractere é uma letra (A-Z ou a-z) ou um número (0-9)
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
                {
                    // Adiciona o caractere em minúscula
                    textoLimpo += char.ToLower(c);
                }
            }

            return textoLimpo;
        }

        static bool Palindromo(string texto)
        {
            // Verificar se o texto é igual ao seu inverso sem usar Array.Reverse
            int comprimento = texto.Length;
            for (int i = 0; i < comprimento / 2; i++)
            {
                if (texto[i] != texto[comprimento - 1 - i])
                {
                    return false; // Se encontrar uma diferença, não é um palíndromo
                }
            }
            return true; // Se passar em todas as comparações, é um palíndromo
        }

        static void Main(string[] args)
        {
            // Solicitar ao usuário a sequência de caracteres
            Console.Write("Digite uma sequência de caracteres: ");
            string frase = Console.ReadLine();

            // Limpar a string: remover espaços e pontuação, e deixar tudo em minúsculas
            string fraseLimpa = LimparTexto(frase);

            // Verificar se a frase é um palíndromo
            bool ehPalindromo = Palindromo(fraseLimpa);

            // Exibir o resultado
            if (ehPalindromo)
                Console.WriteLine("A sequência é um palíndromo.");
            else
                Console.WriteLine("A sequência não é um palíndromo.");

            Console.ReadLine();
        }

    }
}
