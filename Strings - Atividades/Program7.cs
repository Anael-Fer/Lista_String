using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv7
{
    internal class Program
    {

        static string RemoverEspacosExtras(string texto)
        {
            // Variável para armazenar o texto formatado
            string resultado = "";
            bool espacoAnterior = false;

            // Percorrer cada caractere do texto
            foreach (char c in texto)
            {
                // Verifica se o caractere é um espaço
                if (c == ' ')
                {
                    // Se o caractere anterior já foi um espaço, ignora este espaço
                    if (!espacoAnterior && resultado.Length > 0)
                    {
                        resultado += c;
                        espacoAnterior = true;
                    }
                }
                else
                {
                    // Adiciona o caractere ao resultado e marca que não é um espaço
                    resultado += c;
                    espacoAnterior = false;
                }
            }

            // Remover os espaços no início e no final sem usar Trim
            if (resultado.Length > 0 && resultado[0] == ' ')
            {
                resultado = resultado.Substring(1);
            }
            if (resultado.Length > 0 && resultado[resultado.Length - 1] == ' ')
            {
                resultado = resultado.Substring(0, resultado.Length - 1);
            }

            return resultado;
        }

        static void Main(string[] args)
        {

            // Solicitar ao usuário o texto de entrada
            Console.Write("Digite o texto: ");
            string texto = Console.ReadLine();

            // Remover os espaços em branco adicionais
            string textoSemEspacosExtras = RemoverEspacosExtras(texto);

            // Exibir o texto formatado
            Console.WriteLine("Texto sem espaços extras: " + textoSemEspacosExtras);
            Console.ReadLine();
        }   
    }
}

