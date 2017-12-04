using System;

using ConsoleApp.QuestaoRevisao;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Revisao questaoRevisao = new Revisao();

            int id;

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Leitura e escrita");
            Console.WriteLine("2 - Operações com números e palavras");
            Console.WriteLine("3 - Operações com arrays");
            Console.WriteLine("4 - Comparar dois números");
            Console.WriteLine("5 - Converter número em string e vice-versa");
            Console.WriteLine("6 - Atribuir valor nulo");
            Console.WriteLine("7 - Variações de string");
            Console.WriteLine("8 - Calcular potência de um número");
            Console.Write("Opção: ");
            id = Convert.ToInt32(Console.ReadLine());

            switch (id){
                case 1:
                    questaoRevisao.LeituraEscrita();
                    break;
                case 2:
                    questaoRevisao.Operacoes();
                    break;
                case 3:
                    questaoRevisao.OperacoesArray();
                    break;
                case 4:
                    questaoRevisao.CompararNumeros();
                    break;
                case 5:
                    questaoRevisao.Converter();
                    break;
                case 6:
                    questaoRevisao.AtribuirNulo();
                    break;
                case 7:
                    questaoRevisao.VariarString();
                    break;
                case 8:
                    questaoRevisao.Potencia();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }


        }
    }
}
