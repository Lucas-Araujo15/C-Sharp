using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");
            int ano = int.Parse(Console.ReadLine());
            int atual = DateTime.Now.Year;
            int idade = atual - ano;
            int semana = idade * 52;

            Console.Write("A sua idade, em anos, é igual a "+ idade +", o que equivale a aproximadamente " + semana + " semanas");

        }
    }
}
