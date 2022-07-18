using System;
using static System.Console;

namespace Projeto_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bem vindo ao tabuapp!");
            WriteLine("Insira o valor que deseja multiplicar: ");
            int valor = int.Parse(ReadLine());
            
            int i = 0;
            while (i <= 10 ){
                int multiplicacao = valor * i;
                WriteLine($"O resultado de {valor} x {i} é: {multiplicacao}");
                i++;
            }
        }
    }
}
