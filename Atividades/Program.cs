using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Estudos___Prova_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //- parametro.ToString() converte para string;
            //- parametro.Equals() verifica se dois conteudos são identicos (retorna em true ou false)
            //- parametro.CompareTo() verifica se as string são identicas (retorna em inteiros -1, 0 e 1)
            //- parametro.StartsWith() verifica se a string começa com um texto passado como argumento - inicio (ini)
            //- parametro.EndsWith() verifica se a string termina com um texto passado como argumento - inicio (cio)
            //- parametro.IndexOf() encontra a primeira ocorrencia de um caracter em uma string
            //- parametro.LastIndexOf() encontra a ultima ocorrencia de um caracter em uma string
            //- parametro.Substring() faz uma cópia da string a partir de uma posição
            //- parametro.Concat() concatena strings
            //- parametro.Join() concatena um separador entre as strings
            //- parametro.ToLower() converte strings em letras minusculas
            //- parametro.ToUpper() converte strings em letras maiusculas
            //- parametro.Split() divide uma string em substrings

            // ------------------------------------------------------------------------------------------------------------------------

            //Escreva um programa que leia do teclado uma string S.Gere uma string I, com os caracteres
            //em ordem contrária.Crie uma nova string e não use função pronta do C#.
            //Ex.: S = “Abacate”, I = “etacabA”

            string S;
            string I = "";

            Console.WriteLine("Escreva algo: ");
            S = Console.ReadLine();

            for (int i = S.Length - 1; i >= 0; i--)
            {
                I += S[i];
            }

            Console.WriteLine(I);
            Console.ReadLine();

            //Leia uma cadeia de caracteres e converta todos os caracteres para maiúscula.

            string frase;

            Console.WriteLine("Escreva uma frase: ");
            frase = Console.ReadLine().ToUpper();

            Console.WriteLine(frase);
            Console.ReadLine();

            // ------------------------------------------------------------------------------------------------------------------------

            //Escreva um programa que, a partir de um nome informado pelo usuário, exiba suas iniciais.
            //As iniciais são formadas pela primeira letra de cada nome, sendo que todas deverão aparecer
            //em maiúsculas na saída do programa.Note que os conectores e, do, da, dos, das, de, di, du
            //não são considerados nomes e, portanto, não devem ser considerados para a obtenção das
            //iniciais.As iniciais devem ser impressas em maiúsculas, ainda que o nome seja entrado todo
            //em minúsculas.Exemplos:

            //José Carlos Souza => JCS
            //Nome do Fulano => NF
            //Heloísa Martins Vieira => HMV

            string[] conectores = { "e", "do", "da", "dos", "das", "de", "di", "du" };

            Console.WriteLine("Digite o seu nome: ");
            string NomeCompleto = Console.ReadLine();

            string[] partesNome = NomeCompleto.Split(); // Divide o nome em partes
            string iniciais = ""; // Variável para armazenar as iniciais

            foreach (string palavra in partesNome)
            {
                bool ehConector = false;

                // Verifica se a palavra é um dos conectores
                foreach (string conector in conectores)
                {
                    if (palavra.ToLower() == conector) // Compara ignorando o caso
                    {
                        ehConector = true;
                        break;
                    }
                }

                if (!ehConector)
                {
                    iniciais += palavra[0].ToString().ToUpper(); // Adiciona a inicial em maiúsculo
                }
            }

            Console.WriteLine("Iniciais: " + iniciais);
            Console.ReadLine();

            // ------------------------------------------------------------------------------------------------------------------------

            //Palíndromo.Um palíndromo é uma sequência de caracteres cuja leitura é idêntica se feita da
            //direita para esquerda ou vice−versa.Por exemplo: OSSO e OVO são palíndromos.Em textos
            //mais complexos os espaços e pontuação são ignorados. A frase SUBI NO ONIBUS é o
            //exemplo de uma frase palíndroma onde os espaços foram ignorados.Faça um programa que
            //leia uma sequência de caracteres, mostre−a e diga se é um palíndromo ou não.

            string frase, reverso = "";

            Console.WriteLine("Escreva uma frase: ");
            frase = Console.ReadLine();

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                reverso += frase[i];
            }

            if (frase == reverso)
            {
                Console.WriteLine("A frase é um palindromo");
            }
            else
                Console.WriteLine("A frase não é um palindromo");

            Console.ReadLine();

            // ------------------------------------------------------------------------------------------------------------------------

            //Faça um programa que, a partir de um texto digitado pelo usuário, imprima o texto removendo
            //todos os espaços em branco adicionais encontrados, de modo que haja, no máximo, um espaço
            //em branco separando as palavras presentes nesse texto.
            //Exemplo:
            //Entrada: Josefina  anda de   bicicleta
            //Saída: Josefina anda de bicicleta.

            string texto;

            Console.WriteLine("Digite um texto: ");
            texto = Console.ReadLine();

            string[] partestexto = texto.Split();
            string resultado = "";

            foreach (string parte in partestexto)
            {
                if (parte != "")
                {
                    if (resultado != "")
                    {
                        resultado += " ";
                    }

                    resultado += parte;
                }
            }

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadLine();

            // ------------------------------------------------------------------------------------------------------------------------

            //01.Escreva um programa que leia uma string e um caractere, e retorne o número de vezes que esse caractere
            //aparece na string.

            string palavrra;
            char caractere;
            int cont = 0;

            Console.WriteLine("Escreva uma palavra: ");
            palavrra = Console.ReadLine();

            Console.WriteLine("Escreva uma palavra: ");
            caractere = char.Parse(Console.ReadLine());

            foreach (char p in palavrra)
            {
                if (p == caractere)
                    cont++;
            }

            Console.WriteLine($"A quantidade de {caractere} é {cont}");
            Console.ReadLine();

            // ------------------------------------------------------------------------------------------------------------------------

            //02.Escreva um programa que leia duas strings. Se as strings forem iguais, escreva “strings iguais”. Caso
            //contrário, imprima a string que possui o maior tamanho e, em seguida, a string resultante da concatenação das
            //duas strings.

            string p1, p2;

            Console.WriteLine("Escreva uma palavra: ");
            p1 = Console.ReadLine();
            Console.WriteLine("Escreva uma outra palavra: ");
            p2 = Console.ReadLine();

            if (p1 == p2)
                Console.WriteLine("strings iguais");
            else if (p1.Length > p2.Length)
            {
                Console.WriteLine($"Maior palavra: " + p1);
                Console.WriteLine($"Concatenação: " + p1 + p2);
            }
            else
            {
                Console.WriteLine($"Maior palavra: " + p2);
                Console.WriteLine($"Concatenação: " + p2 + p1);
            }

            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------


            //03.Escreva um método que receba como parâmetro uma string e retorne o número de vogais e de consoantes
            //dessa string.Considere que a string lida terá apenas letras(Dica: consoantes não são vogais).

            static string ContVogalOuCons(string palavra)
            {
                int contV = 0, contC = 0;

                foreach (char v in palavra)
                {
                    if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                        contV++;
                    else
                        contC++;

                }
                return $"Número de vogais: {contV} e número de consoantes: {contC}";

            }


            string p, resultado;

            Console.WriteLine("Escreva algo: ");
            p = Console.ReadLine();

            resultado = ContVogalOuCons(p);
            Console.WriteLine(resultado);
            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            //04.Escreva um programa que leia uma palavra e a imprima de trás - para - frente.

            //string palavra;

            Console.WriteLine("Escreva algo");
            palavra = Console.ReadLine();

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                Console.Write(palavra[i]);
            }
            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            //05.Escreva um método que receba uma string e indique se ela é um palíndromo. Seu método deve retornar
            //um booleano. Um palíndromo é uma string que tem a propriedade de poder ser lida tanto da direita para a
            //esquerda, como da esquerda para a direita. Ex: ovo, arara, osso.

            static bool Palindromo(string palavra)
            {
                string inverso = "";

                for (int i = palavra.Length - 1; i >= 0; i--)
                {
                    inverso += palavra[i];
                }

                if (palavra == inverso)
                    return true;
                else
                    return false;
            }

            string palavra;

            Console.WriteLine("Escreva uma palavra: ");
            palavra = Console.ReadLine();

            Console.WriteLine(Palindromo(palavra));
            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            //06.Faça um programa para criptografar uma frase informada pelo usuário.A criptografia deverá trocar as
            //vogais da frase por*
            //Exemplo:
            //Frase: EU ESTOU NA ESCOLA
            //Saída: ***ST * *N * *SC * L *

            string palavra;
            string vogais = "AEIOUaeiou";

            Console.WriteLine("Escreva uma palavra: ");
            palavra = Console.ReadLine();

            foreach (char v in vogais)
            {
                palavra = palavra.Replace(v, '*');
            }

            Console.WriteLine(palavra);
            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            // 7.Faça um método que receba uma frase como parâmetro, calcule e retorne a quantidade de palavras da frase
            //(considere que a string lida não terá sinais de pontuação).
            //Exemplos:
            //rase 1: Nas quintas há aula teórica de Algoritmos e Técnicas de Programação
            //Número de palavras: 11
            //Frase 2: A lista de exercícios é sobre strings
            //Número de palavras: 7

            static string QuantFrase(string frase)
            {
                string[] partesFrase = frase.Split(' ');
                return $"Quantidade de palavras na frase é: " + partesFrase.Length;
            }

            string frase;

            Console.WriteLine("Escreva uma frase: ");
            frase = Console.ReadLine();

            Console.WriteLine(QuantFrase(frase));
            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            //08.Em um verbo regular, o radical é a parte invariante, que dá origem a todas as conjugações.Faça um
            //programa que leia um verbo regular terminado em “AR”, e imprima a conjugação do verbo nos seguintes
            //tempos verbais:
            //a) Presente do indicativo;
            //b) Pretérito perfeito do indicativo;
            //c) Futuro do presente do indicativo.

            string[] presente = { "o", "as", "a", "mos", "ais", "am" };
            string[] preterito = { "ei", "aste", "ou", "amos", "aram" };
            string[] futuro = { "arei", "arás", "ará", "aremos", "areis", "arão" };
            string[] pronomes = { "eu", "tu", "ele/ela", "nós", "vós", "eles/elas" };

            string verbo, subst;

            Console.WriteLine("Escreva um verbo que termine com AR");
            verbo = Console.ReadLine();

            subst = verbo.Substring(0, verbo.Length - 2);

            for (int i = 0; i < presente.Length; i++)
            {
                Console.WriteLine($"{pronomes[i]} {subst}{presente[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < preterito.Length; i++)
            {
                Console.WriteLine($"{pronomes[i]} {subst}{preterito[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < futuro.Length; i++)
            {
                Console.WriteLine($"{pronomes[i]} {subst}{futuro[i]}");
            }
            Console.WriteLine();

            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            //09.Escreva um método que receba o nome completo de um estudante e retorne o seu e - mail institucional.Na
            //Universidade um e-mail contém apenas letras minúsculas e a regra para geração do e - mail é:
            //nome.sobrenome @acme.br

            static string Email(string NomeCompleto)
            {
                string[] partesNome = NomeCompleto.ToLower().Split();
                string PNome = partesNome[0];
                string UNome = partesNome[partesNome.Length - 1];

                return $"{PNome}.{UNome}@acme.br";

            }

            string NomeCompleto;

            Console.WriteLine("Digite seu nome completo: ");
            NomeCompleto = Console.ReadLine();

            Console.WriteLine(Email(NomeCompleto));

            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            //10.Escreva um programa que leia uma frase A com pelo menos 50 caracteres e uma string B contendo
            //exatamente 2 caracteres.Imprima o número de vezes que a string B aparece na string A

            string fraseA, stringB;
            int cont = 0;

            do
            {
                Console.WriteLine("Escreva pelo menos 50 caracteres: ");
                fraseA = Console.ReadLine();

                if (fraseA.Length < 50)
                    Console.WriteLine("Quantidade de caracteres abaixo do esperado: ");

            } while (fraseA.Length < 50);

            do
            {
                Console.WriteLine("Escreva exatos 2 caracteres: ");
                stringB = Console.ReadLine();

                if (stringB.Length != 2)
                    Console.WriteLine("Quantidade de caracteres abaixo do esperado: ");
            } while (stringB.Length != 2);

            for (int i = 0; i <= fraseA.Length - stringB.Length; i++)
            {
                if (fraseA.Substring(i, stringB.Length) == stringB)
                    cont++;
            }

            Console.WriteLine($"Quantidade de vezes que {stringB} aparece é {cont}");
            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            //11.Escreva um método que receba uma string contendo dados em formato CSV(valores separados por vírgula)
            //e retorne uma matriz com os dados.
            //Exemplo:


            string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";

            string[,] mat = Dados(csv);

            // Imprimir a matriz formatada
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }



        static string[,] Dados(string csv)
        {
            // Separar as linhas do CSV
            string[] linhas = csv.Split('\n');

            // Determinar o número de linhas e colunas
            int numLinhas = linhas.Length;
            int numColunas = linhas[0].Split(',').Length;

            // Criar a matriz com as dimensões adequadas
            string[,] matriz = new string[numLinhas, numColunas];

            // Preencher a matriz
            for (int i = 0; i < numLinhas; i++)
            {
                string[] colunas = linhas[i].Split(',');

                for (int j = 0; j < numColunas; j++)
                {
                    matriz[i, j] = colunas[j];
                }
            }

            return matriz;
        }

    }
}
