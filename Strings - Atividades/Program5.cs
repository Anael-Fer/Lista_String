using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Lista de conectores a serem ignorados
            string[] conectores = { "e", "do", "da", "dos", "das", "de", "di", "du" };

            // Solicitar ao usuário o nome completo
            Console.Write("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            // Separar o nome completo em palavras
            string[] partesNome = nomeCompleto.Split(' ');

            // Variável para armazenar as iniciais
            string iniciais = "";

            // Iterar pelas partes do nome
            foreach (var parte in partesNome)
            {
                // Converter a parte para minúsculas
                string palavra = parte.ToLower();

                // Verificar se a palavra não é um conector
                bool ehConector = false;

                // Checar se a palavra é um conector
                for (int i = 0; i < conectores.Length; i++)
                {
                    if (palavra == conectores[i])
                    {
                        ehConector = true;
                    }
                }

                // Se não for um conector, adiciona a inicial
                if (!ehConector)
                {
                    iniciais += parte[0].ToString().ToUpper();
                }
            }

            // Exibir as iniciais
            Console.WriteLine("Iniciais: " + iniciais);
            Console.ReadLine();
        }
    }
}

