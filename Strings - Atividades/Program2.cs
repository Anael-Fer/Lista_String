using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    class Program
    {
        // Método para converter o valor ASCII para um caractere
        static char ConverterCaractere(int valorASCII)
        {
            // Retorna o caractere correspondente ao valor ASCII
            return (char)valorASCII;
        }

        // Método para criptografar o texto
        static string Criptografar(string texto, int chave)
        {
            string resultado = "";

            for (int i = 0; i < texto.Length; i++)
            {
                int valorASCII = texto[i];
                int novoValorASCII = (valorASCII + chave) % 256;  // Desloca o valor ASCII pela chave
                resultado += ConverterCaractere(novoValorASCII);  // Converte e adiciona ao resultado
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            // Solicitar ao usuário a string e a chave
            Console.Write("Digite a string a ser criptografada: ");
            string texto = Console.ReadLine();

            Console.Write("Digite a chave (número inteiro): ");
            int chave = int.Parse(Console.ReadLine());

            // Criptografar o texto
            string textoCriptografado = Criptografar(texto, chave);

            // Exibir os resultados
            Console.WriteLine("Texto criptografado: " + textoCriptografado);
            Console.ReadLine();
        }
    }
}
