using System;
using LibCalc;

namespace Calculadora
{
    class Program
    {

        static void Main(string[] args) 
        {
            Console.WriteLine("============================ Calculadora ============================");

            Console.WriteLine("Digite o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a operação ( / | + | * | - ): ");
            string operador = Console.ReadLine();


            Console.WriteLine("Digite o segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("\nResultado: ");

            switch (operador)
            {
                case "+":
                    Funcoes.setSoma(a, b);
                    Console.Write(Funcoes.getSoma());
                    break;
                case "-":
                    Funcoes.setSub(a, b);
                    Console.Write(Funcoes.getSub()); ;
                    break;
                case "*":
                    Funcoes.setMult(a, b);
                    Console.Write(Funcoes.getMult());
                    break;
                case "/":
                    Funcoes.setDiv(a, b);
                    Console.Write(Funcoes.getDiv());
                    break;
            }
            Console.ReadKey(true);
        }
    }
}