using System;
using System.Text;

namespace ConsoleApp.QuestaoRevisao
{
    public class Revisao
    {
        public bool LeituraEscrita(){
            int idade;
            double altura;
            string nome;

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");

            return true;
        }

        public void Operacoes(){
            int a, b, opcao;

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição de dois números");
            Console.WriteLine("2 - Subtração de dois números");
            Console.WriteLine("3 - Multiplicação de dois números");
            Console.WriteLine("4 - Divisão de dois números");
            Console.WriteLine("5 - Concatenar duas strings");
            Console.WriteLine("6 - Comparar dois números");
            Console.WriteLine("7 - Verificação lógica");
            Console.Write("Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao){
                case 1:
                    Console.WriteLine("Digite o primeiro número:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: {0}", a+b);
                    break;
                case 2:
                    Console.WriteLine("Digite o primeiro número:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: {0}", a-b);
                    break;
                case 3:
                    Console.WriteLine("Digite o primeiro número:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: {0}", a*b);
                    break;
                case 4:
                    Console.WriteLine("Digite o primeiro número:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultado: {0}", a/(double)b);
                    break;
                case 5:
                    StringBuilder stringBuilder = new StringBuilder();
                    Console.WriteLine("Digite a primeira palavra:");
                    stringBuilder.Append(Console.ReadLine()); 
                    Console.WriteLine("Digite a segunda palavra:");
                    stringBuilder.Append(Console.ReadLine());
                    string s = stringBuilder.ToString();
                    Console.WriteLine($"Resultado: {s}");
                    break;
                case 6:
                    Console.WriteLine("Digite o primeiro número:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    b = Convert.ToInt32(Console.ReadLine());
                    if(a!=b){
                        if(a>b){
                            Console.WriteLine("Resultado: A > B");
                        }else if(a<b){
                            Console.WriteLine("Resultado: A < B");
                        }
                    }else if(a==b){
                        Console.WriteLine("Resultado: A = B");
                    }
                    break;
                case 7:
                    Console.WriteLine("Digite um número:");
                    a = Convert.ToInt32(Console.ReadLine());
                    if(a>0 && a<10 || a>11 && a<19){
                        Console.WriteLine("O número está entre 0 e 10, ou, entre 11 e 19.");
                    }
                    else{
                        Console.WriteLine("O número não está entre 0 e 10, ou, entre 11 e 19.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public void OperacoesArray(){
            int a, i;
            int[] inteiros = new int[10];

            Console.WriteLine("Digite 5 números:");
            for(i=0;i<5;i++){
                a = Convert.ToInt32(Console.ReadLine());
                inteiros[i] = a;
            }
            Console.WriteLine("Os numeros digitados foram:");
            for(i=0;i<5;i++){
                Console.Write($"{inteiros[i]} ");
            }
        }

        public void CompararNumeros(){
            int a, b, opcao;
            bool continuar = true;

            while(continuar == true){
                Console.WriteLine("Digite o primeiro número:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                b = Convert.ToInt32(Console.ReadLine());
                if(a>b){
                    Console.WriteLine("Resultado: A > B");
                }else if(a<b){
                    Console.WriteLine("Resultado: A < B");
                }else if(a==b){
                Console.WriteLine("Resultado: A = B"); 
                }

                Console.WriteLine("Digite 1 para verificar novamente ou outro número para sair");
                Console.Write("Opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao == 1){
                    continuar = true;
                }else{
                    continuar = false;
                }
            }
        }

        public void Converter(){
            int a;
            string s;

            Console.WriteLine("Digite um número:");
            a = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToString(a);
            Console.WriteLine($"O número convertido para string é: {s}");
            a = Int32.Parse(s);
            Console.WriteLine($"Voltando para inteiro, o valor é: {a}");   
        }

        public void AtribuirNulo(){
            int? numero = null;

            if(numero.HasValue){
                Console.WriteLine("numero = " + numero.Value);
            }else{
                Console.WriteLine("numero = Null");
            }

            int y = numero.GetValueOrDefault();

            try{
                y = numero.Value;
            }catch (InvalidOperationException e){
                Console.WriteLine(e.Message);
            }
        }

        public void VariarString(){
            string s, a, aux;

            Console.WriteLine("Digite a primeira string:");
            s = Console.ReadLine();
            Console.WriteLine("Digite a segunda string:");
            a = Console.ReadLine();

            Console.WriteLine("Primeira string dividida na posição 3: " + s.Insert(3 , ""));
            aux = String.Copy(a);
            Console.WriteLine($"Cópia da segunda string: {aux}");
            aux = string.Concat(s, a);
            Console.WriteLine($"Strings concatenadas: {aux}");
            Console.WriteLine($"Strings concatenadas sem espaço excessivo: {aux.Trim()}");
            Console.WriteLine($"Strings concatenadas maiúsculas: {aux.ToUpper()}");
            Console.WriteLine($"Strings concatenadas minúsculas: {aux.ToLower()}");
            if(s.Equals(a)){
                Console.WriteLine("A primeira string é igual a segunda");
            }else{
                Console.WriteLine("As strings são diferentes");
            }
            Console.WriteLine($"O tamanho da primeira string é: {s.Length}");
            Console.WriteLine($"O tamanho da segunda string é: {s.Length}");
        }

        public void Potencia(){
            int x, y;

            Console.WriteLine("Digite o número X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número Y que X será elevado:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Resultado: ");
            Console.WriteLine(Math.Pow(x, y));
        }
    }
}