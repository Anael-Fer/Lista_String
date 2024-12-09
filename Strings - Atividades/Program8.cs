using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv8
{
    class Program
    {
        static string CodificarCifraDeCesar(string texto, int deslocamento)
        {
            string resultado = "";

            foreach (var c in texto)
            {
                if (LetraMaiuscula(c))
                    resultado += CodificarMaiuscula(c, deslocamento);
                else if (LetraMinuscula(c))
                    resultado += CodificarMinuscula(c, deslocamento);
                else
                    resultado += c;  // Para caracteres que não são letras, mantemos no texto original
            }

            return resultado;
        }

        // Verifica se o caractere é uma letra maiúscula
        static bool LetraMaiuscula(char c)
        {
            return c >= 'A' && c <= 'Z';
        }

        // Verifica se o caractere é uma letra minúscula
        static bool LetraMinuscula(char c)
        {
            return c >= 'a' && c <= 'z';
        }

        // Codifica uma letra maiúscula com a cifra de César
        static string CodificarMaiuscula(char letra, int deslocamento)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int indice = EncontrarIndice(alfabeto, letra);
            int novoIndice = (indice + deslocamento) % 26;
            return alfabeto[novoIndice].ToString();  // Retorna a letra codificada
        }

        // Codifica uma letra minúscula com a cifra de César
        static string CodificarMinuscula(char letra, int deslocamento)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            int indice = EncontrarIndice(alfabeto, letra);
            int novoIndice = (indice + deslocamento) % 26;
            return alfabeto[novoIndice].ToString();  // Retorna a letra codificada
        }

        // Encontra o índice de uma letra em uma string de alfabeto
        static int EncontrarIndice(string alfabeto, char letra)
        {
            int indice = 0;
            foreach (char c in alfabeto)
            {
                if (c == letra)
                {
                    return indice;
                }
                indice++;
            }
            return -1; // Caso não encontre, retorna -1 (não deve acontecer)
        }

        static void Main(string[] args)
        {
            // Solicitar ao usuário que digite o texto
            Console.Write("Digite o texto para ser codificado: ");
            string textoOriginal = Console.ReadLine();

            // Definir o deslocamento (3 para a cifra de César)
            int deslocamento = 3;

            // Codificar o texto usando a cifra de César
            string textoCodificado = CodificarCifraDeCesar(textoOriginal, deslocamento);

            // Exibir o resultado
            Console.WriteLine("Texto codificado: " + textoCodificado);
            Console.ReadLine();
        }
    }
}
