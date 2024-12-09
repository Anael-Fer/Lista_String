using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9___String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite uma string: ");
            string S = Console.ReadLine();

            string I = "";

            for (int i = S.Length - 1; i >= 0; i--)
            {
                I += S[i]; 
            }

            Console.WriteLine("String invertida: " + I);
            Console.ReadLine();

        }
    }
}
