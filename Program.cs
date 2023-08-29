using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Clear();

            Console.Write("Insira o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação (+ - x / ):  ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, Opção Inválida");
                    break;
                case '+':
                    resultado = valor1 + valor2;
                    Console.WriteLine("O resultado da soma é : " + resultado);
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    Console.WriteLine("O resultado da subtração é : " + resultado);
                    break;
                case 'x':
                    resultado = valor1 * valor2;
                    Console.WriteLine("O resultado da multiplicação é : " + resultado);
                    break;
                case ':':
                case '/':
                    if (valor2 == 0)
                        NewMethod();
                    else
                    {
                        resultado = valor1 / valor2;
                        Console.WriteLine("O resultado da divisão é : " + resultado);
                    }
                    break;
            }
            Console.Write("Continuar calculando? (s / n)");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }

            Console.ReadKey();

            void NewMethod()
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }

        }
    }
}
