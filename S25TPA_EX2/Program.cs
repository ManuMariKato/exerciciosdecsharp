/*TÉCNICAS DE PROGRAMAÇÃO E ALGORITMO
 Data: 28/08/25
 Autora: Manuela Mari 
 Descrição: Leia um número inteiro qualquer, calcule e escreva o antecessor e o sucessor do
número dado.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S25TPA_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int num = 0;
            int antecessor = 0;
            int sucessor = 0;


            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Digite um número inteiro qualquer: ");
            num = Convert.ToInt32(Console.ReadLine());
            antecessor = num - 1;
            sucessor = num + 1;
            Console.WriteLine("O antecessor de " + num + " é " + antecessor+ " e o sucessor é "+ sucessor);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\tDigite qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
