using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Solicitar ao usuário a cadeia de caracteres
            Console.Write("Digite uma cadeia de caracteres: ");
            string texto = Console.ReadLine();

            // Converter a cadeia para maiúscula
            string textoMaiuscula = texto.ToUpper();

            // Exibir o resultado
            Console.WriteLine("Texto em maiúscula: " + textoMaiuscula);
            Console.ReadLine();
        }
    }
}


