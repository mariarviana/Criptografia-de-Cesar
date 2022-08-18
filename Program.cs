using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptografiaCesar
{
    class Program
    {
        static void Main()
        {
            /*
            Alunas: Eloizy Campi Reis, Maria Eduarda Ribeiro Viana
            Turma/Curso: 3°A - Técnico em informática

            obs: o código está comentado para facilitar o entendimento das alunas na
            hora da explicação do código em sala de aula <3.
             */
            
            string text1 = "", text2 = "";
            int opcao; 
            //numConv = 0, numeroCaracteres = 0;
            //numeroCaracteres conta quantos caracteres possui numa frase

            //cabeçalho
            Console.WriteLine("\n ______________________________________________");
            Console.WriteLine("║                                              ║");
            Console.WriteLine("║        CRIPTOGRAFIA - CIFRA DE CÉSAR         ║");
            Console.WriteLine("╟══════════════════════════════════════════════╢");
            Console.WriteLine("║  Para encriptar um texto digite: 1           ║");
            Console.WriteLine("╟----------------------------------------------╢");
            Console.WriteLine("║  Para descriptografar um texto digite: 2     ║");
            Console.WriteLine("╟----------------------------------------------╢");
            Console.WriteLine("║  Para encerrar digite: 3                     ║");
            Console.WriteLine("║______________________________________________║");
            opcao = Convert.ToInt16(Console.ReadLine()); //toInt16 é para byte

            switch (opcao)
            {
                case 1:
                    //Puxar a função de criptografar
                    Console.Clear();
                    Console.WriteLine("\n ______________________________________________" +
                        "\n║                                              ║" +
                        "\n║            ENCRIPTOGRAFIA DE CÉSAR           ║" +
                        "\n║                                              ║"+
                        "\n║______________________________________________║");
                    Console.WriteLine("\nInsira o texto que deseja encriptar: ");
                    text1 = Console.ReadLine();

                    Criptografar(text1);

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("\n ______________________________________________" +
                        "\n║                                              ║" +
                        "\n║            DECRIPTOGRAFIA DE CÉSAR           ║" +
                        "\n║                                              ║" +
                        "\n║______________________________________________║");
                    Console.WriteLine("\nInsira o texto que deseja decriptar: ");
                    text1 = Console.ReadLine();
                    //Puxar a função de decriptar
                    Decriptografar(text1);

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("\nPressione ENTER para fechar o programa.");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }

        static void Criptografar(string text1)
        {
            int numConv = 0;
            string text2 = "";

            //Console.WriteLine("\nInsira o texto que deseja encriptar: ");
            //text1 = Console.ReadLine();

            // fazendo leitura de caracteres
            int numeroCaracteres = text1.Length; //length conta caracteres e devolve um valor

            for (int i = 0; i < numeroCaracteres; i++) //variavel contadora | condição = enquanto for menor que o num de caracteres
            {
                numConv = Convert.ToInt16(text1[i]) + 7; //7 é a chave de criptografia
                text2 += Convert.ToChar(numConv);
            }

            Console.WriteLine("\nO texto encriptografado é: " + text2 +
                "\n\nClique ENTER para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            Main();
        }

        static void Decriptografar(string text1)
        {
            int numConv = 0, numeroCaracteres = 0;
            string text2 = "";

            //Console.WriteLine("\nInsira o texto que deseja decriptar: ");
            //text1 = Console.ReadLine();
            
            numeroCaracteres = text1.Length;

            for (int i = 0; i < numeroCaracteres; i++)
            {
                numConv = Convert.ToInt16(text1[i]) - 7;
                text2 += Convert.ToChar(numConv);
            }
            Console.WriteLine("\nO texto descriptografado é: "+text2+"" +
                "\n\nClique ENTER para voltar ao menu");

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}

