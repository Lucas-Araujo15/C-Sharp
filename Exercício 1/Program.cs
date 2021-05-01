using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = idade * 365; 
            int horas = idade * 8760;
            int minutos = idade * 525600;

            Console.WriteLine($@"
            Você tem:  {meses}  meses
            Você tem:  {dias}  dias
            Você tem:  {horas}  horas
            Você tem:  {minutos}  minutos");
        }
    }
}
